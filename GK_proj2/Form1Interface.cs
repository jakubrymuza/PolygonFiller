using System;
using System.Drawing;
using System.Windows.Forms;


namespace GK_proj2
{
    public partial class Form1 : Form
    {
        private void TriangulationTrackBar_Scroll(object sender, EventArgs e)
        {
            _Scene.GridGenerator.GenerateGrid(TriangulationTrackBar.Value);
            MyPictureBox.Invalidate();
        }

        private void HeightTackBar_Scroll(object sender, EventArgs e)
        {
            _Scene.Animator.ChangeLightingHeight(HeightTackBar.Value);
            MyPictureBox.Invalidate();
        }

        private void KTrackBar_Scroll(object sender, EventArgs e)
        {
            _Scene.Coefficients.k = (float)KTrackBar.Value / 100;
            _Scene.ColorCalculator.CalculateNormalVersorArray();
            MyPictureBox.Invalidate();
        }

        private void KDTrackBar_Scroll(object sender, EventArgs e)
        {
            _Scene.Coefficients.kd = (float)KDTrackBar.Value / 100;
            MyPictureBox.Invalidate();
        }

        private void KSTrackBar_Scroll(object sender, EventArgs e)
        {
            _Scene.Coefficients.ks = (float)KSTrackBar.Value / 100;
            MyPictureBox.Invalidate();
        }

        private void MTrackBar_Scroll(object sender, EventArgs e)
        {
            _Scene.Coefficients.m = MTrackBar.Value;
            MyPictureBox.Invalidate();
        }

        private void PreciseFillRadioButton_Click(object sender, EventArgs e)
        {
            _Scene.FillPrecise = true;
            MyPictureBox.Invalidate();
        }

        private void InterpolatedFillRadioButton_Click(object sender, EventArgs e)
        {
            _Scene.FillPrecise = false;
            MyPictureBox.Invalidate();
        }

        private void LightColorButton_Click(object sender, EventArgs e)
        {
            Color? c = ChooseColor();

            if(c != null)
                _Scene.Animator.ChangeLightingColor((Color)c);

            MyPictureBox.Invalidate();
        }

        private void ColorRadioButton_Click(object sender, EventArgs e)
        {
            Color? c = ChooseColor();

            if (c != null)
                _Scene.SceneInfo.TextureBitmap = GetSingleColorBitmap((Color)c);

            MyPictureBox.Invalidate();
        }

        private void ShowGridCheckBox_Click(object sender, EventArgs e)
        {
            _Scene.DrawGrid = ShowGridCheckBox.Checked;
            MyPictureBox.Invalidate();
        }

        private void NormalMapButton_Click(object sender, EventArgs e)
        {
            string name = ChooseImage();

            if (name.Length > 0)
                _Scene.SceneInfo.NormalMapBitmap = new Bitmap(name);

            _Scene.ColorCalculator.CalculateNormalVersorArray();
            MyPictureBox.Invalidate();
        }

        private void TextureRadioButton_Click(object sender, EventArgs e)
        {
            string name = ChooseImage();

            if (name.Length > 0)
                _Scene.SceneInfo.TextureBitmap = new Bitmap(name);

            MyPictureBox.Invalidate();
        }

        private Color? ChooseColor()
        {
            Color? c = null;
            _Timer.Enabled = false;
            ColorDialog myDialog = new ColorDialog();

            if (myDialog.ShowDialog() == DialogResult.OK)
                c = myDialog.Color;

            _Timer.Enabled = true;

            return c;
        }

        private string ChooseImage()
        {
            string name = "";
            _Timer.Enabled = false;
            OpenFileDialog myDialog = new OpenFileDialog();
            myDialog.Filter = "Images (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg;*.jpeg;*.jpe;*.jfif;*.png";

            if (myDialog.ShowDialog() == DialogResult.OK)
                name = myDialog.FileName;

            _Timer.Enabled = true;

            return name;
        }
    }
}
