
namespace KPAPP.Reportes
{
    partial class frmrpttareas
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
            this.RPT_TAREASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSTareas = new KPAPP.Reportes.DSTareas();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RPT_TAREASTableAdapter = new KPAPP.Reportes.DSTareasTableAdapters.RPT_TAREASTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CmbFabric = new System.Windows.Forms.ComboBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RPT_TAREASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSTareas)).BeginInit();
            this.SuspendLayout();
            // 
            // RPT_TAREASBindingSource
            // 
            this.RPT_TAREASBindingSource.DataMember = "RPT_TAREAS";
            this.RPT_TAREASBindingSource.DataSource = this.DSTareas;
            // 
            // DSTareas
            // 
            this.DSTareas.DataSetName = "DSTareas";
            this.DSTareas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.RPT_TAREASBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "KPAPP.Reportes.rptTareas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(985, 523);
            this.reportViewer1.TabIndex = 0;
            // 
            // RPT_TAREASTableAdapter
            // 
            this.RPT_TAREASTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CmbFabric
            // 
            this.CmbFabric.FormattingEnabled = true;
            this.CmbFabric.Location = new System.Drawing.Point(12, 12);
            this.CmbFabric.Name = "CmbFabric";
            this.CmbFabric.Size = new System.Drawing.Size(276, 21);
            this.CmbFabric.TabIndex = 2;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(305, 10);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BtnFiltrar.TabIndex = 3;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // frmrpttareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 574);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.CmbFabric);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmrpttareas";
            this.Text = "Reporte de Tareas";
            this.Load += new System.EventHandler(this.frmrpttareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RPT_TAREASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSTareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource RPT_TAREASBindingSource;
        private DSTareas DSTareas;
        private DSTareasTableAdapters.RPT_TAREASTableAdapter RPT_TAREASTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox CmbFabric;
        private System.Windows.Forms.Button BtnFiltrar;
    }
}