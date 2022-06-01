using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Controls;


namespace GestorSoporte
{
    public partial class Query : Form
    {
        public Query(string accion1)
        {
            InitializeComponent();
            accion = accion1;
        }

        public bool cambios = false;
        public string accion;

        private void Query_Load(object sender, EventArgs e)
        {
            //Darle al ComboBox los dos tipos de consultas ERP y DTE
            DataTable dtEstado = new DataTable();
            dtEstado.Columns.Add("value");
            dtEstado.Columns.Add("descripcion");

            DataRow row = dtEstado.NewRow();
            row["value"] = "1";
            row["descripcion"] = "Base de Datos del Gestor DTE";
            dtEstado.Rows.Add(row);

            DataRow row1 = dtEstado.NewRow();
            row1["value"] = "2";
            row1["descripcion"] = "Base de Datos del ERP";
            dtEstado.Rows.Add(row1);

            DataRow row2 = dtEstado.NewRow();
            row2["value"] = "3";
            row2["descripcion"] = "Base de Datos SoporteManager";
            dtEstado.Rows.Add(row2);

            cbTipo.DisplayMember = "descripcion";
            cbTipo.ValueMember = "value";
            cbTipo.DataSource = dtEstado;

            if (accion == "new")
            {
                tsmModificar.Visible = false;
            }
            else if (accion == "edit")
            {
                tsmCrear.Visible = false;
                CargaEditar();
            }
            else
            {
                alerta.error("", "No Conozco esta accion");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cambios == false)
            {
                this.Close();
            }
            else
            {
                DialogResult confirma = MessageBox.Show("Desea salir sin grabar?", "Responda por favor",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirma == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void txtQuery_Click(object sender, EventArgs e)
        {
            cambios = true;
        }

        private void CargaEditar()
        {
            string id_query = SelQuery.id_query;
            //alerta.aviso("",id_query);
            DataTable dt = new DataTable();

            dt = MySql.VerQuery(int.Parse(SelQuery.id_query));

            DataRow row = dt.Rows[0];

            txtTitulo.Text = row["nombre"].ToString();
            //txtQuery.Text = row["query"].ToString();
            rtbQuery.AppendText(row["query"].ToString());
            cbTipo.SelectedValue = row["tipo"].ToString();
        }

        private void tsmCrear_Click(object sender, EventArgs e)
        {
            string nombre = txtTitulo.Text;
            //string query = txtQuery.Text;
            string query = rtbQuery.Text;
            //alerta.error("",query);
            string tipo = cbTipo.SelectedValue.ToString();



            //Verifico si la consulta tiene INSERT, UPDATE, DELETE, TRUNCATE o ALTER
            if (query.ToLower().Contains("insert") ||  query.ToLower().Contains("update") || query.ToLower().Contains("delete") ||
                query.ToLower().Contains("truncate") || query.ToLower().Contains("alter") || query.ToLower().Contains("create") ||
                query.ToLower().Contains("drop"))
            {
                alerta.error("Aviso","La consulta contiene acciones no permitidas.");
            }

            else
            {
                DataRow conData = SelConnection.conData;

                string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                    "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

                MySqlConnection cn = new MySqlConnection(cnString);

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert sql_queries(nombre, query, tipo) values(@nombre, @query, @tipo)";
                cmd.Parameters.Add("@nombre", MySqlDbType.String).Value = nombre; 
                cmd.Parameters.Add("@query", MySqlDbType.String).Value = query;
                cmd.Parameters.Add("@tipo", MySqlDbType.VarChar,3).Value = tipo;

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

        }

        private void tsmModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtTitulo.Text;
            string query = rtbQuery.Text;
            //alerta.error("", query);
            string tipo = cbTipo.SelectedValue.ToString();

            //Verifico si la consulta tiene INSERT, UPDATE, DELETE, TRUNCATE o ALTER
            if (query.ToLower().Contains("insert") || query.ToLower().Contains("update") || query.ToLower().Contains("delete") || query.ToLower().Contains("truncate") || query.ToLower().Contains("alter"))
            {
                alerta.error("Aviso", "La consulta contiene acciones no permitidas.");
            }

            else
            {
                DataRow conData = SelConnection.conData;

                string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                    "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

                MySqlConnection cn = new MySqlConnection(cnString);

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "update sql_queries set nombre = @nombre, query = @query, tipo = @tipo where id = @id;";
                cmd.Parameters.Add("@nombre", MySqlDbType.String).Value = nombre;
                cmd.Parameters.Add("@query", MySqlDbType.String).Value = query;
                cmd.Parameters.Add("@tipo", MySqlDbType.VarChar, 3).Value = tipo;
                cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = int.Parse(SelQuery.id_query);

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
        }
    }
}
