using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;
using System.Data;
using System.Data.SqlClient;

namespace CDatos
{
    public class DDocum
    {

        public DataTable Buscar(int id)
        {
            SqlDataReader dr;
            DataTable dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("DOCUM_BUSCAR", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("ID", SqlDbType.Int).Value = id;
                Con.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }
        public string InsertarDocum(EDocum obj)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("INSERTA_DOCUMENTO", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar).Value = obj.nombre;
                cmd.Parameters.Add("@DOC", SqlDbType.VarChar).Value = obj.doc;
                cmd.Parameters.Add("@FABRICACION_ID", SqlDbType.Int).Value = obj.fabricacion_id;
                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el documento";


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
