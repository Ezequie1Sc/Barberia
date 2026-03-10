using DataAccess;
namespace DoMain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        private int idUser;
        private string usuario;
        private string nombre;
        private string apellido;
        private string password;
        public string correo;

        public UserModel(int idUser, string usuario, string nombre, string apellido, string password, string correo)
        {
            this.idUser = idUser;
            this.usuario = usuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.password = password;
            this.correo = correo;
        }

        public UserModel()
        {

        }

        public bool editUser(string usuario, string nombre, string apellido, string correo, string contrasena, byte[] imagen, int idUser)
        {
            
               return userDao.editUser(usuario, nombre, apellido, correo, contrasena, imagen, idUser);

               
        }



        public string RegisterUser(string usuario, string nombre, string apellido, string correo, string contrasena, byte[] imagen = null)
        {
            bool isRegistered = userDao.RegisterUser(usuario, nombre, apellido, correo, contrasena, imagen);

            if (isRegistered)
            {
                return "Usuario registrado exitosamente.";
            }
            else
            {
                return "El usuario ya existe o hubo un error.";
            }
        }

        public bool Login(string user, string pass)
        {

            return userDao.Login(user,pass); ;
        }
        
    }
}
