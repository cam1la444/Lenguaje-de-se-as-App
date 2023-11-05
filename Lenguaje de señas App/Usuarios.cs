using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenguaje_de_señas_App
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Clave { get; set; }


        public Usuarios() { }

        public Usuarios (int pIdUsuario, string pEmail,string pClave)
        {
            this.IdUsuario = pIdUsuario;
            this.Email = pEmail;
            this.Clave = pClave;
        }
    }
}
