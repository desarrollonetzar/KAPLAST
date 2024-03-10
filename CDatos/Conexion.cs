using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CDatos
{
    public class Conexion
    {
        private static Conexion Con = null;


        private Conexion()
        {

        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
               // Cadena.ConnectionString = "Data Source=DESKTOP-7QCVH09; Initial Catalog=kpdb; Integrated Security=true;";
                Cadena.ConnectionString = "Data Source=NETZAR-NB; Initial Catalog=kpdb; Integrated Security=true;";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}