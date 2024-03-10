
namespace KPAPP.Reportes
{
    partial class FrmRptListarHerramientas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RPT_listar_orden_herramientaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsHerramientas = new KPAPP.Reportes.DsHerramientas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RPT_listar_orden_herramientaTableAdapter = new KPAPP.Reportes.DsHerramientasTableAdapters.RPT_listar_orden_herramientaTableAdapter();
            this.txtidbusqueda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RPT_listar_orden_herramientaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // RPT_listar_orden_herramientaBindingSource
            // 
            this.RPT_listar_orden_herramientaBindingSource.DataMember = "RPT_listar_orden_herramienta";
            this.RPT_listar_orden_herramientaBindingSource.DataSource = this.DsHerramientas;
            // 
            // DsHerramientas
            // 
            this.DsHerramientas.DataSetName = "DsHerramientas";
            this.DsHerramientas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsListar_Tareas";
            reportDataSource1.Value = this.RPT_listar_orden_herramientaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KPAPP.Reportes.rpt_listar_tareas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(928, 651);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // RPT_listar_orden_herramientaTableAdapter
            // 
            this.RPT_listar_orden_herramientaTableAdapter.ClearBeforeFill = true;
            // 
            // txtidbusqueda
            // 
            this.txtidbusqueda.Location = new System.Drawing.Point(706, 0);
            this.txtidbusqueda.Name = "txtidbusqueda";
            this.txtidbusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtidbusqueda.TabIndex = 1;
            this.txtidbusqueda.Visible = false;
            // 
            // FrmRptListarHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 651);
            this.Controls.Add(this.txtidbusqueda);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRptListarHerramientas";
            this.Text = "FrmRptListarHerramientas";
            this.Load += new System.EventHandler(this.FrmRptListarHerramientas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RPT_listar_orden_herramientaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsHerramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RPT_listar_orden_herramientaBindingSource;
        private DsHerramientas DsHerramientas;
        private DsHerramientasTableAdapters.RPT_listar_orden_herramientaTableAdapter RPT_listar_orden_herramientaTableAdapter;
        public System.Windows.Forms.TextBox txtidbusqueda;
    }
}