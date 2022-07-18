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
    public partial class SelConnection : Form
    {
        public SelConnection()
        {
            InitializeComponent();
        }

        public static DataRow row;
        public static string[] datos_usuario = new string[3];

        private void SelConnection_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Conectar();
        }

        private void Conectar()
        {
            string user = txtUser.Text == null ? "" : Seguridad.Encriptar(txtUser.Text.ToLower());
            string pass = txtpass.Text == null ? "" : Seguridad.Encriptar(txtpass.Text.ToLower());

            int usuOk = MySql.VerificaUsuario(user, pass);

            string nombre_usuario = "";
            string nivel_usuario = "";
            string id_sucursal = "";


            
            if (usuOk == 1)
            {

                //Una vez que se que el usuario existe, consulto su nivel y suc asignada
                DataRow dr = MySql.AccesoUsuario(user,pass);
                nivel_usuario = dr["tipo_usuario"].ToString();
                nombre_usuario = dr["descripcion"].ToString();
                id_sucursal = dr["id_sucursal"].ToString();
                datos_usuario[0] = nivel_usuario;
                datos_usuario[1] = nombre_usuario;
                datos_usuario[2] = id_sucursal;


                //Si es tipo dos, solo debe tener acceso directo al cPanel de la sucursal asignada
                if (nivel_usuario == "2")
                {
                    //MessageBox.Show("Este usuario "+ nombre_usuario +" es tipo 2!, nivel normal, su sucursal es: " + id_sucursal);
                }

                //Si es nivel 1, significa que es libre de hacer lo que quiera
                else if (nivel_usuario == "1")
                {
                    //MessageBox.Show("Este usuario es tipo 1, Administrador normal");
                }

                //Si no, dime que algo está mal
                else
                {
                    MessageBox.Show("Tipo usuario desconocido");
                }

                this.DialogResult = DialogResult.OK;
                //Si quisiera decir que esto está mal, quizás por una autentificaciónde usuario concorrecta, podría usar DialogResult.Abort
                //más Información de este código en: http://ltuttini.blogspot.com/2010/05/login-usando-password-con-hash.html

            }

            else
            {
                this.DialogResult = DialogResult.Abort;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //Con esta funcion, hago publica el DataRow "conData", así el form principal puede acceder a la información
        public static DataRow conData
        {
            get { return row; }
        }

        //Con esta funcion, hago publica el array "datosUsuario", así el form principal puede acceder a la información
        public static string[] UserData
        {
            get { return datos_usuario; }
        }

        private void txtpass_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Conectar();
            }
        }
    }
}
