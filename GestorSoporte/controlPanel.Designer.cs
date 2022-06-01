namespace GestorSoporte
{
    partial class controlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlPanel));
            this.btnMysql = new System.Windows.Forms.Button();
            this.cmMysql = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarMySQLMariaDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPlayRun = new System.Windows.Forms.Button();
            this.btnSsh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCmd = new System.Windows.Forms.Button();
            this.btnHelpSsh = new System.Windows.Forms.Button();
            this.btnWinScp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPhpmyadmin = new System.Windows.Forms.Button();
            this.btnCups = new System.Windows.Forms.Button();
            this.btnWebmin = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPlayStop = new System.Windows.Forms.Button();
            this.btnGestorDTE = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDatosClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEditarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carpetaGDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketDeSoporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eRPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAnalisisFolios = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNotasCliente = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGrabaNota = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdministrador = new System.Windows.Forms.TextBox();
            this.txtCTecnico = new System.Windows.Forms.TextBox();
            this.txtCComercial = new System.Windows.Forms.TextBox();
            this.lbAssm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbAccionSII = new System.Windows.Forms.GroupBox();
            this.lbCert = new System.Windows.Forms.Label();
            this.lbCertFecha = new System.Windows.Forms.Label();
            this.lbUsuarioSII = new System.Windows.Forms.Label();
            this.lbUsu = new System.Windows.Forms.Label();
            this.cbEnlace = new System.Windows.Forms.ComboBox();
            this.btnIr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbErp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDte = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbHosting = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmsComandos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.espacioDisponibleHDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uptimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmMysql.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gbAccionSII.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.cmsComandos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMysql
            // 
            this.btnMysql.ContextMenuStrip = this.cmMysql;
            this.btnMysql.ForeColor = System.Drawing.Color.Black;
            this.btnMysql.Location = new System.Drawing.Point(17, 19);
            this.btnMysql.Name = "btnMysql";
            this.btnMysql.Size = new System.Drawing.Size(99, 23);
            this.btnMysql.TabIndex = 0;
            this.btnMysql.Text = "MariaDB -->";
            this.btnMysql.UseVisualStyleBackColor = true;
            this.btnMysql.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMysql_MouseClick);
            // 
            // cmMysql
            // 
            this.cmMysql.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarIPToolStripMenuItem,
            this.mostrarUsuarioToolStripMenuItem,
            this.reiniciarMySQLMariaDBToolStripMenuItem});
            this.cmMysql.Name = "cmMysql";
            this.cmMysql.Size = new System.Drawing.Size(211, 70);
            // 
            // mostrarIPToolStripMenuItem
            // 
            this.mostrarIPToolStripMenuItem.Name = "mostrarIPToolStripMenuItem";
            this.mostrarIPToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.mostrarIPToolStripMenuItem.Text = "Iniciar MySQL/MariaDB";
            this.mostrarIPToolStripMenuItem.Click += new System.EventHandler(this.iniciarMySQLToolStripMenuItem_Click);
            // 
            // mostrarUsuarioToolStripMenuItem
            // 
            this.mostrarUsuarioToolStripMenuItem.Name = "mostrarUsuarioToolStripMenuItem";
            this.mostrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.mostrarUsuarioToolStripMenuItem.Text = "Detener MySQL/MariaDB";
            this.mostrarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.detenerMySQLToolStripMenuItem_Click);
            // 
            // reiniciarMySQLMariaDBToolStripMenuItem
            // 
            this.reiniciarMySQLMariaDBToolStripMenuItem.Name = "reiniciarMySQLMariaDBToolStripMenuItem";
            this.reiniciarMySQLMariaDBToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.reiniciarMySQLMariaDBToolStripMenuItem.Text = "Reiniciar MySQL/MariaDB";
            this.reiniciarMySQLMariaDBToolStripMenuItem.Click += new System.EventHandler(this.reiniciarMySQLMariaDBToolStripMenuItem_Click);
            // 
            // btnPlayRun
            // 
            this.btnPlayRun.ForeColor = System.Drawing.Color.Black;
            this.btnPlayRun.Location = new System.Drawing.Point(14, 48);
            this.btnPlayRun.Name = "btnPlayRun";
            this.btnPlayRun.Size = new System.Drawing.Size(99, 23);
            this.btnPlayRun.TabIndex = 1;
            this.btnPlayRun.Text = "Iniciar Gestor";
            this.btnPlayRun.UseVisualStyleBackColor = true;
            this.btnPlayRun.Click += new System.EventHandler(this.btnPlayRun_Click);
            // 
            // btnSsh
            // 
            this.btnSsh.ForeColor = System.Drawing.Color.Black;
            this.btnSsh.Location = new System.Drawing.Point(17, 46);
            this.btnSsh.Name = "btnSsh";
            this.btnSsh.Size = new System.Drawing.Size(71, 23);
            this.btnSsh.TabIndex = 2;
            this.btnSsh.Text = "SSH";
            this.btnSsh.UseVisualStyleBackColor = true;
            this.btnSsh.Click += new System.EventHandler(this.btnSsh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCmd);
            this.groupBox1.Controls.Add(this.btnHelpSsh);
            this.groupBox1.Controls.Add(this.btnWinScp);
            this.groupBox1.Controls.Add(this.btnMysql);
            this.groupBox1.Controls.Add(this.btnSsh);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administración Servidor";
            // 
            // btnCmd
            // 
            this.btnCmd.ContextMenuStrip = this.cmsComandos;
            this.btnCmd.ForeColor = System.Drawing.Color.Black;
            this.btnCmd.Location = new System.Drawing.Point(17, 73);
            this.btnCmd.Name = "btnCmd";
            this.btnCmd.Size = new System.Drawing.Size(99, 23);
            this.btnCmd.TabIndex = 8;
            this.btnCmd.Text = "Comandos -->";
            this.btnCmd.UseVisualStyleBackColor = true;
            this.btnCmd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHelpSsh
            // 
            this.btnHelpSsh.Location = new System.Drawing.Point(88, 46);
            this.btnHelpSsh.Name = "btnHelpSsh";
            this.btnHelpSsh.Size = new System.Drawing.Size(28, 23);
            this.btnHelpSsh.TabIndex = 4;
            this.btnHelpSsh.Text = "...";
            this.btnHelpSsh.UseVisualStyleBackColor = true;
            this.btnHelpSsh.Click += new System.EventHandler(this.btnHelpSsh_Click);
            // 
            // btnWinScp
            // 
            this.btnWinScp.ForeColor = System.Drawing.Color.Black;
            this.btnWinScp.Location = new System.Drawing.Point(17, 100);
            this.btnWinScp.Name = "btnWinScp";
            this.btnWinScp.Size = new System.Drawing.Size(99, 23);
            this.btnWinScp.TabIndex = 3;
            this.btnWinScp.Text = "WinSCP";
            this.btnWinScp.UseVisualStyleBackColor = true;
            this.btnWinScp.Click += new System.EventHandler(this.btnWinScp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPhpmyadmin);
            this.groupBox2.Controls.Add(this.btnCups);
            this.groupBox2.Controls.Add(this.btnWebmin);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 112);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Web Tools";
            // 
            // btnPhpmyadmin
            // 
            this.btnPhpmyadmin.ForeColor = System.Drawing.Color.Black;
            this.btnPhpmyadmin.Location = new System.Drawing.Point(14, 77);
            this.btnPhpmyadmin.Name = "btnPhpmyadmin";
            this.btnPhpmyadmin.Size = new System.Drawing.Size(99, 23);
            this.btnPhpmyadmin.TabIndex = 5;
            this.btnPhpmyadmin.Text = "PhpMyAdmin";
            this.btnPhpmyadmin.UseVisualStyleBackColor = true;
            this.btnPhpmyadmin.Click += new System.EventHandler(this.btnPhpmyadmin_Click);
            // 
            // btnCups
            // 
            this.btnCups.ForeColor = System.Drawing.Color.Black;
            this.btnCups.Location = new System.Drawing.Point(14, 48);
            this.btnCups.Name = "btnCups";
            this.btnCups.Size = new System.Drawing.Size(99, 23);
            this.btnCups.TabIndex = 1;
            this.btnCups.Text = "Cups";
            this.btnCups.UseVisualStyleBackColor = true;
            this.btnCups.Click += new System.EventHandler(this.btnCups_Click);
            // 
            // btnWebmin
            // 
            this.btnWebmin.ForeColor = System.Drawing.Color.Black;
            this.btnWebmin.Location = new System.Drawing.Point(14, 19);
            this.btnWebmin.Name = "btnWebmin";
            this.btnWebmin.Size = new System.Drawing.Size(99, 23);
            this.btnWebmin.TabIndex = 0;
            this.btnWebmin.Text = "Webmin";
            this.btnWebmin.UseVisualStyleBackColor = true;
            this.btnWebmin.Click += new System.EventHandler(this.btnWebmin_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPlayStop);
            this.groupBox3.Controls.Add(this.btnGestorDTE);
            this.groupBox3.Controls.Add(this.btnPlayRun);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(12, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 111);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestor DTE";
            // 
            // btnPlayStop
            // 
            this.btnPlayStop.ForeColor = System.Drawing.Color.Black;
            this.btnPlayStop.Location = new System.Drawing.Point(14, 77);
            this.btnPlayStop.Name = "btnPlayStop";
            this.btnPlayStop.Size = new System.Drawing.Size(99, 23);
            this.btnPlayStop.TabIndex = 3;
            this.btnPlayStop.Text = "Detener Gestor";
            this.btnPlayStop.UseVisualStyleBackColor = true;
            this.btnPlayStop.Click += new System.EventHandler(this.btnPlayStop_Click);
            // 
            // btnGestorDTE
            // 
            this.btnGestorDTE.ForeColor = System.Drawing.Color.Black;
            this.btnGestorDTE.Location = new System.Drawing.Point(14, 19);
            this.btnGestorDTE.Name = "btnGestorDTE";
            this.btnGestorDTE.Size = new System.Drawing.Size(99, 23);
            this.btnGestorDTE.TabIndex = 2;
            this.btnGestorDTE.Text = "Abrir Gestor DTE";
            this.btnGestorDTE.UseVisualStyleBackColor = true;
            this.btnGestorDTE.Click += new System.EventHandler(this.btnGestorDTE_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sucursalToolStripMenuItem,
            this.carpetaGDriveToolStripMenuItem,
            this.ticketDeSoporteToolStripMenuItem,
            this.consultasSQLToolStripMenuItem,
            this.tsmAnalisisFolios,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sucursalToolStripMenuItem
            // 
            this.sucursalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarDatosClienteToolStripMenuItem,
            this.verEditarDatosToolStripMenuItem});
            this.sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            this.sucursalToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sucursalToolStripMenuItem.Text = "Cliente";
            // 
            // editarDatosClienteToolStripMenuItem
            // 
            this.editarDatosClienteToolStripMenuItem.Name = "editarDatosClienteToolStripMenuItem";
            this.editarDatosClienteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.editarDatosClienteToolStripMenuItem.Text = "Editar Cliente";
            this.editarDatosClienteToolStripMenuItem.Click += new System.EventHandler(this.editarDatosClienteToolStripMenuItem_Click);
            // 
            // verEditarDatosToolStripMenuItem
            // 
            this.verEditarDatosToolStripMenuItem.Name = "verEditarDatosToolStripMenuItem";
            this.verEditarDatosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.verEditarDatosToolStripMenuItem.Text = "Editar Sucursal Actual";
            this.verEditarDatosToolStripMenuItem.Click += new System.EventHandler(this.verEditarDatosToolStripMenuItem_Click);
            // 
            // carpetaGDriveToolStripMenuItem
            // 
            this.carpetaGDriveToolStripMenuItem.Name = "carpetaGDriveToolStripMenuItem";
            this.carpetaGDriveToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.carpetaGDriveToolStripMenuItem.Text = "Carpeta GDrive";
            this.carpetaGDriveToolStripMenuItem.Click += new System.EventHandler(this.carpetaGDriveToolStripMenuItem_Click);
            // 
            // ticketDeSoporteToolStripMenuItem
            // 
            this.ticketDeSoporteToolStripMenuItem.Name = "ticketDeSoporteToolStripMenuItem";
            this.ticketDeSoporteToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.ticketDeSoporteToolStripMenuItem.Text = "Ticket de Soporte";
            this.ticketDeSoporteToolStripMenuItem.Click += new System.EventHandler(this.ticketDeSoporteToolStripMenuItem_Click);
            // 
            // consultasSQLToolStripMenuItem
            // 
            this.consultasSQLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eRPToolStripMenuItem,
            this.dTEToolStripMenuItem});
            this.consultasSQLToolStripMenuItem.Name = "consultasSQLToolStripMenuItem";
            this.consultasSQLToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.consultasSQLToolStripMenuItem.Text = "Consultas SQL";
            // 
            // eRPToolStripMenuItem
            // 
            this.eRPToolStripMenuItem.Name = "eRPToolStripMenuItem";
            this.eRPToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.eRPToolStripMenuItem.Text = "Consultas al ERP";
            this.eRPToolStripMenuItem.Click += new System.EventHandler(this.eRPToolStripMenuItem_Click);
            // 
            // dTEToolStripMenuItem
            // 
            this.dTEToolStripMenuItem.Name = "dTEToolStripMenuItem";
            this.dTEToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.dTEToolStripMenuItem.Text = "Consultas Gestor DTE";
            this.dTEToolStripMenuItem.Click += new System.EventHandler(this.dTEToolStripMenuItem_Click);
            // 
            // tsmAnalisisFolios
            // 
            this.tsmAnalisisFolios.Name = "tsmAnalisisFolios";
            this.tsmAnalisisFolios.Size = new System.Drawing.Size(93, 20);
            this.tsmAnalisisFolios.Text = "Analisis Folios";
            this.tsmAnalisisFolios.Click += new System.EventHandler(this.tsmAnalisisFolios_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // txtNotasCliente
            // 
            this.txtNotasCliente.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtNotasCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotasCliente.Location = new System.Drawing.Point(0, 49);
            this.txtNotasCliente.Multiline = true;
            this.txtNotasCliente.Name = "txtNotasCliente";
            this.txtNotasCliente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotasCliente.Size = new System.Drawing.Size(640, 199);
            this.txtNotasCliente.TabIndex = 7;
            this.txtNotasCliente.TabStop = false;
            this.txtNotasCliente.Click += new System.EventHandler(this.txtNotasCliente_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGrabaNota);
            this.groupBox4.Controls.Add(this.txtNotasCliente);
            this.groupBox4.ForeColor = System.Drawing.Color.Navy;
            this.groupBox4.Location = new System.Drawing.Point(152, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(646, 258);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Notas Cliente";
            // 
            // btnGrabaNota
            // 
            this.btnGrabaNota.ForeColor = System.Drawing.Color.Black;
            this.btnGrabaNota.Location = new System.Drawing.Point(5, 20);
            this.btnGrabaNota.Name = "btnGrabaNota";
            this.btnGrabaNota.Size = new System.Drawing.Size(75, 23);
            this.btnGrabaNota.TabIndex = 0;
            this.btnGrabaNota.Text = "Grabar Nota";
            this.btnGrabaNota.UseVisualStyleBackColor = true;
            this.btnGrabaNota.Click += new System.EventHandler(this.btnGrabaNota_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtAdministrador);
            this.groupBox5.Controls.Add(this.txtCTecnico);
            this.groupBox5.Controls.Add(this.txtCComercial);
            this.groupBox5.Location = new System.Drawing.Point(12, 457);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(785, 149);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(535, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Administrador del Sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(272, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contacto Técnico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contacto Comercial";
            // 
            // txtAdministrador
            // 
            this.txtAdministrador.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtAdministrador.Location = new System.Drawing.Point(535, 31);
            this.txtAdministrador.Multiline = true;
            this.txtAdministrador.Name = "txtAdministrador";
            this.txtAdministrador.Size = new System.Drawing.Size(244, 108);
            this.txtAdministrador.TabIndex = 2;
            // 
            // txtCTecnico
            // 
            this.txtCTecnico.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCTecnico.Location = new System.Drawing.Point(272, 32);
            this.txtCTecnico.Multiline = true;
            this.txtCTecnico.Name = "txtCTecnico";
            this.txtCTecnico.Size = new System.Drawing.Size(257, 107);
            this.txtCTecnico.TabIndex = 1;
            // 
            // txtCComercial
            // 
            this.txtCComercial.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtCComercial.Location = new System.Drawing.Point(7, 32);
            this.txtCComercial.Multiline = true;
            this.txtCComercial.Name = "txtCComercial";
            this.txtCComercial.Size = new System.Drawing.Size(259, 107);
            this.txtCComercial.TabIndex = 0;
            // 
            // lbAssm
            // 
            this.lbAssm.AutoSize = true;
            this.lbAssm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssm.Location = new System.Drawing.Point(658, 73);
            this.lbAssm.Name = "lbAssm";
            this.lbAssm.Size = new System.Drawing.Size(63, 16);
            this.lbAssm.TabIndex = 9;
            this.lbAssm.Text = "InActivo";
            this.lbAssm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(658, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado ASSM";
            // 
            // gbAccionSII
            // 
            this.gbAccionSII.Controls.Add(this.lbCert);
            this.gbAccionSII.Controls.Add(this.lbCertFecha);
            this.gbAccionSII.Controls.Add(this.lbUsuarioSII);
            this.gbAccionSII.Controls.Add(this.lbUsu);
            this.gbAccionSII.Controls.Add(this.cbEnlace);
            this.gbAccionSII.Controls.Add(this.btnIr);
            this.gbAccionSII.ForeColor = System.Drawing.Color.Navy;
            this.gbAccionSII.Location = new System.Drawing.Point(152, 33);
            this.gbAccionSII.Name = "gbAccionSII";
            this.gbAccionSII.Size = new System.Drawing.Size(492, 82);
            this.gbAccionSII.TabIndex = 11;
            this.gbAccionSII.TabStop = false;
            this.gbAccionSII.Text = "Acciones en el SII";
            // 
            // lbCert
            // 
            this.lbCert.AutoSize = true;
            this.lbCert.ForeColor = System.Drawing.Color.Black;
            this.lbCert.Location = new System.Drawing.Point(391, 58);
            this.lbCert.Name = "lbCert";
            this.lbCert.Size = new System.Drawing.Size(41, 13);
            this.lbCert.TabIndex = 5;
            this.lbCert.Text = "label14";
            // 
            // lbCertFecha
            // 
            this.lbCertFecha.AutoSize = true;
            this.lbCertFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCertFecha.Location = new System.Drawing.Point(267, 58);
            this.lbCertFecha.Name = "lbCertFecha";
            this.lbCertFecha.Size = new System.Drawing.Size(123, 13);
            this.lbCertFecha.TabIndex = 4;
            this.lbCertFecha.Text = "Certificado Válido Hasta:";
            // 
            // lbUsuarioSII
            // 
            this.lbUsuarioSII.AutoSize = true;
            this.lbUsuarioSII.ForeColor = System.Drawing.Color.Black;
            this.lbUsuarioSII.Location = new System.Drawing.Point(102, 58);
            this.lbUsuarioSII.Name = "lbUsuarioSII";
            this.lbUsuarioSII.Size = new System.Drawing.Size(41, 13);
            this.lbUsuarioSII.TabIndex = 3;
            this.lbUsuarioSII.Text = "label12";
            // 
            // lbUsu
            // 
            this.lbUsu.AutoSize = true;
            this.lbUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUsu.Location = new System.Drawing.Point(3, 58);
            this.lbUsu.Name = "lbUsu";
            this.lbUsu.Size = new System.Drawing.Size(99, 13);
            this.lbUsu.TabIndex = 2;
            this.lbUsu.Text = "Usuario Autorizado:";
            // 
            // cbEnlace
            // 
            this.cbEnlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEnlace.FormattingEnabled = true;
            this.cbEnlace.Location = new System.Drawing.Point(6, 23);
            this.cbEnlace.Name = "cbEnlace";
            this.cbEnlace.Size = new System.Drawing.Size(384, 23);
            this.cbEnlace.TabIndex = 1;
            // 
            // btnIr
            // 
            this.btnIr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIr.ForeColor = System.Drawing.Color.Black;
            this.btnIr.Location = new System.Drawing.Point(398, 23);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(75, 23);
            this.btnIr.TabIndex = 0;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(9, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sigue® ERP:";
            // 
            // lbErp
            // 
            this.lbErp.AutoSize = true;
            this.lbErp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErp.ForeColor = System.Drawing.Color.Black;
            this.lbErp.Location = new System.Drawing.Point(85, 20);
            this.lbErp.Name = "lbErp";
            this.lbErp.Size = new System.Drawing.Size(93, 15);
            this.lbErp.TabIndex = 14;
            this.lbErp.Text = "Si (dd-mm-yyyy)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(198, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sigue® DTE:";
            // 
            // lbDte
            // 
            this.lbDte.AutoSize = true;
            this.lbDte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDte.ForeColor = System.Drawing.Color.Black;
            this.lbDte.Location = new System.Drawing.Point(274, 20);
            this.lbDte.Name = "lbDte";
            this.lbDte.Size = new System.Drawing.Size(98, 15);
            this.lbDte.TabIndex = 16;
            this.lbDte.Text = "No (dd-mm-yyyy)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(383, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "WebHosting:";
            // 
            // lbHosting
            // 
            this.lbHosting.AutoSize = true;
            this.lbHosting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHosting.ForeColor = System.Drawing.Color.Black;
            this.lbHosting.Location = new System.Drawing.Point(461, 20);
            this.lbHosting.Name = "lbHosting";
            this.lbHosting.Size = new System.Drawing.Size(93, 15);
            this.lbHosting.TabIndex = 18;
            this.lbHosting.Text = "Si (dd-mm-yyyy)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbErp);
            this.groupBox7.Controls.Add(this.lbHosting);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.lbDte);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.ForeColor = System.Drawing.Color.Navy;
            this.groupBox7.Location = new System.Drawing.Point(12, 405);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(779, 50);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Productos";
            // 
            // cmsComandos
            // 
            this.cmsComandos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.espacioDisponibleHDDToolStripMenuItem,
            this.uptimeToolStripMenuItem});
            this.cmsComandos.Name = "cmsComandos";
            this.cmsComandos.Size = new System.Drawing.Size(201, 70);
            // 
            // espacioDisponibleHDDToolStripMenuItem
            // 
            this.espacioDisponibleHDDToolStripMenuItem.Name = "espacioDisponibleHDDToolStripMenuItem";
            this.espacioDisponibleHDDToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.espacioDisponibleHDDToolStripMenuItem.Text = "Espacio disponible HDD";
            this.espacioDisponibleHDDToolStripMenuItem.Click += new System.EventHandler(this.espacioDisponibleHDDToolStripMenuItem_Click);
            // 
            // uptimeToolStripMenuItem
            // 
            this.uptimeToolStripMenuItem.Name = "uptimeToolStripMenuItem";
            this.uptimeToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.uptimeToolStripMenuItem.Text = "Uptime";
            this.uptimeToolStripMenuItem.Click += new System.EventHandler(this.uptimeToolStripMenuItem_Click);
            // 
            // controlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(804, 612);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.gbAccionSII);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbAssm);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "controlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "controlPanel";
            this.Load += new System.EventHandler(this.controlPanel_Load);
            this.cmMysql.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gbAccionSII.ResumeLayout(false);
            this.gbAccionSII.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.cmsComandos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMysql;
        private System.Windows.Forms.Button btnPlayRun;
        private System.Windows.Forms.Button btnSsh;
        private System.Windows.Forms.ContextMenuStrip cmMysql;
        private System.Windows.Forms.ToolStripMenuItem mostrarIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWinScp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnWebmin;
        private System.Windows.Forms.Button btnPhpmyadmin;
        private System.Windows.Forms.Button btnCups;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGestorDTE;
        private System.Windows.Forms.ToolStripMenuItem reiniciarMySQLMariaDBToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEditarDatosToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNotasCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGrabaNota;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketDeSoporteToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdministrador;
        private System.Windows.Forms.TextBox txtCTecnico;
        private System.Windows.Forms.TextBox txtCComercial;
        private System.Windows.Forms.ToolStripMenuItem consultasSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eRPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dTEToolStripMenuItem;
        private System.Windows.Forms.Button btnPlayStop;
        private System.Windows.Forms.Label lbAssm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbAccionSII;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.ToolStripMenuItem carpetaGDriveToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbEnlace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbErp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbHosting;
        private System.Windows.Forms.Label lbCert;
        private System.Windows.Forms.Label lbCertFecha;
        private System.Windows.Forms.Label lbUsuarioSII;
        private System.Windows.Forms.Label lbUsu;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ToolStripMenuItem editarDatosClienteToolStripMenuItem;
        private System.Windows.Forms.Button btnHelpSsh;
        private System.Windows.Forms.ToolStripMenuItem tsmAnalisisFolios;
        private System.Windows.Forms.Button btnCmd;
        private System.Windows.Forms.ContextMenuStrip cmsComandos;
        private System.Windows.Forms.ToolStripMenuItem espacioDisponibleHDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uptimeToolStripMenuItem;
    }
}