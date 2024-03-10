using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocios;

namespace KPAPP.Reportes
{
    public partial class frmrpttareas : Form
    {
        public frmrpttareas()
        {
            InitializeComponent();
        }

        private void cmb_fabric()
        {
            CmbFabric.DisplayMember = "FABRICACION_NOMBRE";
            CmbFabric.ValueMember = "IDFABRICACION";
            CmbFabric.DataSource = NNueva_Fabricacion.Cmb_Fabricacion();
        }

        private void frmrpttareas_Load(object sender, EventArgs e)
        {
            cmb_fabric();
            // TODO: esta línea de código carga datos en la tabla 'DSTareas.RPT_TAREAS' Puede moverla o quitarla según sea necesario.
            this.RPT_TAREASTableAdapter.TAREAS_PARAMETRO(this.DSTareas.RPT_TAREAS,Convert.ToInt32(CmbFabric.SelectedValue));

            this.reportViewer1.RefreshReport();
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            this.RPT_TAREASTableAdapter.TAREAS_PARAMETRO(this.DSTareas.RPT_TAREAS, Convert.ToInt32(CmbFabric.SelectedValue));

            this.reportViewer1.RefreshReport();
        }
    }
}
