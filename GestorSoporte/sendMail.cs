using MimeKit;
using MailKit.Net.Smtp;
using MailKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace GestorSoporte
{
    internal class sendMail
    {
        public static void sendMailToClient(string asuntoEvento, string descripcionEvento, string fantasiaCliente, string sucursalCliente,
                                        string funcionario, int tiempo, string fecha, bool cobrar, string horaInicio, string solicitante,
                                        string rutCliente)
        {
            //Obtiene los datos para el envío desde BD
            DataRow config = MySql.GetConfig().Rows[0];
            string smtpServer = Seguridad.DesEncriptar(config["smtpServer"].ToString());
            int smtpPort = Int32.Parse(config["smtpPort"].ToString());
            bool ssl = config["useSsl"].ToString() == "1" ? true : false;
            string emailUser = Seguridad.DesEncriptar(config["emailUser"].ToString());
            string emailPass = Seguridad.DesEncriptar(config["emailPass"].ToString());

            //Obtiene los correos del cliente para el envío
            string correos = MySql.DatosCliente(rutCliente).Rows[0]["notificaEmails"].ToString();
            InternetAddressList listaCorreos = InternetAddressList.Parse(correos);

            string cobranza = "";
            
            if (cobrar)
            {
                cobranza = "<p><b>Nota: Este servicio está sujeto a cobro según lo establecido.</b></p>";
            }

            //Si hay o no un solicitante
            string solicitadoPor = "";

            if (solicitante.Length > 2)
            {
                solicitadoPor = " a solicitud de: <b>" + solicitante + "</b>,";
            }

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Equipo Zenitx", "soporte@zenitx.com"));

            //message.To.Add(new MailboxAddress("Eric Concha", "ericconchaexl@gmail.com")); --> Para un solo receptor
            message.To.AddRange(listaCorreos); // --> Para una lista separada por comas ya parseada
            
            message.Bcc.Add(new MailboxAddress("Eric Concha", "ericconchaexl@gmail.com"));// --> Para enviar copias Cc, para enviar copias ocultas Bcc

            message.Subject = "Informe de soporte realizado";

            message.Body = new TextPart("html")
            {
                Text = @"Estimado Cliente " + fantasiaCliente + @",<br>

                    <p>Le informamos que el <b>" + fecha + " a las " + horaInicio + @"</b> se realizó un servicio" +
                    solicitadoPor + @" por el concepto de: <b>"+ asuntoEvento + @"</b>.</p>
                    <p>La atención fue brindada por <b>" + funcionario + @"</b> de manera remota en: <b>" + sucursalCliente + @"</b>, el
                    funcionario dejó el siguiente comentario:</p>

                    <blockquote>" + descripcionEvento + "</blockquote>"

                    +
                    cobranza
                    +

                    "Atentamente,<br>" +
                    "El Equipo Zenitx<br><br>" +
                    "<i>Nota: Aunque este correo es automático, puede responderlo con sus observaciones.</i>"
            };

            using (var client = new SmtpClient())
            {
                client.Connect(smtpServer, smtpPort, ssl); //servidor smtp, puerto, ssl?

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate(emailUser, emailPass);

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}