using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSoporte
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Llamo al Form de Usaurio/Conexion
            SelConnection selc = new SelConnection();
            selc.ShowDialog();

            //Si está todo bien llamo al Form Principal
            if(selc.DialogResult == DialogResult.OK)
            { 
                Application.Run(new Form1());
            }
            else
            {
                if (selc.DialogResult == DialogResult.Cancel)
                {
                    Application.Exit();
                }

                else
                { 
                    alerta.error("Alerta", "Usuario y/o Contraseña incorrectos");
                }
            }

        }
    }
}
