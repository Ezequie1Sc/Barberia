using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Puesto11
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
            components = new System.ComponentModel.Container();
            fileSystemWatcher1 = new FileSystemWatcher();
            panelMenu = new Panel();
            iconButton4 = new IconButton();
            btn_Product = new IconButton();
            iconButton2 = new IconButton();
            iconButton1 = new IconButton();
            btn_GolesAsi = new IconButton();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbl_Correo = new Label();
            lbl_Nombre = new Label();
            fileSystemWatcher2 = new FileSystemWatcher();
            panel_titulo = new Panel();
            picture_Minimizar = new PictureBox();
            picture_Cerrar = new PictureBox();
            label1 = new Label();
            icono_inicio = new IconPictureBox();
            lbl_Home = new Label();
            pnl_Shadow = new Panel();
            iconSplitButton1 = new IconSplitButton();
            Fecha_Hora = new System.Windows.Forms.Timer(components);
            pnl_escritorio = new Panel();
            lbl_Fecha = new Label();
            lbl_Hora = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rjCircle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).BeginInit();
            panel_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_Cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icono_inicio).BeginInit();
            pnl_escritorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(142, 209, 198);
            panelMenu.Controls.Add(iconButton4);
            panelMenu.Controls.Add(btn_Product);
            panelMenu.Controls.Add(iconButton2);
            panelMenu.Controls.Add(iconButton1);
            panelMenu.Controls.Add(btn_GolesAsi);
            panelMenu.Controls.Add(panel1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 600);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.FromArgb(58, 73, 118);
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton4.ForeColor = Color.Gainsboro;
            iconButton4.IconChar = IconChar.DoorOpen;
            iconButton4.IconColor = Color.Red;
            iconButton4.IconFont = IconFont.Auto;
            iconButton4.IconSize = 32;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 488);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(220, 112);
            iconButton4.TabIndex = 10;
            iconButton4.Text = "SALIR";
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click_1;
            // 
            // btn_Product
            // 
            btn_Product.BackColor = Color.FromArgb(58, 73, 118);
            btn_Product.Dock = DockStyle.Top;
            btn_Product.FlatAppearance.BorderSize = 0;
            btn_Product.FlatStyle = FlatStyle.Flat;
            btn_Product.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Product.ForeColor = Color.Gainsboro;
            btn_Product.IconChar = IconChar.CartPlus;
            btn_Product.IconColor = Color.Gainsboro;
            btn_Product.IconFont = IconFont.Auto;
            btn_Product.IconSize = 32;
            btn_Product.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Product.Location = new Point(0, 401);
            btn_Product.Name = "btn_Product";
            btn_Product.Size = new Size(220, 87);
            btn_Product.TabIndex = 9;
            btn_Product.Text = "Productos";
            btn_Product.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Product.UseVisualStyleBackColor = false;
            btn_Product.Click += iconButton3_Click_1;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(58, 73, 118);
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = IconChar.Shop;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = IconFont.Auto;
            iconButton2.IconSize = 32;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 314);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(220, 87);
            iconButton2.TabIndex = 8;
            iconButton2.Text = "Catalago";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click_1;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(58, 73, 118);
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = IconChar.CalendarCheck;
            iconButton1.IconColor = Color.WhiteSmoke;
            iconButton1.IconFont = IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 227);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(220, 87);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Agendar Cita";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click_2;
            // 
            // btn_GolesAsi
            // 
            btn_GolesAsi.BackColor = Color.FromArgb(58, 73, 118);
            btn_GolesAsi.Dock = DockStyle.Top;
            btn_GolesAsi.FlatAppearance.BorderSize = 0;
            btn_GolesAsi.FlatStyle = FlatStyle.Flat;
            btn_GolesAsi.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_GolesAsi.ForeColor = Color.White;
            btn_GolesAsi.IconChar = IconChar.PenToSquare;
            btn_GolesAsi.IconColor = Color.WhiteSmoke;
            btn_GolesAsi.IconFont = IconFont.Auto;
            btn_GolesAsi.IconSize = 32;
            btn_GolesAsi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_GolesAsi.Location = new Point(0, 140);
            btn_GolesAsi.Name = "btn_GolesAsi";
            btn_GolesAsi.Size = new Size(220, 87);
            btn_GolesAsi.TabIndex = 6;
            btn_GolesAsi.Text = "Editar Perfil";
            btn_GolesAsi.TextAlign = ContentAlignment.MiddleLeft;
            btn_GolesAsi.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_GolesAsi.UseVisualStyleBackColor = false;
            btn_GolesAsi.Click += btn_deseos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(142, 209, 198);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 140);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(58, 73, 118);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Black_and_Brown_Vintage_Retro_Barbershop_Badge_Logo__1__removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // rjCircle1
            // 
            rjCircle1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircle1.BorderColor = Color.RoyalBlue;
            rjCircle1.BorderColor2 = Color.Khaki;
            rjCircle1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircle1.BorderSize = 2;
            rjCircle1.GradientAngle = 50F;
            rjCircle1.Location = new Point(613, -1);
            rjCircle1.Name = "rjCircle1";
            rjCircle1.Size = new Size(57, 57);
            rjCircle1.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircle1.TabIndex = 6;
            rjCircle1.TabStop = false;
            // 
            // lbl_Correo
            // 
            lbl_Correo.AutoSize = true;
            lbl_Correo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Correo.ForeColor = Color.FromArgb(58, 73, 118);
            lbl_Correo.Location = new Point(460, 30);
            lbl_Correo.Name = "lbl_Correo";
            lbl_Correo.Size = new Size(125, 17);
            lbl_Correo.TabIndex = 3;
            lbl_Correo.Text = "CorreoElectronico";
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Nombre.ForeColor = Color.FromArgb(58, 73, 118);
            lbl_Nombre.Location = new Point(460, 9);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(69, 17);
            lbl_Nombre.TabIndex = 2;
            lbl_Nombre.Text = "Nombree";
            lbl_Nombre.Click += lbl_Nombre_Click;
            // 
            // fileSystemWatcher2
            // 
            fileSystemWatcher2.EnableRaisingEvents = true;
            fileSystemWatcher2.SynchronizingObject = this;
            // 
            // panel_titulo
            // 
            panel_titulo.BackColor = Color.FromArgb(252, 252, 252);
            panel_titulo.Controls.Add(lbl_Correo);
            panel_titulo.Controls.Add(rjCircle1);
            panel_titulo.Controls.Add(lbl_Nombre);
            panel_titulo.Controls.Add(picture_Minimizar);
            panel_titulo.Controls.Add(picture_Cerrar);
            panel_titulo.Controls.Add(label1);
            panel_titulo.Controls.Add(icono_inicio);
            panel_titulo.Controls.Add(lbl_Home);
            panel_titulo.Dock = DockStyle.Top;
            panel_titulo.Location = new Point(220, 0);
            panel_titulo.Name = "panel_titulo";
            panel_titulo.Size = new Size(780, 75);
            panel_titulo.TabIndex = 1;
            panel_titulo.Paint += panel_titulo_Paint;
            panel_titulo.MouseDown += panel_titulo_MouseDown;
            // 
            // picture_Minimizar
            // 
            picture_Minimizar.BorderStyle = BorderStyle.FixedSingle;
            picture_Minimizar.Image = Properties.Resources.morad;
            picture_Minimizar.Location = new Point(687, 0);
            picture_Minimizar.Name = "picture_Minimizar";
            picture_Minimizar.Size = new Size(43, 44);
            picture_Minimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_Minimizar.TabIndex = 5;
            picture_Minimizar.TabStop = false;
            picture_Minimizar.Click += picture_Minimizar_Click;
            // 
            // picture_Cerrar
            // 
            picture_Cerrar.BorderStyle = BorderStyle.FixedSingle;
            picture_Cerrar.Image = Properties.Resources._as;
            picture_Cerrar.Location = new Point(734, 0);
            picture_Cerrar.Name = "picture_Cerrar";
            picture_Cerrar.Size = new Size(43, 44);
            picture_Cerrar.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_Cerrar.TabIndex = 4;
            picture_Cerrar.TabStop = false;
            picture_Cerrar.Click += picture_Cerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 32);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // icono_inicio
            // 
            icono_inicio.BackColor = Color.White;
            icono_inicio.ForeColor = Color.FromArgb(58, 73, 118);
            icono_inicio.IconChar = IconChar.HomeLgAlt;
            icono_inicio.IconColor = Color.FromArgb(58, 73, 118);
            icono_inicio.IconFont = IconFont.Auto;
            icono_inicio.IconSize = 31;
            icono_inicio.Location = new Point(6, 24);
            icono_inicio.Name = "icono_inicio";
            icono_inicio.Size = new Size(32, 32);
            icono_inicio.TabIndex = 2;
            icono_inicio.TabStop = false;
            // 
            // lbl_Home
            // 
            lbl_Home.AutoSize = true;
            lbl_Home.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Home.ForeColor = Color.FromArgb(58, 73, 118);
            lbl_Home.Location = new Point(39, 32);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(42, 17);
            lbl_Home.TabIndex = 1;
            lbl_Home.Text = "Inicio";
            lbl_Home.Click += lbl_Home_Click_1;
            // 
            // pnl_Shadow
            // 
            pnl_Shadow.BackColor = Color.FromArgb(62, 79, 125);
            pnl_Shadow.Dock = DockStyle.Top;
            pnl_Shadow.Location = new Point(220, 75);
            pnl_Shadow.Name = "pnl_Shadow";
            pnl_Shadow.Size = new Size(780, 10);
            pnl_Shadow.TabIndex = 2;
            // 
            // iconSplitButton1
            // 
            iconSplitButton1.Flip = FlipOrientation.Normal;
            iconSplitButton1.IconChar = IconChar.None;
            iconSplitButton1.IconColor = Color.Black;
            iconSplitButton1.IconFont = IconFont.Auto;
            iconSplitButton1.IconSize = 48;
            iconSplitButton1.Name = "iconSplitButton1";
            iconSplitButton1.Rotation = 0D;
            iconSplitButton1.Size = new Size(23, 23);
            iconSplitButton1.Text = "iconSplitButton1";
            // 
            // Fecha_Hora
            // 
            Fecha_Hora.Enabled = true;
            Fecha_Hora.Tick += Fecha_Hora_Tick;
            // 
            // pnl_escritorio
            // 
            pnl_escritorio.BackColor = Color.Gainsboro;
            pnl_escritorio.Controls.Add(lbl_Fecha);
            pnl_escritorio.Controls.Add(lbl_Hora);
            pnl_escritorio.Controls.Add(pictureBox2);
            pnl_escritorio.Dock = DockStyle.Fill;
            pnl_escritorio.Location = new Point(220, 85);
            pnl_escritorio.Name = "pnl_escritorio";
            pnl_escritorio.Size = new Size(780, 515);
            pnl_escritorio.TabIndex = 3;
            pnl_escritorio.Paint += pnl_escritorio_Paint_1;
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.BackColor = Color.FromArgb(252, 252, 252);
            lbl_Fecha.Font = new Font("Century Gothic", 20F);
            lbl_Fecha.ForeColor = Color.FromArgb(8, 182, 166);
            lbl_Fecha.Location = new Point(300, 202);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(96, 33);
            lbl_Fecha.TabIndex = 1;
            lbl_Fecha.Text = "label2";
            // 
            // lbl_Hora
            // 
            lbl_Hora.AutoSize = true;
            lbl_Hora.BackColor = Color.FromArgb(252, 252, 252);
            lbl_Hora.Font = new Font("Century Gothic", 40F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Hora.ForeColor = Color.FromArgb(106, 191, 175);
            lbl_Hora.Location = new Point(259, 137);
            lbl_Hora.Name = "lbl_Hora";
            lbl_Hora.Size = new Size(191, 65);
            lbl_Hora.TabIndex = 0;
            lbl_Hora.Text = "label2";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._33;
            pictureBox2.Location = new Point(0, -102);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(780, 617);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 600);
            Controls.Add(pnl_escritorio);
            Controls.Add(pnl_Shadow);
            Controls.Add(panel_titulo);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rjCircle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher2).EndInit();
            panel_titulo.ResumeLayout(false);
            panel_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picture_Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_Cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)icono_inicio).EndInit();
            pnl_escritorio.ResumeLayout(false);
            pnl_escritorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private Panel panelMenu;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btn_GolesAsi; 
        private FileSystemWatcher fileSystemWatcher2;
        private Panel panel_titulo;
        private Label lbl_Home;
        private IconPictureBox icono_inicio;
        private Label label1;
        private Panel pnl_Shadow;
        private PictureBox picture_Cerrar;
        private PictureBox picture_Minimizar;
        private IconSplitButton iconSplitButton1;
        private System.Windows.Forms.Timer Fecha_Hora;
        private Panel pnl_escritorio;
        private IconButton iconButton2;
        private IconButton iconButton1;
        private PictureBox pictureBox1;
        private Label lbl_Nombre;
        private Label lbl_Correo;
        private RJCircle rjCircle1;
        private Label lbl_Hora;
        private Label lbl_Fecha;
        private IconButton btn_Product;
        private IconButton iconButton4;
        private PictureBox pictureBox2;
    }

}
