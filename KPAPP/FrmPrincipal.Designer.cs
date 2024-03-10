
namespace KPAPP
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuOrdenes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeOrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnualtaprocesos = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNuevoTipoDeFabricaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaNuevasTareasAsociadasAProcesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionDeHerramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccesos = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOrdenes,
            this.mnuReportes,
            this.mnualtaprocesos,
            this.mnuAccesos,
            this.salirToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1215, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuOrdenes
            // 
            this.mnuOrdenes.Name = "mnuOrdenes";
            this.mnuOrdenes.Size = new System.Drawing.Size(119, 20);
            this.mnuOrdenes.Text = "Ordenes de trabajo";
            this.mnuOrdenes.Click += new System.EventHandler(this.ordenesDeTrabajoToolStripMenuItem_Click);
            // 
            // mnuReportes
            // 
            this.mnuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeTareasToolStripMenuItem,
            this.reporteDeOrdenesToolStripMenuItem});
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Size = new System.Drawing.Size(65, 20);
            this.mnuReportes.Text = "Reportes";
            // 
            // listadoDeTareasToolStripMenuItem
            // 
            this.listadoDeTareasToolStripMenuItem.Name = "listadoDeTareasToolStripMenuItem";
            this.listadoDeTareasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.listadoDeTareasToolStripMenuItem.Text = "Listado de Tareas";
            this.listadoDeTareasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTareasToolStripMenuItem_Click);
            // 
            // reporteDeOrdenesToolStripMenuItem
            // 
            this.reporteDeOrdenesToolStripMenuItem.Name = "reporteDeOrdenesToolStripMenuItem";
            this.reporteDeOrdenesToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.reporteDeOrdenesToolStripMenuItem.Text = "Reporte de Ordenes";
            this.reporteDeOrdenesToolStripMenuItem.Click += new System.EventHandler(this.reporteDeOrdenesToolStripMenuItem_Click);
            // 
            // mnualtaprocesos
            // 
            this.mnualtaprocesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaNuevoTipoDeFabricaciónToolStripMenuItem,
            this.altaNuevasTareasAsociadasAProcesoToolStripMenuItem,
            this.administracionDeHerramientasToolStripMenuItem});
            this.mnualtaprocesos.Name = "mnualtaprocesos";
            this.mnualtaprocesos.Size = new System.Drawing.Size(163, 20);
            this.mnualtaprocesos.Text = "Administracion de Ordenes";
            // 
            // altaNuevoTipoDeFabricaciónToolStripMenuItem
            // 
            this.altaNuevoTipoDeFabricaciónToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.altaNuevoTipoDeFabricaciónToolStripMenuItem.Name = "altaNuevoTipoDeFabricaciónToolStripMenuItem";
            this.altaNuevoTipoDeFabricaciónToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.altaNuevoTipoDeFabricaciónToolStripMenuItem.Text = "Alta nuevo Tipo de Fabricación";
            this.altaNuevoTipoDeFabricaciónToolStripMenuItem.Click += new System.EventHandler(this.altaNuevoTipoDeFabricaciónToolStripMenuItem_Click);
            // 
            // altaNuevasTareasAsociadasAProcesoToolStripMenuItem
            // 
            this.altaNuevasTareasAsociadasAProcesoToolStripMenuItem.Name = "altaNuevasTareasAsociadasAProcesoToolStripMenuItem";
            this.altaNuevasTareasAsociadasAProcesoToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.altaNuevasTareasAsociadasAProcesoToolStripMenuItem.Text = "Alta nuevas Tareas asociadas a Proceso";
            this.altaNuevasTareasAsociadasAProcesoToolStripMenuItem.Click += new System.EventHandler(this.altaNuevasTareasAsociadasAProcesoToolStripMenuItem_Click);
            // 
            // administracionDeHerramientasToolStripMenuItem
            // 
            this.administracionDeHerramientasToolStripMenuItem.Name = "administracionDeHerramientasToolStripMenuItem";
            this.administracionDeHerramientasToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.administracionDeHerramientasToolStripMenuItem.Text = "Administracion de Herramientas";
            this.administracionDeHerramientasToolStripMenuItem.Click += new System.EventHandler(this.administracionDeHerramientasToolStripMenuItem_Click);
            // 
            // mnuAccesos
            // 
            this.mnuAccesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.mnuAccesos.Name = "mnuAccesos";
            this.mnuAccesos.Size = new System.Drawing.Size(62, 20);
            this.mnuAccesos.Text = "Accesos";
            this.mnuAccesos.Click += new System.EventHandler(this.mnuAccesos_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.rolesToolStripMenuItem.Text = "&Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.usuariosToolStripMenuItem.Text = "&Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 534);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1215, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(42, 17);
            this.statusBar.Text = "Estado";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1215, 556);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipal";
            this.Text = "Sistema para el control de procesos de fabricación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem mnuOrdenes;
        private System.Windows.Forms.ToolStripMenuItem mnuAccesos;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReportes;
        private System.Windows.Forms.ToolStripMenuItem mnualtaprocesos;
        private System.Windows.Forms.ToolStripMenuItem altaNuevoTipoDeFabricaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaNuevasTareasAsociadasAProcesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionDeHerramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeOrdenesToolStripMenuItem;
    }
}



