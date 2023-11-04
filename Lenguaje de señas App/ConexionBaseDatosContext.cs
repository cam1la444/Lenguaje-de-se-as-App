using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lenguaje_de_señas_App
{
    class ConexionBaseDatosContext
    {
            public ConexionBaseDatosContext()
                : base (GetDbContextOptions("Server=LAPTOP-S0L1KC73\\SQLMANCIA;Database=;TrustServerCertificate=True;Trusted_Connection=True"))
            {

            }
            public DbSet<IngresoUsuarios> Empleados { get; set; }

            private static DbContextOptions GetDbContextOptions(string cadenaConexion)
            {
                return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), cadenaConexion).Options;
            }
    }
}
