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
    public partial class SelQuery : Form
    {
        public SelQuery()
        {
            InitializeComponent();
        }

        public static string id;

        private void SelQuery_Load(object sender, EventArgs e)
        {
            Carga();
        }

        private void Carga()
        {
            DataTable dtb1 = new DataTable();

            dtb1 = MySql.Queries("1' or tipo = '2' or tipo = '3");

            dgvConsultas.DataSource = dtb1;

            dgvConsultas.Columns[0].HeaderText = "ID";
            dgvConsultas.Columns[0].Width = 40;
            dgvConsultas.Columns[1].HeaderText = "Nombre";
            dgvConsultas.Columns[1].Width = 310;
            dgvConsultas.Columns[2].Visible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Query q = new Query("new");
            q.ShowDialog();
            this.Close();
        }

        private void dgvConsultas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionaQuery();

        }

        private void SeleccionaQuery()
        {
            id = this.dgvConsultas.CurrentRow.Cells[0].Value.ToString();
            Query q = new Query("edit");
            q.ShowDialog();
            this.Close();
        }

        public static String id_query
        {
            get { return id; }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id_q = int.Parse(this.dgvConsultas.CurrentRow.Cells[0].Value.ToString());
            string query = this.dgvConsultas.CurrentRow.Cells[1].Value.ToString();
            DialogResult respuesta = MessageBox.Show(
            "Esta apunto de eliminar la consulta " + query + ".\n\n¿Está seguro de que desea continuar?",
            "Atención!",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                MySql.BorraQuery(id_q);
            }
            Carga();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuTextEditarSuc_Click(object sender, EventArgs e)
        {
            id = this.dgvConsultas.CurrentRow.Cells[0].Value.ToString();
            Query q = new Query("edit");
            q.ShowDialog();
            this.Close();
        }

        private void dgvConsultas_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionaQuery();
            }
        }
    }
}
