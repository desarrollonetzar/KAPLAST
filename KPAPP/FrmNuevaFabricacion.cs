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
    public partial class FrmNuevaFabricacion : Form
    {
        public FrmNuevaFabricacion()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtnroorden.Clear();
            txtobs.Clear();
            errorProvider.Clear();
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
            try
            {
                DgvListado2.DataSource = NNueva_Fabricacion.Listar();

            }catch(Exception ex)
            {
                MessageBox.Show("Error en datos: " + ex.Message + ex.StackTrace);
            }
        }

        private void ListarFabricacion()
        {

            CmbFabric.DataSource = NNueva_Fabricacion.Cmb_Fabricacion();
            CmbFabric.DisplayMember = "fabricacion_nombre";
            CmbFabric.ValueMember = "idfabricacion";
        }

        private void Cmb_Tarea()
        {
            cmbtarea.DataSource = NProceso_Fabricacion.Cmb_tarea();
            cmbtarea.DisplayMember = "tarea_nombre";
            cmbtarea.ValueMember = "Fabricacion_id";
        
        }

        private void ListarUsuario()
        {
            CmbUsuario.DataSource = NUsuario.Cmb_Usuario();
            CmbUsuario.DisplayMember = "Usuario_Nombre";
            CmbUsuario.ValueMember = "idusuario";
        }
        public void Buscar(string valor)
        {
            try
            {
                DgvListado2.DataSource = NNueva_Fabricacion.Buscar(valor);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en datos: " + ex.Message + ex.StackTrace);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmNuevaFabricacion_Load(object sender, EventArgs e)
        {
           
            Listar();
            ListarFabricacion();
            ListarUsuario();
            Cmb_Tarea();
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void CmbFabric_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarFabricacion();
        }

        private void BtnCreaOrden_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                string rpta2 = "";
               
                if (txtnroorden.Text == string.Empty)
                {
                    this.MensajeError("Ingrese los datos requeridos.");
                    errorProvider.SetError(txtnroorden, "Ingrese un número de orden");
                }
                else
                {
                    rpta = NNueva_Fabricacion.Insertar(dtpfecha.Value,txtobs.Text,Convert.ToInt32(CmbUsuario.SelectedValue),txtnroorden.Text,Convert.ToInt32(CmbFabric.SelectedValue));
                   
                    if (rpta.Equals("OK") )
                    {
                        this.MensajeOk("La orden se cargó correctamente");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarUsuario();
        }

        private void DgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

            }catch(Exception )
            {

            }
        }

        private void btnasociar_Click(object sender, EventArgs e)
        {
            DgvListado2.Visible = true;

            //FrmAsociaTask frm = new FrmAsociaTask();
            //frm.Show();
            ////try
            //{
            //    string rpta = "";
               

            //    if (txtnroorden.Text == string.Empty)
            //    {
            //        this.MensajeError("Ingrese los datos requeridos.");
            //        errorProvider.SetError(txtnroorden, "Ingrese un número de orden");
            //    }
            //    else
            //    {
                    
            //        rpta = NProceso_Fabricacion.Actualizadatosproceso(Convert.ToInt32(CmbUsuario.SelectedValue), dtpfecha.Value, Convert.ToInt32(txtnroorden.Text));
            //        if (rpta.Equals("OK"))
            //        {
            //            this.MensajeOk("La orden se cargó correctamente");
            //            this.Limpiar();
            //            this.Listar();
            //        }
            //        else
            //        {
            //            this.MensajeError(rpta);
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}
        }

        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
