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
namespace KPAPP
{
    public partial class FrmNuevoTipoFabricacion : Form
    {
        public FrmNuevoTipoFabricacion()
        {
            InitializeComponent();
        }

        private void MensajeError(string mensaje)

        {
            MessageBox.Show(mensaje, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Proceso de carga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Listar()
        {
            dgvfabric.DataSource = NFabricacion.Listar();
        }
        private void FrmNuevoTipoFabricacion_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            lblfabric.Visible = true;
            txtfabric.Visible = true;
            btnAceptar.Visible = true;
            btnagregar.Visible = false;
            btncancelar.Visible = true;
        }


           

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtfabric.Text == string.Empty)
                {
                    this.MensajeError("Ingrese la descripción");
                }
                else
                {
                    rpta = NFabricacion.Insertar(txtfabric.Text);
                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Tipo de fabricación cargada");
                    lblfabric.Visible = false;
                    txtfabric.Visible = false;
                    btnAceptar.Visible = false;
                    btnagregar.Visible = false;
                    Listar();
                }
                else
                {
                    this.MensajeError(rpta);
                }
               
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            lblfabric.Visible = false;
            txtfabric.Visible = false;
            btnAceptar.Visible = false;
            btnagregar.Visible = true;
            btncancelar.Visible = false;
            Listar();
        }
    }
}
