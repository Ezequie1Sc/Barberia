using Microsoft.Data.SqlClient;
using System;

namespace Puesto11
{
    public class ConexionSQL : IDisposable
    {
        private SqlConnection conection;
        private string cadenaConexion = "Data source=EZEQUIEL\\SQLEXPRESS; Initial Catalog = LigaDeportiva; TrustServerCertificate=true; Integrated Security=True;";

        public ConexionSQL()
        {
            conection = new SqlConnection(cadenaConexion);
            conection.Open();
        }

        public SqlConnection Connection()
        {
            return conection;
        }

        public void Dispose()
        {
            if (conection != null)
            {
                conection.Close();
                conection.Dispose();
            }
        }
    }
}
