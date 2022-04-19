using System;
using System.Collections.Generic;
using GK_proj2.SceneComponents.PolygonComponents;

namespace GK_proj2.SceneComponents.GridGenerator
{
    public class SphereGridGenerator : IGridGenerator
    {
        private Scene _Scene;
        private int _CircleSize = 50;
        private float _StepPsi;
        private float _StepPhi;

        public SphereGridGenerator(Scene scene)
        {
            _Scene = scene;
        }

        // algorytm własny
        public void GenerateGrid(int precision)
        {
            _Scene.ClearScene();

            _StepPsi = ((float)Math.PI / 2) / precision;
            _StepPhi = ((float)Math.PI * 2 / _CircleSize);

            Vertex[] prev1 = new Vertex[_CircleSize];

            Vertex startV = new Vertex(_Scene.SceneInfo.Center.X, _Scene.SceneInfo.Center.Y);
            GenerateFirstCircle(prev1);
            AddFirstCircleTriangles(startV, prev1);

            GenerateRemainingCircles(precision, prev1);

        }

        private void GenerateFirstCircle(Vertex[] prev)
        {
            float currPhi = 0;
            float currPsi = _StepPsi;
            int rad = (int)((float)_Scene.SceneInfo.Radius * Math.Sin(currPsi));

            for (int i = 0; i < _CircleSize; ++i)
            {
                currPhi += _StepPhi;

                Vertex newV = GetNewVertex(rad, currPhi);
                prev[i] = newV;
            }
        }

        private void AddFirstCircleTriangles(Vertex startV, Vertex[] prev)
        {
            for (int i = 0; i < _CircleSize; ++i)
            {
                List<Vertex> list = new List<Vertex>
                {
                    startV,
                    prev[i],
                    prev[(i + 1) % _CircleSize]
                };

                _Scene.AddPolygon(list);
            }
        }

        private void GenerateRemainingCircles(int precision, Vertex[] prev1)
        {
            Vertex[] prev2 = new Vertex[_CircleSize];
            int depth = 1;
            float currPsi = _StepPsi;

            while (depth < precision)
            {
                currPsi += _StepPsi;

                GenerateNextCircle(prev1, prev2, currPsi);

                AddTriangles(prev1, prev2);

                prev1 = (Vertex[])prev2.Clone();
                ++depth;
            }
        }

        private void GenerateNextCircle(Vertex[] prev1, Vertex[] prev2, float currPsi)
        {
            int rad = (int)((float)_Scene.SceneInfo.Radius * Math.Sin(currPsi));

            float currPhi = 0;

            for (int i = 0; i < _CircleSize; ++i)
            {
                currPhi += _StepPhi;

                prev2[i] = GetNewVertex(rad, currPhi);
            }
        }

        private void AddTriangles(Vertex[] prev1, Vertex[] prev2)
        {
            for (int i = 0; i < _CircleSize; ++i)
            {

                List<Vertex> list = new List<Vertex>
                    {
                        prev1[i],
                        prev2[i],
                        prev2[(i + 1) % _CircleSize]
                    };

                _Scene.AddPolygon(list);

                list = new List<Vertex>
                    {
                        prev1[i],
                        prev1[(i + 1) % _CircleSize],
                        prev2[(i + 1) % _CircleSize]
                    };

                _Scene.AddPolygon(list);

                list = new List<Vertex>
                    {
                        prev1[(i + 1) % _CircleSize],
                        prev2[(i + 1) % _CircleSize],
                        prev2[(i + 2) % _CircleSize]
                    };

                _Scene.AddPolygon(list);
            }
        }

        private Vertex GetNewVertex(int radius, float phi) => new Vertex(
                _Scene.SceneInfo.Center.X + (int)(radius * Math.Cos(phi)),
                _Scene.SceneInfo.Center.Y + (int)(radius * Math.Sin(phi))
                );
    }
}
