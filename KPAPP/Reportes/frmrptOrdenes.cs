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
    public partial class frmrptOrdenes : Form
    {
        public frmrptOrdenes()
        {
            InitializeComponent();
        }
       
        private void combo()
        {
            cmbfabric.ValueMember = "IDNUEVAFABRICACION";
            cmbfabric.DisplayMember = "NROFABRICACION";
            
            cmbfabric.DataSource = NNueva_Fabricacion.Cmb_nueva_fabricacion();
        }
        private void frmrptOrdenes_Load(object sender, EventArgs e)
        {
            combo();
            // TODO: esta línea de código carga datos en la tabla 'DsOrdenes.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DsOrdenes.DataTable1, Convert.ToInt32(cmbfabric.SelectedValue));
            

            this.reportViewer1.RefreshReport();
        }

        private void cmbfabric_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsOrdenes.DataTable1' Puede moverla o quitarla según sea necesario.
            this.DataTable1TableAdapter.Fill(this.DsOrdenes.DataTable1, Convert.ToInt32(cmbfabric.SelectedValue));
            this.reportViewer1.RefreshReport();
        }
    }
}
