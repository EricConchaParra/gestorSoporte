using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestorSoporte
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Obtengo los datos de conexion de la función conData almacenada en el SelConnection (login)
            DataRow conData = SelConnection.conData;

            //Obtengo datos del usuario que inició sesion
            string[] datos_usuario = SelConnection.datos_usuario;
            /*
            datos_usuario[0] = nivel_usuario;
            datos_usuario[1] = nombre_usuario;
            datos_usuario[2] = id_sucursal;
            */

            //TO DO, aqui debe decidir que si es usuario tipo dos, esconde el form y abre el control panel de la sucursal asignada
            //el Control Panel debe bloquear todos los accesos peligrosos. y al cerrar debe cerrar la aplicacion (si el usuario es nivel 2).

            if(datos_usuario[0] == "1")
            {
                //MessageBox.Show("administrador");
            }

            else if (datos_usuario[0] == "2")
            {
                //MessageBox.Show("usuario normal");

                DataTable cmData = MySql.DatosSucursal(datos_usuario[2]);
                DataRow sucData = cmData.Rows[0];
                controlPanel cp = new controlPanel(Seguridad.sucDataDesEncripta(sucData));
                this.Hide();
                cp.ShowDialog();
                Environment.Exit(0);
            }

            else
            {
                MessageBox.Show("No reconozco tipo de usuario");
            }

            Carga();
        }

        
        public void Carga()
        {
            // Crea un datatable y lo lleno con la Consulta VerClientes del archivo MySQL
            DataTable dt = new DataTable();
            dt = MySql.VerClientes();

            //Doy formato al DGV
            dgvClientes.DataSource = dt;
            dgvClientes.Columns[0].HeaderText = "Rut";
            dgvClientes.Columns[0].Width = 100;

            dgvClientes.Columns[1].HeaderText = "Fantasía";
            dgvClientes.Columns[1].Width = 200;

            dgvClientes.Columns[2].HeaderText = "Razón Social";
            dgvClientes.Columns[2].Width = 250;

            dgvClientes.Columns[3].HeaderText = "Funcionario Cargo";
            dgvClientes.Columns[3].Width = 200;
            lbRegistros.Text = "Regs. " + dgvClientes.RowCount.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionaCliente();
        }

        private void SeleccionaCliente()
        {
            //Obtengo el RUT del cliente y su fantasía como variables string
            string id_cliente = this.dgvClientes.CurrentRow.Cells[0].Value.ToString();
            string fantasia = this.dgvClientes.CurrentRow.Cells[1].Value.ToString();

            //Pregunta si tiene 0, 1 o más sucursales
            int nSucursales = MySql.CuentaSucursalesCliente(id_cliente);

            if (nSucursales == 0)
            {
                alerta.error("Error", "No hay Datos de sucursal!");
            }
            //Si solo tiene una, carga la CM
            else if (nSucursales == 1)
            {
                DataTable cmData = MySql.DatosCasaMatriz(id_cliente);
                DataRow sucData = cmData.Rows[0];
                controlPanel cp = new controlPanel(Seguridad.sucDataDesEncripta(sucData));
                cp.Show();
            }
            else
            {
                //Si tiene mas llamo al Form de Sucursales, para que elija una
                SelSucursal suc = new SelSucursal(id_cliente, fantasia);
                suc.ShowDialog();

                DataRow sucData = SelSucursal.sucData;

                if (suc.DialogResult == DialogResult.OK)
                {
                    controlPanel cp = new controlPanel(Seguridad.sucDataDesEncripta(sucData));
                    cp.Show();
                }
            }
        }

        //Este es el buscador, si cambia el texto en el textBox realiza una busqueda
        private void txtBuscaFantasia_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscaFantasia.Text != "")
            {
                string busqueda = txtBuscaFantasia.Text;
                //Esta funcion de MySQL busca en razon social, fantasia y funcionario
                dgvClientes.DataSource = MySql.BuscaClientes(busqueda);
                lbRegistros.Text = "Regs. " + dgvClientes.RowCount.ToString();
            }
            else
            {
                dgvClientes.DataSource = MySql.VerClientes();
                lbRegistros.Text = "Regs. " + dgvClientes.RowCount.ToString();
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string accion = "new";
            Cliente clte = new Cliente(accion,"");
            clte.ShowDialog();
            Carga();
        }

        private void editarExistenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelCliente selC = new SelCliente();
            selC.ShowDialog();
            Carga();
        }

        private void agregarSucursalAClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carga();
        }

        private void agregarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id_cliente = this.dgvClientes.CurrentRow.Cells[0].Value.ToString();
            string fantasia = this.dgvClientes.CurrentRow.Cells[1].Value.ToString();

            DialogResult confirma = MessageBox.Show("Desea agregar una sucursal al cliente " + fantasia + "?", "Responda por favor",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (confirma == DialogResult.OK)
            {
                Sucursal suc = new Sucursal("new", id_cliente, "");
                suc.ShowDialog();
            }
            else if (confirma == DialogResult.Cancel)
            {

            }

            else
            {
                alerta.error("", "No entendí su respuesta. No realicé ninguna acción.");
            }
        }

        private void agregarSucursalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string id_cliente = this.dgvClientes.CurrentRow.Cells[0].Value.ToString();
            Sucursal suc = new Sucursal("new", id_cliente,"");
            suc.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alerta.informacion("", "Pendiente!, por ahora es necesario editar la base de datos directamente.");
        }

        private void consultasSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelQuery SQ = new SelQuery();
            SQ.ShowDialog();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultasSQL qs = new ConsultasSQL("x","3");
            qs.ShowDialog();
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
