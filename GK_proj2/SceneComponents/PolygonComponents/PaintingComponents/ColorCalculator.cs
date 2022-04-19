using System;
using System.Drawing;
using System.Numerics;
using System.Collections.Generic;
using GK_proj2.SceneComponents.Lighting;

namespace GK_proj2.SceneComponents.PolygonComponents.PaintingComponents
{
    public class ColorCalculator
    {
        private Light _Light;
       
        private SceneInfo _SceneInfo;
        private Coefficients _Coefficients;

        private Vector3[,] _NormalVersorArray;

        private List<Point> _Cavities;
        private ObservatorPosition _ObservatorPosition;

        public ColorCalculator(Light light, SceneInfo sceneInfo, Coefficients coefficients, ObservatorPosition observatorPosition)
        {
            _Light = light;
            _SceneInfo = sceneInfo;
            _Coefficients = coefficients;

            _ObservatorPosition = observatorPosition;
            GenerateCavities();

            _NormalVersorArray = new Vector3[_SceneInfo.GetWidth(), _SceneInfo.GetHeight()];
            CalculateNormalVersorArray();

        }

        public Color GetPixelColor(Point p)
        {
            Color c = GetPixelComponentFromBitmap(p, _SceneInfo.TextureBitmap);
            float or = Scale2Float(c.R);
            float og = Scale2Float(c.G);
            float ob = Scale2Float(c.B);

            float lr = Scale2Float(_Light.Color.R);
            float lg = Scale2Float(_Light.Color.G);
            float lb = Scale2Float(_Light.Color.B);

            Vector3 N, L, V, R;

            N = _NormalVersorArray[p.X, p.Y];

            //V = Vector3.UnitZ;
            if (!_ObservatorPosition.P.Equals(Vector3.UnitZ))
            {
                Vector3 SphereVec = new Vector3(p.X, p.Y, Geometry.GetSphereHeight(p, _SceneInfo));
                V = Vector3.Subtract(_ObservatorPosition.P, SphereVec);
                V = Vector3.Normalize(V);

                if (Vector3.Dot(N, V) < 0) // kąt powyzej 90st.
                    return Color.Black;
            }
            else V = Vector3.UnitZ;
            



            L = Vector3.Subtract(_Light.Position, _SceneInfo.Get3DCenter());
            L = Vector3.Normalize(L);

            R = Vector3.Subtract(Vector3.Multiply(2 * Vector3.Dot(N, L), N), L);
            R = Vector3.Normalize(R);

            float a1 = Math.Max(Geometry.GetCosinus(N, L), 0);
            float a2 = Math.Max(Geometry.GetCosinus(V, R), 0);
            a2 = (float)Math.Pow((double)a2, (double)_Coefficients.m);

            float r = CalculateColorComponent(or, lr, a1, a2);
            float g = CalculateColorComponent(og, lg, a1, a2);
            float b = CalculateColorComponent(ob, lb, a1, a2);

            return Color.FromArgb(Scale2Int(r), Scale2Int(g), Scale2Int(b));
        }

        public void CalculateNormalVersorArray()
        {
            for (int i = 0; i < _SceneInfo.GetWidth(); ++i)
                for (int j = 0; j < _SceneInfo.GetHeight(); ++j)
                    _NormalVersorArray[i, j] = GetNormalVersor(new Point(i, j));

        }


        private int Scale2Int(float x) => Math.Min((int)(x * 255), 255);

        private float Scale2Float(int x) => (float)x / 255;

        private float CalculateColorComponent(float o, float l, float a1, float a2) =>
            _Coefficients.kd * o * l * a1 + _Coefficients.ks * o * l * a2;

        private Vector3 GetNormalVersor(Point p)
        {
            Vector3 Ns = GetSphereNormalVersor(p);

            if (_Coefficients.k > 0.99f)
                return Ns;

            Vector3 Nt = GetTextureNormalVersor(p);

            Matrix3x3 M = GetTransformationMatrix(Ns);

            Vector3 N = Vector3.Add(Vector3.Multiply(_Coefficients.k, Ns),
                Vector3.Multiply(1 - _Coefficients.k, Geometry.MultiplyVectorByMatrix3(M, Nt)));

            N = Vector3.Normalize(N);

            return N;
        }

        private Vector3 GetSphereNormalVersor(Point p)
        {
            if (Geometry.Distance(p, _SceneInfo.Center) >= _SceneInfo.Radius)
                return new Vector3(0, 0, 1); // point outside the sphere

            //Vector3 N = new Vector3(p.X, p.Y, Geometry.GetSphereHeight(p, _SceneInfo));
            Vector3 N = new Vector3(p.X, p.Y, Geometry.GetNewSphereHeight(p, _SceneInfo, _Cavities));
            N = Vector3.Subtract(N, _SceneInfo.Get3DCenter());
            N = Vector3.Normalize(N);

            return N;
        }

        private Color GetPixelComponentFromBitmap(Point p, Bitmap bitmap) =>
            bitmap.GetPixel(
                p.X % bitmap.Width,
                p.Y % bitmap.Height);

        private Vector3 GetTextureNormalVersor(Point p)
        {
            Color c = GetPixelComponentFromBitmap(p, _SceneInfo.NormalMapBitmap);
            float r = ((float)c.R - 127.5F) / 127.5F;
            float g = ((float)c.G - 127.5F) / 127.5F;
            float b = (float)c.B / 255F;

            return new Vector3(r, g, b);
        }

        public Matrix3x3 GetTransformationMatrix(Vector3 Ns)
        {
            Vector3 B = GetBinormalVector(Ns);
            Vector3 T = Vector3.Multiply(B, Ns);

            return new Matrix3x3(T, B, Ns);
        }

        public Vector3 GetBinormalVector(Vector3 Ns)
        {
            if (Vector3.Distance(Ns, Vector3.UnitZ) < 0.01f)
                return Vector3.UnitY;

            return Vector3.Multiply(Ns, Vector3.UnitZ);
        }



        // czesc labolatoryjna
        private const int R = 100;
        private void GenerateCavities()
        {
            _Cavities = new List<Point>(){
                new Point(_SceneInfo.Center.X, _SceneInfo.Center.Y + R),
                new Point(_SceneInfo.Center.X, _SceneInfo.Center.Y - R),
                new Point(_SceneInfo.Center.X + R, _SceneInfo.Center.Y),
                new Point(_SceneInfo.Center.X - R, _SceneInfo.Center.Y)
                };
        }
    }
}

