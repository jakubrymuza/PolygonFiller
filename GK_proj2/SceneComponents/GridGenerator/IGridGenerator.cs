using GK_proj2.SceneComponents.PolygonComponents;
using System.Collections.Generic;

namespace GK_proj2.SceneComponents.GridGenerator
{
    public interface IGridGenerator
    {
        public void GenerateGrid(int precision);
    }
}
