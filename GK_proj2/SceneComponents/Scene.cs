using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Collections.Generic;
using GK_proj2.SceneComponents.Lighting;
using GK_proj2.SceneComponents.GridGenerator;
using GK_proj2.SceneComponents.PolygonComponents;
using GK_proj2.SceneComponents.PolygonComponents.PaintingComponents;

namespace GK_proj2.SceneComponents
{
    public class Scene
    {
        public bool DrawGrid = true;
        public bool FillPrecise = true;
        public SceneInfo SceneInfo;

        private const int DefaultPrecision = 6;
        public IGridGenerator GridGenerator;

        public Coefficients Coefficients;
        public ILightingAnimator Animator;
        public ColorCalculator ColorCalculator;

        public ObserverAnimator ObserverAnimator;

        private List<Polygon> _Polygons;

        public Scene(int width, int height, Bitmap textureBitmap, Bitmap normalMapBitmap)
        {
            SceneInfo = new SceneInfo(new Point(width / 2, height / 2), Math.Min(width, height) / 2, textureBitmap, normalMapBitmap);
            _Polygons = new List<Polygon>();

            ObserverAnimator = new ObserverAnimator(SceneInfo.Center, SceneInfo.Radius * 2);
            Animator = new LightingCircularAnimator(SceneInfo.Center, SceneInfo.Radius / 2);      
            Coefficients = new Coefficients();

            ColorCalculator = new ColorCalculator(Animator.Light, SceneInfo, Coefficients, ObserverAnimator.Position);

            GridGenerator = new SphereGridGenerator(this);
            GridGenerator.GenerateGrid(DefaultPrecision);
        }

        public void Paint(Bitmap bitmap)
        {
            foreach (Polygon p in _Polygons)
            {
                if (FillPrecise)
                    p.Filler.Fill(bitmap);
                else
                    p.Filler.FillInterpolated(bitmap);

                if (DrawGrid)
                    p.Drawer.DrawGrid(bitmap);
            }
        }

        public Vertex CheckHitboxes(Point p)
        {
            foreach(Polygon poly in _Polygons)
            {
                Vertex v = poly.CheckPointHitbox(p);

                if (v != null)
                    return v;
            }

            return null;
        }


        public void ClearScene()
        {
            _Polygons = new List<Polygon>();
        }

        public void AddPolygon(List<Vertex> list)
        {
            _Polygons.Add(new Polygon(list, ColorCalculator));
        }
          
    }
}
