namespace Common.Cache;

public class ActiveUser
{
    // Propiedades estáticas
    public static int idUser;
    public static string nombre;
    public static string apellido;
    public static string correo;
    public static byte[] imageData;
    public static string password;
    public static string usuario;

    // Constructor para inicializar los valores
    public ActiveUser(int id, string nom, string ap, string pos, string email, byte[] image)
    {
        idUser = id;
        nombre = nom;
        apellido = ap;
        correo = email;
        imageData = image;
       
    }

    
}



