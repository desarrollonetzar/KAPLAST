using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace CEntidades
{
  public  class ENueva_Fabricacion
    {
        public int idNuevaFabricacion { get; set; }
        public DateTime FechaInicio { get; set; }
       
     
        public string Observaciones { get; set; }

        public Boolean Completada { get; set; }
        public int idUsuario { get; set; }
        public string nrofabricacion { get; set; }

        public int Fabricacion_Id { get; set; }

        public DateTime FechaCierre { get; set; }

        public string Estado { get; set; }
        public DataTable  Detalles { get; set; }

    }
}
