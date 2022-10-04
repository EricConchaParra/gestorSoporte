namespace GestorSoporte
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.cbFuncionario = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbASSM = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbActivo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateCertificado = new System.Windows.Forms.DateTimePicker();
            this.txtUserSII = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tmCrear = new System.Windows.Forms.ToolStripMenuItem();
            this.tmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateDte = new System.Windows.Forms.DateTimePicker();
            this.dateErp = new System.Windows.Forms.DateTimePicker();
            this.ckDte = new System.Windows.Forms.CheckBox();
            this.ckErp = new System.Windows.Forms.CheckBox();
            this.cbNotificaCliente = new System.Windows.Forms.CheckBox();
            this.txtEmailsNotifica = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razón Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(138, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fantasía";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(10, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Funcionario Asignado";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(14, 42);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(121, 20);
            this.txtRut.TabIndex = 0;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(14, 89);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(327, 20);
            this.txtRazonSocial.TabIndex = 1;
            // 
            // txtFantasia
            // 
            this.txtFantasia.Location = new System.Drawing.Point(141, 42);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(200, 20);
            this.txtFantasia.TabIndex = 2;
            // 
            // txtNotas
            // 
            this.txtNotas.ForeColor = System.Drawing.Color.Black;
            this.txtNotas.Location = new System.Drawing.Point(6, 18);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(380, 91);
            this.txtNotas.TabIndex = 5;
            // 
            // cbFuncionario
            // 
            this.cbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuncionario.FormattingEnabled = true;
            this.cbFuncionario.Location = new System.Drawing.Point(13, 139);
            this.cbFuncionario.Name = "cbFuncionario";
            this.cbFuncionario.Size = new System.Drawing.Size(151, 21);
            this.cbFuncionario.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEmailsNotifica);
            this.groupBox1.Controls.Add(this.cbNotificaCliente);
            this.groupBox1.Controls.Add(this.cbASSM);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbActivo);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.cbFuncionario);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtRazonSocial);
            this.groupBox1.Controls.Add(this.txtFantasia);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(11, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 266);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificación";
            // 
            // cbASSM
            // 
            this.cbASSM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbASSM.FormattingEnabled = true;
            this.cbASSM.Location = new System.Drawing.Point(189, 139);
            this.cbASSM.Name = "cbASSM";
            this.cbASSM.Size = new System.Drawing.Size(134, 21);
            this.cbASSM.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(186, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "ASSM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(11, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Estado";
            // 
            // cbActivo
            // 
            this.cbActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbActivo.FormattingEnabled = true;
            this.cbActivo.Location = new System.Drawing.Point(14, 190);
            this.cbActivo.Name = "cbActivo";
            this.cbActivo.Size = new System.Drawing.Size(151, 21);
            this.cbActivo.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox2.Controls.Add(this.txtNotas);
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(376, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 116);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notas";
            // 
            // dateCertificado
            // 
            this.dateCertificado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCertificado.Location = new System.Drawing.Point(235, 91);
            this.dateCertificado.Name = "dateCertificado";
            this.dateCertificado.Size = new System.Drawing.Size(114, 20);
            this.dateCertificado.TabIndex = 10;
            // 
            // txtUserSII
            // 
            this.txtUserSII.ForeColor = System.Drawing.Color.Black;
            this.txtUserSII.Location = new System.Drawing.Point(8, 91);
            this.txtUserSII.Name = "txtUserSII";
            this.txtUserSII.Size = new System.Drawing.Size(187, 20);
            this.txtUserSII.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(8, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Usuario Autorizado en SII";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmCrear,
            this.tmModificar,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tmCrear
            // 
            this.tmCrear.Name = "tmCrear";
            this.tmCrear.Size = new System.Drawing.Size(47, 20);
            this.tmCrear.Text = "Crear";
            this.tmCrear.Click += new System.EventHandler(this.tmCrear_Click);
            // 
            // tmModificar
            // 
            this.tmModificar.Name = "tmModificar";
            this.tmModificar.Size = new System.Drawing.Size(70, 20);
            this.tmModificar.Text = "Modificar";
            this.tmModificar.Click += new System.EventHandler(this.tmModificar_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dateDte);
            this.groupBox3.Controls.Add(this.dateErp);
            this.groupBox3.Controls.Add(this.dateCertificado);
            this.groupBox3.Controls.Add(this.ckDte);
            this.groupBox3.Controls.Add(this.ckErp);
            this.groupBox3.Controls.Add(this.txtUserSII);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(376, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(394, 144);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(232, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Certificado válido hasta";
            // 
            // dateDte
            // 
            this.dateDte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDte.Location = new System.Drawing.Point(100, 43);
            this.dateDte.Name = "dateDte";
            this.dateDte.Size = new System.Drawing.Size(95, 20);
            this.dateDte.TabIndex = 4;
            // 
            // dateErp
            // 
            this.dateErp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateErp.Location = new System.Drawing.Point(100, 17);
            this.dateErp.Name = "dateErp";
            this.dateErp.Size = new System.Drawing.Size(95, 20);
            this.dateErp.TabIndex = 3;
            // 
            // ckDte
            // 
            this.ckDte.AutoSize = true;
            this.ckDte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckDte.Location = new System.Drawing.Point(8, 46);
            this.ckDte.Name = "ckDte";
            this.ckDte.Size = new System.Drawing.Size(86, 17);
            this.ckDte.TabIndex = 1;
            this.ckDte.Text = "Sigue® DTE";
            this.ckDte.UseVisualStyleBackColor = true;
            this.ckDte.CheckedChanged += new System.EventHandler(this.ckDte_CheckedChanged);
            // 
            // ckErp
            // 
            this.ckErp.AutoSize = true;
            this.ckErp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ckErp.Location = new System.Drawing.Point(8, 19);
            this.ckErp.Name = "ckErp";
            this.ckErp.Size = new System.Drawing.Size(86, 17);
            this.ckErp.TabIndex = 0;
            this.ckErp.Text = "Sigue® ERP";
            this.ckErp.UseVisualStyleBackColor = true;
            this.ckErp.CheckedChanged += new System.EventHandler(this.ckErp_CheckedChanged);
            // 
            // cbNotificaCliente
            // 
            this.cbNotificaCliente.AutoSize = true;
            this.cbNotificaCliente.ForeColor = System.Drawing.Color.Black;
            this.cbNotificaCliente.Location = new System.Drawing.Point(189, 192);
            this.cbNotificaCliente.Name = "cbNotificaCliente";
            this.cbNotificaCliente.Size = new System.Drawing.Size(162, 17);
            this.cbNotificaCliente.TabIndex = 12;
            this.cbNotificaCliente.Text = "¿Notifica Servicio vía Email?";
            this.cbNotificaCliente.UseVisualStyleBackColor = true;
            // 
            // txtEmailsNotifica
            // 
            this.txtEmailsNotifica.Location = new System.Drawing.Point(14, 238);
            this.txtEmailsNotifica.Name = "txtEmailsNotifica";
            this.txtEmailsNotifica.Size = new System.Drawing.Size(327, 20);
            this.txtEmailsNotifica.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(11, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Emails para notificación (separados por comas)";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(776, 305);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cliente";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.ComboBox cbFuncionario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tmCrear;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmModificar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbActivo;
        private System.Windows.Forms.ComboBox cbASSM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUserSII;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckDte;
        private System.Windows.Forms.CheckBox ckErp;
        private System.Windows.Forms.DateTimePicker dateDte;
        private System.Windows.Forms.DateTimePicker dateErp;
        private System.Windows.Forms.DateTimePicker dateCertificado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailsNotifica;
        private System.Windows.Forms.CheckBox cbNotificaCliente;
    }
}