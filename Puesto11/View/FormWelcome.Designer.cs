namespace Puesto11.View
{
    partial class FormWelcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            lbl_Welcome = new Label();
            lbl_UserName = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            circularProgressBar1 = new CircularProgressBar_NET5.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Cartel_Horizontal_Estamos_Contratando_Empleo_Moderno_Verde_y_Rosa__4_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.BackColor = Color.White;
            lbl_Welcome.Font = new Font("Century Gothic", 30F);
            lbl_Welcome.ForeColor = Color.Black;
            lbl_Welcome.Location = new Point(138, 155);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.Size = new Size(306, 53);
            lbl_Welcome.TabIndex = 40;
            lbl_Welcome.Text = "¡Bienveinido!";
            lbl_Welcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_UserName
            // 
            lbl_UserName.BackColor = Color.White;
            lbl_UserName.Font = new Font("Century Gothic", 30F);
            lbl_UserName.ForeColor = Color.FromArgb(58, 73, 140);
            lbl_UserName.Location = new Point(251, 208);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(549, 48);
            lbl_UserName.TabIndex = 41;
            lbl_UserName.Text = "@username";
            lbl_UserName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 30;
            timer2.Tick += timer2_Tick;
            // 
            // circularProgressBar1
            // 
            circularProgressBar1.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            circularProgressBar1.AnimationSpeed = 500;
            circularProgressBar1.BackColor = Color.White;
            circularProgressBar1.Font = new Font("Segoe UI", 34F, FontStyle.Bold);
            circularProgressBar1.ForeColor = Color.FromArgb(64, 64, 64);
            circularProgressBar1.InnerColor = Color.FromArgb(224, 224, 224);
            circularProgressBar1.InnerMargin = 2;
            circularProgressBar1.InnerWidth = -1;
            circularProgressBar1.Location = new Point(337, 254);
            circularProgressBar1.MarqueeAnimationSpeed = 2000;
            circularProgressBar1.Name = "circularProgressBar1";
            circularProgressBar1.OuterColor = Color.Brown;
            circularProgressBar1.OuterMargin = -25;
            circularProgressBar1.OuterWidth = 26;
            circularProgressBar1.ProgressColor = Color.FromArgb(58, 73, 118);
            circularProgressBar1.ProgressWidth = 25;
            circularProgressBar1.SecondaryFont = new Font("Segoe UI", 36F);
            circularProgressBar1.Size = new Size(178, 158);
            circularProgressBar1.StartAngle = 270;
            circularProgressBar1.SubscriptColor = Color.Maroon;
            circularProgressBar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            circularProgressBar1.SubscriptText = "";
            circularProgressBar1.SuperscriptColor = Color.Brown;
            circularProgressBar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            circularProgressBar1.SuperscriptText = "%";
            circularProgressBar1.TabIndex = 42;
            circularProgressBar1.Text = "0";
            circularProgressBar1.TextMargin = new Padding(8, 8, 0, 0);
            circularProgressBar1.Value = 68;
            circularProgressBar1.Click += circularProgressBar1_Click;
            // 
            // FormWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 439);
            Controls.Add(circularProgressBar1);
            Controls.Add(lbl_UserName);
            Controls.Add(lbl_Welcome);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormWelcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormWelcome";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_Welcome;
        private Label lbl_UserName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private CircularProgressBar_NET5.CircularProgressBar circularProgressBar1;
    }
}