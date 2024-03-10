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
    public class DNueva_Fabricacion
    {

        // Store Procedures para cargar los combo box

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

        public DataTable Cmb_Nueva_Fabricacion()
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("cmb_nuevafabricacion", Con);
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

        public DataTable Cmb_estado()
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("estado_orden", Con);
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
                SqlCommand cmd = new SqlCommand("Fabricaciones_Listar", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                Con.Open();
                Dr = cmd.ExecuteReader();
                Dt.Load(Dr);
                return Dt;
                    
            }catch(Exception ex)
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
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Fabricaciones_Buscar", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
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

        public string Insertar(ENueva_Fabricacion obj)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Nuevafabricacion_Insertar", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = obj.FechaInicio;
                cmd.Parameters.Add("@observaciones", SqlDbType.VarChar).Value = obj.Observaciones;
                cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.idUsuario;
                cmd.Parameters.Add("@nrofabricacion", SqlDbType.VarChar).Value = obj.nrofabricacion;
                cmd.Parameters.Add("@fabricacion_id", SqlDbType.Int).Value = obj.Fabricacion_Id;
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

        public string Actualizar (ENueva_Fabricacion obj)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Nuevafabricacion_Actualizar",Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idnuevafabricacion", SqlDbType.Int).Value = obj.idNuevaFabricacion;
                cmd.Parameters.Add("@fecha_inicio", SqlDbType.DateTime).Value = obj.FechaInicio;
                cmd.Parameters.Add("@observaciones", SqlDbType.DateTime).Value = obj.Observaciones;
                cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.idUsuario;
                cmd.Parameters.Add("@nrofabricacion", SqlDbType.VarChar).Value = obj.nrofabricacion;
                cmd.Parameters.Add("@fabricacion_id", SqlDbType.Int).Value = obj.Fabricacion_Id;
                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";


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

        public string Eliminar (int id)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("Nuevafabricacion_Eliminar", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idnuevafabricacion", SqlDbType.Int).Value = id;
         
                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";


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


        public string CerrarOrden(ENueva_Fabricacion obj)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("cierra_orden", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = obj.idNuevaFabricacion;
                cmd.Parameters.Add("@chk", SqlDbType.Bit).Value = obj.Completada;
                cmd.Parameters.Add("@fecha_cierre", SqlDbType.DateTime).Value = obj.FechaCierre;
                cmd.Parameters.Add("@ESTADO", SqlDbType.VarChar).Value = obj.Estado;
             
                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo cerrar la Orden";


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
