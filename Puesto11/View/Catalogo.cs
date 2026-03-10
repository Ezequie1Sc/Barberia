using Puesto11.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Puesto11
{
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }

        private void title_inciar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            AgendarCitas agendarCitas = new AgendarCitas();
            agendarCitas.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rjCircle3_Click(object sender, EventArgs e)
        {

        }

        private void btn_MoreInfo_Click(object sender, EventArgs e)
        {
            Catalago1 ar = new Catalago1();
            ar.Show();
        }

        private void rjCircle1_Click(object sender, EventArgs e)
        {
            using (Mensaje me = new Mensaje())
            {
                // Configurar el formulario que oscurece el fondo
                me.StartPosition = FormStartPosition.Manual;
                me.FormBorderStyle = FormBorderStyle.None;
                me.Opacity = 0.6; // Opacidad: 0.7 es el 70% de transparencia
                me.BackColor = Color.Black;
                me.WindowState = FormWindowState.Maximized;
                me.TopMost = true; // Se mantiene en la parte superior
                me.Location = this.Location; // Mismo inicio que el formulario principal
                me.ShowInTaskbar = false;

                // Mostrar el formulario de fondo
                me.Show();

                // Mostrar el formulario de notificación
                using (Catalago1 ne = new Catalago1())
                {
                    ne.StartPosition = FormStartPosition.CenterParent; // Centrado en el formulario de fondo
                    ne.FormBorderStyle = FormBorderStyle.None; // Formulario tipo notificación
                    ne.Owner = me; // Vincular con el formulario de fondo
                    ne.ShowDialog(); // Mostrar como cuadro de diálogo modal
                }

            }

            
           




        }
    }
}
