using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lenguaje_de_señas_App
{
    class ConexionBaseDatos
    {
        public static int CrearCuentas(string Email, string Clave)
        {
            int resultado = 0;
            SqlConnection conectar = ConexionBaseDatos.ObtenerConexion();

            SqlCommand Comando = new SqlCommand(string.Format("INSERT INTO registroUsuarios (Email,Clave)"));

            resultado = Comando.ExecuteNonQuery();
            conectar.Close();

            return resultado;
        }
    }
}
