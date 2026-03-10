namespace Puesto11
{
    partial class EmpleadoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpleadoForm));
            panel7 = new Panel();
            lbl_IniciarSesion = new Label();
            btn_CerrarLoggin = new PictureBox();
            btn_Aceptar = new FontAwesome.Sharp.IconButton();
            btn_clean = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            rjCircle1 = new BarberFex.btn_personalizado.RJCircle();
            panel1 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel8 = new Panel();
            txt_Usuario = new RJTextBox();
            label10 = new Label();
            panel4 = new Panel();
            txt_nombree = new RJTextBox();
            label1 = new Label();
            panel9 = new Panel();
            txt_Apellido = new RJTextBox();
            label9 = new Label();
            panel10 = new Panel();
            txt_Email = new RJTextBox();
            label4 = new Label();
            panel11 = new Panel();
            txt_password = new RJTextBox();
            label7 = new Label();
            panel12 = new Panel();
            txt_confirmPassword = new RJTextBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_CerrarLoggin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rjCircle1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel8.SuspendLayout();
            panel4.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(lbl_IniciarSesion);
            panel7.Location = new Point(290, 12);
            panel7.Name = "panel7";
            panel7.Size = new Size(330, 39);
            panel7.TabIndex = 6;
            // 
            // lbl_IniciarSesion
            // 
            lbl_IniciarSesion.AutoSize = true;
            lbl_IniciarSesion.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_IniciarSesion.ForeColor = Color.White;
            lbl_IniciarSesion.Location = new Point(3, 6);
            lbl_IniciarSesion.Name = "lbl_IniciarSesion";
            lbl_IniciarSesion.Size = new Size(165, 24);
            lbl_IniciarSesion.TabIndex = 16;
            lbl_IniciarSesion.Text = "CREAR CUENTA";
            // 
            // btn_CerrarLoggin
            // 
            btn_CerrarLoggin.BorderStyle = BorderStyle.FixedSingle;
            btn_CerrarLoggin.Image = (Image)resources.GetObject("btn_CerrarLoggin.Image");
            btn_CerrarLoggin.Location = new Point(612, -1);
            btn_CerrarLoggin.Name = "btn_CerrarLoggin";
            btn_CerrarLoggin.Size = new Size(43, 33);
            btn_CerrarLoggin.SizeMode = PictureBoxSizeMode.Zoom;
            btn_CerrarLoggin.TabIndex = 15;
            btn_CerrarLoggin.TabStop = false;
            btn_CerrarLoggin.Click += btn_CerrarLoggin_Click;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.BackgroundImage = Properties.Resources._168fab7bca50a83c913a768057288d62_removebg_preview;
            btn_Aceptar.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Aceptar.ForeColor = Color.Green;
            btn_Aceptar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btn_Aceptar.IconColor = Color.Green;
            btn_Aceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Aceptar.IconSize = 23;
            btn_Aceptar.ImageAlign = ContentAlignment.BottomLeft;
            btn_Aceptar.Location = new Point(327, 404);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(131, 31);
            btn_Aceptar.TabIndex = 14;
            btn_Aceptar.Text = "Registrar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // btn_clean
            // 
            btn_clean.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_clean.ForeColor = Color.FromArgb(192, 0, 0);
            btn_clean.IconChar = FontAwesome.Sharp.IconChar.TrashCan;
            btn_clean.IconColor = Color.FromArgb(192, 0, 0);
            btn_clean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_clean.IconSize = 23;
            btn_clean.ImageAlign = ContentAlignment.BottomLeft;
            btn_clean.Location = new Point(499, 404);
            btn_clean.Name = "btn_clean";
            btn_clean.Size = new Size(131, 31);
            btn_clean.TabIndex = 15;
            btn_clean.Text = "Cancelar";
            btn_clean.UseVisualStyleBackColor = true;
            btn_clean.Click += btn_clean_Click;
            // 
            // iconButton1
            // 
            iconButton1.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.Green;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Image;
            iconButton1.IconColor = Color.Green;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 23;
            iconButton1.ImageAlign = ContentAlignment.BottomLeft;
            iconButton1.Location = new Point(73, 352);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(166, 40);
            iconButton1.TabIndex = 33;
            iconButton1.Text = "Seleccionar Foto";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // rjCircle1
            // 
            rjCircle1.BackgroundImage = Properties.Resources.Iniar;
            rjCircle1.BackgroundImageLayout = ImageLayout.Stretch;
            rjCircle1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircle1.BorderColor = Color.RoyalBlue;
            rjCircle1.BorderColor2 = Color.HotPink;
            rjCircle1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircle1.BorderSize = 2;
            rjCircle1.GradientAngle = 50F;
            rjCircle1.Location = new Point(18, 77);
            rjCircle1.Name = "rjCircle1";
            rjCircle1.Size = new Size(269, 269);
            rjCircle1.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircle1.TabIndex = 34;
            rjCircle1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(rjCircle1);
            panel1.Location = new Point(-3, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 446);
            panel1.TabIndex = 35;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(panel8);
            flowLayoutPanel2.Controls.Add(panel4);
            flowLayoutPanel2.Controls.Add(panel9);
            flowLayoutPanel2.Controls.Add(panel10);
            flowLayoutPanel2.Controls.Add(panel11);
            flowLayoutPanel2.Controls.Add(panel12);
            flowLayoutPanel2.Location = new Point(290, 57);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(348, 319);
            flowLayoutPanel2.TabIndex = 37;
            // 
            // panel8
            // 
            panel8.Controls.Add(txt_Usuario);
            panel8.Controls.Add(label10);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(341, 42);
            panel8.TabIndex = 37;
            // 
            // txt_Usuario
            // 
            txt_Usuario.BackColor = Color.FromArgb(58, 73, 118);
            txt_Usuario.BorderColor = Color.Honeydew;
            txt_Usuario.BorderFocusColor = Color.DarkMagenta;
            txt_Usuario.BorderSize = 2;
            txt_Usuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Usuario.ForeColor = Color.White;
            txt_Usuario.Location = new Point(96, 3);
            txt_Usuario.Margin = new Padding(4);
            txt_Usuario.Multiline = false;
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Padding = new Padding(7);
            txt_Usuario.PasswordChar = false;
            txt_Usuario.Size = new Size(241, 36);
            txt_Usuario.TabIndex = 15;
            txt_Usuario.Texts = "";
            txt_Usuario.UnderlinedStyle = false;
            // 
            // label10
            // 
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 4);
            label10.Name = "label10";
            label10.Size = new Size(100, 28);
            label10.TabIndex = 0;
            label10.Text = "Usuario:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            panel4.Controls.Add(txt_nombree);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(3, 51);
            panel4.Name = "panel4";
            panel4.Size = new Size(341, 42);
            panel4.TabIndex = 23;
            // 
            // txt_nombree
            // 
            txt_nombree.BackColor = Color.FromArgb(58, 73, 118);
            txt_nombree.BorderColor = Color.MintCream;
            txt_nombree.BorderFocusColor = Color.DarkMagenta;
            txt_nombree.BorderSize = 2;
            txt_nombree.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_nombree.ForeColor = Color.White;
            txt_nombree.Location = new Point(96, 3);
            txt_nombree.Margin = new Padding(4);
            txt_nombree.Multiline = false;
            txt_nombree.Name = "txt_nombree";
            txt_nombree.Padding = new Padding(7);
            txt_nombree.PasswordChar = false;
            txt_nombree.Size = new Size(241, 36);
            txt_nombree.TabIndex = 15;
            txt_nombree.Texts = "";
            txt_nombree.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            panel9.Controls.Add(txt_Apellido);
            panel9.Controls.Add(label9);
            panel9.Location = new Point(3, 99);
            panel9.Name = "panel9";
            panel9.Size = new Size(345, 42);
            panel9.TabIndex = 36;
            // 
            // txt_Apellido
            // 
            txt_Apellido.BackColor = Color.FromArgb(58, 73, 118);
            txt_Apellido.BorderColor = Color.MintCream;
            txt_Apellido.BorderFocusColor = Color.DarkMagenta;
            txt_Apellido.BorderSize = 2;
            txt_Apellido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Apellido.ForeColor = Color.White;
            txt_Apellido.Location = new Point(96, 3);
            txt_Apellido.Margin = new Padding(4);
            txt_Apellido.Multiline = false;
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Padding = new Padding(7);
            txt_Apellido.PasswordChar = false;
            txt_Apellido.Size = new Size(245, 36);
            txt_Apellido.TabIndex = 15;
            txt_Apellido.Texts = "";
            txt_Apellido.UnderlinedStyle = false;
            // 
            // label9
            // 
            label9.Font = new Font("Century Gothic", 9F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 4);
            label9.Name = "label9";
            label9.Size = new Size(100, 28);
            label9.TabIndex = 0;
            label9.Text = "Apellido:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel10
            // 
            panel10.Controls.Add(txt_Email);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(3, 147);
            panel10.Name = "panel10";
            panel10.Size = new Size(341, 42);
            panel10.TabIndex = 26;
            // 
            // txt_Email
            // 
            txt_Email.BackColor = Color.FromArgb(58, 73, 118);
            txt_Email.BorderColor = Color.MintCream;
            txt_Email.BorderFocusColor = Color.DarkMagenta;
            txt_Email.BorderSize = 2;
            txt_Email.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Email.ForeColor = Color.White;
            txt_Email.Location = new Point(95, 8);
            txt_Email.Margin = new Padding(4);
            txt_Email.Multiline = false;
            txt_Email.Name = "txt_Email";
            txt_Email.Padding = new Padding(7);
            txt_Email.PasswordChar = false;
            txt_Email.Size = new Size(241, 36);
            txt_Email.TabIndex = 16;
            txt_Email.Texts = "";
            txt_Email.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.Font = new Font("Century Gothic", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, -3);
            label4.Name = "label4";
            label4.Size = new Size(100, 38);
            label4.TabIndex = 0;
            label4.Text = "Correo Electronico:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel11
            // 
            panel11.Controls.Add(txt_password);
            panel11.Controls.Add(label7);
            panel11.Location = new Point(3, 195);
            panel11.Name = "panel11";
            panel11.Size = new Size(341, 59);
            panel11.TabIndex = 24;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.FromArgb(58, 73, 118);
            txt_password.BorderColor = Color.MintCream;
            txt_password.BorderFocusColor = Color.DarkMagenta;
            txt_password.BorderSize = 2;
            txt_password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.ForeColor = Color.White;
            txt_password.Location = new Point(96, 8);
            txt_password.Margin = new Padding(4);
            txt_password.Multiline = false;
            txt_password.Name = "txt_password";
            txt_password.Padding = new Padding(7);
            txt_password.PasswordChar = false;
            txt_password.Size = new Size(241, 36);
            txt_password.TabIndex = 16;
            txt_password.Texts = "";
            txt_password.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.Font = new Font("Century Gothic", 9F);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(0, 6);
            label7.Name = "label7";
            label7.Size = new Size(97, 38);
            label7.TabIndex = 0;
            label7.Text = "Contraseña:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel12
            // 
            panel12.Controls.Add(txt_confirmPassword);
            panel12.Controls.Add(label8);
            panel12.Location = new Point(3, 260);
            panel12.Name = "panel12";
            panel12.Size = new Size(341, 63);
            panel12.TabIndex = 25;
            // 
            // txt_confirmPassword
            // 
            txt_confirmPassword.BackColor = Color.FromArgb(58, 73, 118);
            txt_confirmPassword.BorderColor = Color.MintCream;
            txt_confirmPassword.BorderFocusColor = Color.DarkMagenta;
            txt_confirmPassword.BorderSize = 2;
            txt_confirmPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_confirmPassword.ForeColor = Color.White;
            txt_confirmPassword.Location = new Point(100, 16);
            txt_confirmPassword.Margin = new Padding(4);
            txt_confirmPassword.Multiline = true;
            txt_confirmPassword.Name = "txt_confirmPassword";
            txt_confirmPassword.Padding = new Padding(7);
            txt_confirmPassword.PasswordChar = true;
            txt_confirmPassword.Size = new Size(241, 36);
            txt_confirmPassword.TabIndex = 16;
            txt_confirmPassword.Texts = "";
            txt_confirmPassword.UnderlinedStyle = false;
            // 
            // label8
            // 
            label8.Font = new Font("Century Gothic", 9F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(0, 10);
            label8.Name = "label8";
            label8.Size = new Size(99, 42);
            label8.TabIndex = 0;
            label8.Text = " Confirmar la Contraseña:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.show;
            pictureBox1.Location = new Point(637, 258);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // EmpleadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 73, 118);
            ClientSize = new Size(667, 447);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Aceptar);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(btn_clean);
            Controls.Add(panel1);
            Controls.Add(btn_CerrarLoggin);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmpleadoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EmpleadoForm";
            Load += EmpleadoForm_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_CerrarLoggin).EndInit();
            ((System.ComponentModel.ISupportInitialize)rjCircle1).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel7;
        private FontAwesome.Sharp.IconButton btn_Aceptar;
        private PictureBox btn_CerrarLoggin;
        private Label lbl_IniciarSesion;
        private FontAwesome.Sharp.IconButton btn_clean;
        private RJTextBox tbxConfirmarPassword;
        private RJTextBox tbx_Password;
        private RJTextBox tbxEmail;
        private RJTextBox tbxNombre;
        private FontAwesome.Sharp.IconButton iconButton1;
        private RJCircle rjCircle1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel8;
        private RJTextBox txt_Usuario;
        private Label label10;
        private Panel panel4;
        private RJTextBox txt_nombree;
        private Label label1;
        private Panel panel9;
        private RJTextBox txt_Apellido;
        private Label label9;
        private Panel panel10;
        private RJTextBox txt_Email;
        private Label label4;
        private Panel panel11;
        private Label label7;
        private Panel panel12;
        private RJTextBox txt_confirmPassword;
        private Label label8;
        private RJTextBox txt_password;
        private PictureBox pictureBox1;
    }
}