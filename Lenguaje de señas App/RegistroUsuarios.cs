using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenguaje_de_señas_App
{
     class RegistroUsuarios
    {
        public static int CrearCuentas(string pEmail, string pClave)
        {
            int resultado = 0;
            using (SqlConnection conectar = BDUsuarios.ObtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("INSERT INTO registroUsuarios (Email,Clave) VALUES ('{0}',PwdEncrypt('{1}'))", pEmail, pClave), conectar);
                resultado = Comando.ExecuteNonQuery();
                conectar.Close();

                return resultado;
            }
        }
    }
}
