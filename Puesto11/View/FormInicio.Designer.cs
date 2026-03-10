namespace Puesto11
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            pictureBox1 = new PictureBox();
            btn_Acceder = new FontAwesome.Sharp.IconButton();
            btn_CerrarLoggin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_CerrarLoggin).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Cartel_Horizontal_Estamos_Contratando_Empleo_Moderno_Verde_y_Rosa__3_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_Acceder
            // 
            btn_Acceder.BackColor = Color.Brown;
            btn_Acceder.FlatAppearance.BorderSize = 0;
            btn_Acceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_Acceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_Acceder.FlatStyle = FlatStyle.Popup;
            btn_Acceder.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btn_Acceder.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Acceder.ForeColor = Color.FromArgb(192, 255, 255);
            btn_Acceder.IconChar = FontAwesome.Sharp.IconChar.CircleArrowLeft;
            btn_Acceder.IconColor = Color.White;
            btn_Acceder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Acceder.IconSize = 42;
            btn_Acceder.Location = new Point(267, 293);
            btn_Acceder.Name = "btn_Acceder";
            btn_Acceder.Size = new Size(314, 57);
            btn_Acceder.TabIndex = 4;
            btn_Acceder.Text = "ENTRAR";
            btn_Acceder.TextAlign = ContentAlignment.MiddleRight;
            btn_Acceder.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Acceder.UseVisualStyleBackColor = false;
            btn_Acceder.Click += btn_Acceder_Click;
            // 
            // btn_CerrarLoggin
            // 
            btn_CerrarLoggin.BackColor = Color.FromArgb(58, 71, 116);
            btn_CerrarLoggin.BorderStyle = BorderStyle.FixedSingle;
            btn_CerrarLoggin.Image = (Image)resources.GetObject("btn_CerrarLoggin.Image");
            btn_CerrarLoggin.Location = new Point(750, 0);
            btn_CerrarLoggin.Name = "btn_CerrarLoggin";
            btn_CerrarLoggin.Size = new Size(50, 37);
            btn_CerrarLoggin.SizeMode = PictureBoxSizeMode.Zoom;
            btn_CerrarLoggin.TabIndex = 12;
            btn_CerrarLoggin.TabStop = false;
            btn_CerrarLoggin.Click += btn_CerrarLoggin_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_CerrarLoggin);
            Controls.Add(btn_Acceder);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormInicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_CerrarLoggin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btn_Acceder;
        private PictureBox btn_CerrarLoggin;
    }
}