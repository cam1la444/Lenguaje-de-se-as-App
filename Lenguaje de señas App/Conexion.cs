 using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenguaje_de_señas_App
{
    public  class Conexion
    {
        public static int Agregar(Usuarios pUsuarios)
        {
            int retorno =  0;
            using (SqlConnection conectar = BDUsuarios.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("INSERT INTO registroUsuarios (Email,Clave) VALUES ('{0}','{1}')", pUsuarios.Email, pUsuarios.Clave), conectar);
                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
