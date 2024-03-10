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
    public partial class FrmHerramientas : Form
    {
        public FrmHerramientas()
        {
            InitializeComponent();
        }

        private void formato()
        {
            DgvHerramientas.Columns[0].Visible = false;
            DgvHerramientas.Columns[1].Visible = false;
            DgvHerramientas.Columns[2].HeaderText = "HERRAMIENTA";
            DgvHerramientas.Columns[3].HeaderText = "TIPO";

        }

        private void MensajeError(string mensaje)

        {
            MessageBox.Show(mensaje, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Proceso de carga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void tipo()
        {
            cmbtipo.DisplayMember = "TIPO";
            cmbtipo.ValueMember = "TIPO";
            cmbtipo.DataSource = NHerramientas.cmb_tipo();
        }

        private void CmbBusca()
        {
            cmbbuscar.DisplayMember = "TIPO";
            cmbbuscar.ValueMember = "TIPO";
            cmbbuscar.DataSource = NHerramientas.cmb_tipo();
        }

        private void EdTipo()
        {
            cmbEdTipo.DisplayMember = "TIPO";
            cmbEdTipo.ValueMember = "TIPO";
            cmbEdTipo.DataSource = NHerramientas.cmb_tipo();
        }

        private void Listar()
        {
            DgvHerramientas.DataSource = NHerramientas.Listar();
        }

        private void Buscar()
        {
            DgvHerramientas.DataSource = NHerramientas.Buscar(Convert.ToString(cmbbuscar.SelectedValue));
        }

        private void BuscaText()
        {
            DgvHerramientas.DataSource = NHerramientas.Buscar(txtbuscar.Text);
        }

        private void FrmHerramientas_Load(object sender, EventArgs e)
        {

            Listar();
            formato();
            CmbBusca();
            EdTipo();
            BuscaText();
            tipo();


        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscaText();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string rpta = "";
            try
            {
                if (txtdesc.Text == string.Empty)
                {
                    this.MensajeError("Ingrese los datos requeridos.");
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("Se agregara la herramienta " + txtdesc.Text + "del tipo " + cmbtipo.SelectedValue +
                 ". Desea continuar?", "Nueva Herramienta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resultado == DialogResult.Yes)
                    {
                        rpta = NHerramientas.Insertar(txtdesc.Text.Trim(), Convert.ToString(cmbtipo.SelectedValue));
                        if (rpta.Equals("OK"))
                        {
                            this.MensajeOk("Se ha cargado la nueva herramienta");

                           this.Listar();

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

        private void DgvHerramientas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EdTipo();
            GbEditar.Visible = true;
            btnEditar.Visible = true;
            Gbherramientas.Enabled = false;
            GbBuscar.Enabled = false;
            txtEdDesc.Text = DgvHerramientas.CurrentRow.Cells[2].Value.ToString();
            cmbEdTipo.SelectedValue = DgvHerramientas.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEdDesc.Text != string.Empty)
                {
                    DialogResult resultado = MessageBox.Show("Desea editar la Herramienta con el nuevo valor: " + txtEdDesc.Text + "Tipo: " + cmbEdTipo.SelectedValue + " ?. La acción no podrán deshacerse",
                        "Editar Herramienta",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (resultado == DialogResult.Yes)
                    {
                        NHerramientas.Editar(Convert.ToInt32(DgvHerramientas.CurrentRow.Cells[1].Value.ToString()), txtEdDesc.Text.Trim(), Convert.ToString(cmbEdTipo.SelectedValue));
                        MessageBox.Show("Se ha editado la herramienta");
                        Listar();
                        GbEditar.Visible = false;
                        Gbherramientas.Enabled = true;
                        GbBuscar.Enabled = true;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }


            }


