using System;
using GK_proj2.SceneComponents.PolygonComponents;

namespace GK_proj2.Table
{
    public class EdgeTableElement
    {
        public int YMax;
        public float XMin;
        public float mInv;

        public EdgeTableElement(Edge e)
        {
            (Vertex v1, Vertex v2) = e.Ends;
            YMax = Math.Max(v1.Coords.Y, v2.Coords.Y);
            XMin = (YMax == v1.Coords.Y) ? XMin = v2.Coords.X : v1.Coords.X;

            mInv = (v1.Coords.Y == v2.Coords.Y) ? 0 : mInv = ((float)v1.Coords.X - v2.Coords.X) / (v1.Coords.Y - v2.Coords.Y);
        }

    }
}
