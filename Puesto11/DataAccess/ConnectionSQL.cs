using Microsoft.Data.SqlClient;
using System;

namespace DataAccess
{
    public abstract class ConnectionSQL : IDisposable
    {
        // Cadena de conexión, puedes ajustarla si usas autenticación SQL Server.
        string cadenaConexion = "";




        private SqlConnection conection;

        // Constructor que inicializa la conexión
        public ConnectionSQL()
        {
            conection = new SqlConnection(cadenaConexion);
        }

        // Método para obtener la conexión de forma segura
        public SqlConnection GetConnection()
        {
            try
            {
                // Abrimos la conexión solo si está cerrada
                if (conection.State == System.Data.ConnectionState.Closed)
                {
                    conection.Open();
                }
                return conection;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error al abrir la conexión: {ex.Message}");
                throw;
            }
        }

        // Método para liberar los recursos correctamente
        public void Dispose()
        {
            if (conection != null)
            {
                // Cerramos y liberamos la conexión solo si está abierta
                if (conection.State != System.Data.ConnectionState.Closed)
                {
                    conection.Close();
                }
                conection.Dispose();
                conection = null;
            }
        }
    }
}
