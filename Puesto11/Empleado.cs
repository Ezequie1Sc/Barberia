
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regitro_De_Empleado
{
    public class Empleado
    {
        public string Id { get; private set; }
        public string Nombre { get; private set; }
        public string apellido1 { get; private set; }
        public string password { get; private set; }
        public double Edad { get; private set; }
        public string Email { get; private set; }

        public Empleado(string id, string nombre, string apellido1, string password, double edad, string email)
        {
            Id = id;
            Nombre = nombre;
            this.apellido1 = apellido1;
            this.password = password;
            Edad = edad;
            Email = email;
        }
    }
}
