
namespace KPAPP
{
    partial class FrmNuevaFabricacion
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
            this.components = new System.ComponentModel.Container();
            this.DgvListado2 = new System.Windows.Forms.DataGridView();
            this.txtnroorden = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.CmbFabric = new System.Windows.Forms.ComboBox();
            this.CmbUsuario = new System.Windows.Forms.ComboBox();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblnroorden = new System.Windows.Forms.Label();
            this.lblfabricacion = new System.Windows.Forms.Label();
            this.USUARIO = new System.Windows.Forms.Label();
            this.lblobservacion = new System.Windows.Forms.Label();
            this.BtnCreaOrden = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbtarea = new System.Windows.Forms.ComboBox();
            this.btnasociar = new System.Windows.Forms.Button();
            this.txtidnuevafabricacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListado2
            // 
            this.DgvListado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado2.Location = new System.Drawing.Point(12, 266);
            this.DgvListado2.Name = "DgvListado2";
            this.DgvListado2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado2.Size = new System.Drawing.Size(1322, 288);
            this.DgvListado2.TabIndex = 0;
            this.DgvListado2.Visible = false;
            this.DgvListado2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentDoubleClick);
            this.DgvListado2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // txtnroorden
            // 
            this.txtnroorden.Location = new System.Drawing.Point(270, 38);
            this.txtnroorden.Name = "txtnroorden";
            this.txtnroorden.Size = new System.Drawing.Size(100, 20);
            this.txtnroorden.TabIndex = 1;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfecha.Location = new System.Drawing.Point(27, 38);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(200, 20);
            this.dtpfecha.TabIndex = 2;
            // 
            // CmbFabric
            // 
            this.CmbFabric.FormattingEnabled = true;
            this.CmbFabric.Location = new System.Drawing.Point(406, 37);
            this.CmbFabric.Name = "CmbFabric";
            this.CmbFabric.Size = new System.Drawing.Size(319, 21);
            this.CmbFabric.TabIndex = 3;
            this.CmbFabric.SelectedIndexChanged += new System.EventHandler(this.CmbFabric_SelectedIndexChanged);
            // 
            // CmbUsuario
            // 
            this.CmbUsuario.FormattingEnabled = true;
            this.CmbUsuario.Location = new System.Drawing.Point(751, 36);
            this.CmbUsuario.Name = "CmbUsuario";
            this.CmbUsuario.Size = new System.Drawing.Size(121, 21);
            this.CmbUsuario.TabIndex = 4;
            this.CmbUsuario.SelectedIndexChanged += new System.EventHandler(this.CmbUsuario_SelectedIndexChanged);
            // 
            // txtobs
            // 
            this.txtobs.Location = new System.Drawing.Point(27, 117);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(343, 78);
            this.txtobs.TabIndex = 5;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(27, 19);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(42, 13);
            this.lblfecha.TabIndex = 6;
            this.lblfecha.Text = "FECHA";
            // 
            // lblnroorden
            // 
            this.lblnroorden.AutoSize = true;
            this.lblnroorden.Location = new System.Drawing.Point(267, 19);
            this.lblnroorden.Name = "lblnroorden";
            this.lblnroorden.Size = new System.Drawing.Size(91, 13);
            this.lblnroorden.TabIndex = 7;
            this.lblnroorden.Text = "NRO DE ORDEN";
            // 
            // lblfabricacion
            // 
            this.lblfabricacion.AutoSize = true;
            this.lblfabricacion.Location = new System.Drawing.Point(403, 19);
            this.lblfabricacion.Name = "lblfabricacion";
            this.lblfabricacion.Size = new System.Drawing.Size(78, 13);
            this.lblfabricacion.TabIndex = 8;
            this.lblfabricacion.Text = "FABRICACION";
            // 
            // USUARIO
            // 
            this.USUARIO.AutoSize = true;
            this.USUARIO.Location = new System.Drawing.Point(748, 19);
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Size = new System.Drawing.Size(35, 13);
            this.USUARIO.TabIndex = 9;
            this.USUARIO.Text = "label4";
            // 
            // lblobservacion
            // 
            this.lblobservacion.AutoSize = true;
            this.lblobservacion.Location = new System.Drawing.Point(27, 101);
            this.lblobservacion.Name = "lblobservacion";
            this.lblobservacion.Size = new System.Drawing.Size(98, 13);
            this.lblobservacion.TabIndex = 10;
            this.lblobservacion.Text = "OBSERVACIONES";
            // 
            // BtnCreaOrden
            // 
            this.BtnCreaOrden.Location = new System.Drawing.Point(924, 34);
            this.BtnCreaOrden.Name = "BtnCreaOrden";
            this.BtnCreaOrden.Size = new System.Drawing.Size(181, 23);
            this.BtnCreaOrden.TabIndex = 11;
            this.BtnCreaOrden.Text = "CREAR ORDEN";
            this.BtnCreaOrden.UseVisualStyleBackColor = true;
            this.BtnCreaOrden.Click += new System.EventHandler(this.BtnCreaOrden_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmbtarea
            // 
            this.cmbtarea.FormattingEnabled = true;
            this.cmbtarea.Location = new System.Drawing.Point(406, 65);
            this.cmbtarea.Name = "cmbtarea";
            this.cmbtarea.Size = new System.Drawing.Size(121, 21);
            this.cmbtarea.TabIndex = 12;
            // 
            // btnasociar
            // 
            this.btnasociar.Location = new System.Drawing.Point(924, 91);
            this.btnasociar.Name = "btnasociar";
            this.btnasociar.Size = new System.Drawing.Size(181, 23);
            this.btnasociar.TabIndex = 13;
            this.btnasociar.Text = "ASOCIAR TASKS";
            this.btnasociar.UseVisualStyleBackColor = true;
            this.btnasociar.Click += new System.EventHandler(this.btnasociar_Click);
            // 
            // txtidnuevafabricacion
            // 
            this.txtidnuevafabricacion.Location = new System.Drawing.Point(270, 68);
            this.txtidnuevafabricacion.Name = "txtidnuevafabricacion";
            this.txtidnuevafabricacion.Size = new System.Drawing.Size(100, 20);
            this.txtidnuevafabricacion.TabIndex = 14;
            // 
            // FrmNuevaFabricacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 566);
            this.Controls.Add(this.txtidnuevafabricacion);
            this.Controls.Add(this.btnasociar);
            this.Controls.Add(this.cmbtarea);
            this.Controls.Add(this.BtnCreaOrden);
            this.Controls.Add(this.lblobservacion);
            this.Controls.Add(this.USUARIO);
            this.Controls.Add(this.lblfabricacion);
            this.Controls.Add(this.lblnroorden);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.txtobs);
            this.Controls.Add(this.CmbUsuario);
            this.Controls.Add(this.CmbFabric);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtnroorden);
            this.Controls.Add(this.DgvListado2);
            this.Name = "FrmNuevaFabricacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Fabricaciones";
            this.Load += new System.EventHandler(this.FrmNuevaFabricacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListado2;
        private System.Windows.Forms.TextBox txtnroorden;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.ComboBox CmbFabric;
        private System.Windows.Forms.ComboBox CmbUsuario;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblnroorden;
        private System.Windows.Forms.Label lblfabricacion;
        private System.Windows.Forms.Label USUARIO;
        private System.Windows.Forms.Label lblobservacion;
        private System.Windows.Forms.Button BtnCreaOrden;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cmbtarea;
        private System.Windows.Forms.Button btnasociar;
        private System.Windows.Forms.TextBox txtidnuevafabricacion;
    }
}