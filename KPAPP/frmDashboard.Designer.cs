
namespace KPAPP
{
    partial class frmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.chartConsumo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTareas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtnrofabricacion = new System.Windows.Forms.TextBox();
            this.txtConsumo1 = new System.Windows.Forms.TextBox();
            this.txtconsumo2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnotas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtusrorden = new System.Windows.Forms.TextBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpfechaorden = new System.Windows.Forms.DateTimePicker();
            this.lblId = new System.Windows.Forms.Label();
            this.txtnroorden = new System.Windows.Forms.TextBox();
            this.txtidseleccionado = new System.Windows.Forms.TextBox();
            this.chartDias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtfechacierre = new System.Windows.Forms.TextBox();
            this.dtpCierre = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartConsumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTareas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDias)).BeginInit();
            this.SuspendLayout();
            // 
            // chartConsumo
            // 
            this.chartConsumo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chartConsumo.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chartConsumo.BorderSkin.BorderColor = System.Drawing.Color.Gray;
            chartArea1.Name = "ChartArea1";
            this.chartConsumo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartConsumo.Legends.Add(legend1);
            this.chartConsumo.Location = new System.Drawing.Point(43, 205);
            this.chartConsumo.Name = "chartConsumo";
            this.chartConsumo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Consumos";
            this.chartConsumo.Series.Add(series1);
            this.chartConsumo.Size = new System.Drawing.Size(300, 300);
            this.chartConsumo.TabIndex = 0;
            this.chartConsumo.Text = "chart1";
            // 
            // chartTareas
            // 
            this.chartTareas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            chartArea2.Name = "ChartArea1";
            this.chartTareas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTareas.Legends.Add(legend2);
            this.chartTareas.Location = new System.Drawing.Point(384, 205);
            this.chartTareas.Name = "chartTareas";
            this.chartTareas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series2.BackSecondaryColor = System.Drawing.SystemColors.GradientInactiveCaption;
            series2.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Tareas";
            this.chartTareas.Series.Add(series2);
            this.chartTareas.Size = new System.Drawing.Size(300, 300);
            this.chartTareas.TabIndex = 1;
            this.chartTareas.Text = "chart1";
            // 
            // txtnrofabricacion
            // 
            this.txtnrofabricacion.Location = new System.Drawing.Point(43, 399);
            this.txtnrofabricacion.Name = "txtnrofabricacion";
            this.txtnrofabricacion.Size = new System.Drawing.Size(100, 20);
            this.txtnrofabricacion.TabIndex = 2;
            this.txtnrofabricacion.Visible = false;
            // 
            // txtConsumo1
            // 
            this.txtConsumo1.Location = new System.Drawing.Point(384, 511);
            this.txtConsumo1.Name = "txtConsumo1";
            this.txtConsumo1.Size = new System.Drawing.Size(100, 20);
            this.txtConsumo1.TabIndex = 3;
            this.txtConsumo1.Visible = false;
            this.txtConsumo1.TextChanged += new System.EventHandler(this.txtConsumo1_TextChanged);
            // 
            // txtconsumo2
            // 
            this.txtconsumo2.Location = new System.Drawing.Point(584, 511);
            this.txtconsumo2.Name = "txtconsumo2";
            this.txtconsumo2.Size = new System.Drawing.Size(100, 20);
            this.txtconsumo2.TabIndex = 4;
            this.txtconsumo2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnotas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Controls.Add(this.txtusrorden);
            this.groupBox1.Controls.Add(this.lbltipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpfechaorden);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtnroorden);
            this.groupBox1.Controls.Add(this.txtidseleccionado);
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1192, 85);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Orden";
            // 
            // txtnotas
            // 
            this.txtnotas.Location = new System.Drawing.Point(609, 43);
            this.txtnotas.Multiline = true;
            this.txtnotas.Name = "txtnotas";
            this.txtnotas.Size = new System.Drawing.Size(319, 20);
            this.txtnotas.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Notas";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Location = new System.Drawing.Point(412, 27);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 11;
            this.lblusuario.Text = "Usuario";
            // 
            // txtusrorden
            // 
            this.txtusrorden.Location = new System.Drawing.Point(415, 43);
            this.txtusrorden.Name = "txtusrorden";
            this.txtusrorden.Size = new System.Drawing.Size(178, 20);
            this.txtusrorden.TabIndex = 10;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.ForeColor = System.Drawing.Color.Red;
            this.lbltipo.Location = new System.Drawing.Point(90, 7);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(57, 20);
            this.lbltipo.TabIndex = 9;
            this.lbltipo.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número de Orden";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha de Orden";
            // 
            // dtpfechaorden
            // 
            this.dtpfechaorden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaorden.Location = new System.Drawing.Point(94, 43);
            this.dtpfechaorden.Name = "dtpfechaorden";
            this.dtpfechaorden.Size = new System.Drawing.Size(143, 20);
            this.dtpfechaorden.TabIndex = 5;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(5, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id";
            // 
            // txtnroorden
            // 
            this.txtnroorden.Location = new System.Drawing.Point(257, 43);
            this.txtnroorden.Name = "txtnroorden";
            this.txtnroorden.Size = new System.Drawing.Size(143, 20);
            this.txtnroorden.TabIndex = 3;
            // 
            // txtidseleccionado
            // 
            this.txtidseleccionado.Location = new System.Drawing.Point(7, 43);
            this.txtidseleccionado.Name = "txtidseleccionado";
            this.txtidseleccionado.Size = new System.Drawing.Size(56, 20);
            this.txtidseleccionado.TabIndex = 1;
            // 
            // chartDias
            // 
            this.chartDias.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            chartArea3.Name = "ChartArea1";
            this.chartDias.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartDias.Legends.Add(legend3);
            this.chartDias.Location = new System.Drawing.Point(43, 103);
            this.chartDias.Name = "chartDias";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.HorizontalCenter;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Cantidad";
            this.chartDias.Series.Add(series3);
            this.chartDias.Size = new System.Drawing.Size(300, 96);
            this.chartDias.TabIndex = 20;
            this.chartDias.Text = "charttiempo";
            // 
            // txtfechacierre
            // 
            this.txtfechacierre.Location = new System.Drawing.Point(584, 538);
            this.txtfechacierre.Name = "txtfechacierre";
            this.txtfechacierre.Size = new System.Drawing.Size(100, 20);
            this.txtfechacierre.TabIndex = 21;
            // 
            // dtpCierre
            // 
            this.dtpCierre.Location = new System.Drawing.Point(747, 537);
            this.dtpCierre.Name = "dtpCierre";
            this.dtpCierre.Size = new System.Drawing.Size(200, 20);
            this.dtpCierre.TabIndex = 22;
            this.dtpCierre.Visible = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1378, 606);
            this.Controls.Add(this.dtpCierre);
            this.Controls.Add(this.txtfechacierre);
            this.Controls.Add(this.chartDias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtconsumo2);
            this.Controls.Add(this.txtConsumo1);
            this.Controls.Add(this.txtnrofabricacion);
            this.Controls.Add(this.chartTareas);
            this.Controls.Add(this.chartConsumo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.Text = " Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartConsumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTareas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartConsumo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTareas;
        public System.Windows.Forms.TextBox txtnrofabricacion;
        private System.Windows.Forms.TextBox txtConsumo1;
        private System.Windows.Forms.TextBox txtconsumo2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtnotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblusuario;
        public System.Windows.Forms.TextBox txtusrorden;
        public System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dtpfechaorden;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.TextBox txtnroorden;
        public System.Windows.Forms.TextBox txtidseleccionado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDias;
        public System.Windows.Forms.TextBox txtfechacierre;
        public System.Windows.Forms.DateTimePicker dtpCierre;
    }
}