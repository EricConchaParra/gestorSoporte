namespace GestorSoporte
{
    partial class ConsultasSQL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasSQL));
            this.dgvSQL = new System.Windows.Forms.DataGridView();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarAExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEditarConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbRegs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSQL
            // 
            this.dgvSQL.AllowUserToAddRows = false;
            this.dgvSQL.AllowUserToDeleteRows = false;
            this.dgvSQL.AllowUserToResizeColumns = false;
            this.dgvSQL.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dgvSQL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSQL.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dgvSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSQL.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSQL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSQL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSQL.Location = new System.Drawing.Point(0, 83);
            this.dgvSQL.Name = "dgvSQL";
            this.dgvSQL.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSQL.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSQL.Size = new System.Drawing.Size(727, 375);
            this.dgvSQL.TabIndex = 1;
            // 
            // cbConsulta
            // 
            this.cbConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Location = new System.Drawing.Point(6, 17);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(432, 23);
            this.cbConsulta.TabIndex = 2;
            this.cbConsulta.SelectedIndexChanged += new System.EventHandler(this.cbConsulta_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.exportarAExcelToolStripMenuItem,
            this.verEditarConsultasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(727, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.consultarToolStripMenuItem.Text = "Ejecutar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // exportarAExcelToolStripMenuItem
            // 
            this.exportarAExcelToolStripMenuItem.Name = "exportarAExcelToolStripMenuItem";
            this.exportarAExcelToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.exportarAExcelToolStripMenuItem.Text = "Exportar a Excel";
            this.exportarAExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarAExcelToolStripMenuItem_Click);
            // 
            // verEditarConsultasToolStripMenuItem
            // 
            this.verEditarConsultasToolStripMenuItem.Name = "verEditarConsultasToolStripMenuItem";
            this.verEditarConsultasToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.verEditarConsultasToolStripMenuItem.Text = "Ver/Editar Consultas";
            this.verEditarConsultasToolStripMenuItem.Click += new System.EventHandler(this.verEditarConsultasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbRegs);
            this.groupBox1.Controls.Add(this.cbConsulta);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta a Ejecutar";
            // 
            // lbRegs
            // 
            this.lbRegs.AutoSize = true;
            this.lbRegs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbRegs.Location = new System.Drawing.Point(639, 20);
            this.lbRegs.Name = "lbRegs";
            this.lbRegs.Size = new System.Drawing.Size(76, 13);
            this.lbRegs.TabIndex = 3;
            this.lbRegs.Text = "Regs:  XXXXX";
            // 
            // ConsultasSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(727, 458);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSQL);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConsultasSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas a Base de Datos";
            this.Load += new System.EventHandler(this.DTEControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQL)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSQL;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarAExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem verEditarConsultasToolStripMenuItem;
        private System.Windows.Forms.Label lbRegs;
    }
}