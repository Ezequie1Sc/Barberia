namespace Puesto11
{
    partial class AgendarCitas
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
            tbxNombreData = new RJTextBox();
            label2 = new Label();
            rjDatePicker1 = new RJDatePicker();
            rjComboBox1 = new RJComboBox();
            btn_Acceder = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            dataGridViewVer = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ColumnaFecha = new DataGridViewTextBoxColumn();
            ColumnaHorarioa = new DataGridViewTextBoxColumn();
            btn_VerReserva = new FontAwesome.Sharp.IconButton();
            btn_Eliminar = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tbxNombreData
            // 
            tbxNombreData.BackColor = Color.White;
            tbxNombreData.BorderColor = Color.FromArgb(58, 73, 118);
            tbxNombreData.BorderFocusColor = Color.HotPink;
            tbxNombreData.BorderSize = 2;
            tbxNombreData.Font = new Font("Segoe UI", 9.5F);
            tbxNombreData.ForeColor = Color.DimGray;
            tbxNombreData.Location = new Point(44, 67);
            tbxNombreData.Margin = new Padding(4);
            tbxNombreData.Multiline = false;
            tbxNombreData.Name = "tbxNombreData";
            tbxNombreData.Padding = new Padding(7);
            tbxNombreData.PasswordChar = false;
            tbxNombreData.Size = new Size(306, 32);
            tbxNombreData.TabIndex = 1;
            tbxNombreData.Texts = "";
            tbxNombreData.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(44, 23);
            label2.Name = "label2";
            label2.Size = new Size(291, 42);
            label2.TabIndex = 0;
            label2.Text = "Nombre de quien hace la reservacion:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rjDatePicker1
            // 
            rjDatePicker1.BorderColor = Color.FromArgb(58, 73, 118);
            rjDatePicker1.BorderSize = 0;
            rjDatePicker1.Font = new Font("Segoe UI", 9.5F);
            rjDatePicker1.Location = new Point(43, 134);
            rjDatePicker1.MinimumSize = new Size(0, 35);
            rjDatePicker1.Name = "rjDatePicker1";
            rjDatePicker1.Size = new Size(307, 35);
            rjDatePicker1.SkinColor = Color.FromArgb(58, 73, 118);
            rjDatePicker1.TabIndex = 26;
            rjDatePicker1.TextColor = Color.White;
            rjDatePicker1.ValueChanged += rjDatePicker1_ValueChanged;
            // 
            // rjComboBox1
            // 
            rjComboBox1.AutoCompleteCustomSource.AddRange(new string[] { "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00" });
            rjComboBox1.BackColor = Color.FromArgb(58, 73, 118);
            rjComboBox1.BorderColor = Color.FromArgb(58, 73, 118);
            rjComboBox1.BorderSize = 1;
            rjComboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            rjComboBox1.Font = new Font("Segoe UI", 10F);
            rjComboBox1.ForeColor = Color.White;
            rjComboBox1.IconColor = Color.DarkBlue;
            rjComboBox1.Items.AddRange(new object[] { "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "16:00", "17:00", "19:00", "20:00" });
            rjComboBox1.ListBackColor = Color.FromArgb(65, 79, 130);
            rjComboBox1.ListTextColor = SystemColors.ButtonHighlight;
            rjComboBox1.Location = new Point(433, 86);
            rjComboBox1.MinimumSize = new Size(200, 30);
            rjComboBox1.Name = "rjComboBox1";
            rjComboBox1.Padding = new Padding(1);
            rjComboBox1.Size = new Size(304, 30);
            rjComboBox1.TabIndex = 27;
            rjComboBox1.Texts = "                   HORARIO";
            rjComboBox1.OnSelectedIndexChanged += rjComboBox1_OnSelectedIndexChanged;
            // 
            // btn_Acceder
            // 
            btn_Acceder.BackColor = Color.Maroon;
            btn_Acceder.FlatAppearance.BorderSize = 0;
            btn_Acceder.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btn_Acceder.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btn_Acceder.FlatStyle = FlatStyle.Popup;
            btn_Acceder.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btn_Acceder.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Acceder.ForeColor = Color.White;
            btn_Acceder.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            btn_Acceder.IconColor = Color.White;
            btn_Acceder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Acceder.IconSize = 42;
            btn_Acceder.Location = new Point(433, 145);
            btn_Acceder.Name = "btn_Acceder";
            btn_Acceder.Size = new Size(304, 47);
            btn_Acceder.TabIndex = 28;
            btn_Acceder.Text = "RESERVAR";
            btn_Acceder.TextImageRelation = TextImageRelation.TextBeforeImage;
            btn_Acceder.UseVisualStyleBackColor = false;
            btn_Acceder.Click += btn_Acceder_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(433, 55);
            label1.Name = "label1";
            label1.Size = new Size(227, 28);
            label1.TabIndex = 29;
            label1.Text = "Seleccione el horario deseado:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(44, 103);
            label3.Name = "label3";
            label3.Size = new Size(227, 28);
            label3.TabIndex = 30;
            label3.Text = "Seleccione la fecha deseada:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Controls.Add(dataGridViewVer);
            panel1.Controls.Add(dataGridView2);
            panel1.Location = new Point(1, 213);
            panel1.Name = "panel1";
            panel1.Size = new Size(782, 292);
            panel1.TabIndex = 31;
            panel1.Paint += panel1_Paint;
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
            dataGridViewVer.Location = new Point(0, 0);
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
            dataGridViewVer.Size = new Size(779, 292);
            dataGridViewVer.TabIndex = 27;
            dataGridViewVer.Visible = false;
            dataGridViewVer.CellContentClick += dataGridViewVer_CellContentClick;
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
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(58, 73, 118);
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(89, 100, 190);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, ColumnaFecha, ColumnaHorarioa });
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.GridColor = Color.White;
            dataGridView2.Location = new Point(0, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(70, 80, 140);
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.Indigo;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(69, 89, 150);
            dataGridViewCellStyle6.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.Navy;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.Size = new Size(779, 289);
            dataGridView2.TabIndex = 19;
            dataGridView2.Visible = false;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 250;
            // 
            // ColumnaFecha
            // 
            ColumnaFecha.HeaderText = "Fecha";
            ColumnaFecha.Name = "ColumnaFecha";
            ColumnaFecha.ReadOnly = true;
            ColumnaFecha.Width = 240;
            // 
            // ColumnaHorarioa
            // 
            ColumnaHorarioa.HeaderText = "Horario";
            ColumnaHorarioa.Name = "ColumnaHorarioa";
            ColumnaHorarioa.ReadOnly = true;
            ColumnaHorarioa.Width = 240;
            // 
            // btn_VerReserva
            // 
            btn_VerReserva.FlatStyle = FlatStyle.Flat;
            btn_VerReserva.Font = new Font("Century Gothic", 8.25F, FontStyle.Italic);
            btn_VerReserva.ForeColor = Color.Green;
            btn_VerReserva.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            btn_VerReserva.IconColor = Color.Green;
            btn_VerReserva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_VerReserva.IconSize = 23;
            btn_VerReserva.ImageAlign = ContentAlignment.BottomLeft;
            btn_VerReserva.Location = new Point(238, 174);
            btn_VerReserva.Name = "btn_VerReserva";
            btn_VerReserva.Size = new Size(154, 36);
            btn_VerReserva.TabIndex = 28;
            btn_VerReserva.Text = "Ver TÚ reservacion";
            btn_VerReserva.UseVisualStyleBackColor = true;
            btn_VerReserva.Visible = false;
            btn_VerReserva.Click += btn_Aceptar_Click;
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
            btn_Eliminar.Location = new Point(44, 175);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.RightToLeft = RightToLeft.No;
            btn_Eliminar.Size = new Size(168, 36);
            btn_Eliminar.TabIndex = 18;
            btn_Eliminar.Text = "Eliminar reservacion";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Visible = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // AgendarCitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(780, 507);
            Controls.Add(btn_VerReserva);
            Controls.Add(panel1);
            Controls.Add(btn_Eliminar);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btn_Acceder);
            Controls.Add(rjComboBox1);
            Controls.Add(rjDatePicker1);
            Controls.Add(tbxNombreData);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgendarCitas";
            Text = "Agendar Citas";
            Load += AgendarCitas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private RJTextBox tbxNombreData;
        private Label label2;
        private RJDatePicker rjDatePicker1;
        private RJComboBox rjComboBox1;
        private FontAwesome.Sharp.IconButton btn_Acceder;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private DataGridView dataGridView2;
        private DataGridView dataGridViewVer;
        private FontAwesome.Sharp.IconButton btn_VerReserva;
        private FontAwesome.Sharp.IconButton btn_Eliminar;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn ColumnaFecha;
        private DataGridViewTextBoxColumn ColumnaHorarioa;
    }
}