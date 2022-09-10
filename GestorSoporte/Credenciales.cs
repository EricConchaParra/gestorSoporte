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
        public bool isNew = false;
        DataTable accesos = new DataTable();

        //Crea un bindingSource
        BindingSource bs = new BindingSource();

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
            //Get data from MySQL
            accesos = MySql.VerAccesos(rutCliente);

            //Asigna el DataTable al BS
            bs.DataSource = accesos;

            //Vincular a DGV
            dgvAccesos.DataSource = bs;

            //Darle formato a la tabla (ancho de columnas) TODO
            dgvAccesos.Columns[0].Visible = false;

            dgvAccesos.Columns[1].Visible = false;

            dgvAccesos.Columns[2].HeaderText = "Descripción";
            dgvAccesos.Columns[2].Width = 170;

            dgvAccesos.Columns[3].HeaderText = "Tipo Acceso";
            dgvAccesos.Columns[3].Width = 100;

            dgvAccesos.Columns[4].Visible = false;
            dgvAccesos.Columns[5].Visible = false;
            dgvAccesos.Columns[6].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Trae datos de fila seleccionada
            try
            {
                txtId.Text = Seguridad.DesEncriptar(this.dgvAccesos.CurrentRow.Cells[4].Value.ToString());
                traeDatos();
            }
            catch
            {
                //nada
            }
        }

        private void traeDatos()
        {
            txtDescripcion.Text = this.dgvAccesos.CurrentRow.Cells[2].Value.ToString();
            txtId.Text = Seguridad.DesEncriptar(this.dgvAccesos.CurrentRow.Cells[4].Value.ToString());
            txtPass.Text = Seguridad.DesEncriptar(this.dgvAccesos.CurrentRow.Cells[5].Value.ToString());
            txtUrl.Text = Seguridad.DesEncriptar(this.dgvAccesos.CurrentRow.Cells[6].Value.ToString());
            cbTipoAcceso.SelectedValue = this.dgvAccesos.CurrentRow.Cells[3].Value.ToString();

            if (txtUrl.Text == "")
            {
                btnCpUrl.Enabled = false;
            }
            else
            {
                btnCpUrl.Enabled = true;
            }
                
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Captura los datos de los TextBox
            string descripcion = txtDescripcion.Text;
            string tipoAcceso = cbTipoAcceso.Text;
            string IdAsociado = txtId.Text;
            string PassAsociado = txtPass.Text;
            string Url = txtUrl.Text;

            if (descripcion == "")
            {
                alerta.error("Error", "No puedes agregar una descripción vacía");
                return;
            }

            //Encripta ID,  Pass Asociado y URL
            IdAsociado = Seguridad.Encriptar(IdAsociado);
            PassAsociado = Seguridad.Encriptar(PassAsociado);
            Url = Seguridad.Encriptar(Url);

            //Graba MySQL
            string insert = string.Format("insert into accesos (fkcliente, descripcion, tipoAcceso, idAcceso, passAcceso, url) values " +
                                        "('{0}','{1}','{2}','{3}','{4}','{5}');",
                                        rutCliente,
                                        descripcion,
                                        tipoAcceso,
                                        IdAsociado,
                                        PassAsociado,
                                        Url);

            MySql.ejecutaQuery(insert);

            UpdateTabla();
            limpiaTxt();

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id = 0;            
            try
            {
                id = Int32.Parse(this.dgvAccesos.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
                return;
            }
                
            //Modifica la fila seleccionada (pregunta primero)
            DialogResult respuesta = MessageBox.Show("¿Desea sobreescribir esta credencial?",
                                            "Confirme",
                                            MessageBoxButtons.OKCancel,
                                            MessageBoxIcon.Question);

            if (DialogResult.OK != respuesta)
            {
                return;
            }

            //Captura los datos de los TextBox
            id = Int32.Parse(this.dgvAccesos.CurrentRow.Cells[0].Value.ToString());
            string descripcion = txtDescripcion.Text;
            string tipoAcceso = cbTipoAcceso.Text;
            string IdAsociado = txtId.Text;
            string PassAsociado = txtPass.Text;
            string Url = txtUrl.Text;


            //Encripta ID y Pass Asociado
            IdAsociado = Seguridad.Encriptar(IdAsociado);
            PassAsociado = Seguridad.Encriptar(PassAsociado);
            Url = Seguridad.Encriptar(Url);

            //Graba MySQL
            string update = string.Format("update accesos set descripcion  = '{0}', tipoAcceso  = '{1}', idAcceso  = '{2}', passAcceso = '{3}'," +
                                        " url = '{4}'" +
                                        " where id = {5};",
                                        descripcion,
                                        tipoAcceso,
                                        IdAsociado,
                                        PassAsociado,
                                        Url,
                                        id);

            MySql.ejecutaQuery(update);

            //Update tabla
            UpdateTabla();
            limpiaTxt();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int idReg = Int32.Parse(this.dgvAccesos.CurrentRow.Cells[0].Value.ToString());
                //Borra la fila seleccionada (pregunta primero)
                DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar esta fila?",
                                                "Confirme",
                                                MessageBoxButtons.OKCancel,
                                                MessageBoxIcon.Question);

                if (respuesta == DialogResult.OK)
                {
                    MySql.BorraCredencial(idReg);
                }


                //Update tabla
                UpdateTabla();
                limpiaTxt();
            }
            catch
            {
                return;
            }

        }

        private void limpiaTxt()
        {
            //Limpiar textboxes
            txtDescripcion.Text = "";
            txtId.Text = "";
            txtPass.Text = "";
            txtUrl.Text = "";

        }
        private void btnCpId_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtId.Text);
        }

        private void btnCpPass_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPass.Text);
        }

        private void dgvAccesos_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Filtrar las credenciales
            bs.Filter = string.Format("descripcion LIKE '%{0}%' or tipoAcceso LIKE '%{0}%'", txtBusqueda.Text);

            //Fuente: https://stackoverflow.com/questions/5843537/filtering-datagridview-without-changing-datasource
        }

        private void btnCpUrl_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(txtUrl.Text);
            Clipboard.SetText(txtUrl.Text);
        }

        private void dgvAccesos_SelectionChanged(object sender, EventArgs e)
        {
            traeDatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiaTxt();
        }
    }
}
