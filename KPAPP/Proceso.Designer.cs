
namespace KPAPP
{
    partial class Proceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proceso));
            this.DgvProceso = new System.Windows.Forms.DataGridView();
            this.txtidseleccionado = new System.Windows.Forms.TextBox();
            this.txtnrofabricacion = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dtpfechaorden = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.txtusrorden = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnotas = new System.Windows.Forms.TextBox();
            this.txttask = new System.Windows.Forms.TextBox();
            this.lbltask = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txttaskcomp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtrest = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.chkcerrada = new System.Windows.Forms.CheckBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnherramientas = new System.Windows.Forms.Button();
            this.btnverherramientas = new System.Windows.Forms.Button();
            this.GbCerrar = new System.Windows.Forms.GroupBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpcierre = new System.Windows.Forms.DateTimePicker();
            this.gbautcerrar = new System.Windows.Forms.GroupBox();
            this.btncierraorden = new System.Windows.Forms.Button();
            this.btnCancelarchk2 = new System.Windows.Forms.Button();
            this.txtusuariochkcerrar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcontraseñachkcerrar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnverplano = new System.Windows.Forms.Button();
            this.btncargaplano = new System.Windows.Forms.Button();
            this.lblruta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProceso)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GbCerrar.SuspendLayout();
            this.gbautcerrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvProceso
            // 
            this.DgvProceso.AllowUserToAddRows = false;
            this.DgvProceso.AllowUserToDeleteRows = false;
            this.DgvProceso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProceso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvProceso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.DgvProceso.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DgvProceso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProceso.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvProceso.Location = new System.Drawing.Point(13, 257);
            this.DgvProceso.Name = "DgvProceso";
            this.DgvProceso.ReadOnly = true;
            this.DgvProceso.Size = new System.Drawing.Size(1185, 406);
            this.DgvProceso.TabIndex = 0;
            this.DgvProceso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProceso_CellContentClick);
            this.DgvProceso.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvProceso_CellFormatting);
            this.DgvProceso.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvProceso_EditingControlShowing);
            // 
            // txtidseleccionado
            // 
            this.txtidseleccionado.Location = new System.Drawing.Point(7, 43);
            this.txtidseleccionado.Name = "txtidseleccionado";
            this.txtidseleccionado.Size = new System.Drawing.Size(56, 20);
            this.txtidseleccionado.TabIndex = 1;
            // 
            // txtnrofabricacion
            // 
            this.txtnrofabricacion.Location = new System.Drawing.Point(257, 43);
            this.txtnrofabricacion.Name = "txtnrofabricacion";
            this.txtnrofabricacion.Size = new System.Drawing.Size(143, 20);
            this.txtnrofabricacion.TabIndex = 3;
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
            // dtpfechaorden
            // 
            this.dtpfechaorden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaorden.Location = new System.Drawing.Point(94, 43);
            this.dtpfechaorden.Name = "dtpfechaorden";
            this.dtpfechaorden.Size = new System.Drawing.Size(143, 20);
            this.dtpfechaorden.TabIndex = 5;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número de Orden";
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
            // txtusrorden
            // 
            this.txtusrorden.Location = new System.Drawing.Point(415, 43);
            this.txtusrorden.Name = "txtusrorden";
            this.txtusrorden.Size = new System.Drawing.Size(178, 20);
            this.txtusrorden.TabIndex = 10;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(848, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Notas";
            // 
            // txtnotas
            // 
            this.txtnotas.Location = new System.Drawing.Point(851, 43);
            this.txtnotas.Multiline = true;
            this.txtnotas.Name = "txtnotas";
            this.txtnotas.Size = new System.Drawing.Size(319, 20);
            this.txtnotas.TabIndex = 13;
            // 
            // txttask
            // 
            this.txttask.Location = new System.Drawing.Point(607, 43);
            this.txttask.Name = "txttask";
            this.txttask.Size = new System.Drawing.Size(100, 20);
            this.txttask.TabIndex = 14;
            // 
            // lbltask
            // 
            this.lbltask.AutoSize = true;
            this.lbltask.Location = new System.Drawing.Point(604, 27);
            this.lbltask.Name = "lbltask";
            this.lbltask.Size = new System.Drawing.Size(92, 13);
            this.lbltask.TabIndex = 15;
            this.lbltask.Text = "Cantidad de tasks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(722, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Tasks Completadas";
            // 
            // txttaskcomp
            // 
            this.txttaskcomp.Location = new System.Drawing.Point(725, 43);
            this.txttaskcomp.Name = "txttaskcomp";
            this.txttaskcomp.Size = new System.Drawing.Size(100, 20);
            this.txttaskcomp.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtrest);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttaskcomp);
            this.groupBox1.Controls.Add(this.lbltask);
            this.groupBox1.Controls.Add(this.txttask);
            this.groupBox1.Controls.Add(this.txtnotas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Controls.Add(this.txtusrorden);
            this.groupBox1.Controls.Add(this.lbltipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpfechaorden);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.txtnrofabricacion);
            this.groupBox1.Controls.Add(this.txtidseleccionado);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1192, 85);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Orden";
            // 
            // txtrest
            // 
            this.txtrest.Location = new System.Drawing.Point(607, 65);
            this.txtrest.Name = "txtrest";
            this.txtrest.Size = new System.Drawing.Size(100, 20);
            this.txtrest.TabIndex = 29;
            this.txtrest.Visible = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.Location = new System.Drawing.Point(14, 681);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(112, 25);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar Tarea";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.Location = new System.Drawing.Point(246, 94);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 66);
            this.btnCerrar.TabIndex = 26;
            this.btnCerrar.Text = "CERRAR ORDEN";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // chkcerrada
            // 
            this.chkcerrada.AutoSize = true;
            this.chkcerrada.Location = new System.Drawing.Point(256, 173);
            this.chkcerrada.Name = "chkcerrada";
            this.chkcerrada.Size = new System.Drawing.Size(95, 17);
            this.chkcerrada.TabIndex = 28;
            this.chkcerrada.Text = "Orden Cerrada";
            this.chkcerrada.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditar.Location = new System.Drawing.Point(364, 94);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 65);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "EDITAR ORDEN";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnherramientas
            // 
            this.btnherramientas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnherramientas.Image = ((System.Drawing.Image)(resources.GetObject("btnherramientas.Image")));
            this.btnherramientas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnherramientas.Location = new System.Drawing.Point(130, 94);
            this.btnherramientas.Name = "btnherramientas";
            this.btnherramientas.Size = new System.Drawing.Size(110, 66);
            this.btnherramientas.TabIndex = 31;
            this.btnherramientas.Text = "AGREGAR HERRAMIENTAS";
            this.btnherramientas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnherramientas.UseVisualStyleBackColor = true;
            this.btnherramientas.Click += new System.EventHandler(this.btnherramientas_Click);
            // 
            // btnverherramientas
            // 
            this.btnverherramientas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverherramientas.Image = ((System.Drawing.Image)(resources.GetObject("btnverherramientas.Image")));
            this.btnverherramientas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnverherramientas.Location = new System.Drawing.Point(14, 94);
            this.btnverherramientas.Name = "btnverherramientas";
            this.btnverherramientas.Size = new System.Drawing.Size(110, 66);
            this.btnverherramientas.TabIndex = 32;
            this.btnverherramientas.Text = "VER HERRAMIENTAS";
            this.btnverherramientas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnverherramientas.UseVisualStyleBackColor = true;
            this.btnverherramientas.Click += new System.EventHandler(this.btnverherramientas_Click);
            // 
            // GbCerrar
            // 
            this.GbCerrar.Controls.Add(this.cmbestado);
            this.GbCerrar.Controls.Add(this.label9);
            this.GbCerrar.Controls.Add(this.label6);
            this.GbCerrar.Controls.Add(this.checkBox1);
            this.GbCerrar.Controls.Add(this.label5);
            this.GbCerrar.Controls.Add(this.dtpcierre);
            this.GbCerrar.Location = new System.Drawing.Point(502, 98);
            this.GbCerrar.Name = "GbCerrar";
            this.GbCerrar.Size = new System.Drawing.Size(177, 155);
            this.GbCerrar.TabIndex = 33;
            this.GbCerrar.TabStop = false;
            this.GbCerrar.Text = "Cerrar Orden";
            this.GbCerrar.Visible = false;
            // 
            // cmbestado
            // 
            this.cmbestado.BackColor = System.Drawing.Color.Tomato;
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(30, 75);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(121, 21);
            this.cmbestado.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Estado de la orden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "(Deberá ingresar su usuario)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Red;
            this.checkBox1.Location = new System.Drawing.Point(30, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "CERRAR ORDEN";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha de Cierre";
            // 
            // dtpcierre
            // 
            this.dtpcierre.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpcierre.Location = new System.Drawing.Point(40, 32);
            this.dtpcierre.Name = "dtpcierre";
            this.dtpcierre.Size = new System.Drawing.Size(94, 20);
            this.dtpcierre.TabIndex = 0;
            // 
            // gbautcerrar
            // 
            this.gbautcerrar.Controls.Add(this.btncierraorden);
            this.gbautcerrar.Controls.Add(this.btnCancelarchk2);
            this.gbautcerrar.Controls.Add(this.txtusuariochkcerrar);
            this.gbautcerrar.Controls.Add(this.label7);
            this.gbautcerrar.Controls.Add(this.txtcontraseñachkcerrar);
            this.gbautcerrar.Controls.Add(this.label8);
            this.gbautcerrar.ForeColor = System.Drawing.Color.Red;
            this.gbautcerrar.Location = new System.Drawing.Point(502, 98);
            this.gbautcerrar.Name = "gbautcerrar";
            this.gbautcerrar.Size = new System.Drawing.Size(177, 155);
            this.gbautcerrar.TabIndex = 34;
            this.gbautcerrar.TabStop = false;
            this.gbautcerrar.Text = "Ingrese sus credenciales";
            this.gbautcerrar.Visible = false;
            // 
            // btncierraorden
            // 
            this.btncierraorden.ForeColor = System.Drawing.Color.Black;
            this.btncierraorden.Image = ((System.Drawing.Image)(resources.GetObject("btncierraorden.Image")));
            this.btncierraorden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncierraorden.Location = new System.Drawing.Point(47, 97);
            this.btncierraorden.Name = "btncierraorden";
            this.btncierraorden.Size = new System.Drawing.Size(75, 25);
            this.btncierraorden.TabIndex = 15;
            this.btncierraorden.Text = "Aceptar";
            this.btncierraorden.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncierraorden.UseVisualStyleBackColor = true;
            this.btncierraorden.Click += new System.EventHandler(this.btncierraorden_Click);
            // 
            // btnCancelarchk2
            // 
            this.btnCancelarchk2.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarchk2.Image")));
            this.btnCancelarchk2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarchk2.Location = new System.Drawing.Point(47, 124);
            this.btnCancelarchk2.Name = "btnCancelarchk2";
            this.btnCancelarchk2.Size = new System.Drawing.Size(75, 25);
            this.btnCancelarchk2.TabIndex = 14;
            this.btnCancelarchk2.Text = "Cancelar";
            this.btnCancelarchk2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarchk2.UseVisualStyleBackColor = true;
            this.btnCancelarchk2.Click += new System.EventHandler(this.btnCancelarchk2_Click);
            // 
            // txtusuariochkcerrar
            // 
            this.txtusuariochkcerrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusuariochkcerrar.Location = new System.Drawing.Point(37, 32);
            this.txtusuariochkcerrar.Name = "txtusuariochkcerrar";
            this.txtusuariochkcerrar.Size = new System.Drawing.Size(101, 20);
            this.txtusuariochkcerrar.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(53, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contraseña:";
            // 
            // txtcontraseñachkcerrar
            // 
            this.txtcontraseñachkcerrar.Location = new System.Drawing.Point(15, 72);
            this.txtcontraseñachkcerrar.Name = "txtcontraseñachkcerrar";
            this.txtcontraseñachkcerrar.PasswordChar = '*';
            this.txtcontraseñachkcerrar.Size = new System.Drawing.Size(145, 20);
            this.txtcontraseñachkcerrar.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(62, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Usuario:";
            // 
            // btnDash
            // 
            this.btnDash.Image = ((System.Drawing.Image)(resources.GetObject("btnDash.Image")));
            this.btnDash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDash.Location = new System.Drawing.Point(1088, 95);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(110, 65);
            this.btnDash.TabIndex = 35;
            this.btnDash.Text = "DASHBOARD";
            this.btnDash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnverplano
            // 
            this.btnverplano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverplano.Image = ((System.Drawing.Image)(resources.GetObject("btnverplano.Image")));
            this.btnverplano.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnverplano.Location = new System.Drawing.Point(130, 179);
            this.btnverplano.Name = "btnverplano";
            this.btnverplano.Size = new System.Drawing.Size(110, 66);
            this.btnverplano.TabIndex = 36;
            this.btnverplano.Text = "VER PLANO";
            this.btnverplano.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnverplano.UseVisualStyleBackColor = true;
            this.btnverplano.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncargaplano
            // 
            this.btncargaplano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargaplano.Image = ((System.Drawing.Image)(resources.GetObject("btncargaplano.Image")));
            this.btncargaplano.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncargaplano.Location = new System.Drawing.Point(14, 179);
            this.btncargaplano.Name = "btncargaplano";
            this.btncargaplano.Size = new System.Drawing.Size(110, 66);
            this.btncargaplano.TabIndex = 37;
            this.btncargaplano.Text = "CARGAR PLANO";
            this.btncargaplano.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncargaplano.UseVisualStyleBackColor = true;
            this.btncargaplano.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblruta
            // 
            this.lblruta.AutoSize = true;
            this.lblruta.Location = new System.Drawing.Point(749, 240);
            this.lblruta.Name = "lblruta";
            this.lblruta.Size = new System.Drawing.Size(35, 13);
            this.lblruta.TabIndex = 38;
            this.lblruta.Text = "label9";
            this.lblruta.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Proceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1223, 717);
            this.Controls.Add(this.lblruta);
            this.Controls.Add(this.btncargaplano);
            this.Controls.Add(this.btnverplano);
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.gbautcerrar);
            this.Controls.Add(this.GbCerrar);
            this.Controls.Add(this.btnverherramientas);
            this.Controls.Add(this.btnherramientas);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvProceso);
            this.Controls.Add(this.chkcerrada);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Proceso";
            this.Text = "Proceso";
            this.Load += new System.EventHandler(this.Proceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProceso)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbCerrar.ResumeLayout(false);
            this.GbCerrar.PerformLayout();
            this.gbautcerrar.ResumeLayout(false);
            this.gbautcerrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProceso;
        public System.Windows.Forms.TextBox txtidseleccionado;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.DateTimePicker dtpfechaorden;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtnrofabricacion;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblusuario;
        public System.Windows.Forms.TextBox txtusrorden;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtnotas;
        private System.Windows.Forms.Label lbltask;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txttask;
        public System.Windows.Forms.TextBox txttaskcomp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        public System.Windows.Forms.CheckBox chkcerrada;
        private System.Windows.Forms.TextBox txtrest;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnherramientas;
        private System.Windows.Forms.Button btnverherramientas;
        private System.Windows.Forms.GroupBox GbCerrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpcierre;
        private System.Windows.Forms.GroupBox gbautcerrar;
        private System.Windows.Forms.Button btnCancelarchk2;
        private System.Windows.Forms.TextBox txtusuariochkcerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcontraseñachkcerrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncierraorden;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnverplano;
        private System.Windows.Forms.Button btncargaplano;
        private System.Windows.Forms.Label lblruta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label9;
    }
}