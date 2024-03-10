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
   public class NDocum
    {
        public static DataTable Buscar(int id)
        {
            DDocum Datos = new DDocum();
            return Datos.Buscar(id);
        }

        public static string Insertar(string nombre, string doc, int fabricacion_id)
        {
            DDocum Datos = new DDocum();
            EDocum obj = new EDocum();
            obj.nombre = nombre;
            obj.doc = doc;
            obj.fabricacion_id = fabricacion_id;
            return Datos.InsertarDocum(obj);
        }

    }
}
