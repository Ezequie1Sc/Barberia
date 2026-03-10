namespace Puesto11
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel_center_U = new Panel();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ColumnaHorario = new DataGridViewTextBoxColumn();
            ColumnaFecha = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            ColumnaID = new DataGridViewTextBoxColumn();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnApellido1 = new DataGridViewTextBoxColumn();
            ColumnApellido2 = new DataGridViewTextBoxColumn();
            ColumnEdad = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btn_Agregar = new FontAwesome.Sharp.IconButton();
            btn_Eliminar = new FontAwesome.Sharp.IconButton();
            panel_center_U.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel_center_U
            // 
            panel_center_U.BackColor = Color.FromArgb(25, 25, 63);
            panel_center_U.Controls.Add(dataGridView2);
            panel_center_U.Controls.Add(dataGridView1);
            panel_center_U.Controls.Add(iconButton1);
            panel_center_U.Controls.Add(btn_Agregar);
            panel_center_U.Controls.Add(btn_Eliminar);
            panel_center_U.Dock = DockStyle.Fill;
            panel_center_U.Location = new Point(0, 0);
            panel_center_U.Name = "panel_center_U";
            panel_center_U.Size = new Size(800, 413);
            panel_center_U.TabIndex = 0;
            panel_center_U.Paint += panel_center_U_Paint;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(25, 25, 80);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Indigo;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, ColumnaHorario, ColumnaFecha });
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.SlateBlue;
            dataGridView2.Location = new Point(192, 12);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Indigo;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(25, 25, 63);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.Size = new Size(454, 271);
            dataGridView2.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 130;
            // 
            // ColumnaHorario
            // 
            ColumnaHorario.HeaderText = "Horario";
            ColumnaHorario.Name = "ColumnaHorario";
            ColumnaHorario.ReadOnly = true;
            // 
            // ColumnaFecha
            // 
            ColumnaFecha.HeaderText = "FECHA";
            ColumnaFecha.Name = "ColumnaFecha";
            ColumnaFecha.ReadOnly = true;
            ColumnaFecha.Width = 130;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(25, 25, 80);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Indigo;
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnaID, ColumnNombre, ColumnApellido1, ColumnApellido2, ColumnEdad, ColumnEmail });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.SlateBlue;
            dataGridView1.Location = new Point(23, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Indigo;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(25, 25, 63);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Size = new Size(765, 303);
            dataGridView1.TabIndex = 0;
            // 
            // ColumnaID
            // 
            ColumnaID.HeaderText = "ID";
            ColumnaID.Name = "ColumnaID";
            ColumnaID.ReadOnly = true;
            ColumnaID.Width = 60;
            // 
            // ColumnNombre
            // 
            ColumnNombre.HeaderText = "Nombre";
            ColumnNombre.Name = "ColumnNombre";
            ColumnNombre.ReadOnly = true;
            ColumnNombre.Width = 130;
            // 
            // ColumnApellido1
            // 
            ColumnApellido1.HeaderText = "Apellido";
            ColumnApellido1.Name = "ColumnApellido1";
            ColumnApellido1.ReadOnly = true;
            ColumnApellido1.Width = 130;
            // 
            // ColumnApellido2
            // 
            ColumnApellido2.HeaderText = "Contraseña";
            ColumnApellido2.Name = "ColumnApellido2";
            ColumnApellido2.ReadOnly = true;
            ColumnApellido2.Width = 130;
            // 
            // ColumnEdad
            // 
            ColumnEdad.HeaderText = "Edad";
            ColumnEdad.Name = "ColumnEdad";
            ColumnEdad.ReadOnly = true;
            ColumnEdad.Width = 60;
            // 
            // ColumnEmail
            // 
            ColumnEmail.HeaderText = "Correo Electronico";
            ColumnEmail.Name = "ColumnEmail";
            ColumnEmail.ReadOnly = true;
            ColumnEmail.Width = 200;
            // 
            // iconButton1
            // 
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.DarkOrchid;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            iconButton1.IconColor = Color.Indigo;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 23;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(374, 334);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(99, 36);
            iconButton1.TabIndex = 15;
            iconButton1.Text = "Editar";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.FlatStyle = FlatStyle.Flat;
            btn_Agregar.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Agregar.ForeColor = Color.Green;
            btn_Agregar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btn_Agregar.IconColor = Color.Green;
            btn_Agregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Agregar.IconSize = 23;
            btn_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Agregar.Location = new Point(269, 334);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(99, 36);
            btn_Agregar.TabIndex = 13;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.FlatStyle = FlatStyle.Flat;
            btn_Eliminar.Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Eliminar.ForeColor = Color.Red;
            btn_Eliminar.IconChar = FontAwesome.Sharp.IconChar.TrashCan;
            btn_Eliminar.IconColor = Color.Red;
            btn_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Eliminar.IconSize = 23;
            btn_Eliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Eliminar.Location = new Point(479, 334);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.RightToLeft = RightToLeft.No;
            btn_Eliminar.Size = new Size(103, 36);
            btn_Eliminar.TabIndex = 14;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 413);
            Controls.Add(panel_center_U);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            panel_center_U.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_center_U;
        private FontAwesome.Sharp.IconButton btn_Agregar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnaID;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnApellido1;
        private DataGridViewTextBoxColumn ColumnApellido2;
        private DataGridViewTextBoxColumn ColumnEdad;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ColumnaHorario;
        private DataGridViewTextBoxColumn ColumnaFecha;
    }
}