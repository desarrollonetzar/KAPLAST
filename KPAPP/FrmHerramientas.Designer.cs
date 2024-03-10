
namespace KPAPP
{
    partial class FrmHerramientas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHerramientas));
            this.DgvHerramientas = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.Gbherramientas = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.GbBuscar = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbuscar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.GbEditar = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEdTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdDesc = new System.Windows.Forms.TextBox();
            this.btnEdCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHerramientas)).BeginInit();
            this.Gbherramientas.SuspendLayout();
            this.GbBuscar.SuspendLayout();
            this.GbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvHerramientas
            // 
            this.DgvHerramientas.AllowUserToAddRows = false;
            this.DgvHerramientas.AllowUserToDeleteRows = false;
            this.DgvHerramientas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvHerramientas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvHerramientas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgvHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHerramientas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvHerramientas.Location = new System.Drawing.Point(13, 175);
            this.DgvHerramientas.Name = "DgvHerramientas";
            this.DgvHerramientas.ReadOnly = true;
            this.DgvHerramientas.Size = new System.Drawing.Size(880, 437);
            this.DgvHerramientas.TabIndex = 0;
            this.DgvHerramientas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHerramientas_CellContentDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 69;
            // 
            // txtbuscar
            // 
            this.txtbuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtbuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbuscar.Location = new System.Drawing.Point(113, 22);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(168, 20);
            this.txtbuscar.TabIndex = 1;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            this.txtbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscar_KeyUp);
            // 
            // txtdesc
            // 
            this.txtdesc.Location = new System.Drawing.Point(123, 19);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(254, 20);
            this.txtdesc.TabIndex = 2;
            // 
            // Gbherramientas
            // 
            this.Gbherramientas.Controls.Add(this.btnCancelar);
            this.Gbherramientas.Controls.Add(this.btnAgregar);
            this.Gbherramientas.Controls.Add(this.cmbtipo);
            this.Gbherramientas.Controls.Add(this.label1);
            this.Gbherramientas.Controls.Add(this.lbldesc);
            this.Gbherramientas.Controls.Add(this.txtdesc);
            this.Gbherramientas.Location = new System.Drawing.Point(306, 9);
            this.Gbherramientas.Name = "Gbherramientas";
            this.Gbherramientas.Size = new System.Drawing.Size(587, 82);
            this.Gbherramientas.TabIndex = 3;
            this.Gbherramientas.TabStop = false;
            this.Gbherramientas.Text = "Agregar Herramientas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(464, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 60);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregar.Location = new System.Drawing.Point(383, 15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 60);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbtipo
            // 
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Location = new System.Drawing.Point(123, 52);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(254, 21);
            this.cmbtipo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese el tipo:";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Location = new System.Drawing.Point(15, 22);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(102, 13);
            this.lbldesc.TabIndex = 3;
            this.lbldesc.Text = "Ingrese descripción:";
            // 
            // GbBuscar
            // 
            this.GbBuscar.Controls.Add(this.label3);
            this.GbBuscar.Controls.Add(this.cmbbuscar);
            this.GbBuscar.Controls.Add(this.label2);
            this.GbBuscar.Controls.Add(this.txtbuscar);
            this.GbBuscar.Location = new System.Drawing.Point(13, 9);
            this.GbBuscar.Name = "GbBuscar";
            this.GbBuscar.Size = new System.Drawing.Size(287, 82);
            this.GbBuscar.TabIndex = 4;
            this.GbBuscar.TabStop = false;
            this.GbBuscar.Text = "Buscar Herramientas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Busqueda manual:";
            // 
            // cmbbuscar
            // 
            this.cmbbuscar.FormattingEnabled = true;
            this.cmbbuscar.Location = new System.Drawing.Point(113, 55);
            this.cmbbuscar.Name = "cmbbuscar";
            this.cmbbuscar.Size = new System.Drawing.Size(168, 21);
            this.cmbbuscar.TabIndex = 7;
            this.cmbbuscar.SelectedIndexChanged += new System.EventHandler(this.cmbbuscar_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtrar por tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Para editar una tarea, haga doble click sobre ella";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(383, 10);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 60);
            this.btnEditar.TabIndex = 32;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // GbEditar
            // 
            this.GbEditar.Controls.Add(this.btnEdCancelar);
            this.GbEditar.Controls.Add(this.label6);
            this.GbEditar.Controls.Add(this.cmbEdTipo);
            this.GbEditar.Controls.Add(this.label5);
            this.GbEditar.Controls.Add(this.btnEditar);
            this.GbEditar.Controls.Add(this.txtEdDesc);
            this.GbEditar.Location = new System.Drawing.Point(306, 91);
            this.GbEditar.Name = "GbEditar";
            this.GbEditar.Size = new System.Drawing.Size(587, 78);
            this.GbEditar.TabIndex = 34;
            this.GbEditar.TabStop = false;
            this.GbEditar.Text = "Editar Herramienta";
            this.GbEditar.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Editar el tipo:";
            // 
            // cmbEdTipo
            // 
            this.cmbEdTipo.FormattingEnabled = true;
            this.cmbEdTipo.Location = new System.Drawing.Point(123, 43);
            this.cmbEdTipo.Name = "cmbEdTipo";
            this.cmbEdTipo.Size = new System.Drawing.Size(248, 21);
            this.cmbEdTipo.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Editar descripción:";
            // 
            // txtEdDesc
            // 
            this.txtEdDesc.Location = new System.Drawing.Point(123, 19);
            this.txtEdDesc.Name = "txtEdDesc";
            this.txtEdDesc.Size = new System.Drawing.Size(248, 20);
            this.txtEdDesc.TabIndex = 0;
            // 
            // btnEdCancelar
            // 
            this.btnEdCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnEdCancelar.Image")));
            this.btnEdCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEdCancelar.Location = new System.Drawing.Point(464, 10);
            this.btnEdCancelar.Name = "btnEdCancelar";
            this.btnEdCancelar.Size = new System.Drawing.Size(75, 60);
            this.btnEdCancelar.TabIndex = 32;
            this.btnEdCancelar.Text = "CANCELAR";
            this.btnEdCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1019, 627);
            this.Controls.Add(this.GbEditar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GbBuscar);
            this.Controls.Add(this.Gbherramientas);
            this.Controls.Add(this.DgvHerramientas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHerramientas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Herramientas";
            this.Load += new System.EventHandler(this.FrmHerramientas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHerramientas)).EndInit();
            this.Gbherramientas.ResumeLayout(false);
            this.Gbherramientas.PerformLayout();
            this.GbBuscar.ResumeLayout(false);
            this.GbBuscar.PerformLayout();
            this.GbEditar.ResumeLayout(false);
            this.GbEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvHerramientas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.GroupBox Gbherramientas;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.GroupBox GbBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox GbEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEdTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdDesc;
        private System.Windows.Forms.Button btnEdCancelar;
    }
}