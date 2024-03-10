using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class EUsuario
    {

        public int IdUsuario { get; set; }
        public string Usuario_Nombre { get; set; }
        public string Contraseña { get; set; }
        public int Rol_Id { get; set; }

        public bool Estado { get; set; }
    }
}
