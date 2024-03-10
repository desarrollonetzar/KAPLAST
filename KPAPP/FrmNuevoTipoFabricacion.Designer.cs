
namespace KPAPP
{
    partial class FrmNuevoTipoFabricacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevoTipoFabricacion));
            this.dgvfabric = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtfabric = new System.Windows.Forms.TextBox();
            this.lblfabric = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfabric)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvfabric
            // 
            this.dgvfabric.AllowUserToAddRows = false;
            this.dgvfabric.AllowUserToDeleteRows = false;
            this.dgvfabric.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvfabric.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvfabric.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfabric.Location = new System.Drawing.Point(12, 109);
            this.dgvfabric.Name = "dgvfabric";
            this.dgvfabric.ReadOnly = true;
            this.dgvfabric.Size = new System.Drawing.Size(453, 274);
            this.dgvfabric.TabIndex = 0;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
            this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnagregar.Location = new System.Drawing.Point(12, 12);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 91);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Nuevo Tipo";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtfabric
            // 
            this.txtfabric.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfabric.Location = new System.Drawing.Point(113, 25);
            this.txtfabric.Name = "txtfabric";
            this.txtfabric.Size = new System.Drawing.Size(352, 20);
            this.txtfabric.TabIndex = 2;
            this.txtfabric.Visible = false;
            // 
            // lblfabric
            // 
            this.lblfabric.AutoSize = true;
            this.lblfabric.Location = new System.Drawing.Point(110, 9);
            this.lblfabric.Name = "lblfabric";
            this.lblfabric.Size = new System.Drawing.Size(203, 13);
            this.lblfabric.TabIndex = 3;
            this.lblfabric.Text = "Ingrese la descripción para el nuevo item:";
            this.lblfabric.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAceptar.Location = new System.Drawing.Point(113, 51);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 52);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Crear Tipo";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(211, 52);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 51);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Visible = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // FrmNuevoTipoFabricacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(493, 406);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblfabric);
            this.Controls.Add(this.txtfabric);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dgvfabric);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNuevoTipoFabricacion";
            this.Text = "Tipos de Fabricacion";
            this.Load += new System.EventHandler(this.FrmNuevoTipoFabricacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfabric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvfabric;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtfabric;
        private System.Windows.Forms.Label lblfabric;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btncancelar;
    }
}