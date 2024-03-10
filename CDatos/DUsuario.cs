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
    public class DUsuario
    {

        public DataTable Cmb_Usuario()
        {
            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("CMB_USUARIO", Con);
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
                SqlCommand cmd = new SqlCommand("usuario_listar", Con);
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
                SqlCommand cmd = new SqlCommand("usuario_buscar", Con);
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

        public string Existe(string valor)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();
            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usuario_existe", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = valor;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(ParExiste);
                Con.Open();
                cmd.ExecuteNonQuery();
                rpta = Convert.ToString(ParExiste.Value);

            }catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
            return rpta;
        }

        public string Insertar(EUsuario obj)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usuario_insertar", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idrol", SqlDbType.Int).Value = obj.Rol_Id;
                cmd.Parameters.Add("@usuario_nombre", SqlDbType.VarChar).Value = obj.Usuario_Nombre;
                cmd.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = obj.Contraseña;


                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Agregar el usuario";


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

        public string Actualizar(EUsuario obj)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usuario_actualizar", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.IdUsuario;
                cmd.Parameters.Add("@idrol", SqlDbType.Int).Value = obj.Rol_Id;
                cmd.Parameters.Add("@usuario_nombre", SqlDbType.VarChar).Value = obj.Usuario_Nombre;
                cmd.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = obj.Contraseña;


                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el usuario";


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

        public string Eliminar(int id)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usuario_eliminar", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;
           


                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Agregar el usuario";


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

        public string Activar(int id)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usuario_activar", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;



                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Agregar el usuario";


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

        public string Desactivar(int id)
        {
            string rpta = "";
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usuario_desactivar", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = id;



                Con.Open();
                rpta = cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Agregar el usuario";


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
    
        // FUNCION DE LOGIN 

        public DataTable Login(string usuario_nombre, string contraseña)
        {

            // se inicializa la clase Datareader para leer los datos de la base
            SqlDataReader Dr;
            // se declara el datatable para guardar la tabla en memoria
            DataTable Dt = new DataTable();
            SqlConnection Con = new SqlConnection();

            try
            {
                Con = Conexion.getInstancia().CrearConexion();
                SqlCommand cmd = new SqlCommand("usuario_login", Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario_nombre;
                cmd.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = contraseña;
                Con.Open();
                Dr = cmd.ExecuteReader();
                Dt.Load(Dr);
                return Dt;

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            finally
            {
                if (Con.State == ConnectionState.Open) Con.Close();
            }
        }
    }

   

   


}
