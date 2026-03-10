using Microsoft.Data.SqlClient;
using Regitro_De_Empleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using DoMain;
using Common.Cache;

namespace Puesto11
{
    public partial class EmpleadoForm : Form
    {

        public EmpleadoForm()
        {
            InitializeComponent();
        }
        public EmpleadoForm(Empleado empleado)
        {
            InitializeComponent();

        }
        private bool showpasww;
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_Usuario.Texts))
            {
                MessageBox.Show("El nombre de usuario es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_nombree.Texts))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Apellido.Texts))
            {
                MessageBox.Show("El apellido es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Email.Texts) || !IsValidEmail(txt_Email.Texts))
            {
                MessageBox.Show("El correo electrónico es obligatorio y debe ser válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_password.Texts))
            {
                MessageBox.Show("La contraseña es obligatoria.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de longitud mínima de la contraseña
            if (txt_password.Texts.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de confirmación de contraseña
            if (txt_password.Texts != txt_confirmPassword.Texts)
            {
                MessageBox.Show("Las contraseñas no coinciden. Intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución si las contraseñas no coinciden
            }

            if (rjCircle1.Image == null)
            {
                MessageBox.Show("Debe seleccionar una imagen de perfil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convertir la imagen seleccionada a bytes
            byte[] selectedImageBytes = ConvertImageToBytes(rjCircle1.Image);

            // Crear el modelo de usuario y registrar
            UserModel ur = new UserModel();
            ur.RegisterUser(
                txt_Usuario.Texts,
                txt_nombree.Texts,
                txt_Apellido.Texts,
                txt_Email.Texts,
                txt_password.Texts,
                selectedImageBytes
            );

            // Mostrar mensaje de éxito
            MessageBox.Show("¡Registro realizado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            FormularioLoggin k = new FormularioLoggin();
            k.Show();
        }



        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }






        private void btn_CerrarLoggin_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbxEmail__TextChanged(object sender, EventArgs e)
        {

        }

        private void formMessageBox1_Load(object sender, EventArgs e)
        {

        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormularioLoggin er = new FormularioLoggin();
            er.Show();
        }
        private void LimpiarCampos()
        {

        }

        private void EmpleadoForm_Load(object sender, EventArgs e)
        {

        }
        private byte[] ConvertImageToBytes(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat); // Guardar la imagen en el MemoryStream
                return ms.ToArray(); // Retorna el arreglo de bytes
            }
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccione una foto de perfil";
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rjCircle1.Image = new Bitmap(openFileDialog.FileName);
                    rjCircle1.SizeMode = PictureBoxSizeMode.StretchImage;


                    System.Drawing.Drawing2D.GraphicsPath circularPath = new System.Drawing.Drawing2D.GraphicsPath();
                    circularPath.AddEllipse(0, 0, rjCircle1.Width, rjCircle1.Height);
                    rjCircle1.Region = new Region(circularPath);
                }
            }
        }




        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showpasww = !showpasww;
            if (showpasww)

            {

                txt_password.PasswordChar = false;
                txt_confirmPassword.PasswordChar = false;
                pictureBox1.Image = Puesto11.Properties.Resources.show;
            }
            else
            {
               
                txt_password.PasswordChar = true;
                txt_confirmPassword.PasswordChar = false;
                
                pictureBox1.Image = Puesto11.Properties.Resources.hide;

            }
        }
    }
}
