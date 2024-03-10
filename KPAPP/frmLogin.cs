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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crea el Datatable para almacenar los datos de ingreso
                DataTable dt = new DataTable();
                dt = NUsuario.Login(txtusuario.Text.Trim(), txtcontraseña.Text.Trim());
                // Verifica si el usuario existe
                if (dt.Rows.Count<=0)
                {
                    MessageBox.Show("El usuario o la clave no existe.", "Acceso al sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                else
                {
                    //Verifica si el usuario esta activo 
                    if (Convert.ToBoolean(dt.Rows[0][4])==false)
                    {
                        MessageBox.Show("Este usuario no está activo", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Abre el Form Principal 
                        FrmPrincipal frm = new FrmPrincipal();
                        // Le pasa al Form, los datos del Usuario para que administre permisos etc.
                        frm.idUsuario = Convert.ToInt32( dt.Rows[0][0]);
                        frm.idRol = Convert.ToInt32(dt.Rows[0][1]);
                        frm.rol = Convert.ToString(dt.Rows[0][2]);
                        frm.nombre = Convert.ToString(dt.Rows[0][3]);
                        frm.estado = Convert.ToBoolean(dt.Rows[0][4]);
                        frm.Show();
                        this.Hide();

                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    DataTable dt = new DataTable();
                    dt = NUsuario.Login(txtusuario.Text.Trim(), txtcontraseña.Text.Trim());
                    // Verifica si el usuario existe
                    if (dt.Rows.Count <= 0)
                    {
                        MessageBox.Show("El usuario o la clave no existe.", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        //Verifica si el usuario esta activo 
                        if (Convert.ToBoolean(dt.Rows[0][4]) == false)
                        {
                            MessageBox.Show("Este usuario no está activo", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            FrmPrincipal frm = new FrmPrincipal();
                            frm.idUsuario = Convert.ToInt32(dt.Rows[0][0]);
                            frm.idRol = Convert.ToInt32(dt.Rows[0][1]);
                            frm.rol = Convert.ToString(dt.Rows[0][2]);
                            frm.nombre = Convert.ToString(dt.Rows[0][3]);
                            frm.estado = Convert.ToBoolean(dt.Rows[0][4]);
                            frm.Show();
                            this.Hide();

                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
