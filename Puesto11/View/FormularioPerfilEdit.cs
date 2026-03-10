using Common.Cache;
using DoMain;
using FontAwesome.Sharp;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Puesto11
{
    public partial class FormularioPerfilEdit : Form
    {
        String name;
        String email;
        String password;
        private bool showpasww;



        public FormularioPerfilEdit()
        {

            InitializeComponent();
            starStetion();
            mostarImagen();

        }




        public void starStetion()
        {


        }


        public void editProfilee()
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private byte[] ConvertImageToBytes(Image image)
        {
            if (image == null)
                return null;

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Usa PNG o JPEG según necesites
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                // Aquí puedes capturar más detalles sobre el error
                Console.WriteLine("Error al convertir imagen: " + ex.Message);
                return null;
            }
        }





        public void editarData()
        {
            string cadenaConexion = "Data source=EZEQUIEL\\SQLEXPRESS; Initial Catalog = BarberiaBd; TrustServerCertificate=true; Integrated Security=True;";

            // Obtención de los datos desde los controles de la UI
            string usuario = txt_UserBD.Texts;
            string nombre = txt_Nombre.Texts;
            string apellido = txt_ApeBD.Texts;
            string correo = txt_EmailBD.Texts;
            string nuevaContraseña = txt_confiNewPass.Texts;
            byte[] imagenPerfil = null;

            // Validación de campos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Si hay una imagen seleccionada, convertirla a bytes
            if (rjCircle1.Image != null)
            {
                imagenPerfil = ConvertImageToBytes(rjCircle1.Image);
            }
            else
            {
                imagenPerfil = ActiveUser.imageData; // Si no hay imagen seleccionada, usar la imagen existente
            }

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();          
                    string query = @"
UPDATE Usuarios 
SET 
    Nombre = @nombre, 
    Apellido = @apellido, 
    Email = @correo, 
    Contrasena = @nuevaContraseña, 
    Imagen = @imagen
WHERE IdUser = @idUsuario";


                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // Agregar los parámetros con sus valores y asegurarse del tipo de dato
                        comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
                        comando.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = apellido;
                        comando.Parameters.Add("@correo", SqlDbType.NVarChar).Value = correo;
                        comando.Parameters.Add("@nuevaContraseña", SqlDbType.NVarChar).Value = nuevaContraseña;
                        comando.Parameters.Add("@imagen", SqlDbType.VarBinary).Value = imagenPerfil;
                        comando.Parameters.Add("@idUsuario", SqlDbType.Int).Value = ActiveUser.idUser;  // Asegúrate de que ActiveUser.idUser contenga el ID correcto

                        // Ejecutar el comando
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("¡Perfil actualizado con éxito!");

                            // Actualizar los datos en ActiveUser para reflejar los cambios
                            ActiveUser.nombre = nombre;
                            ActiveUser.apellido = apellido;
                            ActiveUser.correo = correo;
                            ActiveUser.password = nuevaContraseña;
                            //ActiveUser.imageData = imagenPerfil;

                            // Refrescar los datos en los controles de la interfaz
                            loudUserData();
                            mostarImagen(); // Para actualizar la imagen de perfil

                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el perfil.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error de SQL: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }





        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            editarData();
        }



        public void mostarImagen()
        {


            using (var ms = new MemoryStream(ActiveUser.imageData))
            {
                rjCircle1.Image = Image.FromStream(ms); // Carga la imagen desde los bytes
                rjCircle1.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta el tamaño para que ocupe el espacio

                // Crear una máscara circular para la imagen
                System.Drawing.Drawing2D.GraphicsPath circularPath = new System.Drawing.Drawing2D.GraphicsPath();
                circularPath.AddEllipse(0, 0, rjCircle1.Width, rjCircle1.Height);
                rjCircle1.Region = new Region(circularPath);
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




        private void lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox5__TextChanged(object sender, EventArgs e)
        {

        }

        private void loudUserData()
        {
            lbl_UsuarioBd.Text = ActiveUser.usuario;
            lbl_NombreBd.Text = ActiveUser.nombre;
            lbl_ApellidoBd.Text = ActiveUser.apellido;
            lbl_EmailBd.Text = ActiveUser.correo;

            txt_UserBD.Texts = ActiveUser.usuario;
            txt_ApeBD.Texts = ActiveUser.apellido;
            txt_Nombre.Texts = ActiveUser.nombre;
            txt_confiNewPass.Texts = ActiveUser.password;
            txt_newPass.Texts = ActiveUser.password;
            txt_password.Texts = "";
            txt_EmailBD.Texts = ActiveUser.correo;


        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {


            loudUserData();
            initializePassEditControl();



        }

        private void initializePassEditControl()
        {


            LinkEdit.Text = "Edit";
            txt_confiNewPass.Enabled = false;
            txt_confiNewPass.PasswordChar = true;
            txt_newPass.Enabled = false;
            txt_newPass.PasswordChar = true;

        }

        private void reset()
        {

            initializePassEditControl();
            loudUserData();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LinkPassw.Text == "Cambiar Contraseña")
            {

                LinkPassw.Text = "Cancelar";
                txt_newPass.Enabled = true;
                txt_newPass.Texts = "";
                txt_confiNewPass.Enabled = true;
                txt_confiNewPass.Texts = "";
            }
            else if (LinkPassw.Text == "Cancelar")
            {
                LinkPassw.Text = "Cambiar Contraseña";
                initializePassEditControl();
                txt_newPass.Texts = ActiveUser.password;
                txt_confiNewPass.Texts = ActiveUser.password;



            }
        
        }

        private void linkEsitar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void LinkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel4_View.Visible = true;

            btn_CambiarFoto.Visible = true;
            loudUserData();


        }

        private void rjCircle1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_NombreBd_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            showpasww = !showpasww;
            if (showpasww)
            {
                txt_password.PasswordChar = false;
                pictureBox1.Image = Puesto11.Properties.Resources.show;
            }
            else
            {
                txt_password.PasswordChar = true;
                pictureBox1.Image = Puesto11.Properties.Resources.hide;

            }




        }

        private void lbl_UsuarioBd_Click(object sender, EventArgs e)
        {

        }
    }
}
