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
   public class NProceso_Fabricacion
    {

        public static string Insertar_Proceso(int fabricacion_id, int nro_fabricacion)
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            EProceso_Fabricacion obj = new EProceso_Fabricacion();
            obj.Fabricacion_Id = fabricacion_id;
            obj.Nro_Fabricacion = nro_fabricacion;
            return Datos.Insertar_Proceso(obj);

        }

        public static DataTable Cmb_tarea()
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            return Datos.Cmb_tarea();
        }

        public static DataTable Cmb_asociacion()
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            return Datos.Cmb_Asociacion();
        }

        public static DataTable Cmb_usuario_uno()
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            return Datos.Cmb_Control_uno();
        }

        public static DataTable Cmb_usuario_dos()
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            return Datos.Cmb_Control_dos();
        }


        public static string Actualizadatosproceso(int realiza, DateTime fecha, int nro_fabricacion)
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            EProceso_Fabricacion obj = new EProceso_Fabricacion();
            obj.Realiza = realiza;
            obj.Fecha = fecha;
            obj.Nro_Fabricacion = nro_fabricacion;
            return Datos.Actualizadatosproceso(obj);
        }

        public static DataTable ListarProceso(int id)
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            return Datos.ListarProceso(id);
        }

        public static string ActualizaControlUno(int idfabricacion, int idTarea,int controlUno ,DateTime fecha, string notas, int consumo_Resina, int consumo_Fibra)
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            EProceso_Fabricacion obj = new EProceso_Fabricacion();
            obj.Nro_Fabricacion = idfabricacion;
            obj.Tarea_Id = idTarea;
            obj.ControlUno = controlUno;
            obj.Fecha = fecha;
            obj.Notas = notas;
            obj.Consumo_Resina = consumo_Resina;
            obj.Consumo_Fibra = consumo_Fibra;
            

            return Datos.ActualizaControlUno(obj);
        }
        public static string ActualizaControlDos(int idfabricacion, int idTarea, int controlDos, DateTime fecha, string notas, DateTime fecha_fin, int t_real, int consumo_resina,int consumo_fibra)
        {
            DProceso_Fabricacion Datos = new DProceso_Fabricacion();
            EProceso_Fabricacion obj = new EProceso_Fabricacion();
            obj.Nro_Fabricacion = idfabricacion;
            obj.Tarea_Id = idTarea;
            obj.ControlDos = controlDos;
            obj.Fecha = fecha;
            obj.Notas = notas;
            obj.Fecha_Fin=fecha_fin;
            obj.T_Real = t_real;
            obj.Consumo_Resina = consumo_resina;
            obj.Consumo_Fibra = consumo_fibra;
            return Datos.ActualizaControlDos(obj);
        }
    }
}
