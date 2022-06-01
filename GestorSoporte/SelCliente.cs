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
    public partial class SelCliente : Form
    {
        public SelCliente()
        {
            InitializeComponent();
        }

        public static DataRow cliData;

        private void txtBuscaFantasia_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscaFantasia.Text != "")
            {
                string busqueda = txtBuscaFantasia.Text;
                //Esta funcion de MySQL busca en razon social, fantasia y funcionario
                dgvClientes.DataSource = MySql.BuscaTodosClientes(busqueda);
            }
            else
            {
                dgvClientes.DataSource = MySql.VerTodosClientes();
            }
        }

        private void SelCliente_Load(object sender, EventArgs e)
        {
            // Crea un datatable y lo lleno con la Consulta VerClientes del archivo MySQL
            DataTable dt = new DataTable();
            dt = MySql.VerTodosClientes();

            //Doy formato al DGV
            dgvClientes.DataSource = dt;
            dgvClientes.Columns[0].HeaderText = "Rut";
            dgvClientes.Columns[0].Width = 100;

            dgvClientes.Columns[1].HeaderText = "Fantasía";
            dgvClientes.Columns[1].Width = 200;

            dgvClientes.Columns[2].Visible = false;

            dgvClientes.Columns[3].Visible = false;
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionaCliente();
        }

        private void SeleccionaCliente()
        {
            //Obtengo el RUT del cliente y su fantasía como variables string
            string rut_cliente = this.dgvClientes.CurrentRow.Cells[0].Value.ToString();
            string fantasia = this.dgvClientes.CurrentRow.Cells[1].Value.ToString();

            DataTable cliData1 = MySql.DatosCliente(rut_cliente);
            cliData = cliData1.Rows[0];

            string accion = "edit";
            Cliente clte = new Cliente(accion, "");
            clte.ShowDialog();
            this.Close();
        }

        public static DataRow DataCliente
        {
            get { return cliData; }
        }

        private void dgvClientes_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionaCliente();
            }
        }
    }


}
