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
    public partial class FrmOrdenes : Form
    {
        public FrmOrdenes()
        {
            InitializeComponent();
        }

        public static string rol;
        public static int idusuario;
        public static int idrol;
        public static bool estado;
        public static string usuario;

        
        // Limpia los elementos del Formulario

        private void Limpiar()
        {
            txtnroorden.Clear();
            txtobs.Clear();
            errorIcono.Clear();
        }

        // Metodos para mostrar los mensajes de OK y Errores
        private void MensajeError(string mensaje)

        {
            MessageBox.Show(mensaje, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Proceso de carga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Lista las Fabricaciones
        public void Listar()
        {
            try
            {
                DgvListado.DataSource = NNueva_Fabricacion.Listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en datos: " + ex.Message + ex.StackTrace);
            }
        }

       
        private void ListarFabricacion()
        {

            CmbFabric.ValueMember = "idfabricacion";
            CmbFabric.DisplayMember = "fabricacion_nombre";
            
            CmbFabric.DataSource = NNueva_Fabricacion.Cmb_Fabricacion();
        }

        //Combobox de Usuario
        private void ListarUsuario()
        {
            CmbUsuario.DataSource = NUsuario.Cmb_Usuario();
            CmbUsuario.DisplayMember = "Usuario_Nombre";
            CmbUsuario.ValueMember = "idusuario";
        }

        // Formatea el DGV 
        private void Formato()
        {
            DgvListado.Columns[0].Visible = false;
            DgvListado.Columns[1].Visible = false;
            DgvListado.Columns[2].HeaderText = "NÚMERO DE ORDEN";
            DgvListado.Columns[3].HeaderText = "FECHA DE ORDEN";
            DgvListado.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            DgvListado.Columns[4].HeaderText = "TIPO DE FABRICACIÓN";
            DgvListado.Columns[5].HeaderText = "USUARIO";
            DgvListado.Columns[6].HeaderText = "NOTAS";
            DgvListado.Columns[8].DisplayIndex = 7;
            DgvListado.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";

        }


        //----------------- Busca Ordenes por nombre-------------------------------//
        public void Buscar()
        {
            DgvListado.DataSource = NNueva_Fabricacion.Buscar(TxtBuscar.Text);
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        //------------------------------------------------------------------------//


        // Se inserta aca todo los metodos que queremos ejecutar al abrir el formulario
        private void FrmOrdenes_Load(object sender, EventArgs e)
        {
            Listar();
            Formato();
            ListarFabricacion();
            ListarUsuario();
            // Muestra u oculta elementos de Tab Administracion, segun el rol logueado
            if (idrol == 2)
            {
               
                lblfabricacion.Enabled = false;
                lblfecha.Enabled = false;
                lblnroorden.Enabled = false;
                lblobservacion.Enabled = false;
                txtidgenerado.Enabled = false;
                txtnroorden.Enabled = false;
                txtobs.Enabled = false;
                dtpfecha.Enabled = false;
                CmbFabric.Enabled = false;
                CmbUsuario.Enabled = false;
                BtnCreaOrden.Enabled = false;
            }

           
            btnasociar.Visible = false;
          
        }

     
        // asigna el valor seleccionado en el Combo, a un textbox 
        private void CmbFabric_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TXTIDFAB.Text = CmbFabric.SelectedValue.ToString();
        }

        //------------------------- Crea una nueva orden de trabajo --------------------------------//
        private void BtnCreaOrden_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                
                if (txtnroorden.Text == string.Empty)
                {
                    this.MensajeError("Ingrese los datos requeridos.");
                    errorIcono.SetError(txtnroorden, "Ingrese un número de orden");
                }
                else
                {
                    rpta = NNueva_Fabricacion.Insertar(dtpfecha.Value, txtobs.Text, Convert.ToInt32(CmbUsuario.SelectedValue), txtnroorden.Text, Convert.ToInt32(CmbFabric.SelectedValue));
                  
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("La orden se cargó correctamente");
                        this.Limpiar();
                        this.Listar();
                        btnasociar.Visible = true;
                        BtnCreaOrden.Enabled = false;
                        
                        txtidgenerado.Text = DgvListado.CurrentRow.Cells[1].Value.ToString();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        // Inserta los el proceso asociado a la fabricacion, y asigna valores default de inicio a las tareas 
        private void btnasociar_Click(object sender, EventArgs e)
        {
          

            if (txtidgenerado.Text != "")
            {
                DialogResult resultado = MessageBox.Show("Se asociarán a la orden " + DgvListado.CurrentRow.Cells[2].Value.ToString() + " las tareas correspondientes a: " + DgvListado.CurrentRow.Cells[4].Value.ToString(),
                    "Los cambios no pueden deshacerse", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.OK)
                {
                    NProceso_Fabricacion.Insertar_Proceso(Convert.ToInt32(CmbFabric.SelectedValue), Convert.ToInt32(txtidgenerado.Text.Trim()));

                    NProceso_Fabricacion.Actualizadatosproceso(Convert.ToInt32(CmbUsuario.SelectedValue), dtpfecha.Value, Convert.ToInt32(txtidgenerado.Text));
                    BtnCreaOrden.Enabled = true;
                    btnasociar.Enabled = false;
                    TabGral.SelectedIndex = 0;
               
                }
                else
                {
                    return;
                }

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

      




        // ------------ Pasa los valores de la orden seleccionada en el DGV de Ordenes al Formulario de Proceso y lo abre ------------------ //
        // ------------ El IF verifica si la orden esta cerrada o abierta y setea los bool en los checkbox del formulario de Proceso   -----------------------//
        private void DgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Proceso frm = new Proceso();

            frm.txtidseleccionado.Text = (DgvListado.CurrentRow.Cells["idnuevafabricacion"].Value).ToString();
            frm.dtpfechaorden.Value = Convert.ToDateTime((DgvListado.CurrentRow.Cells["fecha_inicio"].Value));
            frm.txtnrofabricacion.Text = DgvListado.CurrentRow.Cells[2].Value.ToString();
            frm.lbltipo.Text = DgvListado.CurrentRow.Cells[4].Value.ToString();
            frm.txtusrorden.Text = DgvListado.CurrentRow.Cells[5].Value.ToString();
            frm.txtnotas.Text = DgvListado.CurrentRow.Cells[6].Value.ToString();
            if (Convert.ToBoolean(DgvListado.CurrentRow.Cells[7].Value) != true)
            {
                frm.chkcerrada.Checked = false;
            }
            else
            {
                frm.chkcerrada.Checked = true;
                frm.chkcerrada.Enabled = false;
            }


            frm.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}