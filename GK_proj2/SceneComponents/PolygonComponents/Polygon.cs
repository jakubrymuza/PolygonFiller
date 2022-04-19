using System;
using System.Drawing;
using System.Collections.Generic;
using GK_proj2.SceneComponents.PolygonComponents.PaintingComponents;

namespace GK_proj2.SceneComponents.PolygonComponents
{
    public class Polygon
    {
        public PolygonDrawer Drawer { get; }
        public PolygonFiller Filler { get; }
        public List<Vertex> Vertices { get; private set; }
        public List<Edge> Edges { get; private set; }

        public Polygon(List<Vertex> vertices, ColorCalculator colorCalculator)
        {
            Vertices = vertices;

            InitializeEdges();

            Drawer = new PolygonDrawer(this);
            Filler = new PolygonFiller(this, colorCalculator);
        }
    

        public Vertex CheckPointHitbox(Point p)
        {
            foreach (Vertex v in Vertices)
                if (Geometry.Distance(v.Coords, p) < Vertex.VertexSize)
                    return v;

            return null;
        }

        private void InitializeEdges()
        {
            Edges = new List<Edge>();

            Vertex lastVertex = null;
            foreach (Vertex v in Vertices)
            {
                if (lastVertex != null)
                    Edges.Add(new Edge(lastVertex, v));
                lastVertex = v;
            }
            Edges.Add(new Edge(lastVertex, Vertices[0]));
        }

        /// <summary>
        /// returns smallest rectangle containing the Polygon
        /// </summary>
        public Rectangle GetRectangle()
        {
            int minX = int.MaxValue, minY = int.MaxValue;
            int maxX = 0, maxY = 0;

            foreach (Vertex v in Vertices)
            {
                minX = Math.Min(v.Coords.X, minX);
                minY = Math.Min(v.Coords.Y, minY);
                maxX = Math.Max(v.Coords.X, maxX);
                maxY = Math.Max(v.Coords.Y, maxY);
            }

            return new Rectangle(minX, minY, maxX - minX, maxY - minY);
        }

    }
}
