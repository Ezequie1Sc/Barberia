namespace Puesto11
{
    partial class FormPromociones
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
            title_inciar = new Label();
            SuspendLayout();
            // 
            // title_inciar
            // 
            title_inciar.AutoSize = true;
            title_inciar.BackColor = Color.Transparent;
            title_inciar.Font = new Font("Arial Rounded MT Bold", 30F, FontStyle.Regular, GraphicsUnit.World);
            title_inciar.ForeColor = Color.FromArgb(44, 38, 39);
            title_inciar.Location = new Point(11, 9);
            title_inciar.Margin = new Padding(2, 0, 2, 0);
            title_inciar.Name = "title_inciar";
            title_inciar.Size = new Size(257, 34);
            title_inciar.TabIndex = 26;
            title_inciar.Text = "PROMOCIONES:";
            // 
            // FormPromociones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(743, 364);
            Controls.Add(title_inciar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPromociones";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormPromociones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_inciar;
    }
}