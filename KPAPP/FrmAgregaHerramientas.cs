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
    public partial class FrmAgregaHerramientas : Form
    {
        public FrmAgregaHerramientas()
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

       
        private void listar()
        {
            DgvAgHerramientas.DataSource = NHerramientas.Listar();
        }

        private void Listar_Herramienta_orden()
        {
            Dgvherragregada.DataSource = NHerramientas.Listar_Herramienta_orden(Convert.ToInt32(txtid.Text));
        }


        private void FrmAgregaHerramientas_Load(object sender, EventArgs e)
        {
            listar();
            Listar_Herramienta_orden();
        }

       

        private void DgvAgHerramientas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gbagrega.Visible = true;
            DgvAgHerramientas.Enabled = false;
            txtherragregada.Text = DgvAgHerramientas.CurrentRow.Cells[1].Value.ToString();
            txtcant.Text = "1";


            
        }

        private void btnherramientas_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                if (txtcant.Text == string.Empty)
                {
                    this.MensajeError("Ingrese una cantidad.");
                }
                else { 
                
                    DialogResult resultado = MessageBox.Show("Se agregara la herramienta: " + txtherragregada.Text + "a la orden. Desea continuar?", "Nueva Herramienta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resultado == DialogResult.Yes)
                    {
                        rpta = NHerramientas.Agrega_Herramienta_Orden(Convert.ToInt32(txtid.Text.Trim()), Convert.ToInt32(DgvAgHerramientas.CurrentRow.Cells[0].Value),Convert.ToInt32(txtcant.Text.Trim()));
                        if (rpta.Equals("OK"))
                        {

                            DgvAgHerramientas.Enabled = true;
                            gbagrega.Visible = false;
                            Listar_Herramienta_orden();
                            

                        }
                        else
                        {
                            this.MensajeError(rpta);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
