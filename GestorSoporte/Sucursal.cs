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
    public partial class Sucursal : Form
    {
        public Sucursal(string accion1, string rut_cliente1, string id_sucursal1)
        {
            InitializeComponent();
            accion = accion1;
            rut_cliente = rut_cliente1;
            id_sucursal = id_sucursal1;
        }

        public string accion;
        public string rut_cliente;
        public string id_sucursal;
        
        private void Sucursal_Load(object sender, EventArgs e)
        {
            //Llenar ComboBox de Estados, con los unicos 2 estados posibles
            //SSH
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

            cbSsh.DisplayMember = "estado";
            cbSsh.ValueMember = "cod";
            cbSsh.DataSource = dtEstado;

            //SshRoot
            DataTable dtSshRoot = new DataTable();
            dtSshRoot.Columns.Add("cod");
            dtSshRoot.Columns.Add("estado");

            DataRow rowSshRoot = dtSshRoot.NewRow();
            rowSshRoot["cod"] = "1";
            rowSshRoot["estado"] = "Activo";
            dtSshRoot.Rows.Add(rowSshRoot);

            DataRow rowSshRoot1 = dtSshRoot.NewRow();
            rowSshRoot1["cod"] = "0";
            rowSshRoot1["estado"] = "Inactivo";
            dtSshRoot.Rows.Add(rowSshRoot1);

            cbSshRoot.DisplayMember = "estado";
            cbSshRoot.ValueMember = "cod";
            cbSshRoot.DataSource = dtSshRoot;

            //Mysql
            DataTable dtMysql = new DataTable();
            dtMysql.Columns.Add("cod");
            dtMysql.Columns.Add("estado");

            DataRow rowMysql = dtMysql.NewRow();
            rowMysql["cod"] = "1";
            rowMysql["estado"] = "Activo";
            dtMysql.Rows.Add(rowMysql);

            DataRow rowMysql1 = dtMysql.NewRow();
            rowMysql1["cod"] = "0";
            rowMysql1["estado"] = "Inactivo";
            dtMysql.Rows.Add(rowMysql1);

            cbMysql.DisplayMember = "estado";
            cbMysql.ValueMember = "cod";
            cbMysql.DataSource = dtMysql;


            //GestorDTE
            DataTable dtGestorDte = new DataTable();
            dtGestorDte.Columns.Add("cod");
            dtGestorDte.Columns.Add("estado");

            DataRow rowGestorDte = dtGestorDte.NewRow();
            rowGestorDte["cod"] = "1";
            rowGestorDte["estado"] = "Activo";
            dtGestorDte.Rows.Add(rowGestorDte);

            DataRow rowGestorDte1 = dtGestorDte.NewRow();
            rowGestorDte1["cod"] = "0";
            rowGestorDte1["estado"] = "Inactivo";
            dtGestorDte.Rows.Add(rowGestorDte1);

            cbGestorDte.DisplayMember = "estado";
            cbGestorDte.ValueMember = "cod";
            cbGestorDte.DataSource = dtGestorDte;

            //Ticket de Soporte
            DataTable dtTicket = new DataTable();
            dtTicket.Columns.Add("cod");
            dtTicket.Columns.Add("estado");

            DataRow rowTicket = dtTicket.NewRow();
            rowTicket["cod"] = "1";
            rowTicket["estado"] = "Activo";
            dtTicket.Rows.Add(rowTicket);

            DataRow rowTicket1 = dtTicket.NewRow();
            rowTicket1["cod"] = "0";
            rowTicket1["estado"] = "Inactivo";
            dtTicket.Rows.Add(rowTicket1);

            cbTicket.DisplayMember = "estado";
            cbTicket.ValueMember = "cod";
            cbTicket.DataSource = dtTicket;



            if (accion == "new")
            {
                //alerta.informacion("", "Nuevo!!");
                tsmModificar.Visible = false;
                CargaNew();
            }

            else if (accion == "edit")
            {
                //alerta.informacion("", "Editando!");
                tsmCrear.Visible = false;
                CargaEdit();
            }

            else
            {
                alerta.error("Error", "Acción Desconocida!");
            }

        }


        private void CargaNew()
        {
            DataTable dtCliente = new DataTable();
            dtCliente = MySql.DatosCliente(rut_cliente);
            DataRow cliente = dtCliente.Rows[0];
            dtCliente = MySql.DatosCliente(rut_cliente);
            txtEmpresa.Text = cliente["fantasia"].ToString();
            txtEmpresa.Enabled = false;
            txtSucursalCorrel.Text = (MySql.CuentaSucursalesCliente(rut_cliente) + 1).ToString();
            txtSucursalCorrel.Enabled = false;
        }

        private void CargaEdit()
        {
            DataTable dtCliente = new DataTable();
            dtCliente = MySql.DatosCliente(rut_cliente);
            DataRow cliente = dtCliente.Rows[0];
            dtCliente = MySql.DatosCliente(rut_cliente);
            txtEmpresa.Text = cliente["fantasia"].ToString();
            txtEmpresa.Enabled = false;

            //Datos de la sucursal
            DataTable dtSucursal = new DataTable();
            dtSucursal = MySql.DatosSucursal(id_sucursal);
            DataRow sucursal = dtSucursal.Rows[0];
            sucursal = Seguridad.sucDataDesEncripta(sucursal);

            //Llenar los campos con los datos de sucursal
            //Identificacion
            txtSucursalCorrel.Text = sucursal["sucursal_correl"].ToString();
            txtSucursalCorrel.Enabled = false;
            txtSucNombre.Text = sucursal["sucursal_nombre"].ToString();
            txtIP.Text = sucursal["ip"].ToString();
            //SSH
            cbSsh.SelectedValue = sucursal["ssh"].ToString();
            cbSshRoot.SelectedValue = sucursal["root_access"].ToString();
            txtRootUser.Text = sucursal["root_user"].ToString();
            txtRootPass.Text = sucursal["root_pass"].ToString();
            txtRegularUser.Text = sucursal["regular_user"].ToString();
            txtRegularPass.Text = sucursal["regular_pass"].ToString();
            txtPuertoSsh.Text = sucursal["puerto_ssh"].ToString();
            //MySQL
            cbMysql.SelectedValue = sucursal["mysql"].ToString();
            txtPuertoMysql.Text = sucursal["puerto_mysql"].ToString();
            txtMysqlRootUser.Text = sucursal["root_user_mysql"].ToString();
            txtMysqlRootPass.Text = sucursal["root_pass_mysql"].ToString();
            txtMysqlAccesoUser.Text = sucursal["acceso_user_mysql"].ToString();
            txtMysqlAccesoPass.Text = sucursal["acceso_pass_mysql"].ToString();
            txtDteDb.Text = sucursal["dte_db_mysql"].ToString();
            txtErpDb.Text = sucursal["erp_db_mysql"].ToString();
            //Gestor DTE
            cbGestorDte.SelectedValue = sucursal["gestor_dte"].ToString();
            txtPuertoPlay.Text = sucursal["puerto_play"].ToString();
            txtGestorDteUser.Text = sucursal["gestor_dte_user"].ToString();
            txtGestorDtePass.Text = sucursal["gestor_dte_pass"].ToString();
            txtRutaPlay.Text = sucursal["play_path"].ToString();
            txtRutaGestorDte.Text = sucursal["dte_path"].ToString();
            txtIdScreen.Text = sucursal["screen_id"].ToString();
            txtEspera.Text = sucursal["seg_espera"].ToString();
            //Ticket de Soporte
            cbTicket.SelectedValue = sucursal["ticket"].ToString();
            txtUrlTicket.Text = sucursal["ticket_url"].ToString();
            txtTicketUser.Text = sucursal["ticket_user"].ToString();
            txtTicketPass.Text = sucursal["ticket_pass"].ToString();
        }



        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EscribeDB("new");
        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmModificar_Click(object sender, EventArgs e)
        {
            EscribeDB("edit");
        }

        private void EscribeDB(string accion)
        {
            //Llenar los campos con los datos de sucursal
            //Identificacion
            string sucursal_correl = txtSucursalCorrel.Text;
            string sucursal_nombre = txtSucNombre.Text;
            string ip = Seguridad.Encriptar(txtIP.Text);
            //SSH
            string ssh = cbSsh.SelectedValue.ToString();
            string root_access = cbSshRoot.SelectedValue.ToString();
            string root_user = Seguridad.Encriptar(txtRootUser.Text);
            string root_pass = Seguridad.Encriptar(txtRootPass.Text);
            string regular_user = Seguridad.Encriptar(txtRegularUser.Text);
            string regular_pass = Seguridad.Encriptar(txtRegularPass.Text);
            string puerto_ssh = txtPuertoSsh.Text;
            //MySQL
            string mysql = cbMysql.SelectedValue.ToString();
            string puerto_mysql = txtPuertoMysql.Text;
            string root_user_mysql = Seguridad.Encriptar(txtMysqlRootUser.Text);
            string root_pass_mysql = Seguridad.Encriptar(txtMysqlRootPass.Text);
            string acceso_user_mysql = Seguridad.Encriptar(txtMysqlAccesoUser.Text);
            string acceso_pass_mysql = Seguridad.Encriptar(txtMysqlAccesoPass.Text);
            string dte_db_mysql = txtDteDb.Text;
            string erp_db_mysql = txtErpDb.Text;
            //Gestor DTE
            string gestor_dte = cbGestorDte.SelectedValue.ToString();
            string puerto_play = txtPuertoPlay.Text;
            string gestor_dte_user = Seguridad.Encriptar(txtGestorDteUser.Text);
            string gestor_dte_pass = Seguridad.Encriptar(txtGestorDtePass.Text);
            string play_path = txtRutaPlay.Text;
            string dte_path = txtRutaGestorDte.Text;
            string screen_id = txtIdScreen.Text;
            string seg_espera = txtEspera.Text;
            //Gestor DTE
            string ticket = cbTicket.SelectedValue.ToString();
            string ticket_url = txtUrlTicket.Text;
            string ticket_user = txtTicketUser.Text;
            string ticket_pass = txtTicketPass.Text;


            //Graba los datos en MySQL

            //trae los datos de conexion, dependiendo de donde sea
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            string sCmd = "";
            
            if(accion == "new")
            {
                sCmd = string.Format("INSERT INTO sucursales" +
                    " (" +
                    " fk_cliente," +
                    " sucursal_correl," +
                    " sucursal_nombre," +
                    " ip," +
                    " ssh," +
                    " root_access," +
                    " root_user," +
                    " root_pass," +
                    " regular_user," +
                    " regular_pass," +
                    " puerto_ssh," +
                    " mysql," +
                    " puerto_mysql," +
                    " root_user_mysql," +
                    " root_pass_mysql," +
                    " acceso_user_mysql," +
                    " acceso_pass_mysql," +
                    " dte_db_mysql," +
                    " erp_db_mysql," +
                    " gestor_dte," +
                    " gestor_dte_user," +
                    " gestor_dte_pass," +
                    " play_path," +
                    " dte_path," +
                    " screen_id," +
                    " puerto_play," +
                    " seg_espera," +
                    " ticket," +
                    " ticket_url," +
                    " ticket_user," +
                    " ticket_pass)" +
                    " VALUES" +
                    " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}'," +
                    " '{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}');", 
                    rut_cliente,
                    sucursal_correl,
                    sucursal_nombre,
                    ip,
                    ssh,
                    root_access,
                    root_user,
                    root_pass,
                    regular_user,
                    regular_pass,
                    puerto_ssh,
                    mysql,
                    puerto_mysql,
                    root_user_mysql,
                    root_pass_mysql,
                    acceso_user_mysql,
                    acceso_pass_mysql,
                    dte_db_mysql,
                    erp_db_mysql,
                    gestor_dte,
                    gestor_dte_user,
                    gestor_dte_pass,
                    play_path,
                    dte_path,
                    screen_id,
                    puerto_play,
                    seg_espera,
                    ticket,
                    ticket_url,
                    ticket_user,
                    ticket_pass);


            }
            else if (accion == "edit")
            {
                sCmd = string.Format("update sucursales" +
                    " set sucursal_nombre = '{0}'," +
                    " ip = '{1}'," +
                    " ssh = '{2}'," +
                    " root_access = '{3}'," +
                    " root_user = '{4}'," +
                    " root_pass = '{5}'," +
                    " regular_user = '{6}'," +
                    " regular_pass = '{7}'," +
                    " puerto_ssh = '{8}'," +
                    " mysql = '{9}'," +
                    " puerto_mysql = '{10}'," +
                    " root_user_mysql = '{11}'," +
                    " root_pass_mysql = '{12}'," +
                    " acceso_user_mysql = '{13}'," +
                    " acceso_pass_mysql = '{14}'," +
                    " dte_db_mysql = '{15}'," +
                    " erp_db_mysql = '{16}'," +
                    " gestor_dte = '{17}'," +
                    " gestor_dte_user = '{18}'," +
                    " gestor_dte_pass = '{19}'," +
                    " play_path ='{20}'," +
                    " dte_path = '{21}'," +
                    " screen_id = '{22}'," +
                    " puerto_play = '{23}'," +
                    " seg_espera = '{24}'," +
                    " ticket = '{25}'," +
                    " ticket_url = '{26}'," +
                    " ticket_user = '{27}'," +
                    " ticket_pass = '{28}'" +
                    " where id = '{29}';",
                    sucursal_nombre,
                    ip,
                    ssh,
                    root_access,
                    root_user,
                    root_pass,
                    regular_user,
                    regular_pass,
                    puerto_ssh,
                    mysql,
                    puerto_mysql,
                    root_user_mysql,
                    root_pass_mysql,
                    acceso_user_mysql,
                    acceso_pass_mysql,
                    dte_db_mysql,
                    erp_db_mysql,
                    gestor_dte,
                    gestor_dte_user,
                    gestor_dte_pass,
                    play_path,
                    dte_path,
                    screen_id,
                    puerto_play,
                    seg_espera,
                    ticket,
                    ticket_url,
                    ticket_user,
                    ticket_pass,
                    id_sucursal);
             
            }

            //alerta.error("",sCmd);
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
    }
    }


