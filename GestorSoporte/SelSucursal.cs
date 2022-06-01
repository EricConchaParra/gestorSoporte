using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSoporte
{
    public partial class SelSucursal : Form
    {
        public SelSucursal(string id_cliente, string fantasia)
        {
            InitializeComponent();
            CargaSucursales(id_cliente, fantasia);
            rut_cliente = id_cliente;

        }

        public static DataRow row;
        public static String rut_cliente;
        public static String id_sucursal1;

        private void Sucursales_Load(object sender, EventArgs e)
        {

        }

        public void CargaSucursales(string id_cliente, string fantasia)
        {
            this.dgvSucursales.DataSource = MySql.VerSucursalesCliente(id_cliente);
            this.dgvSucursales.Columns[0].HeaderText = "N°";
            this.dgvSucursales.Columns[1].HeaderText = "Sucursal";
            this.dgvSucursales.Columns[2].HeaderText = "Dirección IP";
            this.dgvSucursales.Columns[3].Visible = false; //este campo es el ID autoincremental de la sucursal seleccionada
                                                           //se envía a lo que sea que se selecione, para que sepa en que 
                                                           //sucursal está parado.
            this.Text = fantasia + " - Sucursales";

            //DesEncripta las IP en esta parte para que se puedan leer
            for (int fila = 0; fila < dgvSucursales.Rows.Count; fila++)
            {
                dgvSucursales.Rows[fila].Cells[2].Value = Seguridad.DesEncriptar(dgvSucursales.Rows[fila].Cells[2].Value.ToString());

            }
        }



        private void dgvSucursales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionaSucursal();
        }

        private void SeleccionaSucursal()
        {
            string id_sucursal = this.dgvSucursales.CurrentRow.Cells[3].Value.ToString(); //Obtiene el ID de la sucursal
            id_sucursal1 = id_sucursal;

            //Obtiene todos los datos de esa sucursal, para enviarlos a lo que corresponda.
            DataTable DT = new DataTable();
            DT = MySql.DatosSucursal(id_sucursal);
            row = DT.Rows[0];

            this.DialogResult = DialogResult.OK;
        }

        public static DataRow sucData
        {
            get { return row; }
        }

        public static String id_sucursalSel
        {
            get { return id_sucursal1; }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AbreEditor()
        {
            string id_sucursal = this.dgvSucursales.CurrentRow.Cells[3].Value.ToString(); //Obtiene el ID de la sucursal
            Sucursal suc = new Sucursal("edit", rut_cliente,id_sucursal);
            suc.ShowDialog();
        }



        private void editarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Editar desde menu de texto
            AbreEditor();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Editar desde menu contextual
            AbreEditor();
        }

        private void agregarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id_sucursal = this.dgvSucursales.CurrentRow.Cells[3].Value.ToString(); //Obtiene el ID de la sucursal
            Sucursal suc = new Sucursal("new", rut_cliente, id_sucursal);
            suc.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string id_sucursal = this.dgvSucursales.CurrentRow.Cells[3].Value.ToString(); //Obtiene el ID de la sucursal
            string nombre_suc = this.dgvSucursales.CurrentRow.Cells[1].Value.ToString(); //nombre
            string ip = this.dgvSucursales.CurrentRow.Cells[2].Value.ToString(); //ip
            DialogResult confirma = MessageBox.Show("Está seguro de que desea eliminar la sucursal: '" + nombre_suc + "' con la ip: " + ip + "?","Responda por favor",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (confirma == DialogResult.OK)
            {
                MySql.borraSucursal(id_sucursal);
                alerta.informacion("", "Sucursal Borrada");
                this.Close();
            }
            else if (confirma == DialogResult.Cancel)
            {

            }

            else
            {
                alerta.error("","No entendí su respuesta. No realicé ninguna acción.");
            }

        }

        private void dgvSucursales_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SeleccionaSucursal();
            }
        }
    }
}
