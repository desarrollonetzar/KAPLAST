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
    public partial class FrmUsuario : Form
    {
        private string UsuarioAnterior;
        public FrmUsuario()
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
        private void Formato()
        {
            DgvUsuario.Columns[0].Visible = false;
            DgvUsuario.Columns[1].Visible = false;
            DgvUsuario.Columns[2].Visible = false;
        }

        private void Limpiar()
        {
            txtusuario.Clear();
            txtpass.Clear();
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
            BtnEliminar.Visible = false;
            chkselec.Checked = false;
        }
        private void Listar()
        {
            DgvUsuario.DataSource = NUsuario.Listar();
        }

        private void Buscar()
        {
            DgvUsuario.DataSource = NUsuario.Buscar(TxtBuscar.Text);
        }

        private void CargaRol()
        {
            try
            {
                cmbrol.DataSource = NRol.Listar();
                cmbrol.DisplayMember = "rol_descrip";
                cmbrol.ValueMember = "idrol";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Listar();
            CargaRol();
            Formato();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (cmbrol.Text == string.Empty || txtusuario.Text == string.Empty || txtpass.Text == string.Empty)
                {
                    this.MensajeError("Ingrese los datos faltantes");
                    errorIcono.SetError(cmbrol, "Seleccione un rol");
                    errorIcono.SetError(txtusuario, "Ingrese un nombre");
                    errorIcono.SetError(txtpass, "Ingrese una contraseña");
                }
                else
                {
                    rpta = NUsuario.Insertar(Convert.ToInt32(cmbrol.SelectedValue), txtusuario.Text.Trim(), txtpass.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se ha creado el usuario correctamente");
                        this.Limpiar();
                        this.Listar();
                        TabGral.SelectedIndex = 0;

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

        private void DgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                btnEditar.Visible = true;
                button1.Enabled = false;
                txtid.Text = Convert.ToString(DgvUsuario.CurrentRow.Cells["ID"].Value);
                cmbrol.SelectedValue = Convert.ToString(DgvUsuario.CurrentRow.Cells["ROL_ID"].Value);
                this.UsuarioAnterior= DgvUsuario.CurrentRow.Cells["Usuario"].Value.ToString();
                txtusuario.Text = DgvUsuario.CurrentRow.Cells["Usuario"].Value.ToString() ;
                
                TabGral.SelectedIndex = 1;


            }catch(Exception ex)
            {
                MessageBox.Show("Seleccione desde la celda nombre." + "|Error: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtid.Text==string.Empty || cmbrol.Text == string.Empty || txtusuario.Text == string.Empty )
                {
                    this.MensajeError("Ingrese los datos faltantes");
                    errorIcono.SetError(cmbrol, "Seleccione un rol");
                    errorIcono.SetError(txtusuario, "Ingrese un nombre");
                    errorIcono.SetError(txtpass, "Ingrese una contraseña");
                }
                else
                {
                    rpta = NUsuario.Actualizar(Convert.ToInt32(txtid.Text), Convert.ToInt32(cmbrol.SelectedValue),this.UsuarioAnterior ,txtusuario.Text.Trim(), txtpass.Text);
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó correctamente");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                        button1.Enabled = true;
                        TabGral.SelectedIndex = 0;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGral.SelectedIndex = 0;
        }

        private void DgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DgvUsuario.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell ChkEliminar = (DataGridViewCheckBoxCell)DgvUsuario.Rows[e.RowIndex].Cells["seleccionar"];
                ChkEliminar.Value = !Convert.ToBoolean(ChkEliminar.Value);
            }
        }

        private void chkselec_CheckedChanged(object sender, EventArgs e)
        {
            if (chkselec.Checked)
            {
                DgvUsuario.Columns[0].Visible = true;
                btnActivar.Visible = true;
                btnDesactivar.Visible = true;
                BtnEliminar.Visible = true;

            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente quiere Eliminar el/los usuarios?", "Admin de usuarios", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (opcion == DialogResult.OK)
                {
                    int Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in DgvUsuario.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            rpta = NUsuario.Eliminar(Codigo);

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se eliminó el usuario: " + Convert.ToString(row.Cells[3].Value));
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente quiere Desactivar el/los usuarios?", "Admin de usuarios", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (opcion == DialogResult.OK)
                {
                    int Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in DgvUsuario.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            rpta = NUsuario.Desactivar(Codigo);

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se desactivó el usuario: " + Convert.ToString(row.Cells[3].Value));
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Realmente quiere Activar el/los usuarios?", "Admin de usuarios", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (opcion == DialogResult.OK)
                {
                    int Codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in DgvUsuario.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToInt32(row.Cells[1].Value);
                            rpta = NUsuario.Activar(Codigo);

                            if (rpta.Equals("OK"))
                            {
                                this.MensajeOk("Se Activó el usuario: " + Convert.ToString(row.Cells[3].Value));
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }
                        }
                    }
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}