using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
   public class ETarea
    {
        public int IdTarea { get; set; }
        public int Orden_Tarea { get; set; }
        public string Nombre_Tarea { get; set; }
        public string Observacion { get; set; }

        public int Fabricacion_Id { get; set; }
        public int fabricacion_nro { get; set; }

        public int Tarea_Existe { get; set; }
    }
}
