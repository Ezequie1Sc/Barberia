using Common.Cache;
using DataAccess;
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class UserDao : ConnectionSQL
{
    public bool Login(string user, string pass)
    {
        using (SqlConnection connection = GetConnection())
        {
            try
            {
                string query = "SELECT IdUser, Nombre, Apellido, Email, Imagen FROM Usuarios WHERE Usuario LIKE @usuario AND Contrasena LIKE @contrasena";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usuario", user);
                    command.Parameters.AddWithValue("@contrasena", pass);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {

                        ActiveUser.password = pass;
                        ActiveUser.usuario = user;
                        while (reader.Read())
                        {

                            ActiveUser.idUser = reader.GetInt32(0);
                            ActiveUser.nombre = reader.GetString(1);
                            ActiveUser.apellido = reader.GetString(2);
                            ActiveUser.correo = reader.GetString(3);


                            byte[] imageData = reader.IsDBNull(4) ? null : (byte[])reader["imagen"];
                            ActiveUser.imageData = imageData;

                            reader.Close();

                            return true;
                        }

                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }


    public bool RegisterUser(string usuario, string nombre, string apellido, string correo, string contrasena, byte[] imagen)
    {
        using (SqlConnection connection = GetConnection())
        {
            try
            {
                string query = @"INSERT INTO Usuarios (Usuario, Nombre, Apellido, Email, Contrasena, Imagen) VALUES (@usuario, @nombre, @apellido, @correo, @contrasena, @imagen)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@contrasena", contrasena);
                    command.Parameters.Add("@imagen", SqlDbType.Image).Value = (object)imagen ?? DBNull.Value;

                    // Ejecutar la consulta
                    int rowsAffected = command.ExecuteNonQuery();

                    // Retorna true si el registro fue exitoso
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }



    public bool editUser(string usuario, string nombre, string apellido, string correo, string contrasena, byte[] imagen, int IdUser)
    {
        using (SqlConnection connection = GetConnection())
        {
            try
            {
                string query = @"
                UPDATE usuarios
                SET 
                    usuario LIKE @usuario,
                    nombre LIKE @nombre,
                    apellido LIKE @apellido,
                    correo LIKE @correo,
                    contrasena LIKE @contrasena,
                    imagen LIKE @imagen
                WHERE id_usuario LIKE @id_usuario";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar parámetros
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@id_usuario", IdUser);
                    command.Parameters.AddWithValue("@contrasena", contrasena);

                    if (imagen != null)
                    {
                        command.Parameters.Add("@imagen", SqlDbType.Image).Value = imagen;
                    }
                    else
                    {
                        command.Parameters.Add("@imagen", SqlDbType.Image).Value = DBNull.Value;
                    }

                    // Abrir conexión
                    connection.Open();

                    // Ejecutar la consulta
                    int rowsAffected = command.ExecuteNonQuery();

                    // Retorna true si se actualizó correctamente
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }

}









