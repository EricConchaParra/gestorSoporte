using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSoporte
{
    public partial class controlPanel : Form
    {


        public controlPanel(DataRow sucData1)
        {
            InitializeComponent();
            sucData = sucData1;

        }

        public DataRow sucData;
        public bool graboNota = true;
        public string rut;
        public string gdrive;

        private void btnMysql_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                alerta.informacion("Información", "Opciones disponibles con clic derecho del mouse");
            }
        }

        private void controlPanel_Load(object sender, EventArgs e)
        {
            Carga();
        }

        private void Carga()
        {

            //Asigno el titutlo del form
            this.Text = sucData["sucursal_nombre"].ToString() + " - " + sucData["ip"].ToString();

            //cargo las notas
            txtNotasCliente.Text = Seguridad.DesEncriptar(MySql.verNotasCliente(sucData["fk_cliente"].ToString()));

            //Cargo los datos del cliente, no de la sucursal, en un datatable
            DataTable dtContacto = new DataTable();
            dtContacto = MySql.DatosCliente(sucData["fk_cliente"].ToString());

            //me traigo la primera fila
            DataRow cont = dtContacto.Rows[0];

            //Datos de contacto
            txtCComercial.Text = cont["c_comercial"].ToString();
            txtCTecnico.Text = cont["c_tecnico"].ToString();
            txtAdministrador.Text = cont["c_adm_sistema"].ToString();

            //Datos de RUT y URL GDrive hechos publicos
            rut = cont["rut"].ToString();
            gdrive = cont["gdrive"].ToString();

            //Verifica accesos y cierra lo que esté bloqueado
            if (sucData["mysql"].ToString() == "0")
            {
                btnMysql.Enabled = false;
                consultasSQLToolStripMenuItem.Visible = false;
            }

            if (sucData["ssh"].ToString() == "0")
            {
                btnSsh.Enabled = false;
                btnWinScp.Enabled = false;
                btnCups.Enabled = false;
                btnWebmin.Enabled = false;
                btnPhpmyadmin.Enabled = false;
                btnHelpSsh.Enabled = false;
                btnCmd.Enabled = false;
            }

            if (sucData["gestor_dte"].ToString() == "0")
            {
                btnPlayRun.Enabled = false;
                btnPlayStop.Enabled = false;
                btnGestorDTE.Enabled = false;
            }

            if (sucData["ticket"].ToString() == "0")
            {
                ticketDeSoporteToolStripMenuItem.Visible = false;
            }

            if (cont["assm"].ToString() == "1")
            {
                lbAssm.Text = "Vigente";
                lbAssm.ForeColor = System.Drawing.Color.Green;
            }

            else if (cont["assm"].ToString() == "0")
            {
                lbAssm.Text = "No Contratado";
                lbAssm.ForeColor = System.Drawing.Color.Purple;
            }

            else if (cont["assm"].ToString() == "2")
            {
                lbAssm.Text = "Descontinuado";
                lbAssm.ForeColor = System.Drawing.Color.Red;
            }


            if (String.IsNullOrEmpty(cont["gdrive"].ToString()))
            {
                carpetaGDriveToolStripMenuItem.Visible = false;
            }

            if(cont["dte"].ToString() == "0")
            {
                gbAccionSII.Enabled = false;
                lbUsu.Visible = false;
                lbUsuarioSII.Visible = false;
                lbCert.Visible = false;
                lbCertFecha.Visible = false;
                dTEToolStripMenuItem.Visible = false;
                tsmAnalisisFolios.Visible = false;

            }

            if (cont["erp"].ToString() == "0")
            {
                eRPToolStripMenuItem.Visible = false;
            }

            //Verifica si el nivel de usuario es "normal", para quitar accesos adicionales
            
            //Obtengo datos del usuario que inició sesion
            string[] datos_usuario = SelConnection.datos_usuario;
            /*
            datos_usuario[0] = nivel_usuario;
            datos_usuario[1] = nombre_usuario;
            datos_usuario[2] = id_sucursal;
            */


            if (datos_usuario[0] == "2")
            {
                btnMysql.Enabled = false;
                consultasSQLToolStripMenuItem.Visible = false;
                btnSsh.Enabled = false;
                btnWinScp.Enabled = false;
                btnCups.Enabled = false;
                btnWebmin.Enabled = false;
                btnPhpmyadmin.Enabled = false;
                btnHelpSsh.Enabled = false;
                btnCmd.Enabled = false;
                sucursalToolStripMenuItem.Visible = false;
                btnGrabaNota.Enabled = false;
            }

            //Carga Enlaces SII
            DataTable enlaces = new DataTable();
            enlaces = MySql.VerEnlances();
            cbEnlace.DisplayMember = "nombre";
            cbEnlace.ValueMember = "url";
            cbEnlace.DataSource = enlaces;

            //FEchas de vencimiento de Servicios y Cert Digital
            lbUsuarioSII.Text = cont["cert_autorizado"].ToString();
            DateTime cert_vencimiento = DateTime.Parse(cont["cert_vencimiento"].ToString());
            DateTime erp_fecha_actual = DateTime.Parse(cont["erp_fecha_actual"].ToString());
            DateTime dte_fecha_actual = DateTime.Parse(cont["dte_fecha_actual"].ToString());
            DateTime hosting_fecha_vence = DateTime.Parse(cont["hosting_fecha_vence"].ToString());

            lbCert.Text = cert_vencimiento.ToString("dd-MM-yyyy");
            lbErp.Text = cont["erp"].ToString() == "1" ? "Si (" + erp_fecha_actual.ToString("dd-MM-yyyy") + ")" : "No";
            lbDte.Text = cont["dte"].ToString() == "1" ? "Si (" + dte_fecha_actual.ToString("dd-MM-yyyy") + ")" : "No";
            lbHosting.Text = cont["hosting"].ToString() == "1" ? "Si (" + hosting_fecha_vence.ToString("dd-MM-yyyy") + ")" : "No";

            if (cont["activo"].ToString() == "2")
            {
                alerta.informacion("Atención!","Cliente presenta observaciones comerciales.\nMás información disponible en las notas.");
            }


        }

        private void btnAnalisisDte_Click(object sender, EventArgs e)
        {

        }

        private void btnGestorDTE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://" + sucData["ip"] + ":" + sucData["puerto_play"]);
        }

        private void btnCups_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://" + sucData["ip"] + ":631");
            try
            {
                Clipboard.SetDataObject(sucData["root_pass"], true);
            }

            catch (Exception err)
            {
                MessageBox.Show("Error al copiar texto al portapapeles: " +
                    Environment.NewLine + err.Message, "Error al copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPhpmyadmin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://" + sucData["ip"] + "/phpmyadmin");
            try
            {
                Clipboard.SetDataObject(sucData["root_pass"].ToString(), true);
            }

            catch (Exception err)
            {
                MessageBox.Show("Error al copiar texto al portapapeles: " +
                    Environment.NewLine + err.Message, "Error al copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWebmin_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://" + sucData["ip"] + ":10000");
            try
            {
                Clipboard.SetDataObject(sucData["root_pass"].ToString(), true);
            }

            catch (Exception err)
            {
                MessageBox.Show("Error al copiar texto al portapapeles: " +
                    Environment.NewLine + err.Message, "Error al copiar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSsh_Click(object sender, EventArgs e)
        {
            string parametros = "";
            if (sucData["root_access"].ToString() == "1")
            {
                parametros = string.Format("-ssh {0}@{1} -pw {2} -P {3}", sucData["root_user"], sucData["ip"].ToString(),
                    sucData["root_pass"].ToString(), sucData["puerto_ssh"]);
            }

            else
            {
                parametros = string.Format("-ssh {0}@{1} -pw {2} -P {3}", sucData["regular_user"].ToString(), sucData["ip"].ToString(),
                    sucData["regular_pass"], sucData["puerto_ssh"]);
                try
                {
                    Clipboard.SetDataObject(sucData["root_pass"].ToString(), true);
                }

                catch (Exception err)
                {
                    MessageBox.Show("Error al copiar texto al portapapeles: " +
                        Environment.NewLine + err.Message, "Error al copiar",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            System.Diagnostics.Process.Start("putty.exe", parametros);


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(graboNota == true)
            {
                this.Close();
            }
            else
            {
                DialogResult confirma = MessageBox.Show("Desea salir sin grabar las modificaciones a la nota?", "Responda por favor",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirma == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void verEditarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sucursal suc = new Sucursal("edit", sucData["fk_cliente"].ToString(), sucData["id"].ToString());
            suc.ShowDialog();
            Carga();
        }



        private void btnGrabaNota_Click(object sender, EventArgs e)
        {
            string nota = Seguridad.Encriptar(txtNotasCliente.Text);
            MySql.grabaNotasCliente(nota, sucData["fk_cliente"].ToString());
            graboNota = true;
        }

        private void txtNotasCliente_Click(object sender, EventArgs e)
        {
            graboNota = false;
        }

        private void btnWinScp_Click(object sender, EventArgs e)
        {
            if (sucData["root_access"].ToString() == "1")
            {
                string parametros = string.Format("scp://{0}:{1}@{2}:{3}/", sucData["root_user"], sucData["root_pass"], sucData["ip"], sucData["puerto_ssh"]);
                System.Diagnostics.Process.Start("winscp.exe", parametros);
            }
            else
            {
                string parametros = string.Format("scp://{0}:{1}@{2}:{3}/", sucData["regular_user"], sucData["regular_pass"], sucData["ip"], sucData["puerto_ssh"]);
                System.Diagnostics.Process.Start("winscp.exe", parametros);
            }
        }

        private void btnPlayRun_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
            "¿Desea iniciar el Gestor DTE en el puerto " + sucData["puerto_play"] + "?\n\n(Recuerde que una vez comenzada la operación debe esperar" +
            " a que se abra la venta del navegador).",
            "Responda por favor",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            if (respuesta == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                //Output("Iniciando Gestor DTE, por favor espere...");
                bool iniciado = estaGestorIniciado();

                if (iniciado)
                {
                    MessageBox.Show(
                    "El Gestor DTE ya está iniciado en el puerto " + sucData["puerto_play"] + "\nSi continúa con problemas, intente reiniciándolo.",
                    "Atención!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    //Output("El Gestor DTE ya está iniciado en el puerto " + puerto);
                }

                else
                {
                    // "\u0022" ==>> Comillas dobles
                    comandoSSH("screen -d -m -S " + sucData["screen_id"] + " && screen -S " + sucData["screen_id"] + " -p 0 -X stuff 'cd " + sucData["dte_path"] + " && export PATH=$PATH:" + sucData["play_path"] + " && play " + "\u0022" + "run " + sucData["puerto_play"] + "\u0022" + "\n'", false);
                    Thread.Sleep(Int32.Parse(sucData["seg_espera"].ToString()) * 1000);
                    System.Diagnostics.Process.Start("http://" + sucData["ip"] + ":" + sucData["puerto_play"]);
                    //Output("Operacion Terminada!\n");
                }
                Cursor.Current = Cursors.Default;
            }
        }

        public bool estaGestorIniciado()
        {
            string cmdUsu = "";
            string cmdPass = "";

            if (sucData["root_access"].ToString() == "1")
            {
                cmdUsu = sucData["root_user"].ToString();
                cmdPass = sucData["root_pass"].ToString();
            }

            else
            {
                cmdUsu = sucData["regular_user"].ToString();
                cmdPass = sucData["regular_pass"].ToString();
            }

            using (var ssh = new SshClient(sucData["ip"].ToString(), cmdUsu, cmdPass))
            {
                ssh.Connect();
                var responseSsh = ssh.RunCommand("screen -ls");
                var response = responseSsh.Result;
                ssh.Disconnect();
                string salida = response;
                bool existe = salida.Contains(sucData["screen_id"].ToString());
                return existe;
            }
        }


        public void comandoSSH(string comando, bool root)
        {

            string cmdUsu = "";
            string cmdPass = "";

            if (sucData["root_access"].ToString() == "1")
            {
                cmdUsu = sucData["root_user"].ToString();
                cmdPass = sucData["root_pass"].ToString();
            }

            else
            {
                cmdUsu = sucData["regular_user"].ToString();
                cmdPass = sucData["regular_pass"].ToString();
            }

            using (var ssh = new SshClient(sucData["ip"].ToString(), cmdUsu, cmdPass))
            {

                try
                {
                    ssh.Connect();
                    var responseSsh = ssh.RunCommand(comando);
                    var response = responseSsh.Result;
                    //MessageBox.Show(response);
                    ssh.Disconnect();
                    //Output(response);
                }

                catch (Exception)
                {
                    MessageBox.Show(
                    "No se puede conectar al servidor, verifique IP, Usuario y Contraseña",
                    "Alto!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

            }
        }

        public void comandoSSHShow(string comando, bool root)
        {

            string cmdUsu = "";
            string cmdPass = "";

            if (sucData["root_access"].ToString() == "1")
            {
                cmdUsu = sucData["root_user"].ToString();
                cmdPass = sucData["root_pass"].ToString();
            }

            else
            {
                cmdUsu = sucData["regular_user"].ToString();
                cmdPass = sucData["regular_pass"].ToString();
            }

            using (var ssh = new SshClient(sucData["ip"].ToString(), cmdUsu, cmdPass))
            {

                try
                {
                    ssh.Connect();
                    var responseSsh = ssh.RunCommand(comando);
                    var response = responseSsh.Result;
                    ssh.Disconnect();
                    salidaSsh sshout = new salidaSsh(response);
                    sshout.Show();
                }

                catch (Exception)
                {
                    MessageBox.Show(
                    "No se puede conectar al servidor, verifique IP, Usuario y Contraseña",
                    "Alto!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

            }
        }

        private void dTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultasSQL DC = new ConsultasSQL(sucData["id"].ToString(),"1");
            DC.ShowDialog();
        }

        private void btnPlayStop_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
            "Detener el Gestor DTE impedirá a todos los usuarios generar documentos electrónicos, dejará de procesar las respuesta del SII y de otros contribuyentes y dejará desconectada la interfaz web.\n\n¿Está seguro de que desea continuar?",
            "Atención!",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;
                //Output("Deteniendo Gestor DTE...");
                comandoSSH("screen -X -S " + sucData["screen_id"] + " quit", false);
                //Output("Operacion Terminada!\n");
                Cursor.Current = Cursors.Default;
            }
        }

        private void ticketDeSoporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://" + sucData["ticket_url"]);
        }

        private void eRPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultasSQL DC = new ConsultasSQL(sucData["id"].ToString(), "2");
            DC.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            alerta.error("","Aún no disponible");
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            string enlace = cbEnlace.SelectedValue.ToString();
            System.Diagnostics.Process.Start(enlace);
            alerta.informacion("RUT del Contribuyente", rut);
        }

        private void carpetaGDriveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(gdrive);
        }

        private void editarDatosClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente("edit_from_controlpanel",sucData["fk_cliente"].ToString());
            c.ShowDialog();
            Carga();
        }

        private void btnHelpSsh_Click(object sender, EventArgs e)
        {
            ayuda help = new ayuda("SSH - Comandos más utilizados","ssh");
            help.Show();
        }

        private void tsmAnalisisFolios_Click(object sender, EventArgs e)
        {
            AnalisisFolios af = new AnalisisFolios(sucData["id"].ToString());
            af.Show();
        }

        private void reiniciarMySQLMariaDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alerta.informacion("Disculpe", "No desarrollado aún");
        }

        private void detenerMySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alerta.informacion("Disculpe", "No desarrollado aún");
        }

        private void iniciarMySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alerta.informacion("Disculpe", "No desarrollado aún");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alerta.informacion("Información", "Utiliza el clic derecho del mouse");
        }

        private void espacioDisponibleHDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sucData["root_access"].ToString() == "1")
            {
                comandoSSHShow("df -lh", true);
            }
            else
            {
                alerta.error("Atención", "Acceso root es requerido");
            }
        }

        private void uptimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sucData["root_access"].ToString() == "1")
            {
                comandoSSHShow("uptime", true);
            }
            else
            {
                alerta.error("Atención", "Acceso root es requerido");
            }
        }
    }
}
