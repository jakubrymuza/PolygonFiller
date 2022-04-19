using System.Drawing;

namespace GK_proj2.SceneComponents.Lighting
{
    public interface ILightingAnimator
    {
        public Light Light { get; }
        public void ChangeLightingHeight(int height);
        public void ChangeLightingColor(Color color);
        public void ResetPosition();
        public void NextPosition();
    }
}
