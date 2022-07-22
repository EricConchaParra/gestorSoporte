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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSlackChannel = new System.Windows.Forms.TextBox();
            this.cbSlack = new System.Windows.Forms.CheckBox();
            this.cbNewRelic = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LemonChiffon;
            this.groupBox2.Controls.Add(this.txtPuertoSsh);
            this.groupBox2.Controls.Add(this.txtRegularPass);
            this.groupBox2.Controls.Add(this.txtRegularUser);
            this.groupBox2.Controls.Add(this.txtRootPass);
            this.groupBox2.Controls.Add(this.txtRootUser);
            this.groupBox2.Controls.Add(this.cbSshRoot);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(13, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acceso SSH";
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
            // cbSsh
            // 
            this.cbSsh.BackColor = System.Drawing.SystemColors.Control;
            this.cbSsh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSsh.FormattingEnabled = true;
            this.cbSsh.Location = new System.Drawing.Point(124, 126);
            this.cbSsh.Name = "cbSsh";
            this.cbSsh.Size = new System.Drawing.Size(93, 21);
            this.cbSsh.TabIndex = 7;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "SSH ?";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGreen;
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
            this.cbMysql.Location = new System.Drawing.Point(10, 175);
            this.cbMysql.Name = "cbMysql";
            this.cbMysql.Size = new System.Drawing.Size(100, 21);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "MySQL?";
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
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox6.Controls.Add(this.cbNewRelic);
            this.groupBox6.Controls.Add(this.cbSlack);
            this.groupBox6.Controls.Add(this.txtSlackChannel);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(342, 247);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(323, 217);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Notificaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Slack Channel";
            // 
            // txtSlackChannel
            // 
            this.txtSlackChannel.Location = new System.Drawing.Point(13, 67);
            this.txtSlackChannel.Name = "txtSlackChannel";
            this.txtSlackChannel.Size = new System.Drawing.Size(159, 20);
            this.txtSlackChannel.TabIndex = 1;
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
            // 
            // cbNewRelic
            // 
            this.cbNewRelic.AutoSize = true;
            this.cbNewRelic.Location = new System.Drawing.Point(11, 105);
            this.cbNewRelic.Name = "cbNewRelic";
            this.cbNewRelic.Size = new System.Drawing.Size(240, 17);
            this.cbNewRelic.TabIndex = 3;
            this.cbNewRelic.Text = "¿Lanza alertas en NewRelic? (Próximamente)";
            this.cbNewRelic.UseVisualStyleBackColor = true;
            // 
            // Sucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 479);
            this.Controls.Add(this.groupBox6);
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
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbNewRelic;
    }
}