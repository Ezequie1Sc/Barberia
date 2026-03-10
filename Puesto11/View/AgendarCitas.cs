using Common.Cache;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puesto11
{
    public partial class AgendarCitas : Form
    {
        public AgendarCitas()
        {
            InitializeComponent();
            rjDatePicker1.MinDate = DateTime.Now.Date;
            rjComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            verReservaciones();
            dataGridViewVer.Visible = true;
        }


        private void AgendarCitas_Load(object sender, EventArgs e)
        {

        }




public void agregarData()
    {
        string cadenaConexion = "Data source=EZEQUIEL\\SQLEXPRESS; Initial Catalog = BarberiaBd; TrustServerCertificate=true; Integrated Security=True;";

        string nombre = tbxNombreData.Texts.Trim();
        DateTime fecha = rjDatePicker1.Value;
        string horario = rjComboBox1.SelectedItem?.ToString()?.Trim(); // Eliminar espacios

        if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(horario))
        {
            MessageBox.Show("Por favor, complete todos los campos.");
            return;
        }

        // 🛠 Depuración: Mostrar el valor real recibido
        MessageBox.Show("Valor de hora recibido: " + horario);

      
        DateTime horaReserva;
        bool formatoValido = DateTime.TryParseExact(
            horario,
            new string[] { "h:mm tt", "hh:mm tt", "H:mm", "HH:mm" }, // Formatos de 12h y 24h
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out horaReserva
        );

        if (formatoValido)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO Reservaciones (Nombre, Fecha, Hora) VALUES (@nombre, @fecha, @hora)";

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
                        comando.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha.Date;
                        comando.Parameters.Add("@hora", SqlDbType.Time).Value = horaReserva.TimeOfDay; // ✅ Guardar correctamente como TIME

                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("¡La reservación ha sido guardada exitosamente!");
                            LimpiarCampos();
                            dataGridView2.Rows.Add(nombre, fecha.ToShortDateString(), horario);
                            rjComboBox1.SelectedIndex = -1;
                            tbxNombreData.Texts = "";
                        }
                        else
                        {
                            MessageBox.Show("Error al guardar la reservación.");
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
        else
        {
            MessageBox.Show("Formato de hora inválido. Use un formato correcto (Ejemplo: 10:30 a.m., 14:00).");
        }

        rjComboBox1.SelectedIndex = -1;
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






        private void LimpiarCampos()
        {
            tbxNombreData.Texts = "";
            rjComboBox1.SelectedIndex = -1;
            rjDatePicker1.Value = DateTime.Now;
        }



        private void btn_Acceder_Click(object sender, EventArgs e)
        {
          
            agregarData();
            tbxNombreData.Texts = "";
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
           

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void title_inciar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewVer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rjDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now.Date;

            
           
        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
