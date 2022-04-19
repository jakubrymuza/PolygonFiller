using System.Drawing;
using System;

namespace GK_proj2.SceneComponents.PolygonComponents
{
    public class Edge
    {
        public (Vertex, Vertex) Ends;

        public Edge(Vertex v1, Vertex v2)
        {
            Ends = (v1, v2);
        }

        public void Draw(Graphics g)
        {
            (Vertex v1, Vertex v2) = Ends;
            g.DrawLine(Pens.Black, v1.Coords, v2.Coords);
        }
    }

}
