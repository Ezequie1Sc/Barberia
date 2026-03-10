namespace Puesto11.View
{
    partial class Catalago1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalago1));
            pictureBox1 = new PictureBox();
            picture_Cerrar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_Cerrar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Black___Orange_Minimalist_Barbershop_Discount_Promotion_Instagram_Story__1_;
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(363, 402);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // picture_Cerrar
            // 
            picture_Cerrar.BackColor = Color.FromArgb(201, 231, 227);
            picture_Cerrar.BorderStyle = BorderStyle.FixedSingle;
            picture_Cerrar.Image = (Image)resources.GetObject("picture_Cerrar.Image");
            picture_Cerrar.Location = new Point(342, 0);
            picture_Cerrar.Name = "picture_Cerrar";
            picture_Cerrar.Size = new Size(33, 26);
            picture_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            picture_Cerrar.TabIndex = 5;
            picture_Cerrar.TabStop = false;
            picture_Cerrar.Click += picture_Cerrar_Click;
            // 
            // Catalago1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 402);
            Controls.Add(picture_Cerrar);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Catalago1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalago1";
            TopMost = true;
            Load += Catalago1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_Cerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox picture_Cerrar;
    }
}