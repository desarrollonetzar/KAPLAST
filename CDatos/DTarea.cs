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
    public class DTarea
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
                SqlCommand cmd = new SqlCommand("TAREA_LISTAR", Con);
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

        public DataTable Buscar(int id)
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("TAREA_BUSCAR", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

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

        public DataTable Cmb_Fabricacion()
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("cmb_fabricacion", Con);
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
       
        public DataTable Cmb_FabricacionNueva()
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("cmb_fabricacion", Con);
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
        public string Insertar(ETarea obj)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("INSERTAR_NUEVA_TAREA", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ORDEN", SqlDbType.Int).Value = obj.Orden_Tarea;
                cmd.Parameters.Add("@NOMBRE_TAREA", SqlDbType.VarChar).Value = obj.Nombre_Tarea;
                cmd.Parameters.Add("@OBSERVACION", SqlDbType.VarChar).Value = obj.Observacion;
                cmd.Parameters.Add("@FABRICACION_ID", SqlDbType.Int).Value = obj.Fabricacion_Id;
                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo crear la tarea";


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

        public string InsertarCopia(ETarea obj)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("INSERTAR_NUEVA_TAREA_COPIA", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@ORDEN", SqlDbType.Int).Value = obj.Orden_Tarea;
                cmd.Parameters.Add("@NOMBRE_TAREA", SqlDbType.VarChar).Value = obj.Nombre_Tarea;
                cmd.Parameters.Add("@OBSERVACION", SqlDbType.VarChar).Value = obj.Observacion;
                cmd.Parameters.Add("@FABRICACION_ID", SqlDbType.Int).Value = obj.Fabricacion_Id;
                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo crear la tarea";


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