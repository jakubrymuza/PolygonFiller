using System.Drawing;

namespace GK_proj2.SceneComponents.PolygonComponents
{
    public class Vertex
    {
        public Point Coords;
        public const int VertexSize = 5;

        public Vertex(int x, int y)
        {
            Coords = new Point(x, y);
        }

        public void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Black), Geometry.GetCenteredSquare(Coords, VertexSize));
        }

        public void ChangePosition(Point p)
        {
            Coords = p;
        }
    }
}
