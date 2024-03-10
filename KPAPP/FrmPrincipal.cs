using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KPAPP
{

   
    public partial class FrmPrincipal : Form
    {
        private int childFormNumber = 0;
       
            public int idUsuario;
            public int idRol;
            public string nombre;
            public string rol;
            public bool estado;
        

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

       

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        
        // -- Carga del FRM Principal -- //


        /* -- PERFILES DE USUARIO -- */
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // Al leer el Frm, Envia los datos del usuario al FRM Proceso para que administre Permisos, etc.
            Proceso.idusuario = idUsuario;
            Proceso.idrol = idRol;
            Proceso.rol = rol;
            Proceso.usuario = nombre.Trim();
            Proceso.estado = estado;
            FrmOrdenes.idrol = idRol;

            FrmControl frm = new FrmControl();

            // Muestra el Usuario Logueado
            statusBar.Text = "Usuario: " + this.nombre;

            // Si el Usuario tiene Rol Admin, se muestran los Menus de acceso y ordenes
            if (this.rol.Equals("ADMIN"))
            {
                mnuAccesos.Enabled = true;
                mnuOrdenes.Enabled = true;

            }
            else
            {
                // Si el usuario tiene Rol SUPERVISOR, se muestra el menú Ordenes
                if (this.rol.Equals("SUPERVISOR"))
                {
                    mnuAccesos.Enabled = false;
                    mnuOrdenes.Enabled = true;
                    mnualtaprocesos.Enabled = false;
                }
                else
                {
                    // Si el usuario tiene Rol USUARIO, muestra el menú Ordenes
                    if (this.rol.Equals("USUARIO"))
                    {
                        mnuAccesos.Enabled = false;
                        mnuOrdenes.Enabled = true;
                        mnualtaprocesos.Enabled = false;
                        mnuReportes.Enabled = false;

                    }
                    else
                    {
                        mnuOrdenes.Enabled = false;
                        mnuAccesos.Enabled = false;

                    }
                }
            }

            /* -- FIN PERFIL DE USUARIO -- */

        }


        private void ordenesDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdenes frm = new FrmOrdenes();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRol frm = new FrmRol();
            frm.MdiParent = this;
            frm.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuAccesos_Click(object sender, EventArgs e)
        {

        }



        
       
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();         
        }

        private void altaNuevoTipoDeFabricaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoTipoFabricacion frm = new FrmNuevoTipoFabricacion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void altaNuevasTareasAsociadasAProcesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaTarea frm = new FrmNuevaTarea();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir del sistema?", "Cerrar Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void listadoDeTareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmrpttareas frm = new Reportes.frmrpttareas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void administracionDeHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHerramientas frm = new FrmHerramientas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void reporteDeOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.frmrptOrdenes frm = new Reportes.frmrptOrdenes();
            frm.Show();
        }
    }
}
