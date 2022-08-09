using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSoporte
{
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            updateTable();
            dgvFuncionarios.Columns[0].ReadOnly = true;
            dgvFuncionarios.Columns[0].Width = 20;

            dgvFuncionarios.Columns[0].HeaderText = "ID";
            dgvFuncionarios.Columns[1].HeaderText = "Nombre";
        }

        private void updateTable()
        {
            DataSet ds = MySql.SelectDataSet("select * from funcionarios");
            dgvFuncionarios.DataSource = ds;
            dgvFuncionarios.DataMember = "Select";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grabarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = (DataSet)dgvFuncionarios.DataSource;
            MySql.SaveDataSet(ds, "select * from funcionarios");
            updateTable();
            alerta.informacion("Información","Cambios guardados");
            this.Close();

        }
    }
}
