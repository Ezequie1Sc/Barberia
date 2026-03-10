namespace Puesto11.View
{
    partial class Mensaje
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel_titulo = new Panel();
            lbl_Correo = new Label();
            rjCircle1 = new BarberFex.btn_personalizado.RJCircle();
            lbl_Nombre = new Label();
            picture_Minimizar = new PictureBox();
            picture_Cerrar = new PictureBox();
            label1 = new Label();
            icono_inicio = new FontAwesome.Sharp.IconPictureBox();
            lbl_Home = new Label();
            panel2 = new Panel();
            dataGridViewVer = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            lbl_apellidoDOS = new Label();
            lbl_nombreDos = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rjCircle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture_Cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icono_inicio).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel_titulo
            // 
            panel_titulo.BackColor = Color.FromArgb(58, 73, 118);
            panel_titulo.Controls.Add(lbl_Correo);
            panel_titulo.Controls.Add(rjCircle1);
            panel_titulo.Controls.Add(lbl_Nombre);
            panel_titulo.Controls.Add(picture_Minimizar);
            panel_titulo.Controls.Add(picture_Cerrar);
            panel_titulo.Controls.Add(label1);
            panel_titulo.Controls.Add(icono_inicio);
            panel_titulo.Controls.Add(lbl_Home);
            panel_titulo.Dock = DockStyle.Top;
            panel_titulo.Location = new Point(0, 0);
            panel_titulo.Name = "panel_titulo";
            panel_titulo.Size = new Size(865, 69);
            panel_titulo.TabIndex = 2;
            // 
            // lbl_Correo
            // 
            lbl_Correo.AutoSize = true;
            lbl_Correo.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Correo.ForeColor = Color.White;
            lbl_Correo.Location = new Point(525, 30);
            lbl_Correo.Name = "lbl_Correo";
            lbl_Correo.Size = new Size(125, 17);
            lbl_Correo.TabIndex = 3;
            lbl_Correo.Text = "CorreoElectronico";
            // 
            // rjCircle1
            // 
            rjCircle1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            rjCircle1.BorderColor = Color.RoyalBlue;
            rjCircle1.BorderColor2 = Color.Khaki;
            rjCircle1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            rjCircle1.BorderSize = 2;
            rjCircle1.GradientAngle = 50F;
            rjCircle1.Location = new Point(695, -1);
            rjCircle1.Name = "rjCircle1";
            rjCircle1.Size = new Size(57, 57);
            rjCircle1.SizeMode = PictureBoxSizeMode.StretchImage;
            rjCircle1.TabIndex = 6;
            rjCircle1.TabStop = false;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Nombre.ForeColor = Color.White;
            lbl_Nombre.Location = new Point(581, 10);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(69, 17);
            lbl_Nombre.TabIndex = 2;
            lbl_Nombre.Text = "Nombree";
            // 
            // picture_Minimizar
            // 
            picture_Minimizar.BorderStyle = BorderStyle.FixedSingle;
            picture_Minimizar.Image = Properties.Resources.morad;
            picture_Minimizar.Location = new Point(771, -1);
            picture_Minimizar.Name = "picture_Minimizar";
            picture_Minimizar.Size = new Size(43, 44);
            picture_Minimizar.SizeMode = PictureBoxSizeMode.StretchImage;
            picture_Minimizar.TabIndex = 5;
            picture_Minimizar.TabStop = false;
            // 
            // picture_Cerrar
            // 
            picture_Cerrar.BorderStyle = BorderStyle.FixedSingle;
            picture_Cerrar.Image = Properties.Resources._as;
            picture_Cerrar.Location = new Point(820, 0);
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
            icono_inicio.BackColor = Color.FromArgb(58, 73, 118);
            icono_inicio.ForeColor = SystemColors.ButtonFace;
            icono_inicio.IconChar = FontAwesome.Sharp.IconChar.Scissors;
            icono_inicio.IconColor = SystemColors.ButtonFace;
            icono_inicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
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
            lbl_Home.ForeColor = Color.White;
            lbl_Home.Location = new Point(39, 32);
            lbl_Home.Name = "lbl_Home";
            lbl_Home.Size = new Size(118, 17);
            lbl_Home.TabIndex = 1;
            lbl_Home.Text = "Citas Reservadas";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewVer);
            panel2.Controls.Add(lbl_apellidoDOS);
            panel2.Controls.Add(lbl_nombreDos);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 395);
            panel2.TabIndex = 4;
            // 
            // dataGridViewVer
            // 
            dataGridViewVer.BackgroundColor = Color.FromArgb(58, 73, 118);
            dataGridViewVer.BorderStyle = BorderStyle.None;
            dataGridViewVer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 73, 118);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.Navy;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewVer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewVer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVer.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewVer.EnableHeadersVisualStyles = false;
            dataGridViewVer.GridColor = Color.White;
            dataGridViewVer.Location = new Point(53, 0);
            dataGridViewVer.Name = "dataGridViewVer";
            dataGridViewVer.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(65, 80, 125);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewVer.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(58, 73, 118);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.GhostWhite;
            dataGridViewVer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewVer.Size = new Size(779, 250);
            dataGridViewVer.TabIndex = 28;
            dataGridViewVer.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 238;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Horario";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 250;
            // 
            // lbl_apellidoDOS
            // 
            lbl_apellidoDOS.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_apellidoDOS.ForeColor = Color.Black;
            lbl_apellidoDOS.Location = new Point(400, 295);
            lbl_apellidoDOS.Name = "lbl_apellidoDOS";
            lbl_apellidoDOS.Size = new Size(193, 42);
            lbl_apellidoDOS.TabIndex = 31;
            lbl_apellidoDOS.Text = "@Apellido";
            lbl_apellidoDOS.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_nombreDos
            // 
            lbl_nombreDos.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_nombreDos.ForeColor = Color.Black;
            lbl_nombreDos.Location = new Point(212, 295);
            lbl_nombreDos.Name = "lbl_nombreDos";
            lbl_nombreDos.Size = new Size(182, 42);
            lbl_nombreDos.TabIndex = 30;
            lbl_nombreDos.Text = "@Nombre";
            lbl_nombreDos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(86, 253);
            label2.Name = "label2";
            label2.Size = new Size(148, 42);
            label2.TabIndex = 29;
            label2.Text = "Bienvenido";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._32;
            pictureBox1.Location = new Point(0, -39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(892, 442);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Mensaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 464);
            Controls.Add(panel2);
            Controls.Add(panel_titulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Mensaje";
            Text = "Mensaje";
            panel_titulo.ResumeLayout(false);
            panel_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)rjCircle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture_Cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)icono_inicio).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_titulo;
        private Label lbl_Correo;
        private RJCircle rjCircle1;
        private Label lbl_Nombre;
        private PictureBox picture_Minimizar;
        private PictureBox picture_Cerrar;
        private Label label1;
        private FontAwesome.Sharp.IconPictureBox icono_inicio;
        private Label lbl_Home;
        private Panel panel2;
        private DataGridView dataGridViewVer;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private PictureBox pictureBox1;
        private Label lbl_apellidoDOS;
        private Label lbl_nombreDos;
        private Label label2;
    }
}