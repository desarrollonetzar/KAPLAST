
namespace KPAPP.Reportes
{
    partial class frmrptOrdenes
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DsOrdenes = new KPAPP.Reportes.DsOrdenes();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbfabric = new System.Windows.Forms.ComboBox();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.DataTable1TableAdapter = new KPAPP.Reportes.DsOrdenesTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DsOrdenes;
            // 
            // DsOrdenes
            // 
            this.DsOrdenes.DataSetName = "DsOrdenes";
            this.DsOrdenes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KPAPP.Reportes.rptOrdenes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 69);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1317, 370);
            this.reportViewer1.TabIndex = 0;
            // 
            // cmbfabric
            // 
            this.cmbfabric.BackColor = System.Drawing.Color.LightBlue;
            this.cmbfabric.FormattingEnabled = true;
            this.cmbfabric.Location = new System.Drawing.Point(13, 35);
            this.cmbfabric.Name = "cmbfabric";
            this.cmbfabric.Size = new System.Drawing.Size(314, 21);
            this.cmbfabric.TabIndex = 1;
            this.cmbfabric.SelectedIndexChanged += new System.EventHandler(this.cmbfabric_SelectedIndexChanged);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.Location = new System.Drawing.Point(354, 35);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnfiltrar.TabIndex = 2;
            this.btnfiltrar.Text = "Filtrar";
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // frmrptOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 491);
            this.Controls.Add(this.btnfiltrar);
            this.Controls.Add(this.cmbfabric);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmrptOrdenes";
            this.Text = "frmrptOrdenes";
            this.Load += new System.EventHandler(this.frmrptOrdenes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DsOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DsOrdenes DsOrdenes;
        private DsOrdenesTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.ComboBox cmbfabric;
        private System.Windows.Forms.Button btnfiltrar;
    }
}