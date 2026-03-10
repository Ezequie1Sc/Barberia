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
using Newtonsoft.Json.Bson;
using DoMain;
using Puesto11.View;



namespace Puesto11
{
    public partial class FormularioLoggin : Form

    {




        public FormularioLoggin()
        {
            InitializeComponent();

        }
        public FormularioLoggin(String nombre)
        {
            InitializeComponent();
            string usuario = rjTextBox1_Usuario.Texts;
            string contrasena = textbox_password.Texts;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]


        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private bool showpasww;

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void FormularioLoggin_Load(object sender, EventArgs e)
        {

        }

        private void picture_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picture_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Acceder_Click(object sender, EventArgs e)
        {
            string user = rjTextBox1_Usuario.Texts;

            this.Hide();

            if (user == "Barbero1")
            {
                Mensaje n = new Mensaje();
                n.ShowDialog();
            }
            else
            {
                FormWelcome clienteForm = new FormWelcome();
                clienteForm.ShowDialog();
            }

            Form1 a = new Form1();
            a.Show();
        }





        private void picture_User_Click(object sender, EventArgs e)
        {

        }
        //hago que se borre lo que esta escrito al momento de que el usuario digite 





        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        //PARA QUE SE PUEDA MOVER LA PANTALLA 
        private void FormularioLoggin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnl_izquierda_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        //METODO PARA VER CONTRASEÑA
        private void check_visible_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_Usuario_Enter(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_Usuario_Leave(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_password_Enter(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_password__TextChanged(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_password_Leave(object sender, EventArgs e)
        {

        }

        private void rjTextBox1_Usuario__TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object fsender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EmpleadoForm empleadoForm = new EmpleadoForm();
            empleadoForm.ShowDialog();

        }

        private void picturePasswordVer_Click(object sender, EventArgs e)
        {
            showpasww = !showpasww;
            if (showpasww)
            {
                textbox_password.PasswordChar = false;
                picturePasswordVer.Image = Puesto11.Properties.Resources.show;
            }
            else
            {
                textbox_password.PasswordChar = true;
                picturePasswordVer.Image = Puesto11.Properties.Resources.hide;

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pnl_izquierda_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
