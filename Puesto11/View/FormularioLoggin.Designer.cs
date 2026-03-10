namespace Puesto11

{
    partial class FormularioLoggin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioLoggin));
            pnl_izquierda = new Panel();
            btn_MinimizarLoggin = new PictureBox();
            btn_CerrarLoggin = new PictureBox();
            iconSplitButton1 = new FontAwesome.Sharp.IconSplitButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btn_Acceder = new FontAwesome.Sharp.IconButton();
            rjTextBox1_Usuario = new RJTextBox();
            linkLabel2 = new LinkLabel();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textbox_password = new RJTextBox();
            picturePasswordVer = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            title_inciar = new Label();
            pictureBox1 = new PictureBox();
            pnl_izquierda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_MinimizarLoggin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_CerrarLoggin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picturePasswordVer).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnl_izquierda
            // 
            pnl_izquierda.BackColor = Color.FromArgb(58, 73, 118);
            pnl_izquierda.Controls.Add(btn_MinimizarLoggin);
            pnl_izquierda.Dock = DockStyle.Top;
            pnl_izquierda.Location = new Point(0, 0);
            pnl_izquierda.Name = "pnl_izquierda";
            pnl_izquierda.Size = new Size(652, 45);
            pnl_izquierda.TabIndex = 0;
            pnl_izquierda.Paint += pnl_izquierda_Paint;
            pnl_izquierda.MouseDown += pnl_izquierda_MouseDown;
            // 
            // btn_MinimizarLoggin
            // 
            btn_MinimizarLoggin.BackColor = Color.FromArgb(34, 33, 74);
            btn_MinimizarLoggin.BorderStyle = BorderStyle.FixedSingle;
            btn_MinimizarLoggin.Image = (Image)resources.GetObject("btn_MinimizarLoggin.Image");
            btn_MinimizarLoggin.Location = new Point(192, 225);
            btn_MinimizarLoggin.Name = "btn_MinimizarLoggin";
            btn_MinimizarLoggin.Size = new Size(43, 33);
            btn_MinimizarLoggin.SizeMode = PictureBoxSizeMode.Zoom;
            btn_MinimizarLoggin.TabIndex = 10;
            btn_MinimizarLoggin.TabStop = false;
            btn_MinimizarLoggin.Click += picture_Minimizar_Click;
            // 
            // btn_CerrarLoggin
            // 
            btn_CerrarLoggin.BorderStyle = BorderStyle.FixedSingle;
            btn_CerrarLoggin.Image = (Image)resources.GetObject("btn_CerrarLoggin.Image");
            btn_CerrarLoggin.Location = new Point(309, 0);
            btn_CerrarLoggin.Name = "btn_CerrarLoggin";
            btn_CerrarLoggin.Size = new Size(50, 37);
            btn_CerrarLoggin.SizeMode = PictureBoxSizeMode.Zoom;
            btn_CerrarLoggin.TabIndex = 11;
            btn_CerrarLoggin.TabStop = false;
            btn_CerrarLoggin.Click += picture_Cerrar_Click;
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            iconSplitButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btn_Acceder
            // 
            btn_Acceder.BackColor = Color.FromArgb(192, 0, 0);
            btn_Acceder.FlatAppearance.BorderSize = 0;
            btn_Acceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_Acceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_Acceder.FlatStyle = FlatStyle.Flat;
            btn_Acceder.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btn_Acceder.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Acceder.ForeColor = SystemColors.ButtonHighlight;
            btn_Acceder.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            btn_Acceder.IconColor = Color.MintCream;
            btn_Acceder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Acceder.IconSize = 42;
            btn_Acceder.Location = new Point(14, 225);
            btn_Acceder.Name = "btn_Acceder";
            btn_Acceder.Rotation = 179D;
            btn_Acceder.Size = new Size(333, 46);
            btn_Acceder.TabIndex = 3;
            btn_Acceder.Text = "         Ingresar";
            btn_Acceder.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Acceder.UseVisualStyleBackColor = false;
            btn_Acceder.Click += btn_Acceder_Click;
            // 
            // rjTextBox1_Usuario
            // 
            rjTextBox1_Usuario.BackColor = Color.White;
            rjTextBox1_Usuario.BorderColor = Color.FromArgb(58, 73, 118);
            rjTextBox1_Usuario.BorderFocusColor = Color.DarkMagenta;
            rjTextBox1_Usuario.BorderSize = 2;
            rjTextBox1_Usuario.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1_Usuario.ForeColor = Color.Black;
            rjTextBox1_Usuario.Location = new Point(17, 115);
            rjTextBox1_Usuario.Margin = new Padding(4);
            rjTextBox1_Usuario.Multiline = false;
            rjTextBox1_Usuario.Name = "rjTextBox1_Usuario";
            rjTextBox1_Usuario.Padding = new Padding(7);
            rjTextBox1_Usuario.PasswordChar = false;
            rjTextBox1_Usuario.Size = new Size(333, 36);
            rjTextBox1_Usuario.TabIndex = 14;
            rjTextBox1_Usuario.Texts = "";
            rjTextBox1_Usuario.UnderlinedStyle = false;
            rjTextBox1_Usuario._TextChanged += rjTextBox1_Usuario__TextChanged;
            rjTextBox1_Usuario.Enter += rjTextBox1_Usuario_Enter;
            rjTextBox1_Usuario.Leave += rjTextBox1_Usuario_Leave;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.FromArgb(0, 122, 204);
            linkLabel2.AutoSize = true;
            linkLabel2.DisabledLinkColor = Color.Blue;
            linkLabel2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.Navy;
            linkLabel2.Location = new Point(229, 285);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(67, 17);
            linkLabel2.TabIndex = 16;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Regisrate";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 73, 118);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 362);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 14);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(80, 92);
            label1.Name = "label1";
            label1.Size = new Size(206, 19);
            label1.TabIndex = 18;
            label1.Text = "Usuario ó Correo Electronico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(129, 155);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 19;
            label2.Text = "Contraseña:";
            // 
            // textbox_password
            // 
            textbox_password.BackColor = Color.White;
            textbox_password.BorderColor = Color.FromArgb(58, 73, 118);
            textbox_password.BorderFocusColor = Color.DarkMagenta;
            textbox_password.BorderSize = 2;
            textbox_password.Font = new Font("Century Gothic", 12F);
            textbox_password.ForeColor = Color.Black;
            textbox_password.Location = new Point(16, 177);
            textbox_password.Margin = new Padding(6, 5, 6, 5);
            textbox_password.Multiline = false;
            textbox_password.Name = "textbox_password";
            textbox_password.Padding = new Padding(10, 9, 10, 9);
            textbox_password.PasswordChar = false;
            textbox_password.Size = new Size(331, 40);
            textbox_password.TabIndex = 20;
            textbox_password.Texts = "";
            textbox_password.UnderlinedStyle = false;
            // 
            // picturePasswordVer
            // 
            picturePasswordVer.Image = Properties.Resources.show;
            picturePasswordVer.Location = new Point(284, 182);
            picturePasswordVer.Name = "picturePasswordVer";
            picturePasswordVer.Size = new Size(54, 28);
            picturePasswordVer.SizeMode = PictureBoxSizeMode.Zoom;
            picturePasswordVer.TabIndex = 21;
            picturePasswordVer.TabStop = false;
            picturePasswordVer.Click += picturePasswordVer_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btn_CerrarLoggin);
            panel2.Controls.Add(title_inciar);
            panel2.Controls.Add(rjTextBox1_Usuario);
            panel2.Controls.Add(btn_Acceder);
            panel2.Controls.Add(picturePasswordVer);
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textbox_password);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(290, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 320);
            panel2.TabIndex = 22;
            panel2.Paint += panel2_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(80, 285);
            label3.Name = "label3";
            label3.Size = new Size(143, 19);
            label3.TabIndex = 25;
            label3.Text = "¿No tienes cuenta?";
            // 
            // title_inciar
            // 
            title_inciar.AutoSize = true;
            title_inciar.BackColor = Color.Transparent;
            title_inciar.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Regular, GraphicsUnit.World);
            title_inciar.ForeColor = Color.Black;
            title_inciar.Location = new Point(87, 39);
            title_inciar.Margin = new Padding(2, 0, 2, 0);
            title_inciar.Name = "title_inciar";
            title_inciar.Size = new Size(209, 34);
            title_inciar.TabIndex = 24;
            title_inciar.Text = "Iniciar sesión";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bARBER;
            pictureBox1.Location = new Point(0, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(292, 320);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // FormularioLoggin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(652, 376);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnl_izquierda);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioLoggin";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormularioLoggin";
            Load += FormularioLoggin_Load;
            MouseDown += FormularioLoggin_MouseDown;
            pnl_izquierda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_MinimizarLoggin).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_CerrarLoggin).EndInit();
            ((System.ComponentModel.ISupportInitialize)picturePasswordVer).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_izquierda;
        private FontAwesome.Sharp.IconSplitButton iconSplitButton1;
        private ContextMenuStrip contextMenuStrip1;
        private FontAwesome.Sharp.IconButton btn_Acceder;
        private PictureBox btn_MinimizarLoggin;
        private PictureBox btn_CerrarLoggin;
        private FontAwesome.Sharp.IconPictureBox picture_User;
        private RJTextBox rjTextBox1_Usuario;
        private RJTextBox rjTextBox1_password;
        private LinkLabel linkLabel2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private RJTextBox textbox_password;
        private PictureBox picturePasswordVer;
        private Panel panel2;
        private Label title_inciar;
        private Label label3;
        private PictureBox pictureBox1;
    }
}