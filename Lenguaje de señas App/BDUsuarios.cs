using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenguaje_de_señas_App
{
    internal class BDUsuarios
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conectar = new SqlConnection("Data Source=LAPTOP-S0L1KC73\\SQLMANCIA; Initial Catalog=registrarUsuario");
            conectar.Open();

            return conectar;
        }
    }
}
