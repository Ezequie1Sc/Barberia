namespace Puesto11
{
    partial class FormularioPerfilEdit
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
            lbl_ApellidoBd = new Label();
            panel4_View = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel8 = new Panel();
            txt_UserBD = new RJTextBox();
            label10 = new Label();
            panel2 = new Panel();
            txt_Nombre = new RJTextBox();
            label1 = new Label();
            panel7 = new Panel();
            txt_ApeBD = new RJTextBox();
            label9 = new Label();
            panel6 = new Panel();
            txt_EmailBD = new RJTextBox();
            label4 = new Label();
            panel3 = new Panel();
            txt_newPass = new RJTextBox();
            label7 = new Label();
            panel5 = new Panel();
            txt_confiNewPass = new RJTextBox();
            LinkPassw = new LinkLabel();
            label8 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label5 = new Label();
            txt_password = new RJTextBox();
            btn_Aceptar = new FontAwesome.Sharp.IconButton();
            btn_CambiarFoto = new FontAwesome.Sharp.IconButton();
            lbl_name = new Label();
            lbl_NombreBd = new Label();
            lbl_Email = new Label();
            lbl_EmailBd = new Label();
            label11 = new Label();
            rjCircle1 = new BarberFex.btn_personalizado.RJCircle();
            label6 = new Label();
            lbl_UsuarioBd = new Label();
            LinkEdit = new LinkLabel();
            label2 = new Label();
            panel1 = new Panel();
            panel4_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rjCircle1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_ApellidoBd
            // 
            lbl_ApellidoBd.Font = new Font("Century Gothic", 10F);
            lbl_ApellidoBd.ForeColor = Color.Black;
            lbl_ApellidoBd.Location = new Point(189, 394);
            lbl_ApellidoBd.Name = "lbl_ApellidoBd";
            lbl_ApellidoBd.Size = new Size(66, 38);
            lbl_ApellidoBd.TabIndex = 31;
            lbl_ApellidoBd.Text = "Apellido";
            lbl_ApellidoBd.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel4_View
            // 
            panel4_View.BackColor = Color.SeaShell;
            panel4_View.Controls.Add(pictureBox1);
            panel4_View.Controls.Add(label3);
            panel4_View.Controls.Add(flowLayoutPanel1);
            panel4_View.Controls.Add(btn_Aceptar);
            panel4_View.Controls.Add(btn_CambiarFoto);
            panel4_View.Location = new Point(364, 0);
            panel4_View.Name = "panel4_View";
            panel4_View.Size = new Size(413, 507);
            panel4_View.TabIndex = 23;
            panel4_View.Visible = false;
            panel4_View.Paint += panel4_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.show;
            pictureBox1.Location = new Point(372, 397);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Century Gothic", 30F);
            label3.ForeColor = Color.FromArgb(58, 73, 118);
            label3.Location = new Point(33, 20);
            label3.Name = "label3";
            label3.Size = new Size(282, 48);
            label3.TabIndex = 40;
            label3.Text = "Editar Perfil";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Location = new Point(27, 71);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(356, 368);
            flowLayoutPanel1.TabIndex = 36;
            // 
            // panel8
            // 
            panel8.Controls.Add(txt_UserBD);
            panel8.Controls.Add(label10);
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(341, 42);
            panel8.TabIndex = 37;
            // 
            // txt_UserBD
            // 
            txt_UserBD.BackColor = Color.SeaShell;
            txt_UserBD.BorderColor = Color.FromArgb(58, 73, 118);
            txt_UserBD.BorderFocusColor = Color.DarkMagenta;
            txt_UserBD.BorderSize = 2;
            txt_UserBD.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_UserBD.ForeColor = Color.DimGray;
            txt_UserBD.Location = new Point(96, 3);
            txt_UserBD.Margin = new Padding(4);
            txt_UserBD.Multiline = false;
            txt_UserBD.Name = "txt_UserBD";
            txt_UserBD.Padding = new Padding(7);
            txt_UserBD.PasswordChar = false;
            txt_UserBD.Size = new Size(241, 36);
            txt_UserBD.TabIndex = 15;
            txt_UserBD.Texts = "";
            txt_UserBD.UnderlinedStyle = false;
            // 
            // label10
            // 
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(3, 4);
            label10.Name = "label10";
            label10.Size = new Size(100, 28);
            label10.TabIndex = 0;
            label10.Text = "Usuario:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(txt_Nombre);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 42);
            panel2.TabIndex = 23;
            panel2.Paint += panel2_Paint;
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.SeaShell;
            txt_Nombre.BorderColor = Color.FromArgb(58, 73, 118);
            txt_Nombre.BorderFocusColor = Color.DarkMagenta;
            txt_Nombre.BorderSize = 2;
            txt_Nombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_Nombre.ForeColor = Color.DimGray;
            txt_Nombre.Location = new Point(96, 3);
            txt_Nombre.Margin = new Padding(4);
            txt_Nombre.Multiline = false;
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Padding = new Padding(7);
            txt_Nombre.PasswordChar = false;
            txt_Nombre.Size = new Size(241, 36);
            txt_Nombre.TabIndex = 15;
            txt_Nombre.Texts = "";
            txt_Nombre.UnderlinedStyle = false;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 9F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(100, 28);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            panel7.Controls.Add(txt_ApeBD);
            panel7.Controls.Add(label9);
            panel7.Location = new Point(3, 99);
            panel7.Name = "panel7";
            panel7.Size = new Size(345, 42);
            panel7.TabIndex = 36;
            // 
            // txt_ApeBD
            // 
            txt_ApeBD.BackColor = Color.SeaShell;
            txt_ApeBD.BorderColor = Color.FromArgb(58, 73, 118);
            txt_ApeBD.BorderFocusColor = Color.DarkMagenta;
            txt_ApeBD.BorderSize = 2;
            txt_ApeBD.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_ApeBD.ForeColor = Color.DimGray;
            txt_ApeBD.Location = new Point(96, 3);
            txt_ApeBD.Margin = new Padding(4);
            txt_ApeBD.Multiline = false;
            txt_ApeBD.Name = "txt_ApeBD";
            txt_ApeBD.Padding = new Padding(7);
            txt_ApeBD.PasswordChar = false;
            txt_ApeBD.Size = new Size(245, 36);
            txt_ApeBD.TabIndex = 15;
            txt_ApeBD.Texts = "";
            txt_ApeBD.UnderlinedStyle = false;
            // 
            // label9
            // 
            label9.Font = new Font("Century Gothic", 9F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(3, 4);
            label9.Name = "label9";
            label9.Size = new Size(100, 28);
            label9.TabIndex = 0;
            label9.Text = "Apellido:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            label9.Click += label9_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(txt_EmailBD);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(3, 147);
            panel6.Name = "panel6";
            panel6.Size = new Size(341, 42);
            panel6.TabIndex = 26;
            // 
            // txt_EmailBD
            // 
            txt_EmailBD.BackColor = Color.SeaShell;
            txt_EmailBD.BorderColor = Color.FromArgb(58, 73, 118);
            txt_EmailBD.BorderFocusColor = Color.DarkMagenta;
            txt_EmailBD.BorderSize = 2;
            txt_EmailBD.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_EmailBD.ForeColor = Color.DimGray;
            txt_EmailBD.Location = new Point(96, 2);
            txt_EmailBD.Margin = new Padding(4);
            txt_EmailBD.Multiline = false;
            txt_EmailBD.Name = "txt_EmailBD";
            txt_EmailBD.Padding = new Padding(7);
            txt_EmailBD.PasswordChar = false;
            txt_EmailBD.Size = new Size(241, 36);
            txt_EmailBD.TabIndex = 16;
            txt_EmailBD.Texts = "";
            txt_EmailBD.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.Font = new Font("Century Gothic", 9F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(3, -3);
            label4.Name = "label4";
            label4.Size = new Size(100, 38);
            label4.TabIndex = 0;
            label4.Text = "Correo Electronico:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(txt_newPass);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(3, 195);
            panel3.Name = "panel3";
            panel3.Size = new Size(341, 44);
            panel3.TabIndex = 24;
            // 
            // txt_newPass
            // 
            txt_newPass.BackColor = Color.SeaShell;
            txt_newPass.BorderColor = Color.FromArgb(58, 73, 118);
            txt_newPass.BorderFocusColor = Color.DarkMagenta;
            txt_newPass.BorderSize = 2;
            txt_newPass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_newPass.ForeColor = Color.DimGray;
            txt_newPass.Location = new Point(96, 0);
            txt_newPass.Margin = new Padding(4);
            txt_newPass.Multiline = false;
            txt_newPass.Name = "txt_newPass";
            txt_newPass.Padding = new Padding(7);
            txt_newPass.PasswordChar = false;
            txt_newPass.Size = new Size(241, 36);
            txt_newPass.TabIndex = 16;
            txt_newPass.Texts = "";
            txt_newPass.UnderlinedStyle = false;
            // 
            // label7
            // 
            label7.Font = new Font("Century Gothic", 9F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(97, 38);
            label7.TabIndex = 0;
            label7.Text = "Nueva Contraseña:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.Controls.Add(txt_confiNewPass);
            panel5.Controls.Add(LinkPassw);
            panel5.Controls.Add(label8);
            panel5.Location = new Point(3, 245);
            panel5.Name = "panel5";
            panel5.Size = new Size(341, 72);
            panel5.TabIndex = 25;
            // 
            // txt_confiNewPass
            // 
            txt_confiNewPass.BackColor = Color.SeaShell;
            txt_confiNewPass.BorderColor = Color.FromArgb(58, 73, 118);
            txt_confiNewPass.BorderFocusColor = Color.DarkMagenta;
            txt_confiNewPass.BorderSize = 2;
            txt_confiNewPass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_confiNewPass.ForeColor = Color.DimGray;
            txt_confiNewPass.Location = new Point(100, 32);
            txt_confiNewPass.Margin = new Padding(4);
            txt_confiNewPass.Multiline = false;
            txt_confiNewPass.Name = "txt_confiNewPass";
            txt_confiNewPass.Padding = new Padding(7);
            txt_confiNewPass.PasswordChar = false;
            txt_confiNewPass.Size = new Size(241, 36);
            txt_confiNewPass.TabIndex = 16;
            txt_confiNewPass.Texts = "";
            txt_confiNewPass.UnderlinedStyle = false;
            // 
            // LinkPassw
            // 
            LinkPassw.AutoSize = true;
            LinkPassw.Font = new Font("Segoe UI", 10F);
            LinkPassw.Location = new Point(203, 9);
            LinkPassw.Name = "LinkPassw";
            LinkPassw.Size = new Size(134, 19);
            LinkPassw.TabIndex = 36;
            LinkPassw.TabStop = true;
            LinkPassw.Text = "Cambiar Contraseña";
            LinkPassw.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label8
            // 
            label8.Font = new Font("Century Gothic", 9F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(-3, 9);
            label8.Name = "label8";
            label8.Size = new Size(127, 42);
            label8.TabIndex = 0;
            label8.Text = " Confirmar la nueva Contraseña:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Controls.Add(txt_password);
            flowLayoutPanel2.Location = new Point(3, 323);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(355, 47);
            flowLayoutPanel2.TabIndex = 28;
            // 
            // label5
            // 
            label5.Font = new Font("Century Gothic", 9F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(86, 36);
            label5.TabIndex = 27;
            label5.Text = "Ingresa Tu contraseña:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.SeaShell;
            txt_password.BorderColor = Color.FromArgb(58, 73, 118);
            txt_password.BorderFocusColor = Color.DarkMagenta;
            txt_password.BorderSize = 2;
            txt_password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.ForeColor = Color.DimGray;
            txt_password.Location = new Point(96, 4);
            txt_password.Margin = new Padding(4);
            txt_password.Multiline = false;
            txt_password.Name = "txt_password";
            txt_password.Padding = new Padding(7);
            txt_password.PasswordChar = false;
            txt_password.Size = new Size(241, 36);
            txt_password.TabIndex = 17;
            txt_password.Texts = "";
            txt_password.UnderlinedStyle = false;
            txt_password._TextChanged += rjTextBox5__TextChanged;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_Aceptar.ForeColor = Color.Green;
            btn_Aceptar.IconChar = FontAwesome.Sharp.IconChar.Check;
            btn_Aceptar.IconColor = Color.Green;
            btn_Aceptar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Aceptar.IconSize = 23;
            btn_Aceptar.ImageAlign = ContentAlignment.BottomLeft;
            btn_Aceptar.Location = new Point(244, 464);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(139, 28);
            btn_Aceptar.TabIndex = 18;
            btn_Aceptar.Text = "Actualizar";
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += btn_Aceptar_Click;
            // 
            // btn_CambiarFoto
            // 
            btn_CambiarFoto.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_CambiarFoto.ForeColor = Color.Green;
            btn_CambiarFoto.IconChar = FontAwesome.Sharp.IconChar.Camera;
            btn_CambiarFoto.IconColor = Color.Green;
            btn_CambiarFoto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CambiarFoto.IconSize = 23;
            btn_CambiarFoto.ImageAlign = ContentAlignment.BottomLeft;
            btn_CambiarFoto.Location = new Point(46, 464);
            btn_CambiarFoto.Name = "btn_CambiarFoto";
            btn_CambiarFoto.Size = new Size(151, 28);
            btn_CambiarFoto.TabIndex = 32;
            btn_CambiarFoto.Text = "Cambiar Foto";
            btn_CambiarFoto.UseVisualStyleBackColor = true;
            btn_CambiarFoto.Visible = false;
            btn_CambiarFoto.Click += iconButton1_Click;
            // 
            // lbl_name
            // 
            lbl_name.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            lbl_name.ForeColor = Color.Black;
            lbl_name.Location = new Point(62, 360);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(86, 38);
            lbl_name.TabIndex = 26;
            lbl_name.Text = "Nombre:";
            lbl_name.TextAlign = ContentAlignment.MiddleLeft;
            lbl_name.Click += lbl_name_Click;
            // 
            // lbl_NombreBd
            // 
            lbl_NombreBd.Font = new Font("Century Gothic", 10F);
            lbl_NombreBd.ForeColor = Color.Black;
            lbl_NombreBd.Location = new Point(189, 360);
            lbl_NombreBd.Name = "lbl_NombreBd";
            lbl_NombreBd.Size = new Size(73, 38);
            lbl_NombreBd.TabIndex = 27;
            lbl_NombreBd.Text = "Nombre:";
            lbl_NombreBd.TextAlign = ContentAlignment.MiddleLeft;
            lbl_NombreBd.Click += lbl_NombreBd_Click;
            // 
            // lbl_Email
            // 
            lbl_Email.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            lbl_Email.ForeColor = Color.Black;
            lbl_Email.Location = new Point(29, 432);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(161, 38);
            lbl_Email.TabIndex = 28;
            lbl_Email.Text = "Correo Electronico:";
            lbl_Email.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_EmailBd
            // 
            lbl_EmailBd.Font = new Font("Century Gothic", 10F);
            lbl_EmailBd.ForeColor = Color.Black;
            lbl_EmailBd.Location = new Point(184, 432);
            lbl_EmailBd.Name = "lbl_EmailBd";
            lbl_EmailBd.Size = new Size(147, 38);
            lbl_EmailBd.TabIndex = 29;
            lbl_EmailBd.Text = "Correo Electronico:";
            lbl_EmailBd.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(62, 394);
            label11.Name = "label11";
            label11.Size = new Size(86, 38);
            label11.TabIndex = 30;
            label11.Text = "Apellido:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            label11.Click += label11_Click;
            // 
            // rjCircle1
            // 
            rjCircle1.BackgroundImage = Properties.Resources._1077063;
            rjCircle1.BackgroundImageLayout = ImageLayout.Stretch;
            rjCircle1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircle1.BorderColor = Color.FromArgb(58, 73, 118);
            rjCircle1.BorderColor2 = Color.FromArgb(58, 73, 118);
            rjCircle1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircle1.BorderSize = 2;
            rjCircle1.GradientAngle = 50F;
            rjCircle1.Location = new Point(62, 53);
            rjCircle1.Name = "rjCircle1";
            rjCircle1.Size = new Size(241, 241);
            rjCircle1.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircle1.TabIndex = 33;
            rjCircle1.TabStop = false;
            rjCircle1.Click += rjCircle1_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(29, 322);
            label6.Name = "label6";
            label6.Size = new Size(161, 38);
            label6.TabIndex = 34;
            label6.Text = "Nombre de Usuario:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_UsuarioBd
            // 
            lbl_UsuarioBd.Font = new Font("Century Gothic", 10F);
            lbl_UsuarioBd.ForeColor = Color.Black;
            lbl_UsuarioBd.Location = new Point(188, 323);
            lbl_UsuarioBd.Name = "lbl_UsuarioBd";
            lbl_UsuarioBd.Size = new Size(74, 38);
            lbl_UsuarioBd.TabIndex = 35;
            lbl_UsuarioBd.Text = "Usuario";
            lbl_UsuarioBd.TextAlign = ContentAlignment.MiddleLeft;
            lbl_UsuarioBd.Click += lbl_UsuarioBd_Click;
            // 
            // LinkEdit
            // 
            LinkEdit.AutoSize = true;
            LinkEdit.Font = new Font("Segoe UI", 10F);
            LinkEdit.Location = new Point(163, 303);
            LinkEdit.Name = "LinkEdit";
            LinkEdit.Size = new Size(74, 19);
            LinkEdit.TabIndex = 37;
            LinkEdit.TabStop = true;
            LinkEdit.Text = "Edit Profile";
            LinkEdit.LinkClicked += LinkEdit_LinkClicked;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 30F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(29, 9);
            label2.Name = "label2";
            label2.Size = new Size(193, 48);
            label2.TabIndex = 39;
            label2.Text = "Mi Perfil";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LinkEdit);
            panel1.Controls.Add(lbl_UsuarioBd);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(rjCircle1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(lbl_EmailBd);
            panel1.Controls.Add(lbl_Email);
            panel1.Controls.Add(lbl_NombreBd);
            panel1.Controls.Add(lbl_name);
            panel1.Controls.Add(panel4_View);
            panel1.Controls.Add(lbl_ApellidoBd);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 507);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // FormularioPerfilEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 507);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioPerfilEdit";
            Text = "FormularioPerfilEdit";
            panel4_View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rjCircle1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_ApellidoBd;
        private Panel panel4_View;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel8;
        private RJTextBox txt_UserBD;
        private Label label10;
        private Panel panel2;
        private RJTextBox txt_Nombre;
        private Label label1;
        private Panel panel7;
        private RJTextBox txt_ApeBD;
        private Label label9;
        private Panel panel6;
        private RJTextBox txt_EmailBD;
        private Label label4;
        private Panel panel3;
        private RJTextBox txt_newPass;
        private Label label7;
        private Panel panel5;
        private RJTextBox txt_confiNewPass;
        private LinkLabel LinkPassw;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label5;
        private RJTextBox txt_password;
        private FontAwesome.Sharp.IconButton btn_Aceptar;
        private FontAwesome.Sharp.IconButton btn_CambiarFoto;
        private Label lbl_name;
        private Label lbl_NombreBd;
        private Label lbl_Email;
        private Label lbl_EmailBd;
        private Label label11;
        private RJCircle rjCircle1;
        private Label label6;
        private Label lbl_UsuarioBd;
        private LinkLabel LinkEdit;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}