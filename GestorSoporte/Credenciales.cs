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
    public partial class Credenciales : Form
    {

        public string rutCliente = "";
        public Credenciales(string rut)
        {
            InitializeComponent();
            rutCliente = rut;
        }

        private void AnyTeam_Load(object sender, EventArgs e)
        {
            //Crear DataTable para ComboBox
            DataTable tipoAcc = new DataTable();

            //Crear Rows AnyDesk y TeamViewer
            tipoAcc.Columns.Add("descripcion");
            tipoAcc.Columns.Add("valor");

            tipoAcc.Rows.Add("AnyDesk", "AnyDesk");
            tipoAcc.Rows.Add("TeamViewer", "TeamViewer");
            tipoAcc.Rows.Add("Sitio Web", "Sitio Web");
            tipoAcc.Rows.Add("Otro", "Otro");

            //Asignar DataSource
            cbTipoAcceso.DataSource = tipoAcc;
            cbTipoAcceso.DisplayMember = "descripcion";
            cbTipoAcceso.ValueMember = "valor";
            UpdateTabla();
        }

        private void UpdateTabla()
        {
            //Consultar lista
            DataTable accesos = MySql.VerAccesos(rutCliente);

            //Vincular a DGV
            dgvAccesos.DataSource = accesos;

            //Darle formato a la tabla (ancho de columnas) TODO
            dgvAccesos.Columns[0].Visible = false;

            dgvAccesos.Columns[1].Visible = false;

            dgvAccesos.Columns[2].HeaderText = "Descripción";
            dgvAccesos.Columns[2].Width = 170;

            dgvAccesos.Columns[3].HeaderText = "Tipo Acceso";
            dgvAccesos.Columns[3].Width = 100;

            dgvAccesos.Columns[4].Visible = false;
            dgvAccesos.Columns[5].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Trae datos de fila seleccionada
            txtDescripcion.Text = this.dgvAccesos.CurrentRow.Cells[2].Value.ToString();
            txtId.Text = Seguridad.DesEncriptar(this.dgvAccesos.CurrentRow.Cells[4].Value.ToString());
            txtPass.Text = Seguridad.DesEncriptar(this.dgvAccesos.CurrentRow.Cells[5].Value.ToString());
            cbTipoAcceso.SelectedValue = this.dgvAccesos.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Captura los datos de los TextBox
            string descripcion = txtDescripcion.Text;
            string tipoAcceso = cbTipoAcceso.Text;
            string IdAsociado = txtId.Text;
            string PassAsociado = txtPass.Text;

            //Encripta ID y Pass Asociado
            IdAsociado = Seguridad.Encriptar(IdAsociado);
            PassAsociado = Seguridad.Encriptar(PassAsociado);

            //Graba MySQL
            string insert = string.Format("insert into accesos (fkcliente, descripcion, tipoAcceso, idAcceso, passAcceso) values " +
                                        "('{0}','{1}','{2}','{3}','{4}');",
                                        rutCliente,
                                        descripcion,
                                        tipoAcceso,
                                        IdAsociado,
                                        PassAsociado);

            MySql.ejecutaQuery(insert);

            //Update tabla
            UpdateTabla();

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Captura los datos de los TextBox
            int id = Int32.Parse(this.dgvAccesos.CurrentRow.Cells[0].Value.ToString());
            string descripcion = txtDescripcion.Text;
            string tipoAcceso = cbTipoAcceso.Text;
            string IdAsociado = txtId.Text;
            string PassAsociado = txtPass.Text;


            //Encripta ID y Pass Asociado
            IdAsociado = Seguridad.Encriptar(IdAsociado);
            PassAsociado = Seguridad.Encriptar(PassAsociado);

            //Graba MySQL
            string update = string.Format("update accesos set descripcion  = '{0}', tipoAcceso  = '{1}', idAcceso  = '{2}', passAcceso = '{3}'" +
                                        " where id = {4};",
                                        descripcion,
                                        tipoAcceso,
                                        IdAsociado,
                                        PassAsociado,
                                        id);

            MySql.ejecutaQuery(update);

            //Update tabla
            UpdateTabla();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Borra la fila seleccionada (pregunta primero)

            //Update tabla
            UpdateTabla();

        }
        private void btnCpId_Click(object sender, EventArgs e)
        {
            //Envía al portapapeles el campo ID
        }

        private void btnCpPass_Click(object sender, EventArgs e)
        {
            //Envia al portapapeles el campo password
        }

        private void dgvAccesos_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Filtrar las credenciales
            //(dataGridViewFields.DataSource as DataTable).DefaultView.RowFilter = string.Format("Field = '{0}'", textBoxFilter.Text);
            //Fuente: https://stackoverflow.com/questions/5843537/filtering-datagridview-without-changing-datasource
        }
    }
}
