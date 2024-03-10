
namespace KPAPP
{
    partial class FrmNuevaTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaTarea));
            this.dgvtarea = new System.Windows.Forms.DataGridView();
            this.cmbfabric = new System.Windows.Forms.ComboBox();
            this.lblfabric = new System.Windows.Forms.Label();
            this.txtorden = new System.Windows.Forms.TextBox();
            this.lblorden = new System.Windows.Forms.Label();
            this.lbldescrip = new System.Windows.Forms.Label();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.gbnuevatarea = new System.Windows.Forms.GroupBox();
            this.lblobs = new System.Windows.Forms.Label();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.cmbbuscar = new System.Windows.Forms.ComboBox();
            this.lblaviso = new System.Windows.Forms.Label();
            this.gbfilt = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbnuevafab = new System.Windows.Forms.ComboBox();
            this.rbmanual = new System.Windows.Forms.RadioButton();
            this.gbradio = new System.Windows.Forms.GroupBox();
            this.rbCopiar = new System.Windows.Forms.RadioButton();
            this.dgvnueva = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtarea)).BeginInit();
            this.gbnuevatarea.SuspendLayout();
            this.gbfilt.SuspendLayout();
            this.gbradio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnueva)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtarea
            // 
            this.dgvtarea.AllowUserToAddRows = false;
            this.dgvtarea.AllowUserToDeleteRows = false;
            this.dgvtarea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtarea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvtarea.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvtarea.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvtarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtarea.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvtarea.Location = new System.Drawing.Point(12, 184);
            this.dgvtarea.Name = "dgvtarea";
            this.dgvtarea.ReadOnly = true;
            this.dgvtarea.Size = new System.Drawing.Size(650, 319);
            this.dgvtarea.TabIndex = 0;
            this.dgvtarea.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtarea_CellContentDoubleClick);
            // 
            // cmbfabric
            // 
            this.cmbfabric.BackColor = System.Drawing.Color.LightBlue;
            this.cmbfabric.FormattingEnabled = true;
            this.cmbfabric.Location = new System.Drawing.Point(113, 25);
            this.cmbfabric.Name = "cmbfabric";
            this.cmbfabric.Size = new System.Drawing.Size(266, 21);
            this.cmbfabric.TabIndex = 2;
            // 
            // lblfabric
            // 
            this.lblfabric.AutoSize = true;
            this.lblfabric.Location = new System.Drawing.Point(6, 28);
            this.lblfabric.Name = "lblfabric";
            this.lblfabric.Size = new System.Drawing.Size(101, 13);
            this.lblfabric.TabIndex = 3;
            this.lblfabric.Text = "Tipo de fabricación:";
            // 
            // txtorden
            // 
            this.txtorden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtorden.Location = new System.Drawing.Point(467, 25);
            this.txtorden.Name = "txtorden";
            this.txtorden.Size = new System.Drawing.Size(79, 20);
            this.txtorden.TabIndex = 3;
            // 
            // lblorden
            // 
            this.lblorden.AutoSize = true;
            this.lblorden.Location = new System.Drawing.Point(385, 28);
            this.lblorden.Name = "lblorden";
            this.lblorden.Size = new System.Drawing.Size(85, 13);
            this.lblorden.TabIndex = 5;
            this.lblorden.Text = "Orden de Tarea:";
            // 
            // lbldescrip
            // 
            this.lbldescrip.AutoSize = true;
            this.lbldescrip.Location = new System.Drawing.Point(569, 28);
            this.lbldescrip.Name = "lbldescrip";
            this.lbldescrip.Size = new System.Drawing.Size(66, 13);
            this.lbldescrip.TabIndex = 7;
            this.lbldescrip.Text = "Descripción:";
            // 
            // txtdescrip
            // 
            this.txtdescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescrip.Location = new System.Drawing.Point(632, 25);
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(266, 20);
            this.txtdescrip.TabIndex = 4;
            // 
            // gbnuevatarea
            // 
            this.gbnuevatarea.Controls.Add(this.lblobs);
            this.gbnuevatarea.Controls.Add(this.txtobs);
            this.gbnuevatarea.Controls.Add(this.btncancelar);
            this.gbnuevatarea.Controls.Add(this.btnaceptar);
            this.gbnuevatarea.Controls.Add(this.cmbfabric);
            this.gbnuevatarea.Controls.Add(this.lbldescrip);
            this.gbnuevatarea.Controls.Add(this.lblfabric);
            this.gbnuevatarea.Controls.Add(this.txtdescrip);
            this.gbnuevatarea.Controls.Add(this.txtorden);
            this.gbnuevatarea.Controls.Add(this.lblorden);
            this.gbnuevatarea.Location = new System.Drawing.Point(127, 25);
            this.gbnuevatarea.Name = "gbnuevatarea";
            this.gbnuevatarea.Size = new System.Drawing.Size(1206, 98);
            this.gbnuevatarea.TabIndex = 8;
            this.gbnuevatarea.TabStop = false;
            this.gbnuevatarea.Text = "Ingrese los datos para la nueva Tarea";
            // 
            // lblobs
            // 
            this.lblobs.AutoSize = true;
            this.lblobs.Location = new System.Drawing.Point(554, 57);
            this.lblobs.Name = "lblobs";
            this.lblobs.Size = new System.Drawing.Size(81, 13);
            this.lblobs.TabIndex = 11;
            this.lblobs.Text = "Observaciones:";
            // 
            // txtobs
            // 
            this.txtobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtobs.Location = new System.Drawing.Point(632, 53);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(266, 37);
            this.txtobs.TabIndex = 5;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(985, 25);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 62);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnaceptar.Image")));
            this.btnaceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnaceptar.Location = new System.Drawing.Point(904, 25);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 62);
            this.btnaceptar.TabIndex = 6;
            this.btnaceptar.Text = "Crear Tarea";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // cmbbuscar
            // 
            this.cmbbuscar.BackColor = System.Drawing.Color.LightBlue;
            this.cmbbuscar.FormattingEnabled = true;
            this.cmbbuscar.Location = new System.Drawing.Point(384, 22);
            this.cmbbuscar.Name = "cmbbuscar";
            this.cmbbuscar.Size = new System.Drawing.Size(266, 21);
            this.cmbbuscar.TabIndex = 8;
            this.cmbbuscar.SelectedIndexChanged += new System.EventHandler(this.cmbbusca_SelectedIndexChanged);
            // 
            // lblaviso
            // 
            this.lblaviso.AutoSize = true;
            this.lblaviso.Location = new System.Drawing.Point(288, 9);
            this.lblaviso.Name = "lblaviso";
            this.lblaviso.Size = new System.Drawing.Size(159, 13);
            this.lblaviso.TabIndex = 13;
            this.lblaviso.Text = "Ingrese las tareas manualmente ";
            // 
            // gbfilt
            // 
            this.gbfilt.Controls.Add(this.label2);
            this.gbfilt.Controls.Add(this.label1);
            this.gbfilt.Controls.Add(this.cmbnuevafab);
            this.gbfilt.Controls.Add(this.cmbbuscar);
            this.gbfilt.Location = new System.Drawing.Point(12, 129);
            this.gbfilt.Name = "gbfilt";
            this.gbfilt.Size = new System.Drawing.Size(1321, 49);
            this.gbfilt.TabIndex = 15;
            this.gbfilt.TabStop = false;
            this.gbfilt.Text = "Filtre por fabricación existente para replicar sus tareas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(968, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Copiar tareas a:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleccione las tareas que desea copiar:";
            // 
            // cmbnuevafab
            // 
            this.cmbnuevafab.BackColor = System.Drawing.Color.LightGreen;
            this.cmbnuevafab.FormattingEnabled = true;
            this.cmbnuevafab.Location = new System.Drawing.Point(1055, 22);
            this.cmbnuevafab.Name = "cmbnuevafab";
            this.cmbnuevafab.Size = new System.Drawing.Size(266, 21);
            this.cmbnuevafab.TabIndex = 9;
            this.cmbnuevafab.SelectedIndexChanged += new System.EventHandler(this.cmbnuevafab_SelectedIndexChanged);
            // 
            // rbmanual
            // 
            this.rbmanual.AutoSize = true;
            this.rbmanual.Location = new System.Drawing.Point(17, 24);
            this.rbmanual.Name = "rbmanual";
            this.rbmanual.Size = new System.Drawing.Size(60, 17);
            this.rbmanual.TabIndex = 16;
            this.rbmanual.TabStop = true;
            this.rbmanual.Text = "Manual";
            this.rbmanual.UseVisualStyleBackColor = true;
            this.rbmanual.CheckedChanged += new System.EventHandler(this.rbmanual_CheckedChanged);
            // 
            // gbradio
            // 
            this.gbradio.Controls.Add(this.rbCopiar);
            this.gbradio.Controls.Add(this.rbmanual);
            this.gbradio.Location = new System.Drawing.Point(12, 25);
            this.gbradio.Name = "gbradio";
            this.gbradio.Size = new System.Drawing.Size(104, 98);
            this.gbradio.TabIndex = 17;
            this.gbradio.TabStop = false;
            this.gbradio.Text = "Tipo de Ingreso";
            this.gbradio.Enter += new System.EventHandler(this.gbradio_Enter);
            // 
            // rbCopiar
            // 
            this.rbCopiar.AutoSize = true;
            this.rbCopiar.Location = new System.Drawing.Point(17, 55);
            this.rbCopiar.Name = "rbCopiar";
            this.rbCopiar.Size = new System.Drawing.Size(55, 17);
            this.rbCopiar.TabIndex = 17;
            this.rbCopiar.TabStop = true;
            this.rbCopiar.Text = "Copiar";
            this.rbCopiar.UseVisualStyleBackColor = true;
            this.rbCopiar.CheckedChanged += new System.EventHandler(this.rbCopiar_CheckedChanged);
            // 
            // dgvnueva
            // 
            this.dgvnueva.AllowUserToAddRows = false;
            this.dgvnueva.AllowUserToDeleteRows = false;
            this.dgvnueva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvnueva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvnueva.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvnueva.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvnueva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnueva.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvnueva.Location = new System.Drawing.Point(668, 184);
            this.dgvnueva.Name = "dgvnueva";
            this.dgvnueva.ReadOnly = true;
            this.dgvnueva.Size = new System.Drawing.Size(665, 319);
            this.dgvnueva.TabIndex = 18;
            // 
            // FrmNuevaTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1351, 517);
            this.Controls.Add(this.dgvnueva);
            this.Controls.Add(this.gbradio);
            this.Controls.Add(this.gbfilt);
            this.Controls.Add(this.lblaviso);
            this.Controls.Add(this.gbnuevatarea);
            this.Controls.Add(this.dgvtarea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNuevaTarea";
            this.Text = "Nuevas Tareas";
            this.Load += new System.EventHandler(this.FrmNuevaTarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtarea)).EndInit();
            this.gbnuevatarea.ResumeLayout(false);
            this.gbnuevatarea.PerformLayout();
            this.gbfilt.ResumeLayout(false);
            this.gbfilt.PerformLayout();
            this.gbradio.ResumeLayout(false);
            this.gbradio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnueva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtarea;
        private System.Windows.Forms.ComboBox cmbfabric;
        private System.Windows.Forms.Label lblfabric;
        private System.Windows.Forms.TextBox txtorden;
        private System.Windows.Forms.Label lblorden;
        private System.Windows.Forms.Label lbldescrip;
        private System.Windows.Forms.TextBox txtdescrip;
        private System.Windows.Forms.GroupBox gbnuevatarea;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lblobs;
        private System.Windows.Forms.TextBox txtobs;
        private System.Windows.Forms.ComboBox cmbbuscar;
        private System.Windows.Forms.Label lblaviso;
        private System.Windows.Forms.GroupBox gbfilt;
        private System.Windows.Forms.ComboBox cmbnuevafab;
        private System.Windows.Forms.RadioButton rbmanual;
        private System.Windows.Forms.GroupBox gbradio;
        private System.Windows.Forms.RadioButton rbCopiar;
        private System.Windows.Forms.DataGridView dgvnueva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}