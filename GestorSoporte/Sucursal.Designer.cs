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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtSucNombre = new System.Windows.Forms.TextBox();
            this.txtSucursalCorrel = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelNSuc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPuertoSsh = new System.Windows.Forms.TextBox();
            this.txtRegularPass = new System.Windows.Forms.TextBox();
            this.txtRegularUser = new System.Windows.Forms.TextBox();
            this.txtRootPass = new System.Windows.Forms.TextBox();
            this.txtRootUser = new System.Windows.Forms.TextBox();
            this.cbSshRoot = new System.Windows.Forms.ComboBox();
            this.cbSsh = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMysql = new System.Windows.Forms.ComboBox();
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
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtEspera = new System.Windows.Forms.TextBox();
            this.txtIdScreen = new System.Windows.Forms.TextBox();
            this.txtRutaGestorDte = new System.Windows.Forms.TextBox();
            this.txtRutaPlay = new System.Windows.Forms.TextBox();
            this.txtGestorDtePass = new System.Windows.Forms.TextBox();
            this.txtGestorDteUser = new System.Windows.Forms.TextBox();
            this.cbGestorDte = new System.Windows.Forms.ComboBox();
            this.txtPuertoPlay = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.cbTicket = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtTicketPass = new System.Windows.Forms.TextBox();
            this.txtTicketUser = new System.Windows.Forms.TextBox();
            this.txtUrlTicket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.txtSucNombre);
            this.groupBox1.Controls.Add(this.txtSucursalCorrel);
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labelNSuc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificación";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(6, 128);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(304, 20);
            this.txtIP.TabIndex = 6;
            // 
            // txtSucNombre
            // 
            this.txtSucNombre.Location = new System.Drawing.Point(123, 85);
            this.txtSucNombre.Name = "txtSucNombre";
            this.txtSucNombre.Size = new System.Drawing.Size(187, 20);
            this.txtSucNombre.TabIndex = 5;
            // 
            // txtSucursalCorrel
            // 
            this.txtSucursalCorrel.Location = new System.Drawing.Point(6, 85);
            this.txtSucursalCorrel.Name = "txtSucursalCorrel";
            this.txtSucursalCorrel.Size = new System.Drawing.Size(100, 20);
            this.txtSucursalCorrel.TabIndex = 4;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(6, 38);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(304, 20);
            this.txtEmpresa.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Sucursal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "IP";
            // 
            // labelNSuc
            // 
            this.labelNSuc.AutoSize = true;
            this.labelNSuc.Location = new System.Drawing.Point(6, 69);
            this.labelNSuc.Name = "labelNSuc";
            this.labelNSuc.Size = new System.Drawing.Size(63, 13);
            this.labelNSuc.TabIndex = 1;
            this.labelNSuc.Text = "N° Sucursal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Controls.Add(this.txtPuertoSsh);
            this.groupBox2.Controls.Add(this.txtRegularPass);
            this.groupBox2.Controls.Add(this.txtRegularUser);
            this.groupBox2.Controls.Add(this.txtRootPass);
            this.groupBox2.Controls.Add(this.txtRootUser);
            this.groupBox2.Controls.Add(this.cbSshRoot);
            this.groupBox2.Controls.Add(this.cbSsh);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(13, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acceso SSH";
            // 
            // txtPuertoSsh
            // 
            this.txtPuertoSsh.Location = new System.Drawing.Point(15, 175);
            this.txtPuertoSsh.Name = "txtPuertoSsh";
            this.txtPuertoSsh.Size = new System.Drawing.Size(63, 20);
            this.txtPuertoSsh.TabIndex = 14;
            // 
            // txtRegularPass
            // 
            this.txtRegularPass.Location = new System.Drawing.Point(175, 129);
            this.txtRegularPass.Name = "txtRegularPass";
            this.txtRegularPass.Size = new System.Drawing.Size(135, 20);
            this.txtRegularPass.TabIndex = 13;
            // 
            // txtRegularUser
            // 
            this.txtRegularUser.Location = new System.Drawing.Point(15, 128);
            this.txtRegularUser.Name = "txtRegularUser";
            this.txtRegularUser.Size = new System.Drawing.Size(134, 20);
            this.txtRegularUser.TabIndex = 12;
            // 
            // txtRootPass
            // 
            this.txtRootPass.Location = new System.Drawing.Point(175, 81);
            this.txtRootPass.Name = "txtRootPass";
            this.txtRootPass.Size = new System.Drawing.Size(135, 20);
            this.txtRootPass.TabIndex = 11;
            // 
            // txtRootUser
            // 
            this.txtRootUser.Location = new System.Drawing.Point(15, 81);
            this.txtRootUser.Name = "txtRootUser";
            this.txtRootUser.Size = new System.Drawing.Size(137, 20);
            this.txtRootUser.TabIndex = 10;
            // 
            // cbSshRoot
            // 
            this.cbSshRoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSshRoot.FormattingEnabled = true;
            this.cbSshRoot.Location = new System.Drawing.Point(175, 36);
            this.cbSshRoot.Name = "cbSshRoot";
            this.cbSshRoot.Size = new System.Drawing.Size(135, 21);
            this.cbSshRoot.TabIndex = 8;
            // 
            // cbSsh
            // 
            this.cbSsh.BackColor = System.Drawing.SystemColors.Control;
            this.cbSsh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSsh.FormattingEnabled = true;
            this.cbSsh.Location = new System.Drawing.Point(15, 36);
            this.cbSsh.Name = "cbSsh";
            this.cbSsh.Size = new System.Drawing.Size(136, 21);
            this.cbSsh.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Puerto SSH";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Regular Pass";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Regular User";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Root Pass";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Root User";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Root?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "SSH ?";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox3.Controls.Add(this.cbMysql);
            this.groupBox3.Controls.Add(this.txtErpDb);
            this.groupBox3.Controls.Add(this.txtDteDb);
            this.groupBox3.Controls.Add(this.txtMysqlAccesoPass);
            this.groupBox3.Controls.Add(this.txtMysqlAccesoUser);
            this.groupBox3.Controls.Add(this.txtMysqlRootPass);
            this.groupBox3.Controls.Add(this.txtMysqlRootUser);
            this.groupBox3.Controls.Add(this.txtPuertoMysql);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(342, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(323, 209);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Servidor MySQL / MariaDB";
            // 
            // cbMysql
            // 
            this.cbMysql.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMysql.FormattingEnabled = true;
            this.cbMysql.Location = new System.Drawing.Point(13, 37);
            this.cbMysql.Name = "cbMysql";
            this.cbMysql.Size = new System.Drawing.Size(140, 21);
            this.cbMysql.TabIndex = 15;
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
            this.txtPuertoMysql.Location = new System.Drawing.Point(171, 37);
            this.txtPuertoMysql.Name = "txtPuertoMysql";
            this.txtPuertoMysql.Size = new System.Drawing.Size(71, 20);
            this.txtPuertoMysql.TabIndex = 17;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(171, 158);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "ERP DB";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 158);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "DTE DB";
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
            this.label13.Location = new System.Drawing.Point(171, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Puerto MySQL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "MySQL?";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Gestor DTE?";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Wheat;
            this.groupBox4.Controls.Add(this.txtEspera);
            this.groupBox4.Controls.Add(this.txtIdScreen);
            this.groupBox4.Controls.Add(this.txtRutaGestorDte);
            this.groupBox4.Controls.Add(this.txtRutaPlay);
            this.groupBox4.Controls.Add(this.txtGestorDtePass);
            this.groupBox4.Controls.Add(this.txtGestorDteUser);
            this.groupBox4.Controls.Add(this.cbGestorDte);
            this.groupBox4.Controls.Add(this.txtPuertoPlay);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Location = new System.Drawing.Point(342, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 219);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gestor DTE";
            // 
            // txtEspera
            // 
            this.txtEspera.Location = new System.Drawing.Point(171, 171);
            this.txtEspera.Name = "txtEspera";
            this.txtEspera.Size = new System.Drawing.Size(71, 20);
            this.txtEspera.TabIndex = 31;
            // 
            // txtIdScreen
            // 
            this.txtIdScreen.Location = new System.Drawing.Point(13, 175);
            this.txtIdScreen.Name = "txtIdScreen";
            this.txtIdScreen.Size = new System.Drawing.Size(137, 20);
            this.txtIdScreen.TabIndex = 30;
            // 
            // txtRutaGestorDte
            // 
            this.txtRutaGestorDte.Location = new System.Drawing.Point(171, 129);
            this.txtRutaGestorDte.Name = "txtRutaGestorDte";
            this.txtRutaGestorDte.Size = new System.Drawing.Size(139, 20);
            this.txtRutaGestorDte.TabIndex = 29;
            // 
            // txtRutaPlay
            // 
            this.txtRutaPlay.Location = new System.Drawing.Point(13, 129);
            this.txtRutaPlay.Name = "txtRutaPlay";
            this.txtRutaPlay.Size = new System.Drawing.Size(139, 20);
            this.txtRutaPlay.TabIndex = 28;
            // 
            // txtGestorDtePass
            // 
            this.txtGestorDtePass.Location = new System.Drawing.Point(171, 82);
            this.txtGestorDtePass.Name = "txtGestorDtePass";
            this.txtGestorDtePass.Size = new System.Drawing.Size(139, 20);
            this.txtGestorDtePass.TabIndex = 27;
            // 
            // txtGestorDteUser
            // 
            this.txtGestorDteUser.Location = new System.Drawing.Point(13, 82);
            this.txtGestorDteUser.Name = "txtGestorDteUser";
            this.txtGestorDteUser.Size = new System.Drawing.Size(140, 20);
            this.txtGestorDteUser.TabIndex = 26;
            // 
            // cbGestorDte
            // 
            this.cbGestorDte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGestorDte.FormattingEnabled = true;
            this.cbGestorDte.Location = new System.Drawing.Point(13, 36);
            this.cbGestorDte.Name = "cbGestorDte";
            this.cbGestorDte.Size = new System.Drawing.Size(142, 21);
            this.cbGestorDte.TabIndex = 24;
            // 
            // txtPuertoPlay
            // 
            this.txtPuertoPlay.Location = new System.Drawing.Point(171, 37);
            this.txtPuertoPlay.Name = "txtPuertoPlay";
            this.txtPuertoPlay.Size = new System.Drawing.Size(71, 20);
            this.txtPuertoPlay.TabIndex = 25;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(171, 158);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 13);
            this.label27.TabIndex = 15;
            this.label27.Text = "Espera (Seg.)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(171, 19);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 13);
            this.label26.TabIndex = 14;
            this.label26.Text = "Puerto Play";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(13, 158);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 13);
            this.label25.TabIndex = 13;
            this.label25.Text = "ID Screen";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(171, 113);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "Ruta Gestor DTE";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 113);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 13);
            this.label23.TabIndex = 11;
            this.label23.Text = "Ruta Play";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(171, 66);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Gestor DTE Pass";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 65);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Gestor DTE User";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCrear,
            this.tsmModificar,
            this.tsmSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
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
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.cbTicket);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.txtTicketPass);
            this.groupBox5.Controls.Add(this.txtTicketUser);
            this.groupBox5.Controls.Add(this.txtUrlTicket);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(13, 470);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 124);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ticket de Soporte";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(15, 28);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(91, 13);
            this.label30.TabIndex = 7;
            this.label30.Text = "Acceso a Ticket?";
            // 
            // cbTicket
            // 
            this.cbTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicket.FormattingEnabled = true;
            this.cbTicket.Location = new System.Drawing.Point(18, 44);
            this.cbTicket.Name = "cbTicket";
            this.cbTicket.Size = new System.Drawing.Size(131, 21);
            this.cbTicket.TabIndex = 32;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(175, 76);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(30, 13);
            this.label29.TabIndex = 5;
            this.label29.Text = "Pass";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(15, 76);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(43, 13);
            this.label28.TabIndex = 4;
            this.label28.Text = "Usuario";
            // 
            // txtTicketPass
            // 
            this.txtTicketPass.Location = new System.Drawing.Point(178, 92);
            this.txtTicketPass.Name = "txtTicketPass";
            this.txtTicketPass.Size = new System.Drawing.Size(132, 20);
            this.txtTicketPass.TabIndex = 35;
            // 
            // txtTicketUser
            // 
            this.txtTicketUser.Location = new System.Drawing.Point(15, 92);
            this.txtTicketUser.Name = "txtTicketUser";
            this.txtTicketUser.Size = new System.Drawing.Size(135, 20);
            this.txtTicketUser.TabIndex = 34;
            // 
            // txtUrlTicket
            // 
            this.txtUrlTicket.Location = new System.Drawing.Point(175, 45);
            this.txtUrlTicket.Name = "txtUrlTicket";
            this.txtUrlTicket.Size = new System.Drawing.Size(131, 20);
            this.txtUrlTicket.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "URL";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox6.Location = new System.Drawing.Point(342, 471);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(323, 124);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Otras Configuraciones";
            // 
            // Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 607);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelNSuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
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
        private System.Windows.Forms.TextBox txtEspera;
        private System.Windows.Forms.TextBox txtIdScreen;
        private System.Windows.Forms.TextBox txtRutaGestorDte;
        private System.Windows.Forms.TextBox txtRutaPlay;
        private System.Windows.Forms.TextBox txtGestorDtePass;
        private System.Windows.Forms.TextBox txtGestorDteUser;
        private System.Windows.Forms.ComboBox cbGestorDte;
        private System.Windows.Forms.TextBox txtPuertoPlay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCrear;
        private System.Windows.Forms.ToolStripMenuItem tsmModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtTicketPass;
        private System.Windows.Forms.TextBox txtTicketUser;
        private System.Windows.Forms.TextBox txtUrlTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox cbTicket;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}