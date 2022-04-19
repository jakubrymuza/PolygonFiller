namespace GK_proj2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FillMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.InterpolatedFillRadioButton = new System.Windows.Forms.RadioButton();
            this.PreciseFillRadioButton = new System.Windows.Forms.RadioButton();
            this.ShowGridCheckBox = new System.Windows.Forms.CheckBox();
            this.NormalMapButton = new System.Windows.Forms.Button();
            this.CoefficientsGroupBox = new System.Windows.Forms.GroupBox();
            this.MTrackBar = new System.Windows.Forms.TrackBar();
            this.MLabel = new System.Windows.Forms.Label();
            this.KSTrackBar = new System.Windows.Forms.TrackBar();
            this.KSLabel = new System.Windows.Forms.Label();
            this.KDTrackBar = new System.Windows.Forms.TrackBar();
            this.KDLabel = new System.Windows.Forms.Label();
            this.KTrackBar = new System.Windows.Forms.TrackBar();
            this.KLabel = new System.Windows.Forms.Label();
            this.LightingGroupBox = new System.Windows.Forms.GroupBox();
            this.LightColorButton = new System.Windows.Forms.Button();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightTackBar = new System.Windows.Forms.TrackBar();
            this.AnimationCheckBox = new System.Windows.Forms.CheckBox();
            this.BackgroundGroupBox = new System.Windows.Forms.GroupBox();
            this.TextureRadioButton = new System.Windows.Forms.RadioButton();
            this.ColorRadioButton = new System.Windows.Forms.RadioButton();
            this.TriangulationLabel = new System.Windows.Forms.Label();
            this.TriangulationTrackBar = new System.Windows.Forms.TrackBar();
            this.NewObservatorCheckBox = new System.Windows.Forms.CheckBox();
            this.MyPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.FillMethodGroupBox.SuspendLayout();
            this.CoefficientsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KSTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KDTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KTrackBar)).BeginInit();
            this.LightingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTackBar)).BeginInit();
            this.BackgroundGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriangulationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.FillMethodGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.ShowGridCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.NormalMapButton);
            this.splitContainer1.Panel1.Controls.Add(this.CoefficientsGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.LightingGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.BackgroundGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.TriangulationLabel);
            this.splitContainer1.Panel1.Controls.Add(this.TriangulationTrackBar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.NewObservatorCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.MyPictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(825, 630);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Text = "splitContainer1";
            // 
            // FillMethodGroupBox
            // 
            this.FillMethodGroupBox.Controls.Add(this.InterpolatedFillRadioButton);
            this.FillMethodGroupBox.Controls.Add(this.PreciseFillRadioButton);
            this.FillMethodGroupBox.Location = new System.Drawing.Point(12, 306);
            this.FillMethodGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FillMethodGroupBox.Name = "FillMethodGroupBox";
            this.FillMethodGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FillMethodGroupBox.Size = new System.Drawing.Size(172, 66);
            this.FillMethodGroupBox.TabIndex = 9;
            this.FillMethodGroupBox.TabStop = false;
            this.FillMethodGroupBox.Text = "Fill Method";
            // 
            // InterpolatedFillRadioButton
            // 
            this.InterpolatedFillRadioButton.AutoSize = true;
            this.InterpolatedFillRadioButton.Location = new System.Drawing.Point(6, 39);
            this.InterpolatedFillRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InterpolatedFillRadioButton.Name = "InterpolatedFillRadioButton";
            this.InterpolatedFillRadioButton.Size = new System.Drawing.Size(89, 19);
            this.InterpolatedFillRadioButton.TabIndex = 0;
            this.InterpolatedFillRadioButton.TabStop = true;
            this.InterpolatedFillRadioButton.Text = "interpolated";
            this.InterpolatedFillRadioButton.UseVisualStyleBackColor = true;
            this.InterpolatedFillRadioButton.Click += new System.EventHandler(this.InterpolatedFillRadioButton_Click);
            // 
            // PreciseFillRadioButton
            // 
            this.PreciseFillRadioButton.AutoSize = true;
            this.PreciseFillRadioButton.Checked = true;
            this.PreciseFillRadioButton.Location = new System.Drawing.Point(6, 18);
            this.PreciseFillRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PreciseFillRadioButton.Name = "PreciseFillRadioButton";
            this.PreciseFillRadioButton.Size = new System.Drawing.Size(62, 19);
            this.PreciseFillRadioButton.TabIndex = 0;
            this.PreciseFillRadioButton.TabStop = true;
            this.PreciseFillRadioButton.Text = "precise";
            this.PreciseFillRadioButton.UseVisualStyleBackColor = true;
            this.PreciseFillRadioButton.Click += new System.EventHandler(this.PreciseFillRadioButton_Click);
            // 
            // ShowGridCheckBox
            // 
            this.ShowGridCheckBox.AutoSize = true;
            this.ShowGridCheckBox.Checked = true;
            this.ShowGridCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowGridCheckBox.Location = new System.Drawing.Point(12, 605);
            this.ShowGridCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowGridCheckBox.Name = "ShowGridCheckBox";
            this.ShowGridCheckBox.Size = new System.Drawing.Size(79, 19);
            this.ShowGridCheckBox.TabIndex = 8;
            this.ShowGridCheckBox.Text = "Show grid";
            this.ShowGridCheckBox.UseVisualStyleBackColor = true;
            this.ShowGridCheckBox.Click += new System.EventHandler(this.ShowGridCheckBox_Click);
            // 
            // NormalMapButton
            // 
            this.NormalMapButton.Location = new System.Drawing.Point(12, 152);
            this.NormalMapButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NormalMapButton.Name = "NormalMapButton";
            this.NormalMapButton.Size = new System.Drawing.Size(172, 20);
            this.NormalMapButton.TabIndex = 1;
            this.NormalMapButton.Text = "Choose Normal Map";
            this.NormalMapButton.UseVisualStyleBackColor = true;
            this.NormalMapButton.Click += new System.EventHandler(this.NormalMapButton_Click);
            // 
            // CoefficientsGroupBox
            // 
            this.CoefficientsGroupBox.Controls.Add(this.MTrackBar);
            this.CoefficientsGroupBox.Controls.Add(this.MLabel);
            this.CoefficientsGroupBox.Controls.Add(this.KSTrackBar);
            this.CoefficientsGroupBox.Controls.Add(this.KSLabel);
            this.CoefficientsGroupBox.Controls.Add(this.KDTrackBar);
            this.CoefficientsGroupBox.Controls.Add(this.KDLabel);
            this.CoefficientsGroupBox.Controls.Add(this.KTrackBar);
            this.CoefficientsGroupBox.Controls.Add(this.KLabel);
            this.CoefficientsGroupBox.Location = new System.Drawing.Point(12, 377);
            this.CoefficientsGroupBox.Name = "CoefficientsGroupBox";
            this.CoefficientsGroupBox.Size = new System.Drawing.Size(175, 217);
            this.CoefficientsGroupBox.TabIndex = 6;
            this.CoefficientsGroupBox.TabStop = false;
            this.CoefficientsGroupBox.Text = "Coefficients";
            // 
            // MTrackBar
            // 
            this.MTrackBar.Location = new System.Drawing.Point(6, 175);
            this.MTrackBar.Maximum = 100;
            this.MTrackBar.Minimum = 1;
            this.MTrackBar.Name = "MTrackBar";
            this.MTrackBar.Size = new System.Drawing.Size(121, 45);
            this.MTrackBar.TabIndex = 3;
            this.MTrackBar.Value = 50;
            this.MTrackBar.Scroll += new System.EventHandler(this.MTrackBar_Scroll);
            // 
            // MLabel
            // 
            this.MLabel.AutoSize = true;
            this.MLabel.Location = new System.Drawing.Point(127, 175);
            this.MLabel.Name = "MLabel";
            this.MLabel.Size = new System.Drawing.Size(18, 15);
            this.MLabel.TabIndex = 4;
            this.MLabel.Text = "m";
            // 
            // KSTrackBar
            // 
            this.KSTrackBar.Location = new System.Drawing.Point(6, 124);
            this.KSTrackBar.Maximum = 100;
            this.KSTrackBar.Name = "KSTrackBar";
            this.KSTrackBar.Size = new System.Drawing.Size(121, 45);
            this.KSTrackBar.TabIndex = 3;
            this.KSTrackBar.Value = 100;
            this.KSTrackBar.Scroll += new System.EventHandler(this.KSTrackBar_Scroll);
            // 
            // KSLabel
            // 
            this.KSLabel.AutoSize = true;
            this.KSLabel.Location = new System.Drawing.Point(127, 124);
            this.KSLabel.Name = "KSLabel";
            this.KSLabel.Size = new System.Drawing.Size(18, 15);
            this.KSLabel.TabIndex = 4;
            this.KSLabel.Text = "ks";
            // 
            // KDTrackBar
            // 
            this.KDTrackBar.Location = new System.Drawing.Point(6, 73);
            this.KDTrackBar.Maximum = 100;
            this.KDTrackBar.Name = "KDTrackBar";
            this.KDTrackBar.Size = new System.Drawing.Size(121, 45);
            this.KDTrackBar.TabIndex = 3;
            this.KDTrackBar.Value = 100;
            this.KDTrackBar.Scroll += new System.EventHandler(this.KDTrackBar_Scroll);
            // 
            // KDLabel
            // 
            this.KDLabel.AutoSize = true;
            this.KDLabel.Location = new System.Drawing.Point(127, 73);
            this.KDLabel.Name = "KDLabel";
            this.KDLabel.Size = new System.Drawing.Size(20, 15);
            this.KDLabel.TabIndex = 4;
            this.KDLabel.Text = "kd";
            // 
            // KTrackBar
            // 
            this.KTrackBar.Location = new System.Drawing.Point(6, 22);
            this.KTrackBar.Maximum = 100;
            this.KTrackBar.Name = "KTrackBar";
            this.KTrackBar.Size = new System.Drawing.Size(121, 45);
            this.KTrackBar.TabIndex = 3;
            this.KTrackBar.Value = 100;
            this.KTrackBar.Scroll += new System.EventHandler(this.KTrackBar_Scroll);
            // 
            // KLabel
            // 
            this.KLabel.AutoSize = true;
            this.KLabel.Location = new System.Drawing.Point(127, 22);
            this.KLabel.Name = "KLabel";
            this.KLabel.Size = new System.Drawing.Size(13, 15);
            this.KLabel.TabIndex = 4;
            this.KLabel.Text = "k";
            // 
            // LightingGroupBox
            // 
            this.LightingGroupBox.Controls.Add(this.LightColorButton);
            this.LightingGroupBox.Controls.Add(this.HeightLabel);
            this.LightingGroupBox.Controls.Add(this.HeightTackBar);
            this.LightingGroupBox.Controls.Add(this.AnimationCheckBox);
            this.LightingGroupBox.Location = new System.Drawing.Point(12, 181);
            this.LightingGroupBox.Name = "LightingGroupBox";
            this.LightingGroupBox.Size = new System.Drawing.Size(175, 120);
            this.LightingGroupBox.TabIndex = 3;
            this.LightingGroupBox.TabStop = false;
            this.LightingGroupBox.Text = "Lighting";
            // 
            // LightColorButton
            // 
            this.LightColorButton.Location = new System.Drawing.Point(6, 85);
            this.LightColorButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LightColorButton.Name = "LightColorButton";
            this.LightColorButton.Size = new System.Drawing.Size(121, 20);
            this.LightColorButton.TabIndex = 5;
            this.LightColorButton.Text = "change color";
            this.LightColorButton.UseVisualStyleBackColor = true;
            this.LightColorButton.Click += new System.EventHandler(this.LightColorButton_Click);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(126, 47);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 15);
            this.HeightLabel.TabIndex = 4;
            this.HeightLabel.Text = "height";
            // 
            // HeightTackBar
            // 
            this.HeightTackBar.Location = new System.Drawing.Point(6, 47);
            this.HeightTackBar.Maximum = 300;
            this.HeightTackBar.Minimum = 1;
            this.HeightTackBar.Name = "HeightTackBar";
            this.HeightTackBar.Size = new System.Drawing.Size(121, 45);
            this.HeightTackBar.TabIndex = 3;
            this.HeightTackBar.Value = 100;
            this.HeightTackBar.Scroll += new System.EventHandler(this.HeightTackBar_Scroll);
            // 
            // AnimationCheckBox
            // 
            this.AnimationCheckBox.AutoSize = true;
            this.AnimationCheckBox.Checked = true;
            this.AnimationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnimationCheckBox.Location = new System.Drawing.Point(6, 22);
            this.AnimationCheckBox.Name = "AnimationCheckBox";
            this.AnimationCheckBox.Size = new System.Drawing.Size(71, 19);
            this.AnimationCheckBox.TabIndex = 2;
            this.AnimationCheckBox.Text = "Animate";
            this.AnimationCheckBox.UseVisualStyleBackColor = true;
            // 
            // BackgroundGroupBox
            // 
            this.BackgroundGroupBox.Controls.Add(this.TextureRadioButton);
            this.BackgroundGroupBox.Controls.Add(this.ColorRadioButton);
            this.BackgroundGroupBox.Location = new System.Drawing.Point(12, 74);
            this.BackgroundGroupBox.Name = "BackgroundGroupBox";
            this.BackgroundGroupBox.Size = new System.Drawing.Size(175, 73);
            this.BackgroundGroupBox.TabIndex = 1;
            this.BackgroundGroupBox.TabStop = false;
            this.BackgroundGroupBox.Text = "Image";
            // 
            // TextureRadioButton
            // 
            this.TextureRadioButton.AutoSize = true;
            this.TextureRadioButton.Checked = true;
            this.TextureRadioButton.Location = new System.Drawing.Point(6, 44);
            this.TextureRadioButton.Name = "TextureRadioButton";
            this.TextureRadioButton.Size = new System.Drawing.Size(91, 19);
            this.TextureRadioButton.TabIndex = 0;
            this.TextureRadioButton.TabStop = true;
            this.TextureRadioButton.Text = "from texture";
            this.TextureRadioButton.UseVisualStyleBackColor = true;
            this.TextureRadioButton.Click += new System.EventHandler(this.TextureRadioButton_Click);
            // 
            // ColorRadioButton
            // 
            this.ColorRadioButton.AutoSize = true;
            this.ColorRadioButton.Location = new System.Drawing.Point(6, 19);
            this.ColorRadioButton.Name = "ColorRadioButton";
            this.ColorRadioButton.Size = new System.Drawing.Size(81, 19);
            this.ColorRadioButton.TabIndex = 0;
            this.ColorRadioButton.Text = "from color";
            this.ColorRadioButton.UseVisualStyleBackColor = true;
            this.ColorRadioButton.Click += new System.EventHandler(this.ColorRadioButton_Click);
            // 
            // TriangulationLabel
            // 
            this.TriangulationLabel.AutoSize = true;
            this.TriangulationLabel.Location = new System.Drawing.Point(12, 9);
            this.TriangulationLabel.Name = "TriangulationLabel";
            this.TriangulationLabel.Size = new System.Drawing.Size(127, 15);
            this.TriangulationLabel.TabIndex = 1;
            this.TriangulationLabel.Text = "Triangulation precision";
            // 
            // TriangulationTrackBar
            // 
            this.TriangulationTrackBar.Location = new System.Drawing.Point(12, 27);
            this.TriangulationTrackBar.Minimum = 1;
            this.TriangulationTrackBar.Name = "TriangulationTrackBar";
            this.TriangulationTrackBar.Size = new System.Drawing.Size(175, 45);
            this.TriangulationTrackBar.TabIndex = 0;
            this.TriangulationTrackBar.Value = 6;
            this.TriangulationTrackBar.Scroll += new System.EventHandler(this.TriangulationTrackBar_Scroll);
            // 
            // NewObservatorCheckBox
            // 
            this.NewObservatorCheckBox.AutoSize = true;
            this.NewObservatorCheckBox.Location = new System.Drawing.Point(3, 8);
            this.NewObservatorCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewObservatorCheckBox.Name = "NewObservatorCheckBox";
            this.NewObservatorCheckBox.Size = new System.Drawing.Size(121, 19);
            this.NewObservatorCheckBox.TabIndex = 1;
            this.NewObservatorCheckBox.Text = "Nowy Obserwator";
            this.NewObservatorCheckBox.UseVisualStyleBackColor = true;
            // 
            // MyPictureBox
            // 
            this.MyPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyPictureBox.Location = new System.Drawing.Point(87, 3);
            this.MyPictureBox.Name = "MyPictureBox";
            this.MyPictureBox.Size = new System.Drawing.Size(528, 627);
            this.MyPictureBox.TabIndex = 0;
            this.MyPictureBox.TabStop = false;
            this.MyPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPictureBox_Paint);
            this.MyPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyPictureBox_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 630);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GK_proj2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.FillMethodGroupBox.ResumeLayout(false);
            this.FillMethodGroupBox.PerformLayout();
            this.CoefficientsGroupBox.ResumeLayout(false);
            this.CoefficientsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KSTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KDTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KTrackBar)).EndInit();
            this.LightingGroupBox.ResumeLayout(false);
            this.LightingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTackBar)).EndInit();
            this.BackgroundGroupBox.ResumeLayout(false);
            this.BackgroundGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TriangulationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox MyPictureBox;
        private System.Windows.Forms.TrackBar TriangulationTrackBar;
        private System.Windows.Forms.Label TriangulationLabel;
        private System.Windows.Forms.CheckBox AnimationCheckBox;
        private System.Windows.Forms.GroupBox BackgroundGroupBox;
        private System.Windows.Forms.RadioButton TextureRadioButton;
        private System.Windows.Forms.RadioButton ColorRadioButton;
        private System.Windows.Forms.GroupBox LightingGroupBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TrackBar HeightTackBar;
        private System.Windows.Forms.GroupBox CoefficientsGroupBox;
        private System.Windows.Forms.TrackBar MTrackBar;
        private System.Windows.Forms.Label MLabel;
        private System.Windows.Forms.TrackBar KSTrackBar;
        private System.Windows.Forms.Label KSLabel;
        private System.Windows.Forms.TrackBar KDTrackBar;
        private System.Windows.Forms.Label KDLabel;
        private System.Windows.Forms.TrackBar KTrackBar;
        private System.Windows.Forms.Label KLabel;
        private System.Windows.Forms.Button LightColorButton;
        private System.Windows.Forms.Button NormalMapButton;
        private System.Windows.Forms.CheckBox ShowGridCheckBox;
        private System.Windows.Forms.GroupBox FillMethodGroupBox;
        private System.Windows.Forms.RadioButton InterpolatedFillRadioButton;
        private System.Windows.Forms.RadioButton PreciseFillRadioButton;
        private System.Windows.Forms.CheckBox NewObservatorCheckBox;
    }
}

