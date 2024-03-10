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
    public partial class FrmControl : Form
    {
        public FrmControl()
        {
            InitializeComponent();
        }

       // Metodos para mostrar Mensajes 
        private void MensajeError(string mensaje)

        {
            MessageBox.Show(mensaje, "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Proceso de carga", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //-------------------------------------------------------------------------------------//
        //-------------------------------------------------------------------------------------//

        private void Inicializa_Cantidades()
        {
            if (txtcantfib.Text == string.Empty)
            {
                txtcantfib.Text = "0";
            }
            else
            {

            }

            if (txtcantres.Text == string.Empty)
            {
                txtcantres.Text = "0";
                
            }
        }
        private void FrmControl_Load(object sender, EventArgs e)
        {
            Inicializa_Cantidades();
        }

        // Metodos para Mostrar el Login para insertar el control 1 o 2 
        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dtf = new DataTable();
           
                if (chk1.Checked == true)
            {
                gbauth.Visible = true;
                chk1.Enabled = false;
                chk2.Enabled = false;
            }
        }


        private void chk2_CheckedChanged(object sender, EventArgs e)
        {

            if (chk2.Checked == true)
            {
                gbaut2.Visible = true;
                chk2.Enabled = false;
                chk1.Enabled = false;
            }
        }


        //-------------------------------------------------------------------------------------//
        //-------------------------------------------------------------------------------------//


        // Boton para insertar el Control1 post validacion de usuario y rol 
        private void btnaceptarchk_Click(object sender, EventArgs e)
        {
            try 
            {
                string rpta = "";
                DataTable dt = new DataTable();
                dt = NUsuario.Login(txtusuariochk.Text.Trim(), txtcontraseñachk.Text.Trim());
                // Verifica si el usuario existe
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("El usuario o la clave no existe.", "Validación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (chk1.Checked == true)
                        {
                            rpta = NProceso_Fabricacion.ActualizaControlUno(
                                Convert.ToInt32(txtidfab.Text),
                                Convert.ToInt32(txtidtarea.Text),
                                Convert.ToInt32(dt.Rows[0][0]),
                                dtpcontrol.Value,
                                txtobser.Text,
                                Convert.ToInt32(txtcantres.Text),
                                Convert.ToInt32(txtcantfib.Text)
                                );

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Control NIVEL 1 Cargado");
                                gbauth.Visible = false;
                                chk1.Checked = false;
                                this.Close();

                            }
                            else
                            {
                                this.MensajeError(rpta);
                                this.Close();
                            }
                        }

                    }
                } 
 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //-------------------------------------------------------------------------------------//
        //-------------------------------------------------------------------------------------//

        // Boton para insertar el Control2 post validacion de usuario y rol 
        private void btnAceptarchk2_Click(object sender, EventArgs e)
        {

            try


            {

                string rpta = "";

                TimeSpan treal = dtpCierre.Value.Date.Subtract(dtpcontrol.Value.Date);

                int dias = treal.Days +1;

                DataTable dt = new DataTable();
                dt = NUsuario.Login(txtusuariochk2.Text.Trim(), txtcontraseñachk2.Text.Trim());
                // Verifica si el usuario existe
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("El usuario o la clave no existe.", "Validación de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (chk2.Checked == true)
                        {
                            if (Convert.ToInt32(dt.Rows[0][1]) == 2)
                            {
                                MessageBox.Show("El Usuario " + Convert.ToString(dt.Rows[0][3]) + " no posee permisos de Nivel 2","Control de Tareas",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            }
                            else {

                                rpta = NProceso_Fabricacion.ActualizaControlDos(
                                    Convert.ToInt32(txtidfab.Text),
                                    Convert.ToInt32(txtidtarea.Text),
                                    Convert.ToInt32(dt.Rows[0][0]),
                                    dtpcontrol.Value,
                                    txtobser.Text,
                                    dtpCierre.Value,
                                    dias,
                                      Convert.ToInt32(txtcantres.Text),
                                Convert.ToInt32(txtcantfib.Text)
                                    );

                                if (rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Control NIVEL 2 Cargado");
                                    gbaut2.Visible = false;
                                    chk2.Checked = false;
                                    this.Close();
                                    
                                }
                                else
                                {
                                    this.MensajeError(rpta);
                                    this.Close();

                                }
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarchk2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcantres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcantfib_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
