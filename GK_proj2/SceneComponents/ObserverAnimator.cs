using System;
using System.Drawing;
using System.Numerics;

namespace GK_proj2.SceneComponents
{

    // czesc labolatoryjna
    public class ObserverAnimator
    {
        public ObservatorPosition Position;
        private int _Radius;

        private float _Angle = 0;
        private Point _Center;

        private const int _DefaultHeight = 400;
        private const float _AngularSpeed = (float)Math.PI / 30;

        public ObserverAnimator(Point center, int radius)
        {
            _Center = center;
            _Radius = radius;

            Position = new ObservatorPosition();

            ResetPosition();
        }

        public void ResetPosition()
        {
            Position.P = new Vector3(_Center.X + _Radius, _Center.Y, _DefaultHeight);
            _Angle = 0;
        }

        public void NextPosition()
        {
            Position.P.X = (int)(_Center.X + _Radius * Math.Cos(_Angle));
            Position.P.Y = (int)(_Center.Y + _Radius * Math.Sin(_Angle));
            _Angle += _AngularSpeed;
        }

        public void Default()
        {
            Position.P.X = 0;
            Position.P.Y = 0;
            Position.P.Z = 1;
        }
    }
}
