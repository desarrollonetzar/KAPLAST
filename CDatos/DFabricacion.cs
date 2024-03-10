using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CEntidades;

namespace CDatos
{
    public class DFabricacion
    {
        public DataTable Listar()
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("TIPO_FABRICACION_LISTAR", Con);
                cmd.CommandType = CommandType.StoredProcedure;

                Con.Open();
                Dr = cmd.ExecuteReader();
                Dt.Load(Dr);
                return Dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }
               public string Insertar(EFabricacion obj)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("TIPO_FABRICACION_INSERTAR", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = obj.Fabricacion_Nombre;
                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
            return rpta;
        }
    }
}
