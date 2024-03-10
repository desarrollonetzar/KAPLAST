using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CDatos
{
    public class DDashboard
    {

        public DataTable consumo(int id)
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("consumo_uno", Con);
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

        public DataTable consumodos(int id)
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("consumo_dos", Con);
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

        public DataTable TareasPendientes(int id)
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("tareas_pendientes", Con);
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

        public DataTable TareasCompletadas(int id)
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("tareas_completadas", Con);
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
    }

    
}