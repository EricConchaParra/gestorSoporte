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
    public partial class ayuda : Form
    {
        public ayuda(string titulo, string tema)
        {
            InitializeComponent();
            this.Text = titulo;
            CargaAyuda(tema);
        }

        private void CargaAyuda(string tema)
        {
            string contenido = MySql.Ayuda(tema);
            txtAyuda.Text = contenido;
        }

        private void ayudaSsh_Load(object sender, EventArgs e)
        {

        }
    }
}
