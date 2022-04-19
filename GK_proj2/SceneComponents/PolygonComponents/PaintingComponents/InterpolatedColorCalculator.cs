using System.Drawing;
using System.Numerics;

namespace GK_proj2.SceneComponents.PolygonComponents.PaintingComponents
{
    public class InterpolatedColorCalculator
    {
        private Polygon _Polygon;
        private ColorCalculator _ColorCalculator;
        private Color[] _VertexColors;

        public InterpolatedColorCalculator(Polygon polygon, ColorCalculator colorCalculator)
        {
            _Polygon = polygon;
            _ColorCalculator = colorCalculator;
            _VertexColors = new Color[3];
        }

        public Color GetInterpolatedColor(Point p)
        {
            Vector3 dist = GetDistanceFromVertices(p);
            float sum = dist.X + dist.Y + dist.Z;

            int r = (int)((dist.X * _VertexColors[0].R + dist.Y * _VertexColors[1].R + dist.Z * _VertexColors[2].R) / sum);
            int g = (int)((dist.X * _VertexColors[0].G + dist.Y * _VertexColors[1].G + dist.Z * _VertexColors[2].G) / sum);
            int b = (int)((dist.X * _VertexColors[0].B + dist.Y * _VertexColors[1].B + dist.Z * _VertexColors[2].B) / sum);

            return Color.FromArgb(r, g, b);
        }

        public void CalculateVertexColors()
        {
            int i = 0;
            foreach (Vertex v in _Polygon.Vertices)
            {
                _VertexColors[i] = _ColorCalculator.GetPixelColor(v.Coords);
                ++i;
            }
        }

        private Vector3 GetDistanceFromVertices(Point p) =>
            new Vector3(
                Geometry.Distance(p, _Polygon.Vertices[0].Coords),
                Geometry.Distance(p, _Polygon.Vertices[1].Coords),
                Geometry.Distance(p, _Polygon.Vertices[2].Coords)
                );
    }
}
