using System.Numerics;

namespace GK_proj2
{
    public class Matrix3x3
    {
        public Vector3[] Columns;

        public Matrix3x3(Vector3 v1, Vector3 v2, Vector3 v3)
        {
            Columns = new Vector3[3];
            Columns[0] = v1;
            Columns[1] = v2;
            Columns[2] = v3;
        }

    }
}
