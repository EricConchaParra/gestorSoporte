namespace GestorSoporte
{
    partial class Credenciales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credenciales));
            this.dgvAccesos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnCpUrl = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCpPass = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCpId = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTipoAcceso = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccesos
            // 
            this.dgvAccesos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvAccesos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccesos.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvAccesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccesos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAccesos.GridColor = System.Drawing.SystemColors.Control;
            this.dgvAccesos.Location = new System.Drawing.Point(2, 55);
            this.dgvAccesos.Name = "dgvAccesos";
            this.dgvAccesos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccesos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccesos.Size = new System.Drawing.Size(322, 258);
            this.dgvAccesos.TabIndex = 0;
            this.dgvAccesos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgvAccesos.CurrentCellChanged += new System.EventHandler(this.dgvAccesos_CurrentCellChanged);
            this.dgvAccesos.SelectionChanged += new System.EventHandler(this.dgvAccesos_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(330, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 301);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de acceso";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnCpUrl);
            this.groupBox7.Controls.Add(this.txtUrl);
            this.groupBox7.Location = new System.Drawing.Point(6, 236);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(280, 51);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "URL (incluya http o https)";
            // 
            // btnCpUrl
            // 
            this.btnCpUrl.Location = new System.Drawing.Point(198, 17);
            this.btnCpUrl.Name = "btnCpUrl";
            this.btnCpUrl.Size = new System.Drawing.Size(75, 23);
            this.btnCpUrl.TabIndex = 2;
            this.btnCpUrl.Text = "Ir a URL";
            this.btnCpUrl.UseVisualStyleBackColor = true;
            this.btnCpUrl.Click += new System.EventHandler(this.btnCpUrl_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(6, 19);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(188, 20);
            this.txtUrl.TabIndex = 4;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(144, 19);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(63, 26);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(75, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(63, 26);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCpPass);
            this.groupBox5.Controls.Add(this.txtPass);
            this.groupBox5.Location = new System.Drawing.Point(6, 175);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(280, 51);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Password";
            // 
            // btnCpPass
            // 
            this.btnCpPass.Location = new System.Drawing.Point(198, 16);
            this.btnCpPass.Name = "btnCpPass";
            this.btnCpPass.Size = new System.Drawing.Size(75, 23);
            this.btnCpPass.TabIndex = 3;
            this.btnCpPass.Text = "Copiar";
            this.btnCpPass.UseVisualStyleBackColor = true;
            this.btnCpPass.Click += new System.EventHandler(this.btnCpPass_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(6, 19);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(188, 20);
            this.txtPass.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCpId);
            this.groupBox4.Controls.Add(this.txtId);
            this.groupBox4.Location = new System.Drawing.Point(6, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(280, 51);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usuario / ID";
            // 
            // btnCpId
            // 
            this.btnCpId.Location = new System.Drawing.Point(198, 17);
            this.btnCpId.Name = "btnCpId";
            this.btnCpId.Size = new System.Drawing.Size(75, 23);
            this.btnCpId.TabIndex = 2;
            this.btnCpId.Text = "Copiar";
            this.btnCpId.UseVisualStyleBackColor = true;
            this.btnCpId.Click += new System.EventHandler(this.btnCpId_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(6, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(188, 20);
            this.txtId.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(63, 26);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Añadir";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbTipoAcceso);
            this.groupBox3.Location = new System.Drawing.Point(212, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(159, 51);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo Credencial";
            // 
            // cbTipoAcceso
            // 
            this.cbTipoAcceso.FormattingEnabled = true;
            this.cbTipoAcceso.Location = new System.Drawing.Point(6, 19);
            this.cbTipoAcceso.Name = "cbTipoAcceso";
            this.cbTipoAcceso.Size = new System.Drawing.Size(140, 21);
            this.cbTipoAcceso.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(6, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 51);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(6, 19);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(188, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtBusqueda);
            this.groupBox6.Location = new System.Drawing.Point(2, 8);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(322, 41);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Buscar";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(6, 15);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(310, 20);
            this.txtBusqueda.TabIndex = 0;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(213, 19);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(63, 26);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Credenciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(715, 321);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAccesos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Credenciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credenciales";
            this.Load += new System.EventHandler(this.AnyTeam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccesos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAccesos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTipoAcceso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCpId;
        private System.Windows.Forms.Button btnCpPass;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnCpUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnLimpiar;
    }
}