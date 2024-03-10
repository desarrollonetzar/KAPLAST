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
    public partial class FrmNuevaTarea : Form
    {
        public FrmNuevaTarea()
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

        private void Listar()
        {
            dgvtarea.DataSource = NTarea.Listar();
            dgvnueva.DataSource = NTarea.Listar();
        }

        private void cmb_fabricacion()
        {
          
            cmbfabric.DisplayMember = "fabricacion_nombre";
            cmbfabric.ValueMember = "idfabricacion";
            cmbfabric.DataSource = NTarea.Cmb_Fabricacion();

        }

        private void formato()
        {
            dgvtarea.Columns[0].Visible = false;
            dgvnueva.Columns[0].Visible = false;
        }
        private void formato2()
        {
           
        }
        private void cmb_busca()
        {
           
            cmbbuscar.DisplayMember = "fabricacion_nombre";
            cmbbuscar.ValueMember = "idfabricacion";
            cmbbuscar.DataSource = NTarea.Cmb_Fabricacion();
            cmbbuscar.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void cmb_nuevafab()
        {

            cmbnuevafab.DisplayMember = "fabricacion_nombre";
            cmbnuevafab.ValueMember = "idfabricacion";
            cmbnuevafab.DataSource = NTarea.Cmb_Fabricacion();
            cmbnuevafab.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbnuevafab.BackColor = Color.LightCyan;
        }

        private void Buscar()
        {
        
            dgvtarea.DataSource = NTarea.Buscar(Convert.ToInt32(cmbbuscar.SelectedValue));
        }

        private void BuscarNueva()
        {

            dgvnueva.DataSource = NTarea.Buscar(Convert.ToInt32(cmbnuevafab.SelectedValue));
        }

        private void tipoAlta()
        {
            rbmanual.Checked = true;

           
        }
        private void FrmNuevaTarea_Load(object sender, EventArgs e)
        {
            Listar();
            formato();
            cmb_fabricacion();
            cmb_busca();
            cmb_nuevafab();
            tipoAlta();
          
        }

    

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtdescrip.Text == string.Empty)
                {
                    this.MensajeError("Ingrese la descripción para la Tarea");
                }
                else
                {
                    rpta = NTarea.Insertar(Convert.ToInt32(txtorden.Text.Trim()), txtdescrip.Text.Trim(), txtobs.Text, Convert.ToInt32(cmbfabric.SelectedValue));
                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Nueva tarea cargada");
                    gbnuevatarea.Visible = false;
                    Listar();
                }
                else
                {
                    this.MensajeError(rpta);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cmbbusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dgvtarea_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string rpta = "";
                DialogResult resultado = MessageBox.Show("Agregar la tarea " + dgvtarea.CurrentRow.Cells[2].Value.ToString() + "para el proceso de fabricación: " + (cmbnuevafab.SelectedText) + " ?"
                    , "Nueva Tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ; ;
                if (resultado == DialogResult.Yes)
                {
                    rpta = NTarea.InsertarCopia(Convert.ToInt32(dgvtarea.CurrentRow.Cells[1].Value), Convert.ToString(dgvtarea.CurrentRow.Cells[2].Value), Convert.ToString(dgvtarea.CurrentRow.Cells[3].Value),
                     Convert.ToInt32(cmbnuevafab.SelectedValue));
                }
                if (rpta.Equals("OK"))
                {
                    this.MensajeOk("Nueva tarea cargada");
                    
                    Listar();
                    BuscarNueva();
                }
                else
                {
                    this.MensajeError(rpta);
                }


            }
            catch
            {

            }
        }

        private void gbradio_Enter(object sender, EventArgs e)
        {

        }

        private void rbmanual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbmanual.Checked == true)
            {
                gbnuevatarea.Enabled = true;
                gbfilt.Enabled = false;
            }

           
        }

        private void rbCopiar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCopiar.Checked == true)
            {
                gbnuevatarea.Enabled = false;
                gbfilt.Enabled = true;
            }
        }

        private void cmbnuevafab_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarNueva();
        }
    }
}
