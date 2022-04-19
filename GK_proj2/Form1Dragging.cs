using System.Windows.Forms;
using System.Drawing;

namespace GK_proj2
{
    public partial class Form1 : Form
    {
        private void MyPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (_Mode == Modes.Default)
            {
                CheckDragHitboxes(e.Location);
            }
        }

        private void CheckDragHitboxes(Point p)
        {
            _SelectedVertex = _Scene.CheckHitboxes(p);

            if (_SelectedVertex != null)
            {
                _Mode = Modes.VertexDrag;
                EnableDragging();
            }
        }

        private void EnableDragging()
        {
            MyPictureBox.MouseMove += new MouseEventHandler(MyPictureBox_MouseMove);
            MyPictureBox.MouseUp += new MouseEventHandler(MyPictureBox_MouseUp);
        }

        private void DisableDragging()
        {
            MyPictureBox.MouseMove -= MyPictureBox_MouseMove;
            MyPictureBox.MouseUp -= MyPictureBox_MouseUp;
        }

        private void MyPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            _SelectedVertex.ChangePosition(e.Location);
            MyPictureBox.Invalidate();
        }

        private void MyPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            DisableDragging();
            _Mode = Modes.Default;
        }
    }
}
