using System.Drawing;
using System.Numerics;

namespace GK_proj2.SceneComponents
{
    public class SceneInfo
    {
        public Point Center;
        public int Radius;
        public Bitmap TextureBitmap;
        public Bitmap NormalMapBitmap;

        public SceneInfo(Point center, int radius, Bitmap textureBitmap, Bitmap normalMapBitmap)
        {
            Center = center;
            Radius = radius;
            TextureBitmap = textureBitmap;
            NormalMapBitmap = normalMapBitmap;
        }

        public Vector3 Get3DCenter() => new Vector3(Center.X, Center.Y, 0);

        public int GetWidth() => Center.X + Radius;

        public int GetHeight() => Center.Y + Radius;
    }
}
