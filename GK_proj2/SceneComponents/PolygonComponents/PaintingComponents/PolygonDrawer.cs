using System.Drawing;

namespace GK_proj2.SceneComponents.PolygonComponents.PaintingComponents
{
    public class PolygonDrawer
    {
        Polygon _Polygon;

        public PolygonDrawer(Polygon polygon)
        {
            _Polygon = polygon;
        }

        public void DrawGrid(Bitmap bitmap)
        {
            Graphics g = Graphics.FromImage(bitmap);
            DrawEdges(g);
            DrawVertices(g);
            g.Dispose();
        }

        private void DrawVertices(Graphics g)
        {
            foreach (Vertex v in _Polygon.Vertices)
                v.Draw(g);
        }
        private void DrawEdges(Graphics g)
        {
            foreach (Edge e in _Polygon.Edges)
                e.Draw(g);
        }
    }
}
