using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class EProceso_Fabricacion
    {
        public int idProcesoFabricacion { get; set; }
        public int Fabricacion_Id { get; set; }
        public int Tarea_Id { get; set; }
        public int Realiza { get; set; }
        public int ControlUno { get; set; }
        public int ControlDos { get; set; }
        public DateTime Fecha { get; set; }

        public DateTime Fecha_Fin { get; set; }
        public int T_Real { get; set; }
        public int Nro_Fabricacion { get; set; }
        public string Notas { get; set; }

        public int Consumo_Resina { get; set; }
        public int Consumo_Fibra { get; set; }
    
    }
}
