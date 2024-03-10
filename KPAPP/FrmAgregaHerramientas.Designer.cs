
namespace KPAPP
{
    partial class FrmAgregaHerramientas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregaHerramientas));
            this.DgvAgHerramientas = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnroorden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgvherragregada = new System.Windows.Forms.DataGridView();
            this.txtherragregada = new System.Windows.Forms.TextBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.lblcant = new System.Windows.Forms.Label();
            this.btnherramientas = new System.Windows.Forms.Button();
            this.gbagrega = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgHerramientas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvherragregada)).BeginInit();
            this.gbagrega.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAgHerramientas
            // 
            this.DgvAgHerramientas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DgvAgHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAgHerramientas.Location = new System.Drawing.Point(12, 92);
            this.DgvAgHerramientas.Name = "DgvAgHerramientas";
            this.DgvAgHerramientas.Size = new System.Drawing.Size(439, 525);
            this.DgvAgHerramientas.TabIndex = 0;
            this.DgvAgHerramientas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAgHerramientas_CellContentDoubleClick);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(12, 31);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(48, 20);
            this.txtid.TabIndex = 1;
            // 
            // txtnroorden
            // 
            this.txtnroorden.Enabled = false;
            this.txtnroorden.Location = new System.Drawing.Point(89, 31);
            this.txtnroorden.Name = "txtnroorden";
            this.txtnroorden.Size = new System.Drawing.Size(159, 20);
            this.txtnroorden.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número de Orden";
            // 
            // Dgvherragregada
            // 
            this.Dgvherragregada.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dgvherragregada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvherragregada.Location = new System.Drawing.Point(501, 92);
            this.Dgvherragregada.Name = "Dgvherragregada";
            this.Dgvherragregada.Size = new System.Drawing.Size(439, 525);
            this.Dgvherragregada.TabIndex = 5;
            // 
            // txtherragregada
            // 
            this.txtherragregada.Enabled = false;
            this.txtherragregada.Location = new System.Drawing.Point(85, 19);
            this.txtherragregada.Name = "txtherragregada";
            this.txtherragregada.Size = new System.Drawing.Size(210, 20);
            this.txtherragregada.TabIndex = 6;
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(228, 57);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(67, 20);
            this.txtcant.TabIndex = 7;
            // 
            // lblcant
            // 
            this.lblcant.AutoSize = true;
            this.lblcant.Location = new System.Drawing.Point(121, 60);
            this.lblcant.Name = "lblcant";
            this.lblcant.Size = new System.Drawing.Size(101, 13);
            this.lblcant.TabIndex = 8;
            this.lblcant.Text = "Ingrese la Cantidad:";
            // 
            // btnherramientas
            // 
            this.btnherramientas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnherramientas.Image = ((System.Drawing.Image)(resources.GetObject("btnherramientas.Image")));
            this.btnherramientas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnherramientas.Location = new System.Drawing.Point(323, 11);
            this.btnherramientas.Name = "btnherramientas";
            this.btnherramientas.Size = new System.Drawing.Size(110, 66);
            this.btnherramientas.TabIndex = 32;
            this.btnherramientas.Text = "AGREGAR HERRAMIENTAS";
            this.btnherramientas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnherramientas.UseVisualStyleBackColor = true;
            this.btnherramientas.Click += new System.EventHandler(this.btnherramientas_Click);
            // 
            // gbagrega
            // 
            this.gbagrega.Controls.Add(this.btnherramientas);
            this.gbagrega.Controls.Add(this.lblcant);
            this.gbagrega.Controls.Add(this.txtherragregada);
            this.gbagrega.Controls.Add(this.txtcant);
            this.gbagrega.Location = new System.Drawing.Point(501, 4);
            this.gbagrega.Name = "gbagrega";
            this.gbagrega.Size = new System.Drawing.Size(439, 82);
            this.gbagrega.TabIndex = 33;
            this.gbagrega.TabStop = false;
            this.gbagrega.Text = "Agregar";
            this.gbagrega.Visible = false;
            // 
            // FrmAgregaHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(986, 629);
            this.Controls.Add(this.gbagrega);
            this.Controls.Add(this.Dgvherragregada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnroorden);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.DgvAgHerramientas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAgregaHerramientas";
            this.Text = "FrmAgregaHerramientas";
            this.Load += new System.EventHandler(this.FrmAgregaHerramientas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgHerramientas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvherragregada)).EndInit();
            this.gbagrega.ResumeLayout(false);
            this.gbagrega.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAgHerramientas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txtnroorden;
        private System.Windows.Forms.DataGridView Dgvherragregada;
        private System.Windows.Forms.TextBox txtherragregada;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Label lblcant;
        private System.Windows.Forms.Button btnherramientas;
        private System.Windows.Forms.GroupBox gbagrega;
    }
}