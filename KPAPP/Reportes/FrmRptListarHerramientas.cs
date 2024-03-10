using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPAPP.Reportes
{
    public partial class FrmRptListarHerramientas : Form
    {
        public FrmRptListarHerramientas()
        {
            InitializeComponent();
        }
     
        private void FrmRptListarHerramientas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsHerramientas.RPT_listar_orden_herramienta' Puede moverla o quitarla según sea necesario.
            this.RPT_listar_orden_herramientaTableAdapter.Fill(this.DsHerramientas.RPT_listar_orden_herramienta,Convert.ToInt32(txtidbusqueda.Text));

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
