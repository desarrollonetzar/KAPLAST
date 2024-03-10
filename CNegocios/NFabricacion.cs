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
   public class NFabricacion
    {
        public static DataTable Listar()
        {
            DFabricacion Datos = new DFabricacion();
            return Datos.Listar();
        }

        public static string Insertar(string valor)
        {
            DFabricacion Datos = new DFabricacion();
            EFabricacion obj = new EFabricacion();
            obj.Fabricacion_Nombre = valor;
            return Datos.Insertar(obj);
        }

       
    }
}
