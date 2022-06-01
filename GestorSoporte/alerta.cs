using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSoporte
{
    public static class alerta
    {
        public static void informacion(string titulo, string texto)
        {
            MessageBox.Show(
            texto,
            titulo,
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        public static void error(string titulo, string texto)
        {
            MessageBox.Show(
            texto,
            titulo,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
        }

        public static void aviso(string titulo, string texto)
        {
            MessageBox.Show(
            texto,
            titulo,
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
        }

    }
}
