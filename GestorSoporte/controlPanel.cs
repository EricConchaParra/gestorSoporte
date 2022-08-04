using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Renci.SshNet;
using RestSharp;
using RestSharp.Authenticators;

using Slack.Webhooks;
using Slack.Webhooks.Blocks;
using Slack.Webhooks.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        public Stopwatch stopWatch = new Stopwatch();
        public DataTable clieData = new DataTable();
        public string[] datos_usuario;
        public string report = "";


        private void controlPanel_Load(object sender, EventArgs e)
        {
            //Quité aca la X de cerrar el diálogo. Asi no puede salir sin verificar el aviso de soporte.
            //this.ControlBox = false;
            Carga();

            //Inicio el contador automáticamente al abrir cPanel
            btnCronometro.Text = "Pausar";
            stopWatch.Start();
            timer1.Enabled = true;
        }

        private void Carga()
        {
            //Preparo todo para slack (si corresponde)
            if (sucData["slack"].ToString() == "1")
            {
                clieData = MySql.DatosCliente(sucData["fk_cliente"].ToString());
                btnSend.Enabled = true;
                txtNotaSoporte.Enabled = true;
            }

            else
            {
                btnSend.Enabled = false;
                btnSend.Text = "Enviar a #" + sucData["slackChannel"];
                txtNotaSoporte.Enabled = false;
                cbSlack.Enabled = false;
            }

            //Asigno el titutlo del form
            this.Text = clieData.Rows[0]["fantasia"].ToString() + " " + sucData["sucursal_nombre"].ToString() + " - " + sucData["ip"].ToString();

            //Cargo los datos del cliente, no de la sucursal, en un datatable
            DataTable dtContacto = new DataTable();
            dtContacto = MySql.DatosCliente(sucData["fk_cliente"].ToString());

            //me traigo la primera fila
            DataRow cont = dtContacto.Rows[0];

            //Notas TEXTO
            txtNotas.Text = Seguridad.DesEncriptar(cont["notas"].ToString());

            //Botones Personalizados
            //Url
            if (sucData["nombreUrl"].ToString() != "")
            {
                btnUrl.Enabled = true;
                btnUrl.Text = sucData["nombreUrl"].ToString();
            }

            //Comando SSH
            if (sucData["nombreComando"].ToString() != "")
            {
                btnComandoSSH.Enabled = true;
                btnComandoSSH.Text = sucData["nombreComando"].ToString();
            }


            //Verifica accesos y cierra lo que esté bloqueado
            if (sucData["mysql"].ToString() == "0")
            {
                consultasSQLToolStripMenuItem.Visible = false;
            }

            if (sucData["ssh"].ToString() == "0")
            {
                btnSsh.Enabled = false;
                btnWinScp.Enabled = false;
                btnHelpSsh.Enabled = false;
            }

            if (sucData["rdp"].ToString() == "1")
            {
                btnRDP.Enabled = true;
            }
            else
            {
                btnRDP.Enabled = false;
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

            if(cont["dte"].ToString() == "0")
            {
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
            datos_usuario = SelConnection.datos_usuario;
            /*
            datos_usuario[0] = nivel_usuario;
            datos_usuario[1] = nombre_usuario;
            datos_usuario[2] = id_sucursal;
            */


            if (datos_usuario[0] == "2")
            {
                consultasSQLToolStripMenuItem.Visible = false;
                btnSsh.Enabled = false;
                btnWinScp.Enabled = false;
                btnHelpSsh.Enabled = false;
                sucursalToolStripMenuItem.Visible = false;
            }

            //Fechas de vencimiento de Servicios y Cert Digital
            lbUsuarioSII.Text = cont["cert_autorizado"].ToString();
            DateTime cert_vencimiento = DateTime.Parse(cont["cert_vencimiento"].ToString());
            //TODO debería avisar cuando el certificado está vencido

            DateTime erp_fecha_actual = DateTime.Parse(cont["erp_fecha_actual"].ToString());
            DateTime dte_fecha_actual = DateTime.Parse(cont["dte_fecha_actual"].ToString());

            lbCert.Text = cert_vencimiento.ToString("dd-MM-yyyy");

            lbErp.Text = cont["erp"].ToString() == "1" ? "Si (" + erp_fecha_actual.ToString("dd-MM-yyyy") + ")" : "No";
            lbDte.Text = cont["dte"].ToString() == "1" ? "Si (" + dte_fecha_actual.ToString("dd-MM-yyyy") + ")" : "No";

            if (cont["activo"].ToString() == "2")
            {
                alerta.informacion("Atención!","Cliente presenta observaciones comerciales.\nMás información disponible en las notas.");
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

        //private void btnPlayRun_Click(object sender, EventArgs e)
        //{
        //    DialogResult respuesta = MessageBox.Show(
        //    "¿Desea iniciar el Gestor DTE en el puerto " + sucData["puerto_play"] + "?\n\n(Recuerde que una vez comenzada la operación debe esperar" +
        //    " a que se abra la venta del navegador).",
        //    "Responda por favor",
        //    MessageBoxButtons.YesNo,
        //    MessageBoxIcon.Information);

        //    if (respuesta == DialogResult.Yes)
        //    {
        //        Cursor.Current = Cursors.WaitCursor;
        //        //Output("Iniciando Gestor DTE, por favor espere...");
        //        bool iniciado = estaGestorIniciado();

        //        if (iniciado)
        //        {
        //            MessageBox.Show(
        //            "El Gestor DTE ya está iniciado en el puerto " + sucData["puerto_play"] + "\nSi continúa con problemas, intente reiniciándolo.",
        //            "Atención!",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Information);
        //            //Output("El Gestor DTE ya está iniciado en el puerto " + puerto);
        //        }

        //        else
        //        {
        //            // "\u0022" ==>> Comillas dobles
        //            comandoSSH("screen -d -m -S " + sucData["screen_id"] + " && screen -S " + sucData["screen_id"] + " -p 0 -X stuff 'cd " + sucData["dte_path"] + " && export PATH=$PATH:" + sucData["play_path"] + " && play " + "\u0022" + "run " + sucData["puerto_play"] + "\u0022" + "\n'", false);
        //            Thread.Sleep(Int32.Parse(sucData["seg_espera"].ToString()) * 1000);
        //            System.Diagnostics.Process.Start("http://" + sucData["ip"] + ":" + sucData["puerto_play"]);
        //            //Output("Operacion Terminada!\n");
        //        }
        //        Cursor.Current = Cursors.Default;
        //    }
        //}

        //public bool estaGestorIniciado()
        //{
        //    string cmdUsu = "";
        //    string cmdPass = "";

        //    if (sucData["root_access"].ToString() == "1")
        //    {
        //        cmdUsu = sucData["root_user"].ToString();
        //        cmdPass = sucData["root_pass"].ToString();
        //    }

        //    else
        //    {
        //        cmdUsu = sucData["regular_user"].ToString();
        //        cmdPass = sucData["regular_pass"].ToString();
        //    }

        //    using (var ssh = new SshClient(sucData["ip"].ToString(), cmdUsu, cmdPass))
        //    {
        //        ssh.Connect();
        //        var responseSsh = ssh.RunCommand("screen -ls");
        //        var response = responseSsh.Result;
        //        ssh.Disconnect();
        //        string salida = response;
        //        bool existe = salida.Contains(sucData["screen_id"].ToString());
        //        return existe;
        //    }
        //}
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
        private void eRPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultasSQL DC = new ConsultasSQL(sucData["id"].ToString(), "2");
            DC.ShowDialog();
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
        private void btnGrabaNota_Click_1(object sender, EventArgs e)
        {
            string nota = Seguridad.Encriptar(txtNotas.Text);
            MySql.grabaNotasCliente(nota, sucData["fk_cliente"].ToString());
            graboNota = true;
        }

        private void btnUrl_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(sucData["url"].ToString());
        }

        private void btnComandoSSH_Click(object sender, EventArgs e)
        {
            comandoSSH(sucData["comando"].ToString(), true);
            alerta.informacion("Información", "Se ha enviado el comando al servidor");
        }

        private void btnRDP_Click(object sender, EventArgs e)
        {
            //set variables RDP
            string rdpUrl = sucData["rdpUrl"].ToString();
            string rdpUser = sucData["rdpUser"].ToString();
            string rdpPass = sucData["rdpPass"].ToString();
            
            // Create credentials
            runHiddenCMD(string.Format("cmdkey /add:{0} /user:{1} /pass:{2}", rdpUrl , rdpUser , rdpPass ));
            // Connect MSTSC with servername and credentials created before
            runHiddenCMD(string.Format("mstsc /v:{0}",rdpUrl));
            // Delete the credentials after MSTSC session is done
            runHiddenCMD(string.Format("cmdkey /delete:{0}",rdpUrl));
        }

        private void runHiddenCMD (string comando)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C " + comando;
            process.StartInfo = startInfo;
            process.Start();
        }

        private void btnCronometro_Click(object sender, EventArgs e)
        {
            if (!stopWatch.IsRunning)
            {
                btnCronometro.Text = "Pausar";
                stopWatch.Start();
                timer1.Enabled = true;
            }
            else
            {
                btnCronometro.Text = "Iniciar";
                stopWatch.Stop();
                timer1.Enabled = false;
            }
        }                
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)stopWatch.ElapsedMilliseconds);
            txtTiempo.Text = ts.ToString("mm\\:ss");
        }

        public void sendSlack(string descripcion, string mensaje, bool cobrar, bool fin)
        {
            //Evento en curso o finalizado
            string tipoEvento = "finalizado :white_check_mark:";

            if(!fin)
            {
                tipoEvento = "en curso :red_circle:";
            }
            
            //Obtengo Datos Cliente
            string nombreCliente = clieData.Rows[0]["fantasia"].ToString();
            
            //Defino el webhook
            var slackClient = new SlackClient(Seguridad.DesEncriptar(MySql.GetConfig().Rows[0]["slack"].ToString()));

            //Obtengo el tiempo que marca el contador
            int tiempo = 0;
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)stopWatch.ElapsedMilliseconds);
            if ((int)stopWatch.ElapsedMilliseconds > 0)
            {
                tiempo = Convert.ToInt32(ts.TotalMinutes);
            }


            var slackMessage = new SlackMessage
            {
                Channel = "#" + sucData["slackChannel"], //Envía el mensaje al canal del webhook
                Username = "Soporte Manager",
                Text = "=================\n" +
                       "Evento " + tipoEvento + "\n" +   
                       "*Cliente:* " + nombreCliente + " - " + sucData["sucursal_nombre"] + "\n" +
                       "*Atendido por:* " + datos_usuario[3] + "\n" +
                       (tiempo > 0 ? "*Tiempo (minutos):* " + tiempo.ToString() + "\n": "") +
                       "*Cobrar:* " + (cobrar ? "Si" : "No") + "\n" + 
                       "\n" +
                       "*" + descripcion + "* \n"
                       + mensaje
            };

            slackClient.Post(slackMessage);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            bool cobrar = cbCobrar.Checked;
            bool slack = cbSlack.Checked;
            bool fin = cbFinEvento.Checked;

            if (slack && !fin)
            {
                this.UseWaitCursor = true;
                sendSlack(txtDescripcionEvento.Text, txtNotaSoporte.Text, cobrar, fin);
                this.UseWaitCursor = false;
            }
            if (fin)
            {
                this.UseWaitCursor = true;
                clieData = MySql.DatosCliente(sucData["fk_cliente"].ToString());
                string fantasiaCliente = clieData.Rows[0]["fantasia"].ToString();

                string configJson = FileTool.readFile("config.json");
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                string funcionario = datos_usuario[3];
                string databaseKey = JsonTool.searchJsonFor(configJson, "notion_database");

                //Obtengo el tiempo que marca el contador
                int tiempo = 0;
                TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)stopWatch.ElapsedMilliseconds);
                if ((int)stopWatch.ElapsedMilliseconds > 0)
                {
                    tiempo = Convert.ToInt32(ts.TotalMinutes);
                }

                string cobranza = cobrar ? "Si" : "No";

                sendNotion.grabaSoporte(txtDescripcionEvento.Text, txtNotaSoporte.Text, fantasiaCliente, funcionario, tiempo, fecha, cobranza);

                if (slack)
                {
                    sendSlack(txtDescripcionEvento.Text, txtNotaSoporte.Text, cobrar, fin);
                }


                //Deten el temporizador y vacia los textos
                stopWatch.Stop();
                timer1.Enabled = false;

                txtDescripcionEvento.Text = "";
                txtNotaSoporte.Text = "";

                this.UseWaitCursor = false;
                
                //Cierra la ventana
                this.Close();
            }
        }

        private void cbSlack_CheckedChanged(object sender, EventArgs e)
        {
            checkBotonSend();
        }

        private void cbFinEvento_CheckedChanged(object sender, EventArgs e)
        {
            checkBotonSend();
        }

        private void checkBotonSend()
        {
            if(cbFinEvento.Checked)
            {
                btnSend.Enabled = true;
                btnSend.Text = "Finalizar ahora";
            }
            else if (cbSlack.Checked)
            {
                btnSend.Enabled = true;
                btnSend.Text = "Enviar a Slack";
            }
            else
            {
                btnSend.Enabled = false;
                btnSend.Text = "Enviar a Slack";
            }
        }
    }
}
