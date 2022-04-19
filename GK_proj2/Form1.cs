using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GK_proj2.SceneComponents;
using GK_proj2.SceneComponents.PolygonComponents;
using System.IO;

namespace GK_proj2
{
    public partial class Form1 : Form
    {
        private Scene _Scene;
        private Timer _Timer;
        private Modes _Mode = Modes.Default;

        private Vertex _SelectedVertex = null;

        public Form1()
        {
            InitializeComponent();

            Bitmap defaultTextureBitmap = new Bitmap(@"..\..\..\Images\wood_texture.jpeg");
            Bitmap defaultNormalMapBitmap = new Bitmap(@"..\..\..\Images\brick_normalmap.png");

            _Scene = new Scene(MyPictureBox.Width, MyPictureBox.Height, defaultTextureBitmap, defaultNormalMapBitmap);

            InitializeTimer();
        }

        private void InitializeTimer()
        {
            _Timer = new Timer();
            _Timer.Tick += new EventHandler(NewFrame);
            _Timer.Interval = 100;
            _Timer.Start();
        }

        private void NewFrame(Object myObject, EventArgs myEventArgs)
        {
            _Timer.Enabled = true;
            if (AnimationCheckBox.Checked == true)
                _Scene.Animator.NextPosition();

            if (NewObservatorCheckBox.Checked == true)
                _Scene.ObserverAnimator.NextPosition();
            else _Scene.ObserverAnimator.Default();

            MyPictureBox.Invalidate();

        }

        private void MyPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitmap = new Bitmap(MyPictureBox.Width, MyPictureBox.Height);

            _Scene.Paint(bitmap);

            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private Bitmap GetSingleColorBitmap(Color color)
        {
            Bitmap newBitmap = new Bitmap(1, 1);
            newBitmap.SetPixel(0, 0, color);
            return newBitmap;
        }
    }

    public enum Modes
    {
        Default, VertexDrag
    }
}
