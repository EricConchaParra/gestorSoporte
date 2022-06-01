using MySql.Data.MySqlClient;
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
    public partial class Cliente : Form
    {
        public Cliente(string accion1, string rut1)
        {
            InitializeComponent();
            accion = accion1;
            rut = rut1;
        }

        public string accion;
        public string rut;
        
        private void Cliente_Load(object sender, EventArgs e)
        {

            //Llenar ComoBox de Funcionarios con Consulta a BD
            DataTable funcionarios = MySql.VerFuncionarios();
            cbFuncionario.DisplayMember = "nombre";
            cbFuncionario.ValueMember = "id";
            cbFuncionario.DataSource = funcionarios;

            //Llenar ComboBox de Estados, con los unicos 2 estados posibles
            DataTable dtEstado = new DataTable();
            dtEstado.Columns.Add("cod");
            dtEstado.Columns.Add("estado");

            DataRow row = dtEstado.NewRow();
            row["cod"] = "1";
            row["estado"] = "Activo";
            dtEstado.Rows.Add(row);

            DataRow row1 = dtEstado.NewRow();
            row1["cod"] = "0";
            row1["estado"] = "Inactivo";
            dtEstado.Rows.Add(row1);

            DataRow row2 = dtEstado.NewRow();
            row2["cod"] = "2";
            row2["estado"] = "Con Observaciones";
            dtEstado.Rows.Add(row2);

            cbActivo.DisplayMember = "estado";
            cbActivo.ValueMember = "cod";
            cbActivo.DataSource = dtEstado;

            //Llenar ComboBox de ASSM, con los unicos 2 estados posibles
            DataTable dtASSM = new DataTable();
            dtASSM.Columns.Add("cod");
            dtASSM.Columns.Add("estado");

            DataRow rASSM = dtASSM.NewRow();
            rASSM["cod"] = "1";
            rASSM["estado"] = "Vigente";
            dtASSM.Rows.Add(rASSM);

            DataRow rASSM1 = dtASSM.NewRow();
            rASSM1["cod"] = "0";
            rASSM1["estado"] = "No Contratado";
            dtASSM.Rows.Add(rASSM1);

            DataRow rASSM2 = dtASSM.NewRow();
            rASSM2["cod"] = "2";
            rASSM2["estado"] = "Descontinuado";
            dtASSM.Rows.Add(rASSM2);

            cbASSM.DisplayMember = "estado";
            cbASSM.ValueMember = "cod";
            cbASSM.DataSource = dtASSM;


            if (accion == "new")
            {
                tmModificar.Enabled = false;
                tmModificar.Visible = false;
                checkCampos();
            }

            else if(accion == "edit")
            {
                tmCrear.Enabled = false;
                tmCrear.Visible = false;
                EditaCliente();
            }

            else if (accion == "edit_from_controlpanel")
            {
                tmCrear.Enabled = false;
                tmCrear.Visible = false;
                EditaCliente();
            }


        }

        //Aquí llena los campos con los datos que existen
        public void EditaCliente()
        {
            txtRut.Enabled = false;
            //alerta.aviso("", "Cargando Datos...!");

            DataRow cliData = SelCliente.DataCliente;

            if(accion == "edit_from_controlpanel")
            {
                DataTable cd = new DataTable();
                cd = MySql.DatosCliente(rut);
                cliData = cd.Rows[0];
            }

            txtRut.Text = cliData["rut"].ToString();
            txtRazonSocial.Text = cliData["razon_social"].ToString();
            txtFantasia.Text = cliData["fantasia"].ToString();
            txtComercial.Text = cliData["c_comercial"].ToString();
            txtTecnico.Text = cliData["c_tecnico"].ToString();
            txtAdministrador.Text = cliData["c_adm_sistema"].ToString();
            txtNotas.Text = Seguridad.DesEncriptar(cliData["notas"].ToString());
            cbFuncionario.SelectedValue = cliData["funcionario"].ToString();
            cbASSM.SelectedValue = cliData["assm"].ToString();
            txtGDrive.Text = cliData["gdrive"].ToString();

            if (cliData["erp"].ToString() == "1")
            {
                ckErp.Checked = true;
                //erp fecha "erp_fecha_actual"
                DateTime erp_actual = DateTime.Parse(cliData["erp_fecha_actual"].ToString());
                dateErp.Value = erp_actual;
            }

            if (cliData["dte"].ToString() == "1")
            {
                ckDte.Checked = true;
                //Fecha Vencimiento certificado digital
                DateTime cert_vencimiento = DateTime.Parse(cliData["cert_vencimiento"].ToString());
                dateCertificado.Value = cert_vencimiento;
                //dte_ fecha_actual
                DateTime dte_fecha_actual = DateTime.Parse(cliData["dte_fecha_actual"].ToString());
                dateDte.Value = dte_fecha_actual;

            }
            txtUserSII.Text = cliData["cert_autorizado"].ToString();
            if (cliData["hosting"].ToString() == "1")
            {
                ckHosting.Checked = true;
                //hosting_fecha_vence
                DateTime hosting_vence = DateTime.Parse(cliData["hosting_fecha_vence"].ToString());
                dateHosting.Value = hosting_vence;

            }
            cbActivo.SelectedValue = cliData["activo"].ToString();
            checkCampos();

        }

        private void checkCampos()
        {
            //Activa/Inactiva fechas de acuerdo a checkbox
            if (ckErp.Checked == true)
            {
                dateErp.Visible = true;
            }
            else
            {
                dateErp.Visible = false;
            }

            if (ckDte.Checked == true)
            {
                dateDte.Visible = true;
                txtUserSII.Enabled = true;
                dateCertificado.Visible = true;
            }
            else
            {
                dateDte.Visible = false;
                txtUserSII.Enabled = false;
                dateCertificado.Visible = false;
            }

            if (ckHosting.Checked == true)
            {
                dateHosting.Visible = true;
            }
            else
            {
                dateHosting.Visible = false;
            }
        }


        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmCrear_Click(object sender, EventArgs e)
        {
            //alerta.aviso("", "Estas creando");
            //Cargar todos los datos en varaibles
            string rut = txtRut.Text;
            string razon_social = txtRazonSocial.Text;
            string fantasia = txtFantasia.Text;
            string c_comercial = txtComercial.Text;
            string c_tecnico = txtTecnico.Text;
            string c_adm_sistema = txtAdministrador.Text;
            string notas = Seguridad.Encriptar(txtNotas.Text);
            string funcionario = cbFuncionario.SelectedValue.ToString();
            string assm = cbASSM.SelectedValue.ToString();
            string gdrive = txtGDrive.Text;
            string erp = ckErp.Checked == true ? "1" : "0";
            string erp_fecha_actual = dateErp.Value.ToString("yyyy-MM-dd");
            string dte = ckDte.Checked == true ? "1" : "0";
            string cert_autorizado = txtUserSII.Text;
            string cert_vencimiento = dateCertificado.Value.ToString("yyyy-MM-dd");
            string dte_fecha_actual = dateDte.Value.ToString("yyyy-MM-dd");
            string hosting = ckHosting.Checked == true ? "1" : "0";
            string hosting_fecha_vence = dateHosting.Value.ToString("yyyy-MM-dd");
            string activo = cbActivo.SelectedValue.ToString();

            //Graba los datos en MySQL

            //trae los datos de conexion, dependiendo de donde sea
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            string sCmd = string.Format("insert into clientes" +
                " (rut, razon_social, fantasia, c_comercial, c_tecnico, c_adm_sistema, notas, funcionario, assm, gdrive, " +
                "erp, erp_fecha_actual, dte, cert_autorizado, cert_vencimiento, dte_fecha_actual, hosting, hosting_fecha_vence, activo) " +
                "values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}');",
                rut,
                razon_social,
                fantasia,
                c_comercial,
                c_tecnico,
                c_adm_sistema,
                notas,
                funcionario,
                assm,
                gdrive,
                erp,
                erp_fecha_actual,
                dte,
                cert_autorizado,
                cert_vencimiento,
                dte_fecha_actual,
                hosting,
                hosting_fecha_vence,
                activo);

            //alerta.error("", sCmd);

            MySqlCommand cmd = new MySqlCommand(sCmd, cn);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                cn.Close();
                this.Close();
            }

        }

        private void tmModificar_Click(object sender, EventArgs e)
        {
            //alerta.aviso("", "Estas modificando");
            string rut = txtRut.Text;
            string razon_social = txtRazonSocial.Text;
            string fantasia = txtFantasia.Text;
            string c_comercial = txtComercial.Text;
            string c_tecnico = txtTecnico.Text;
            string c_adm_sistema = txtAdministrador.Text;
            string notas = Seguridad.Encriptar(txtNotas.Text);
            string funcionario = cbFuncionario.SelectedValue.ToString();
            string assm = cbASSM.SelectedValue.ToString();
            string gdrive = txtGDrive.Text;
            string erp = ckErp.Checked == true ? "1" : "0";
            string erp_fecha_actual = dateErp.Value.ToString("yyyy-MM-dd");
            string dte = ckDte.Checked == true ? "1" : "0";
            string cert_autorizado = txtUserSII.Text;
            string cert_vencimiento = dateCertificado.Value.ToString("yyyy-MM-dd");
            string dte_fecha_actual = dateDte.Value.ToString("yyyy-MM-dd");
            string hosting = ckHosting.Checked == true ? "1" : "0";
            string hosting_fecha_vence = dateHosting.Value.ToString("yyyy-MM-dd");
            string activo = cbActivo.SelectedValue.ToString();

            //Graba los datos en MySQL

            //trae los datos de conexion, dependiendo de donde sea
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            string sCmd = string.Format("update clientes" +
                " set razon_social = '{1}', fantasia = '{2}', c_comercial = '{3}', c_tecnico = '{4}', c_adm_sistema = '{5}', notas = '{6}', funcionario = '{7}', " +
                " assm = '{8}', gdrive = '{9}', erp = '{10}', erp_fecha_actual = '{11}', dte = '{12}', cert_autorizado = '{13}'," +
                " cert_vencimiento = '{14}', dte_fecha_actual = '{15}', hosting = '{16}', hosting_fecha_vence = '{17}', activo = '{18}' " +
                " where rut = '{0}'",
                rut,
                razon_social,
                fantasia,
                c_comercial,
                c_tecnico,
                c_adm_sistema,
                notas,
                funcionario,
                assm,
                gdrive,
                erp,
                erp_fecha_actual,
                dte,
                cert_autorizado,
                cert_vencimiento,
                dte_fecha_actual,
                hosting,
                hosting_fecha_vence,
                activo);

            //alerta.informacion("", sCmd);

            MySqlCommand cmd = new MySqlCommand(sCmd, cn);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                cn.Close();
            }
            this.Close();
        }

        private void ckErp_CheckedChanged(object sender, EventArgs e)
        {
            if(ckErp.Checked == true)
            {
                dateErp.Visible = true;
            }
            else
            {
                dateErp.Visible = false;
            }

        }

        private void ckDte_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDte.Checked == true)
            {
                dateDte.Visible = true;
                txtUserSII.Enabled = true;
                dateCertificado.Visible = true;
            }

            else
            {
                dateDte.Visible = false;
                txtUserSII.Enabled = false;
                dateCertificado.Visible = false;
            }
        }

        private void ckHosting_CheckedChanged(object sender, EventArgs e)
        {
            if (ckHosting.Checked == true)
            {
                dateHosting.Visible = true;
            }
            else
            {
                dateHosting.Visible = false;
            }
        }
    }
}
