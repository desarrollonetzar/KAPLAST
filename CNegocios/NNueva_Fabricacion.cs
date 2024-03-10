using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CEntidades;
using System.Data;
using CEntidades;


namespace CNegocios
{
    public class NNueva_Fabricacion
    {

        public static DataTable Cmb_Fabricacion()
        {
            DNueva_Fabricacion Datos = new DNueva_Fabricacion();
            return Datos.Cmb_Fabricacion();
        }

        public static DataTable Cmb_nueva_fabricacion()
        {
            DNueva_Fabricacion Datos = new DNueva_Fabricacion();
            return Datos.Cmb_Nueva_Fabricacion();


        }

        public static DataTable cmb_estado()
        {
            DNueva_Fabricacion Datos = new DNueva_Fabricacion();
            return Datos.Cmb_estado();
        }
        public static DataTable Listar()
        {
            DNueva_Fabricacion Datos = new DNueva_Fabricacion();
            return Datos.Listar();


        }

        

        public static DataTable Buscar(string valor)
        {
            DNueva_Fabricacion Datos = new DNueva_Fabricacion();
            return Datos.Buscar(valor);
        }

        public static string Insertar(DateTime FechaInicio, string observaciones, int idusuario, string nrofabricacion, int fabricacion_id)
        {
            DNueva_Fabricacion Datos = new DNueva_Fabricacion();
            ENueva_Fabricacion obj = new ENueva_Fabricacion();
            obj.FechaInicio = FechaInicio;
            obj.Observaciones = observaciones;
            obj.idUsuario = idusuario;
            obj.nrofabricacion = nrofabricacion;
            obj.Fabricacion_Id = fabricacion_id;
            return Datos.Insertar(obj);
        }

        public static string Actualizar(int idnuevafabricacion,DateTime FechaInicio, string observaciones, int idusuario, string nrofabricacion, int fabricacion_id)

        {
            DNueva_Fabricacion Datos = new DNueva_Fabricacion();
            ENueva_Fabricacion obj = new ENueva_Fabricacion();
            obj.idNuevaFabricacion = idnuevafabricacion;
            obj.FechaInicio = FechaInicio;
            obj.Observaciones = observaciones;
            obj.idUsuario = idusuario;
            obj.nrofabricacion = nrofabricacion;
            obj.Fabricacion_Id = fabricacion_id;
            return Datos.Actualizar(obj);
        }

        public static string Eliminar (int idnuevafabricacion)
        {
            DNueva_Fabricacion Datos = new DNueva_Fabricacion();
            return Datos.Eliminar(idnuevafabricacion);
        }


        public static string CerrarOrden(int id,bool chk,DateTime fecha_cierre, string estado)
        {
            DNueva_Fabricacion Datos = new DNueva_Fabricacion();
            ENueva_Fabricacion obj = new ENueva_Fabricacion();
            obj.idNuevaFabricacion = id;
            obj.Completada = chk;
            obj.FechaCierre = fecha_cierre;
            obj.Estado = estado;
            return Datos.CerrarOrden(obj);
        }
        

        }
      
    }

