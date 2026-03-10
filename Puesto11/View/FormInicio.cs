using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Diagnostics.Eventing.Reader;
using System.Data.SqlClient;
using Regitro_De_Empleado;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Puesto11
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btn_Acceder_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormularioLoggin formularioLoggin = new FormularioLoggin();
            formularioLoggin.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReleaseCapture();
        }

        private void btn_CerrarLoggin_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
