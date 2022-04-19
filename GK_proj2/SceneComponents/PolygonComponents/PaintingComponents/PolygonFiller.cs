using System.Collections.Generic;
using System.Drawing;
using GK_proj2.Table;
using System.Numerics;

namespace GK_proj2.SceneComponents.PolygonComponents.PaintingComponents
{
    public class PolygonFiller
    {
        private EdgeTable ET;
        private List<EdgeTableElement> AET;
        private Polygon _Polygon;
        private ColorCalculator _ColorCalculator;

        private InterpolatedColorCalculator _InterpolatedColorCalculator;
        private bool _IsExact = true;


        public PolygonFiller(Polygon polygon, ColorCalculator colorCalculator)
        {
            _Polygon = polygon;
            _ColorCalculator = colorCalculator;
            _InterpolatedColorCalculator = new InterpolatedColorCalculator(_Polygon, _ColorCalculator);
        }

        public void Fill(Bitmap bitmap)
        {
            ET = GenerateEdgeTable(_Polygon.Edges, bitmap.Height);
            AET = new List<EdgeTableElement>();

            int y = ET.MinY;

            while (ET.Count > 0 || AET.Count > 0)
            {
                AddToAET(y);

                AET.Sort((a, b) => a.XMin.CompareTo(b.XMin));

                PaintLine(bitmap, y);

                RemoveFromAET(y);

                UpdateXminAET();

                y++;
            }


        }

        private EdgeTable GenerateEdgeTable(List<Edge> edges, int height)
        {
            EdgeTable ET = new EdgeTable(height);
            foreach (Edge e in edges)
            {
                (Vertex v1, Vertex v2) = e.Ends;
                if (v1.Coords.Y != v2.Coords.Y)     // horizontal lines are redundant
                    ET.Add(e);
            }

            return ET;
        }

        private void AddToAET(int y)
        {
            List<EdgeTableElement> newElems = ET.TakeElementsAt(y);
            if (newElems != null)
                AET.AddRange(newElems);
        }

        private void RemoveFromAET(int y)
        {
            AET.RemoveAll((a) => a.YMax == y + 1);
        }

        private void PaintLine(Bitmap bitmap, int y)
        {
            for (int i = 0; i < AET.Count - 1; i += 2)
            {
                for (int x = (int)AET[i].XMin; x <= (int)AET[i + 1].XMin; ++x)
                {
                    bitmap.SetPixel(x, y, GetColor(new Point(x, y)));

                }
            }
        }

        private void UpdateXminAET()
        {
            foreach (EdgeTableElement ete in AET)
                ete.XMin += ete.mInv;
        }

        private Color GetColor(Point p) => _IsExact ? _ColorCalculator.GetPixelColor(p) : _InterpolatedColorCalculator.GetInterpolatedColor(p);

        public void FillInterpolated(Bitmap bitmap)
        {
            // algorithm only for triangles
            if (_Polygon.Vertices.Count != 3)
                return;

            _InterpolatedColorCalculator.CalculateVertexColors();
            _IsExact = false;

            Fill(bitmap);

            _IsExact = true;

        }



    }
}
