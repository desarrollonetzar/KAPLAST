using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CDatos;
using CEntidades;

namespace CNegocios

{
    public class NTarea
    {

        public static DataTable Listar()
        {
            DTarea Datos = new DTarea();
            return Datos.Listar();
        }

        public static DataTable Buscar(int id)
        {
            DTarea Datos = new DTarea();
            return Datos.Buscar(id);
        }

        public static DataTable Cmb_Fabricacion()
        {
            DNueva_Fabricacion Datos = new DNueva_Fabricacion();
            return Datos.Cmb_Fabricacion();
        }

   
        public static DataTable Cmb_FabricacionNueva()
        {
            DNueva_Fabricacion Datos = new DNueva_Fabricacion();
            return Datos.Cmb_Fabricacion();
        }

        public static string Insertar(int orden_tarea,string nombre_tarea,string observacion,int fabricacion_id)
        {
            DTarea Datos = new DTarea();
            ETarea obj = new ETarea();
            obj.Orden_Tarea = orden_tarea;
            obj.Nombre_Tarea = nombre_tarea;
            obj.Observacion = observacion;
            obj.Fabricacion_Id = fabricacion_id;
            return Datos.Insertar(obj);
            
        }

        public static string InsertarCopia(int orden_tarea, string nombre_tarea, string observacion, int fabricacion_id)
        {
            DTarea Datos = new DTarea();
            ETarea obj = new ETarea();
            obj.Orden_Tarea = orden_tarea;
            obj.Nombre_Tarea = nombre_tarea;
            obj.Observacion = observacion;
            obj.Fabricacion_Id = fabricacion_id;
            return Datos.InsertarCopia(obj);

        }


    }
}
