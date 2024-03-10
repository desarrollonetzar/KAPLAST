using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using System.Data;

namespace CNegocios
{
  public  class NDashboard
    {
       public static DataTable consumo(int id)
        {
            DDashboard Datos = new DDashboard();
            return Datos.consumo(id);
        }

        public static DataTable consumodos(int id)
        {
            DDashboard Datos = new DDashboard();
            return Datos.consumodos(id);
        }

        public static DataTable tareasPendientes(int id)
        {
            DDashboard Datos = new DDashboard();
            return Datos.TareasPendientes(id);
        }

        public static DataTable tareasCompletadas(int id)
        {
            DDashboard Datos = new DDashboard();
            return Datos.TareasCompletadas(id);
        }

    }
}
