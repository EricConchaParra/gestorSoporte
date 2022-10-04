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
            this.btnSsh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComandoSSH = new System.Windows.Forms.Button();
            this.btnHelpSsh = new System.Windows.Forms.Button();
            this.btnWinScp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDatosClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEditarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasSQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eRPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAnalisisFolios = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGrabaNota = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cbNotificaCliente = new System.Windows.Forms.CheckBox();
            this.cbSlack = new System.Windows.Forms.CheckBox();
            this.cbFinEvento = new System.Windows.Forms.CheckBox();
            this.cbCobrar = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.txtNotaSoporte = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.txtDescripcionEvento = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.btnCronometro = new System.Windows.Forms.Button();
            this.lbAssm = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCert = new System.Windows.Forms.Label();
            this.lbCertFecha = new System.Windows.Forms.Label();
            this.lbUsuarioSII = new System.Windows.Forms.Label();
            this.lbUsu = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbErp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbDte = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRDP = new System.Windows.Forms.Button();
            this.btnUrl = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnAnyTeam = new System.Windows.Forms.Button();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSsh
            // 
            this.btnSsh.ForeColor = System.Drawing.Color.Black;
            this.btnSsh.Location = new System.Drawing.Point(12, 20);
            this.btnSsh.Name = "btnSsh";
            this.btnSsh.Size = new System.Drawing.Size(71, 23);
            this.btnSsh.TabIndex = 0;
            this.btnSsh.Text = "SSH";
            this.btnSsh.UseVisualStyleBackColor = true;
            this.btnSsh.Click += new System.EventHandler(this.btnSsh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnComandoSSH);
            this.groupBox1.Controls.Add(this.btnHelpSsh);
            this.groupBox1.Controls.Add(this.btnWinScp);
            this.groupBox1.Controls.Add(this.btnSsh);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 104);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servidor Linux";
            // 
            // btnComandoSSH
            // 
            this.btnComandoSSH.Enabled = false;
            this.btnComandoSSH.ForeColor = System.Drawing.Color.Black;
            this.btnComandoSSH.Location = new System.Drawing.Point(12, 72);
            this.btnComandoSSH.Name = "btnComandoSSH";
            this.btnComandoSSH.Size = new System.Drawing.Size(111, 23);
            this.btnComandoSSH.TabIndex = 0;
            this.btnComandoSSH.Text = ". . .";
            this.btnComandoSSH.UseVisualStyleBackColor = true;
            this.btnComandoSSH.Click += new System.EventHandler(this.btnComandoSSH_Click);
            // 
            // btnHelpSsh
            // 
            this.btnHelpSsh.Location = new System.Drawing.Point(83, 20);
            this.btnHelpSsh.Name = "btnHelpSsh";
            this.btnHelpSsh.Size = new System.Drawing.Size(40, 23);
            this.btnHelpSsh.TabIndex = 0;
            this.btnHelpSsh.Text = "...";
            this.btnHelpSsh.UseVisualStyleBackColor = true;
            this.btnHelpSsh.Click += new System.EventHandler(this.btnHelpSsh_Click);
            // 
            // btnWinScp
            // 
            this.btnWinScp.ForeColor = System.Drawing.Color.Black;
            this.btnWinScp.Location = new System.Drawing.Point(12, 46);
            this.btnWinScp.Name = "btnWinScp";
            this.btnWinScp.Size = new System.Drawing.Size(111, 23);
            this.btnWinScp.TabIndex = 0;
            this.btnWinScp.Text = "WinSCP";
            this.btnWinScp.UseVisualStyleBackColor = true;
            this.btnWinScp.Click += new System.EventHandler(this.btnWinScp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sucursalToolStripMenuItem,
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
            this.eRPToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.eRPToolStripMenuItem.Text = "Consultas al ERP";
            this.eRPToolStripMenuItem.Click += new System.EventHandler(this.eRPToolStripMenuItem_Click);
            // 
            // dTEToolStripMenuItem
            // 
            this.dTEToolStripMenuItem.Name = "dTEToolStripMenuItem";
            this.dTEToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
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
            // txtNotas
            // 
            this.txtNotas.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotas.Location = new System.Drawing.Point(6, 42);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotas.Size = new System.Drawing.Size(768, 93);
            this.txtNotas.TabIndex = 7;
            this.txtNotas.TabStop = false;
            this.txtNotas.Click += new System.EventHandler(this.txtNotasCliente_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGrabaNota);
            this.groupBox4.Controls.Add(this.txtNotas);
            this.groupBox4.ForeColor = System.Drawing.Color.Navy;
            this.groupBox4.Location = new System.Drawing.Point(12, 413);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(780, 149);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Notas";
            // 
            // btnGrabaNota
            // 
            this.btnGrabaNota.ForeColor = System.Drawing.Color.Black;
            this.btnGrabaNota.Location = new System.Drawing.Point(6, 15);
            this.btnGrabaNota.Name = "btnGrabaNota";
            this.btnGrabaNota.Size = new System.Drawing.Size(77, 23);
            this.btnGrabaNota.TabIndex = 0;
            this.btnGrabaNota.Text = "Grabar nota";
            this.btnGrabaNota.UseVisualStyleBackColor = true;
            this.btnGrabaNota.Click += new System.EventHandler(this.btnGrabaNota_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox10);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.ForeColor = System.Drawing.Color.Navy;
            this.groupBox5.Location = new System.Drawing.Point(152, 110);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(640, 297);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Eventos de soporte";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.cbNotificaCliente);
            this.groupBox10.Controls.Add(this.cbSlack);
            this.groupBox10.Controls.Add(this.cbFinEvento);
            this.groupBox10.Controls.Add(this.cbCobrar);
            this.groupBox10.Controls.Add(this.btnSend);
            this.groupBox10.Location = new System.Drawing.Point(12, 148);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(147, 143);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Acciones";
            // 
            // cbNotificaCliente
            // 
            this.cbNotificaCliente.AutoSize = true;
            this.cbNotificaCliente.ForeColor = System.Drawing.Color.Black;
            this.cbNotificaCliente.Location = new System.Drawing.Point(14, 38);
            this.cbNotificaCliente.Name = "cbNotificaCliente";
            this.cbNotificaCliente.Size = new System.Drawing.Size(111, 17);
            this.cbNotificaCliente.TabIndex = 5;
            this.cbNotificaCliente.Text = "Notificar al Cliente";
            this.cbNotificaCliente.UseVisualStyleBackColor = true;
            // 
            // cbSlack
            // 
            this.cbSlack.AutoSize = true;
            this.cbSlack.Checked = true;
            this.cbSlack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSlack.ForeColor = System.Drawing.Color.Black;
            this.cbSlack.Location = new System.Drawing.Point(14, 57);
            this.cbSlack.Name = "cbSlack";
            this.cbSlack.Size = new System.Drawing.Size(107, 17);
            this.cbSlack.TabIndex = 6;
            this.cbSlack.Text = "Notifica en Slack";
            this.cbSlack.UseVisualStyleBackColor = true;
            this.cbSlack.CheckedChanged += new System.EventHandler(this.cbSlack_CheckedChanged);
            // 
            // cbFinEvento
            // 
            this.cbFinEvento.AutoSize = true;
            this.cbFinEvento.ForeColor = System.Drawing.Color.Black;
            this.cbFinEvento.Location = new System.Drawing.Point(14, 76);
            this.cbFinEvento.Name = "cbFinEvento";
            this.cbFinEvento.Size = new System.Drawing.Size(101, 17);
            this.cbFinEvento.TabIndex = 7;
            this.cbFinEvento.Text = "Finalizar Evento";
            this.cbFinEvento.UseVisualStyleBackColor = true;
            this.cbFinEvento.CheckedChanged += new System.EventHandler(this.cbFinEvento_CheckedChanged);
            // 
            // cbCobrar
            // 
            this.cbCobrar.AutoSize = true;
            this.cbCobrar.ForeColor = System.Drawing.Color.Black;
            this.cbCobrar.Location = new System.Drawing.Point(14, 19);
            this.cbCobrar.Name = "cbCobrar";
            this.cbCobrar.Size = new System.Drawing.Size(69, 17);
            this.cbCobrar.TabIndex = 4;
            this.cbCobrar.Text = "¿Cobrar?";
            this.cbCobrar.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(9, 100);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 29);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Notifica en Slack";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox14);
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.groupBox13);
            this.groupBox8.Controls.Add(this.groupBox11);
            this.groupBox8.Location = new System.Drawing.Point(165, 20);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(462, 271);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Registro Soporte";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.cbOrigen);
            this.groupBox13.Location = new System.Drawing.Point(271, 19);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(185, 46);
            this.groupBox13.TabIndex = 2;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Origen";
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(6, 17);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(173, 21);
            this.cbOrigen.TabIndex = 1;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.txtNotaSoporte);
            this.groupBox11.Location = new System.Drawing.Point(7, 125);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(449, 140);
            this.groupBox11.TabIndex = 4;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Notas";
            // 
            // txtNotaSoporte
            // 
            this.txtNotaSoporte.Location = new System.Drawing.Point(6, 19);
            this.txtNotaSoporte.Multiline = true;
            this.txtNotaSoporte.Name = "txtNotaSoporte";
            this.txtNotaSoporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotaSoporte.Size = new System.Drawing.Size(437, 111);
            this.txtNotaSoporte.TabIndex = 3;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.txtDescripcionEvento);
            this.groupBox9.Location = new System.Drawing.Point(6, 71);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(450, 46);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Descripción del Evento";
            // 
            // txtDescripcionEvento
            // 
            this.txtDescripcionEvento.Location = new System.Drawing.Point(6, 18);
            this.txtDescripcionEvento.Name = "txtDescripcionEvento";
            this.txtDescripcionEvento.Size = new System.Drawing.Size(438, 20);
            this.txtDescripcionEvento.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTiempo);
            this.groupBox6.Controls.Add(this.btnCronometro);
            this.groupBox6.Location = new System.Drawing.Point(12, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(147, 122);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tiempo";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempo.Location = new System.Drawing.Point(12, 22);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(122, 39);
            this.txtTiempo.TabIndex = 1;
            this.txtTiempo.Text = "00:00";
            this.txtTiempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCronometro
            // 
            this.btnCronometro.ForeColor = System.Drawing.Color.Black;
            this.btnCronometro.Location = new System.Drawing.Point(12, 74);
            this.btnCronometro.Name = "btnCronometro";
            this.btnCronometro.Size = new System.Drawing.Size(122, 33);
            this.btnCronometro.TabIndex = 0;
            this.btnCronometro.Text = "Iniciar";
            this.btnCronometro.UseVisualStyleBackColor = true;
            this.btnCronometro.Click += new System.EventHandler(this.btnCronometro_Click);
            // 
            // lbAssm
            // 
            this.lbAssm.AutoSize = true;
            this.lbAssm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssm.Location = new System.Drawing.Point(526, 34);
            this.lbAssm.Name = "lbAssm";
            this.lbAssm.Size = new System.Drawing.Size(62, 16);
            this.lbAssm.TabIndex = 9;
            this.lbAssm.Text = "InActivo";
            this.lbAssm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(526, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estado ASSM";
            // 
            // lbCert
            // 
            this.lbCert.AutoSize = true;
            this.lbCert.ForeColor = System.Drawing.Color.Black;
            this.lbCert.Location = new System.Drawing.Point(377, 36);
            this.lbCert.Name = "lbCert";
            this.lbCert.Size = new System.Drawing.Size(41, 13);
            this.lbCert.TabIndex = 5;
            this.lbCert.Text = "label14";
            // 
            // lbCertFecha
            // 
            this.lbCertFecha.AutoSize = true;
            this.lbCertFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCertFecha.Location = new System.Drawing.Point(377, 20);
            this.lbCertFecha.Name = "lbCertFecha";
            this.lbCertFecha.Size = new System.Drawing.Size(117, 13);
            this.lbCertFecha.TabIndex = 4;
            this.lbCertFecha.Text = "Certificado válido hasta";
            // 
            // lbUsuarioSII
            // 
            this.lbUsuarioSII.AutoSize = true;
            this.lbUsuarioSII.ForeColor = System.Drawing.Color.Black;
            this.lbUsuarioSII.Location = new System.Drawing.Point(243, 36);
            this.lbUsuarioSII.Name = "lbUsuarioSII";
            this.lbUsuarioSII.Size = new System.Drawing.Size(41, 13);
            this.lbUsuarioSII.TabIndex = 3;
            this.lbUsuarioSII.Text = "label12";
            // 
            // lbUsu
            // 
            this.lbUsu.AutoSize = true;
            this.lbUsu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbUsu.Location = new System.Drawing.Point(241, 20);
            this.lbUsu.Name = "lbUsu";
            this.lbUsu.Size = new System.Drawing.Size(95, 13);
            this.lbUsu.TabIndex = 2;
            this.lbUsu.Text = "Usuario autorizado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(9, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sigue® ERP";
            // 
            // lbErp
            // 
            this.lbErp.AutoSize = true;
            this.lbErp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErp.ForeColor = System.Drawing.Color.Black;
            this.lbErp.Location = new System.Drawing.Point(9, 35);
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
            this.label7.Location = new System.Drawing.Point(120, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sigue® DTE";
            // 
            // lbDte
            // 
            this.lbDte.AutoSize = true;
            this.lbDte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDte.ForeColor = System.Drawing.Color.Black;
            this.lbDte.Location = new System.Drawing.Point(120, 35);
            this.lbDte.Name = "lbDte";
            this.lbDte.Size = new System.Drawing.Size(98, 15);
            this.lbDte.TabIndex = 16;
            this.lbDte.Text = "No (dd-mm-yyyy)";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.lbAssm);
            this.groupBox7.Controls.Add(this.lbCert);
            this.groupBox7.Controls.Add(this.lbUsuarioSII);
            this.groupBox7.Controls.Add(this.lbCertFecha);
            this.groupBox7.Controls.Add(this.lbErp);
            this.groupBox7.Controls.Add(this.lbUsu);
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.lbDte);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.ForeColor = System.Drawing.Color.Navy;
            this.groupBox7.Location = new System.Drawing.Point(152, 36);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(640, 68);
            this.groupBox7.TabIndex = 19;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Productos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRDP);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 58);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Servidor Windows";
            // 
            // btnRDP
            // 
            this.btnRDP.ForeColor = System.Drawing.Color.Black;
            this.btnRDP.Location = new System.Drawing.Point(12, 19);
            this.btnRDP.Name = "btnRDP";
            this.btnRDP.Size = new System.Drawing.Size(111, 23);
            this.btnRDP.TabIndex = 0;
            this.btnRDP.Text = "Acceso RDP";
            this.btnRDP.UseVisualStyleBackColor = true;
            this.btnRDP.Click += new System.EventHandler(this.btnRDP_Click);
            // 
            // btnUrl
            // 
            this.btnUrl.Enabled = false;
            this.btnUrl.ForeColor = System.Drawing.Color.Black;
            this.btnUrl.Location = new System.Drawing.Point(12, 19);
            this.btnUrl.Name = "btnUrl";
            this.btnUrl.Size = new System.Drawing.Size(111, 23);
            this.btnUrl.TabIndex = 0;
            this.btnUrl.Text = ". . .";
            this.btnUrl.UseVisualStyleBackColor = true;
            this.btnUrl.Click += new System.EventHandler(this.btnUrl_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUrl);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(12, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 58);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Personalizado";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnAnyTeam);
            this.groupBox12.ForeColor = System.Drawing.Color.Navy;
            this.groupBox12.Location = new System.Drawing.Point(12, 274);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(134, 58);
            this.groupBox12.TabIndex = 7;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Credenciales";
            // 
            // btnAnyTeam
            // 
            this.btnAnyTeam.ForeColor = System.Drawing.Color.Black;
            this.btnAnyTeam.Location = new System.Drawing.Point(12, 19);
            this.btnAnyTeam.Name = "btnAnyTeam";
            this.btnAnyTeam.Size = new System.Drawing.Size(111, 23);
            this.btnAnyTeam.TabIndex = 0;
            this.btnAnyTeam.Text = "Bóveda de Claves";
            this.btnAnyTeam.UseVisualStyleBackColor = true;
            this.btnAnyTeam.Click += new System.EventHandler(this.btnAnyTeam_Click);
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Location = new System.Drawing.Point(6, 18);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.Size = new System.Drawing.Size(241, 20);
            this.txtSolicitante.TabIndex = 0;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.txtSolicitante);
            this.groupBox14.Location = new System.Drawing.Point(6, 19);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(259, 46);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Solicitante";
            // 
            // controlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(804, 574);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "controlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "controlPanel";
            this.Load += new System.EventHandler(this.controlPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSsh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWinScp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEditarDatosToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem consultasSQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eRPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dTEToolStripMenuItem;
        private System.Windows.Forms.Label lbAssm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbErp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbDte;
        private System.Windows.Forms.Label lbCert;
        private System.Windows.Forms.Label lbCertFecha;
        private System.Windows.Forms.Label lbUsuarioSII;
        private System.Windows.Forms.Label lbUsu;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ToolStripMenuItem editarDatosClienteToolStripMenuItem;
        private System.Windows.Forms.Button btnHelpSsh;
        private System.Windows.Forms.ToolStripMenuItem tsmAnalisisFolios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRDP;
        private System.Windows.Forms.Button btnUrl;
        private System.Windows.Forms.Button btnComandoSSH;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGrabaNota;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtNotaSoporte;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Button btnCronometro;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbFinEvento;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox txtDescripcionEvento;
        private System.Windows.Forms.CheckBox cbCobrar;
        private System.Windows.Forms.CheckBox cbSlack;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button btnAnyTeam;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.CheckBox cbNotificaCliente;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.TextBox txtSolicitante;
    }
}