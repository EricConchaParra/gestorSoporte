namespace GestorSoporte
{
    partial class Sucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sucursal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRdp = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cbMysql = new System.Windows.Forms.ComboBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtSucNombre = new System.Windows.Forms.TextBox();
            this.txtSucursalCorrel = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSsh = new System.Windows.Forms.ComboBox();
            this.labelNSuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbSsh = new System.Windows.Forms.GroupBox();
            this.txtPuertoSsh = new System.Windows.Forms.TextBox();
            this.txtRegularPass = new System.Windows.Forms.TextBox();
            this.txtRegularUser = new System.Windows.Forms.TextBox();
            this.txtRootPass = new System.Windows.Forms.TextBox();
            this.txtRootUser = new System.Windows.Forms.TextBox();
            this.cbSshRoot = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbMySql = new System.Windows.Forms.GroupBox();
            this.txtErpDb = new System.Windows.Forms.TextBox();
            this.txtDteDb = new System.Windows.Forms.TextBox();
            this.txtMysqlAccesoPass = new System.Windows.Forms.TextBox();
            this.txtMysqlAccesoUser = new System.Windows.Forms.TextBox();
            this.txtMysqlRootPass = new System.Windows.Forms.TextBox();
            this.txtMysqlRootUser = new System.Windows.Forms.TextBox();
            this.txtPuertoMysql = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbNewRelic = new System.Windows.Forms.CheckBox();
            this.cbSlack = new System.Windows.Forms.CheckBox();
            this.txtSlackChannel = new System.Windows.Forms.TextBox();
            this.gbPersonalizado = new System.Windows.Forms.GroupBox();
            this.txtNombreComando = new System.Windows.Forms.TextBox();
            this.txtComando = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNombreUrl = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.gbUrl = new System.Windows.Forms.GroupBox();
            this.gbRdp = new System.Windows.Forms.GroupBox();
            this.txtRdpUrl = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtRdpPass = new System.Windows.Forms.TextBox();
            this.txtRdpUser = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.labelusu = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbSsh.SuspendLayout();
            this.gbMySql.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbPersonalizado.SuspendLayout();
            this.gbUrl.SuspendLayout();
            this.gbRdp.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.cbRdp);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.cbMysql);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.txtSucNombre);
            this.groupBox1.Controls.Add(this.txtSucursalCorrel);
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbSsh);
            this.groupBox1.Controls.Add(this.labelNSuc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificación";
            // 
            // cbRdp
            // 
            this.cbRdp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRdp.FormattingEnabled = true;
            this.cbRdp.Location = new System.Drawing.Point(124, 175);
            this.cbRdp.Name = "cbRdp";
            this.cbRdp.Size = new System.Drawing.Size(100, 21);
            this.cbRdp.TabIndex = 17;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(124, 158);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(96, 13);
            this.label24.TabIndex = 16;
            this.label24.Text = "Escritorio Remoto?";
            // 
            // cbMysql
            // 
            this.cbMysql.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMysql.FormattingEnabled = true;
            this.cbMysql.Location = new System.Drawing.Point(10, 175);
            this.cbMysql.Name = "cbMysql";
            this.cbMysql.Size = new System.Drawing.Size(100, 21);
            this.cbMysql.TabIndex = 15;
            this.cbMysql.SelectedIndexChanged += new System.EventHandler(this.cbMysql_SelectedIndexChanged);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(10, 125);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 6;
            // 
            // txtSucNombre
            // 
            this.txtSucNombre.Location = new System.Drawing.Point(127, 82);
            this.txtSucNombre.Name = "txtSucNombre";
            this.txtSucNombre.Size = new System.Drawing.Size(173, 20);
            this.txtSucNombre.TabIndex = 5;
            // 
            // txtSucursalCorrel
            // 
            this.txtSucursalCorrel.Location = new System.Drawing.Point(10, 82);
            this.txtSucursalCorrel.Name = "txtSucursalCorrel";
            this.txtSucursalCorrel.Size = new System.Drawing.Size(100, 20);
            this.txtSucursalCorrel.TabIndex = 4;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(10, 35);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(290, 20);
            this.txtEmpresa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fantasía Sucursal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP";
            // 
            // cbSsh
            // 
            this.cbSsh.BackColor = System.Drawing.SystemColors.Control;
            this.cbSsh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSsh.FormattingEnabled = true;
            this.cbSsh.Location = new System.Drawing.Point(124, 126);
            this.cbSsh.Name = "cbSsh";
            this.cbSsh.Size = new System.Drawing.Size(100, 21);
            this.cbSsh.TabIndex = 7;
            this.cbSsh.SelectedIndexChanged += new System.EventHandler(this.cbSsh_SelectedIndexChanged);
            // 
            // labelNSuc
            // 
            this.labelNSuc.AutoSize = true;
            this.labelNSuc.Location = new System.Drawing.Point(10, 66);
            this.labelNSuc.Name = "labelNSuc";
            this.labelNSuc.Size = new System.Drawing.Size(63, 13);
            this.labelNSuc.TabIndex = 1;
            this.labelNSuc.Text = "N° Sucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "SSH ?";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "MySQL?";
            // 
            // gbSsh
            // 
            this.gbSsh.BackColor = System.Drawing.Color.LemonChiffon;
            this.gbSsh.Controls.Add(this.txtPuertoSsh);
            this.gbSsh.Controls.Add(this.txtRegularPass);
            this.gbSsh.Controls.Add(this.txtRegularUser);
            this.gbSsh.Controls.Add(this.txtRootPass);
            this.gbSsh.Controls.Add(this.txtRootUser);
            this.gbSsh.Controls.Add(this.cbSshRoot);
            this.gbSsh.Controls.Add(this.label11);
            this.gbSsh.Controls.Add(this.label10);
            this.gbSsh.Controls.Add(this.label9);
            this.gbSsh.Controls.Add(this.label8);
            this.gbSsh.Controls.Add(this.label7);
            this.gbSsh.Controls.Add(this.label6);
            this.gbSsh.Location = new System.Drawing.Point(13, 245);
            this.gbSsh.Name = "gbSsh";
            this.gbSsh.Size = new System.Drawing.Size(323, 219);
            this.gbSsh.TabIndex = 1;
            this.gbSsh.TabStop = false;
            this.gbSsh.Text = "Acceso SSH";
            // 
            // txtPuertoSsh
            // 
            this.txtPuertoSsh.Location = new System.Drawing.Point(14, 183);
            this.txtPuertoSsh.Name = "txtPuertoSsh";
            this.txtPuertoSsh.Size = new System.Drawing.Size(63, 20);
            this.txtPuertoSsh.TabIndex = 14;
            // 
            // txtRegularPass
            // 
            this.txtRegularPass.Location = new System.Drawing.Point(174, 137);
            this.txtRegularPass.Name = "txtRegularPass";
            this.txtRegularPass.Size = new System.Drawing.Size(135, 20);
            this.txtRegularPass.TabIndex = 13;
            // 
            // txtRegularUser
            // 
            this.txtRegularUser.Location = new System.Drawing.Point(14, 136);
            this.txtRegularUser.Name = "txtRegularUser";
            this.txtRegularUser.Size = new System.Drawing.Size(134, 20);
            this.txtRegularUser.TabIndex = 12;
            // 
            // txtRootPass
            // 
            this.txtRootPass.Location = new System.Drawing.Point(174, 89);
            this.txtRootPass.Name = "txtRootPass";
            this.txtRootPass.Size = new System.Drawing.Size(135, 20);
            this.txtRootPass.TabIndex = 11;
            // 
            // txtRootUser
            // 
            this.txtRootUser.Location = new System.Drawing.Point(14, 89);
            this.txtRootUser.Name = "txtRootUser";
            this.txtRootUser.Size = new System.Drawing.Size(137, 20);
            this.txtRootUser.TabIndex = 10;
            // 
            // cbSshRoot
            // 
            this.cbSshRoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSshRoot.FormattingEnabled = true;
            this.cbSshRoot.Location = new System.Drawing.Point(12, 39);
            this.cbSshRoot.Name = "cbSshRoot";
            this.cbSshRoot.Size = new System.Drawing.Size(135, 21);
            this.cbSshRoot.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Puerto SSH";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(174, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Regular Pass";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Regular User";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Root Pass";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Root User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Root?";
            // 
            // gbMySql
            // 
            this.gbMySql.BackColor = System.Drawing.Color.LightGreen;
            this.gbMySql.Controls.Add(this.txtErpDb);
            this.gbMySql.Controls.Add(this.txtDteDb);
            this.gbMySql.Controls.Add(this.txtMysqlAccesoPass);
            this.gbMySql.Controls.Add(this.txtMysqlAccesoUser);
            this.gbMySql.Controls.Add(this.txtMysqlRootPass);
            this.gbMySql.Controls.Add(this.txtMysqlRootUser);
            this.gbMySql.Controls.Add(this.txtPuertoMysql);
            this.gbMySql.Controls.Add(this.label19);
            this.gbMySql.Controls.Add(this.label18);
            this.gbMySql.Controls.Add(this.label17);
            this.gbMySql.Controls.Add(this.label16);
            this.gbMySql.Controls.Add(this.label15);
            this.gbMySql.Controls.Add(this.label14);
            this.gbMySql.Controls.Add(this.label13);
            this.gbMySql.Location = new System.Drawing.Point(342, 30);
            this.gbMySql.Name = "gbMySql";
            this.gbMySql.Size = new System.Drawing.Size(323, 209);
            this.gbMySql.TabIndex = 2;
            this.gbMySql.TabStop = false;
            this.gbMySql.Text = "Servidor MySQL / MariaDB";
            // 
            // txtErpDb
            // 
            this.txtErpDb.Location = new System.Drawing.Point(171, 175);
            this.txtErpDb.Name = "txtErpDb";
            this.txtErpDb.Size = new System.Drawing.Size(139, 20);
            this.txtErpDb.TabIndex = 23;
            // 
            // txtDteDb
            // 
            this.txtDteDb.Location = new System.Drawing.Point(13, 175);
            this.txtDteDb.Name = "txtDteDb";
            this.txtDteDb.Size = new System.Drawing.Size(137, 20);
            this.txtDteDb.TabIndex = 22;
            // 
            // txtMysqlAccesoPass
            // 
            this.txtMysqlAccesoPass.Location = new System.Drawing.Point(171, 128);
            this.txtMysqlAccesoPass.Name = "txtMysqlAccesoPass";
            this.txtMysqlAccesoPass.Size = new System.Drawing.Size(139, 20);
            this.txtMysqlAccesoPass.TabIndex = 21;
            // 
            // txtMysqlAccesoUser
            // 
            this.txtMysqlAccesoUser.Location = new System.Drawing.Point(13, 129);
            this.txtMysqlAccesoUser.Name = "txtMysqlAccesoUser";
            this.txtMysqlAccesoUser.Size = new System.Drawing.Size(137, 20);
            this.txtMysqlAccesoUser.TabIndex = 20;
            // 
            // txtMysqlRootPass
            // 
            this.txtMysqlRootPass.Location = new System.Drawing.Point(171, 82);
            this.txtMysqlRootPass.Name = "txtMysqlRootPass";
            this.txtMysqlRootPass.Size = new System.Drawing.Size(139, 20);
            this.txtMysqlRootPass.TabIndex = 19;
            // 
            // txtMysqlRootUser
            // 
            this.txtMysqlRootUser.Location = new System.Drawing.Point(13, 82);
            this.txtMysqlRootUser.Name = "txtMysqlRootUser";
            this.txtMysqlRootUser.Size = new System.Drawing.Size(139, 20);
            this.txtMysqlRootUser.TabIndex = 18;
            // 
            // txtPuertoMysql
            // 
            this.txtPuertoMysql.Location = new System.Drawing.Point(11, 35);
            this.txtPuertoMysql.Name = "txtPuertoMysql";
            this.txtPuertoMysql.Size = new System.Drawing.Size(71, 20);
            this.txtPuertoMysql.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(171, 158);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "Base de Datos ERP";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Base de Datos DTE";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(171, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Acceso Pass";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(13, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Acceso User";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(171, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Root Pass";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Root User";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Puerto MySQL";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCrear,
            this.tsmModificar,
            this.tsmSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmCrear
            // 
            this.tsmCrear.Name = "tsmCrear";
            this.tsmCrear.Size = new System.Drawing.Size(47, 20);
            this.tsmCrear.Text = "Crear";
            this.tsmCrear.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // tsmModificar
            // 
            this.tsmModificar.Name = "tsmModificar";
            this.tsmModificar.Size = new System.Drawing.Size(70, 20);
            this.tsmModificar.Text = "Modificar";
            this.tsmModificar.Click += new System.EventHandler(this.tsmModificar_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(41, 20);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.cbNewRelic);
            this.groupBox6.Controls.Add(this.cbSlack);
            this.groupBox6.Controls.Add(this.txtSlackChannel);
            this.groupBox6.Location = new System.Drawing.Point(342, 247);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(323, 84);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Notificaciones";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(133, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "#";
            // 
            // cbNewRelic
            // 
            this.cbNewRelic.AutoSize = true;
            this.cbNewRelic.Location = new System.Drawing.Point(13, 48);
            this.cbNewRelic.Name = "cbNewRelic";
            this.cbNewRelic.Size = new System.Drawing.Size(240, 17);
            this.cbNewRelic.TabIndex = 3;
            this.cbNewRelic.Text = "¿Lanza alertas en NewRelic? (Próximamente)";
            this.cbNewRelic.UseVisualStyleBackColor = true;
            // 
            // cbSlack
            // 
            this.cbSlack.AutoSize = true;
            this.cbSlack.Location = new System.Drawing.Point(13, 24);
            this.cbSlack.Name = "cbSlack";
            this.cbSlack.Size = new System.Drawing.Size(119, 17);
            this.cbSlack.TabIndex = 2;
            this.cbSlack.Text = "¿Notifica en Slack?";
            this.cbSlack.UseVisualStyleBackColor = true;
            this.cbSlack.CheckedChanged += new System.EventHandler(this.cbSlack_CheckedChanged);
            // 
            // txtSlackChannel
            // 
            this.txtSlackChannel.Enabled = false;
            this.txtSlackChannel.Location = new System.Drawing.Point(149, 22);
            this.txtSlackChannel.Name = "txtSlackChannel";
            this.txtSlackChannel.Size = new System.Drawing.Size(161, 20);
            this.txtSlackChannel.TabIndex = 1;
            // 
            // gbPersonalizado
            // 
            this.gbPersonalizado.BackColor = System.Drawing.Color.Thistle;
            this.gbPersonalizado.Controls.Add(this.txtNombreComando);
            this.gbPersonalizado.Controls.Add(this.txtComando);
            this.gbPersonalizado.Controls.Add(this.label2);
            this.gbPersonalizado.Controls.Add(this.label21);
            this.gbPersonalizado.Location = new System.Drawing.Point(12, 532);
            this.gbPersonalizado.Name = "gbPersonalizado";
            this.gbPersonalizado.Size = new System.Drawing.Size(652, 56);
            this.gbPersonalizado.TabIndex = 13;
            this.gbPersonalizado.TabStop = false;
            this.gbPersonalizado.Text = "Comando SSH";
            // 
            // txtNombreComando
            // 
            this.txtNombreComando.Location = new System.Drawing.Point(62, 22);
            this.txtNombreComando.Name = "txtNombreComando";
            this.txtNombreComando.Size = new System.Drawing.Size(140, 20);
            this.txtNombreComando.TabIndex = 2;
            // 
            // txtComando
            // 
            this.txtComando.Location = new System.Drawing.Point(284, 19);
            this.txtComando.Name = "txtComando";
            this.txtComando.Size = new System.Drawing.Size(355, 20);
            this.txtComando.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(226, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Comando";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(226, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "URL";
            // 
            // txtNombreUrl
            // 
            this.txtNombreUrl.Location = new System.Drawing.Point(58, 21);
            this.txtNombreUrl.Name = "txtNombreUrl";
            this.txtNombreUrl.Size = new System.Drawing.Size(144, 20);
            this.txtNombreUrl.TabIndex = 6;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "Nombre";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(284, 19);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(355, 20);
            this.txtUrl.TabIndex = 4;
            // 
            // gbUrl
            // 
            this.gbUrl.BackColor = System.Drawing.Color.LightSlateGray;
            this.gbUrl.Controls.Add(this.txtUrl);
            this.gbUrl.Controls.Add(this.label22);
            this.gbUrl.Controls.Add(this.label23);
            this.gbUrl.Controls.Add(this.txtNombreUrl);
            this.gbUrl.Location = new System.Drawing.Point(12, 470);
            this.gbUrl.Name = "gbUrl";
            this.gbUrl.Size = new System.Drawing.Size(652, 56);
            this.gbUrl.TabIndex = 14;
            this.gbUrl.TabStop = false;
            this.gbUrl.Text = "URL Personalizada";
            // 
            // gbRdp
            // 
            this.gbRdp.BackColor = System.Drawing.Color.Linen;
            this.gbRdp.Controls.Add(this.txtRdpUrl);
            this.gbRdp.Controls.Add(this.label26);
            this.gbRdp.Controls.Add(this.txtRdpPass);
            this.gbRdp.Controls.Add(this.txtRdpUser);
            this.gbRdp.Controls.Add(this.label25);
            this.gbRdp.Controls.Add(this.labelusu);
            this.gbRdp.Location = new System.Drawing.Point(342, 337);
            this.gbRdp.Name = "gbRdp";
            this.gbRdp.Size = new System.Drawing.Size(322, 127);
            this.gbRdp.TabIndex = 15;
            this.gbRdp.TabStop = false;
            this.gbRdp.Text = "Credenciales Escritorio Remoto";
            // 
            // txtRdpUrl
            // 
            this.txtRdpUrl.Location = new System.Drawing.Point(11, 44);
            this.txtRdpUrl.Name = "txtRdpUrl";
            this.txtRdpUrl.Size = new System.Drawing.Size(298, 20);
            this.txtRdpUrl.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 28);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "URL";
            // 
            // txtRdpPass
            // 
            this.txtRdpPass.Location = new System.Drawing.Point(149, 91);
            this.txtRdpPass.Name = "txtRdpPass";
            this.txtRdpPass.Size = new System.Drawing.Size(160, 20);
            this.txtRdpPass.TabIndex = 3;
            // 
            // txtRdpUser
            // 
            this.txtRdpUser.Location = new System.Drawing.Point(11, 91);
            this.txtRdpUser.Name = "txtRdpUser";
            this.txtRdpUser.Size = new System.Drawing.Size(121, 20);
            this.txtRdpUser.TabIndex = 2;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(146, 75);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 13);
            this.label25.TabIndex = 1;
            this.label25.Text = "Contraseña";
            // 
            // labelusu
            // 
            this.labelusu.AutoSize = true;
            this.labelusu.Location = new System.Drawing.Point(8, 75);
            this.labelusu.Name = "labelusu";
            this.labelusu.Size = new System.Drawing.Size(43, 13);
            this.labelusu.TabIndex = 0;
            this.labelusu.Text = "Usuario";
            // 
            // Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 600);
            this.Controls.Add(this.gbRdp);
            this.Controls.Add(this.gbUrl);
            this.Controls.Add(this.gbPersonalizado);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.gbMySql);
            this.Controls.Add(this.gbSsh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Sucursal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursal";
            this.Load += new System.EventHandler(this.Sucursal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSsh.ResumeLayout(false);
            this.gbSsh.PerformLayout();
            this.gbMySql.ResumeLayout(false);
            this.gbMySql.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbPersonalizado.ResumeLayout(false);
            this.gbPersonalizado.PerformLayout();
            this.gbUrl.ResumeLayout(false);
            this.gbUrl.PerformLayout();
            this.gbRdp.ResumeLayout(false);
            this.gbRdp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNSuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSsh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbMySql;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtSucNombre;
        private System.Windows.Forms.TextBox txtSucursalCorrel;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtPuertoSsh;
        private System.Windows.Forms.TextBox txtRegularPass;
        private System.Windows.Forms.TextBox txtRegularUser;
        private System.Windows.Forms.TextBox txtRootPass;
        private System.Windows.Forms.TextBox txtRootUser;
        private System.Windows.Forms.ComboBox cbSshRoot;
        private System.Windows.Forms.ComboBox cbSsh;
        private System.Windows.Forms.ComboBox cbMysql;
        private System.Windows.Forms.TextBox txtErpDb;
        private System.Windows.Forms.TextBox txtDteDb;
        private System.Windows.Forms.TextBox txtMysqlAccesoPass;
        private System.Windows.Forms.TextBox txtMysqlAccesoUser;
        private System.Windows.Forms.TextBox txtMysqlRootPass;
        private System.Windows.Forms.TextBox txtMysqlRootUser;
        private System.Windows.Forms.TextBox txtPuertoMysql;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCrear;
        private System.Windows.Forms.ToolStripMenuItem tsmModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbSlack;
        private System.Windows.Forms.TextBox txtSlackChannel;
        private System.Windows.Forms.CheckBox cbNewRelic;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox gbPersonalizado;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtNombreUrl;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtNombreComando;
        private System.Windows.Forms.TextBox txtComando;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox gbUrl;
        private System.Windows.Forms.ComboBox cbRdp;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox gbRdp;
        private System.Windows.Forms.TextBox txtRdpUrl;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtRdpPass;
        private System.Windows.Forms.TextBox txtRdpUser;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label labelusu;
    }
}