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
    public class NHerramientas
    {

        public static DataTable Listar()
        {
            DHerramientas Datos = new DHerramientas();
            return Datos.Listar();
        }
        public static DataTable cmb_tipo()
        {
            DHerramientas Datos = new DHerramientas();
            return Datos.cmb_tipo();
        }

        public static DataTable Buscar(string valor)
        {
            DHerramientas Datos = new DHerramientas();
            return Datos.Buscar(valor);
        }

        public static string Insertar(string descripcion, string tipo)
        {
            DHerramientas Datos = new DHerramientas();
            EHerramientas obj = new EHerramientas();
            obj.desc_herramienta = descripcion;
            obj.tipo = tipo;
            return Datos.Insertar(obj);

        }

        public static string Editar(int id, string descripcion, string tipo)
        {
            DHerramientas Datos = new DHerramientas();
            EHerramientas obj = new EHerramientas();
            obj.idherramienta = id;
            obj.desc_herramienta = descripcion;
            obj.tipo = tipo;
            return Datos.Editar(obj);

        }

        public static string Agrega_Herramienta_Orden(int idfabricacion, int idherramienta, int cant)
        {
            DHerramientas Datos = new DHerramientas();
            return Datos.Agrega_Herramienta_Orden(idfabricacion, idherramienta, cant);

        }

        public static DataTable Listar_Herramienta_orden(int id)
        {
            DHerramientas Datos = new DHerramientas();
            return Datos.Listar_Herramienta_orden(id);
        }
    }
}
