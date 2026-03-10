using Common.Cache;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Puesto11.View
{
    public partial class Mensaje : Form
    {
        public Mensaje()
        {
            InitializeComponent();
            verReservaciones();
            dataGridViewVer.Visible = true;
            lbl_Correo.Text = ActiveUser.correo;
            lbl_Nombre.Text = ActiveUser.nombre + " " + ActiveUser.apellido;
            lbl_apellidoDOS.Text = ActiveUser.apellido;
            lbl_nombreDos.Text = ActiveUser.nombre;
            mostrarImagen();
        }

        public void verReservaciones()
        {
            string cadenaConexion = "Data source=EZEQUIEL\\SQLEXPRESS; Initial Catalog = BarberiaBd; TrustServerCertificate=true; Integrated Security=True;";

            // Consulta SQL para obtener todas las reservaciones
            string query = "SELECT IdReservacion, Nombre, Fecha, Hora FROM Reservaciones ORDER BY Fecha DESC, Hora DESC";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open(); // Abrir la conexión

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        // Crear un DataAdapter para llenar un DataTable con los resultados
                        SqlDataAdapter da = new SqlDataAdapter(comando);
                        DataTable dt = new DataTable();

                        da.Fill(dt); // Llenar el DataTable con los datos de la base de datos

                        // Limpiar las filas previas del DataGridView
                        dataGridViewVer.Rows.Clear();

                        // Obtener la fecha y hora actuales
                        DateTime now = DateTime.Now;

                        // Agregar las filas al DataGridView desde el DataTable
                        foreach (DataRow row in dt.Rows)
                        {
                            string nombre = row["Nombre"].ToString();
                            DateTime fecha = Convert.ToDateTime(row["Fecha"]);
                            TimeSpan hora = (TimeSpan)row["Hora"]; // Convertir la hora a TimeSpan

                            // Convertir la hora al formato de 24 horas
                            string horaFormato24 = fecha.ToString("yyyy-MM-dd") + " " + hora.ToString(@"hh\:mm");

                            DateTime horaReserva = Convert.ToDateTime(horaFormato24);

                            // Verificar si la reservación es reciente (más cercana a la fecha y hora actuales)
                            bool esReciente = horaReserva > now.AddMinutes(-30); // Puedes ajustar el rango de "reciente" según tus necesidades

                            // Agregar la fila al DataGridView
                            int rowIndex = dataGridViewVer.Rows.Add(nombre, fecha.ToShortDateString(), hora.ToString(@"hh\:mm"));

                            // Si es reciente, cambiar el color de fondo a verde
                            if (esReciente)
                            {
                                dataGridViewVer.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Green;
                            }
                        }

                        // Verificación de si hay datos
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No hay reservaciones registradas.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    MessageBox.Show("Error al cargar las reservaciones: " + ex.Message);
                }
            }
        }
        public void mostrarImagen()
        {
            if (ActiveUser.imageData != null && ActiveUser.imageData.Length > 0)
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
            else
            {
                // Si no hay imagen, muestra una predeterminada o deja el control vacío
                rjCircle1.Image = null; // O puedes asignar una imagen predeterminada aquí
                rjCircle1.Region = null; // Limpia la región por si ya se aplicó antes
            }
        }

        private void picture_Cerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas SALIR?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.No)
            {

            }
        }
    }
}
