using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenguaje_de_señas_App
{
    internal class Conexion
    {
        public static int Agregar(Usuarios pUsuarios)
        {
            using (SqlConnection conectar = BDUsuarios.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("INSERT INTO registroUsuarios (Email,Clave) VALUES ('{0}','{1}')", pEmail.Email,pClave.Clave),conectar);

                return = Comando.ExecuteNonQuery();
            }
        }
    }
}
