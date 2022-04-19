using System;
using System.Drawing;
using System.Numerics;

namespace GK_proj2.SceneComponents.Lighting
{
    class LightingCircularAnimator : ILightingAnimator
    {
        public Light Light { get; private set; }
        private int _Radius;

        private float _Angle = 0;
        private Point _Center;

        private const int _DefaultHeight = 100;
        private const float _AngularSpeed = (float)Math.PI / 30;

        public LightingCircularAnimator(Point center, int radius)
        {
            _Center = center;
            _Radius = radius;

            Light = new Light();
            Light.Color = Color.White;

            ResetPosition();
        }

        public void ResetPosition()
        {
            Light.Position = new Vector3(_Center.X + _Radius, _Center.Y, _DefaultHeight);
            _Angle = 0;
        }

        public void NextPosition()
        {
            Light.Position.X = (int)(_Center.X + _Radius * Math.Cos(_Angle));
            Light.Position.Y = (int)(_Center.Y + _Radius * Math.Sin(_Angle));
            _Angle += _AngularSpeed;
        }

        public void ChangeLightingHeight(int height)
        {
            Light.Position.Z = height;
        }

        public void ChangeLightingColor(Color color)
        {
            Light.Color = color;
        }
    }
}
