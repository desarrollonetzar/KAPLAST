using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CEntidades;
using System.Data.SqlClient;


namespace CDatos
{
    public class DHerramientas
    {

        public DataTable Listar()
        {
            SqlDataReader dr;

            DataTable dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("herramienta_listar", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                Con.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;

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
        public DataTable Buscar(string valor)
        {
            SqlDataReader dr;

            DataTable dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("herramienta_buscar", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                Con.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;

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

        public string Insertar(EHerramientas obj)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("INSERTAR_HERRAMIENTA", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@DESCRIPCION", SqlDbType.VarChar).Value = obj.desc_herramienta;
                cmd.Parameters.Add("@TIPO", SqlDbType.VarChar).Value = obj.tipo;
                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK":"No se pudo agregar la Herramienta";
             

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();

            }
            return rpta;


        }
        public string Editar(EHerramientas obj)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("EDITAR_HERRAMIENTAS", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = obj.idherramienta;
                cmd.Parameters.Add("@DESC", SqlDbType.VarChar).Value = obj.desc_herramienta;
                cmd.Parameters.Add("@TIPO", SqlDbType.VarChar).Value = obj.tipo;
                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo editar la Herramienta";


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();

            }
            return rpta;


        }

        public DataTable cmb_tipo()
        {
            SqlDataReader dr;

            DataTable dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("cmb_tipo_herramienta", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                Con.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;

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


         // ----------------------------HERRAMIENTAS <--> ORDENES --------------------- //

        public DataTable Listar_Herramienta_orden(int id)
        {
            SqlDataReader dr;

            DataTable dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("listar_orden_herramienta", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                Con.Open();
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                return dt;

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
        public string Agrega_Herramienta_Orden(int idfabricacion, int idherramienta, int cant)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("INSERTAR_HERRAMIENTA_ORDEN", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@IDFABRICACION", SqlDbType.Int).Value = idfabricacion;
                cmd.Parameters.Add("@IDHERRAMIENTA", SqlDbType.Int).Value = idherramienta;
                cmd.Parameters.Add("@CANT", SqlDbType.Int).Value = cant;
                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo agregar la Herramienta";


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();

            }
            return rpta;


        }
    }
}
