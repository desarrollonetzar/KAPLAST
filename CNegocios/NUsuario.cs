using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using System.Data;
using CEntidades;

namespace CNegocios
{
   public class NUsuario
    {

        public static DataTable Cmb_Usuario()
        {
            DUsuario Datos = new DUsuario();
            return Datos.Cmb_Usuario();
        }

        public static DataTable Listar()
        {
            DUsuario Datos = new DUsuario();
            return Datos.Listar();
        }
        public static DataTable Buscar(string valor)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Buscar(valor);
        }

        public static DataTable Login(string usuario_nombre, string contraseña)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Login(usuario_nombre, contraseña);
        }

        public static string Insertar(int idrol,string usuario_nombre, string contraseña)
        {
            DUsuario Datos = new DUsuario();
            string existe = Datos.Existe(usuario_nombre);
            if (existe.Equals("1"))
            {
                return "El usuario ya existe";
            }
            else
            {
                EUsuario obj = new EUsuario();
                obj.Rol_Id = idrol;
                obj.Usuario_Nombre = usuario_nombre;
                obj.Contraseña = contraseña;
                return Datos.Insertar(obj);
            }
        }
        public static string Actualizar(int idusuario, int idrol,string usuario_anterior ,string usuario_nombre, string contraseña)
        {
            DUsuario Datos = new DUsuario();
            EUsuario obj = new EUsuario();
           
            if (usuario_anterior.Equals(usuario_nombre))
            {
                obj.IdUsuario = idusuario;
                obj.Rol_Id = idrol;
                obj.Usuario_Nombre = usuario_nombre;
                obj.Contraseña = contraseña;
                return Datos.Actualizar(obj);
            }
            else
            {
                string existe = Datos.Existe(usuario_nombre);
                if (existe.Equals("1"))
                {
                    return "El usuario ya existe";
                }
                else
                {
                    obj.IdUsuario = idusuario;
                    obj.Rol_Id = idrol;
                    obj.Usuario_Nombre = usuario_nombre;
                    obj.Contraseña = contraseña;
                    return Datos.Actualizar(obj);
                }
            }
        }

        public static string Eliminar(int id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Eliminar(id);
        }

        public static string Activar(int id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Activar(id);
        }

        public static string Desactivar(int id)
        {
            DUsuario Datos = new DUsuario();
            return Datos.Desactivar(id);
        }
    }
}
