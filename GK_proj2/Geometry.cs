using System;
using System.Drawing;
using System.Numerics;
using System.Collections.Generic;
using GK_proj2.SceneComponents;

namespace GK_proj2
{
    public static class Geometry
    {
        public static float Distance(Point p1, Point p2)
        {
            int x = p1.X - p2.X;
            int y = p1.Y - p2.Y;
            return (float)Math.Sqrt(x * x + y * y);
        }

        /// <summary>
        /// returns a square given the center position and side length
        /// </summary>
        public static Rectangle GetCenteredSquare(Point center, int size) => new Rectangle(center.X - size / 2, center.Y - size / 2, size, size);

        public static float GetCosinus(Vector3 v1, Vector3 v2) =>
            Vector3.Dot(v1, v2);

        public static float GetSphereHeight(Point p, SceneInfo sceneInfo) =>
            GetSphereHeight(p, sceneInfo.Center, sceneInfo.Radius);

        private static float GetSphereHeight(Point p, Point center, int radius) =>
            (float)Math.Sqrt(radius * radius -
                (p.X - center.X) * (p.X - center.X) -
                (p.Y - center.Y) * (p.Y - center.Y));

        public static Vector3 MultiplyVectorByMatrix3(Matrix3x3 m, Vector3 v)
        {
            float x = Geometry.MultiplyRow(m.Columns[0].X, m.Columns[1].X, m.Columns[2].X, v);
            float y = Geometry.MultiplyRow(m.Columns[0].Y, m.Columns[1].Y, m.Columns[2].Y, v);
            float z = Geometry.MultiplyRow(m.Columns[0].Z, m.Columns[1].Z, m.Columns[2].Z, v);

            return new Vector3(x, y, z);
        }

        private static float MultiplyRow(float a1, float a2, float a3, Vector3 v)
        {
            return a1 * v.X + a2 * v.Y + a3 * v.X;
        }

        // czesc labolatoryjna
        private const int FlatRadius = 200;
        private const int CavitySphereRadius = 50;
        
        public static float GetNewSphereHeight(Point p, SceneInfo sceneInfo, List<Point> cavities)
        {       
            if (Distance(p, sceneInfo.Center) > FlatRadius)
                return GetSphereHeight(p, sceneInfo);

            float z = GetFlatHeight(p, sceneInfo.Radius);

            foreach(var cav in cavities)
            {
                if (Distance(p, cav) < CavitySphereRadius)
                    z -= GetSphereHeight(p, cav, CavitySphereRadius);

            }
                

            return z;
        }

        private static float GetFlatHeight(Point p, int radius) => (int)Math.Sqrt(radius - FlatRadius);

    }
}
