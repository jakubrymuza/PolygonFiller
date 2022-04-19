using GK_proj2.SceneComponents.PolygonComponents;
using System.Collections.Generic;
using System;

namespace GK_proj2.Table
{
    public class EdgeTable
    {
        public int MinY = int.MaxValue;               // smallest y in the table
        public int Count { get; private set; } = 0;

        private int Height = 1;                       // bitmap height
        private List<EdgeTableElement>[] Table;

        public EdgeTable(int height)
        {
            Height = height;
            Table = new List<EdgeTableElement>[Height];
        }

        public void Add(Edge e)
        {
            EdgeTableElement ete = new EdgeTableElement(e);

            (Vertex v1, Vertex v2) = e.Ends;
            int YMin = Math.Min(v1.Coords.Y, v2.Coords.Y);

            if (Table[YMin] == null)
            {
                Table[YMin] = new List<EdgeTableElement>();

                if (MinY > YMin)
                    MinY = YMin;
            }
            
            Table[YMin].Add(ete);
            ++Count;               
        }

        public List<EdgeTableElement> TakeElementsAt(int y)
        {
            List<EdgeTableElement> elements = Table[y];

            if (elements == null)
                return null;

            Table[y] = null;
            Count -= elements.Count;
            return elements;
        }

    }
}
