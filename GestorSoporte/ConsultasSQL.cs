using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestorSoporte
{
    public partial class ConsultasSQL : Form
    {
        //Declara la varuiable como pública, aquí almacenaré todos los datos de conexion de la sucursal y otras cosas
        public DataTable dSuc = new DataTable();
        public string tipo_consulta;
        public string id_suc;

        public ConsultasSQL(string id_suc1, string tipo_consulta1)
        {
            InitializeComponent();
            tipo_consulta = tipo_consulta1;
            id_suc = id_suc1;

            //Esta es el label que indica la cantidad de lineas
            lbRegs.Visible = false;
            Carga();

        } 

        private void Carga()
        {
            DataTable dtb1 = new DataTable();

            dtb1 = MySql.Queries(tipo_consulta);

            cbConsulta.DisplayMember = "nombre";
            cbConsulta.ValueMember = "query";
            cbConsulta.DataSource = dtb1;


        }


        private void button1_Click(object sender, EventArgs e)
        {
            EjecutaConsulta();
        }

        private void EjecutaConsulta()
        {
            Cursor.Current = Cursors.WaitCursor;
            string cnString = "";
            string DB = "";

            //Paso el DataTable a DataRow
            if (tipo_consulta != "3")
            {
                dSuc = MySql.DatosSucursal(id_suc);
                DataRow row = dSuc.Rows[0];
                row = Seguridad.sucDataDesEncripta(row);
                if (tipo_consulta == "1")
                {
                    DB = row["dte_db_mysql"].ToString();
                }
                else if (tipo_consulta == "2")
                {
                    DB = row["erp_db_mysql"].ToString();
                }
                cnString = MySql.connectString() + "; Convert Zero Datetime=True;";
            }
            else
            {
                DataRow conData = SelConnection.conData;

                cnString = MySql.connectString() + "; Convert Zero Datetime=True;";
            }

            try
            {
                //Conexión MySQL
                MySqlConnection connection = new MySqlConnection(cnString);

                connection.Open();

                string sql_query = cbConsulta.SelectedValue.ToString();

                MySqlDataAdapter da = new MySqlDataAdapter(sql_query, connection);

                DataTable dt = new DataTable();
                da.Fill(dt);

                this.dgvSQL.DataSource = dt;

            }
            catch (Exception ex)
            {
                alerta.error("Error Conexión MySQL", "No se pudo conectar con el servidor MySQL" + ex);
            }

            lbRegs.Text = "Registros: " + dgvSQL.Rows.Count.ToString();
            lbRegs.Visible = true;
            Cursor.Current = Cursors.Default;

        }

        private void DTEControl_Load(object sender, EventArgs e)
        {

        }

        private void dgvDteRevisar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Método que exporta a un fichero Excel el contenido de un DataGridView
        /// </summary>
        /// <param name="grd">DataGridView que contiene los datos a exportar</param>
        /// 
        private void ExportarDataGridViewExcel(DataGridView grd)
        {
            SaveFileDialog fichero = new SaveFileDialog();
            fichero.Filter = "Excel (*.xls)|*.xls";
            if (fichero.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                Microsoft.Office.Interop.Excel.Application aplicacion;
                Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                aplicacion = new Microsoft.Office.Interop.Excel.Application();
                libros_trabajo = aplicacion.Workbooks.Add();
                hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
                //Recorremos el DataGridView rellenando la hoja de trabajo

                // storing header part in Excel  
                for (int i = 1; i < grd.Columns.Count + 1; i++)
                {
                    hoja_trabajo.Cells[1, i] = grd.Columns[i - 1].HeaderText;
                }

                //Sporing rows
                for (int i = 0; i < grd.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < grd.Columns.Count; j++)
                    {
                        hoja_trabajo.Cells[i + 2, j + 1] = grd.Rows[i].Cells[j].Value.ToString();
                    }
                }
                libros_trabajo.SaveAs(fichero.FileName,
                    Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                libros_trabajo.Close(true);
                aplicacion.Quit();
                Cursor.Current = Cursors.Default;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgvSQL);
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EjecutaConsulta();
        }

        private void exportarAExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewExcel(dgvSQL);
        }

        private void btnVerQuery_Click(object sender, EventArgs e)
        {

        }

        private void verEditarConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelQuery sq = new SelQuery();
            sq.ShowDialog();
            Carga();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
