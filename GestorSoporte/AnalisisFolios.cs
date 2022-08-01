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
    public partial class AnalisisFolios : Form
    {


        public AnalisisFolios(string id_sucursal1)
        {
            InitializeComponent();
            id_sucursal = id_sucursal1;
            Carga();
        }

        public string id_sucursal;

        private void Carga()
        {
            
            SucursalesDte();
        }

        //Se conecta a MySQL del usuario para encontrar la lista de sucursales
        private void SucursalesDte()
        {
            Cursor.Current = Cursors.WaitCursor;
            string cnString = "";
            string DB = "";
            DataTable dSuc = new DataTable();
            DataTable dt = new DataTable();

            dSuc = MySql.DatosSucursal(id_sucursal);

            DataRow row = dSuc.Rows[0];

            row = Seguridad.sucDataDesEncripta(row);


            DB = row["dte_db_mysql"].ToString();
            cnString = "SERVER=" + row["ip"] + ";" + "PORT=" + row["puerto_mysql"] + ";" +
            "DATABASE=" + DB + ";" + "UID=" + row["acceso_user_mysql"] + ";" + "PASSWORD=" + row["acceso_pass_mysql"] + "; Convert Zero Datetime=True;";

            try
            {
                //Conexión MySQL
                MySqlConnection connection = new MySqlConnection(cnString);

                connection.Open();

                string sql_query = string.Format("select id, nombre from sucursales order by nombre desc;");

                MySqlDataAdapter da = new MySqlDataAdapter(sql_query, connection);

                da.Fill(dt);

            }

            catch (Exception ex)
            {
                alerta.error("Error Conexión MySQL", "No se pudo conectar con el servidor MySQL" + ex);
            }

            finally
            {
                cbSelSuc.DisplayMember = "nombre";
                cbSelSuc.ValueMember = "id";
                cbSelSuc.DataSource = dt;

                cbSelSucVence.DisplayMember = "nombre";
                cbSelSucVence.ValueMember = "id";
                cbSelSucVence.DataSource = dt;
                Cursor.Current = Cursors.Default;
            }

        }

        private void btnSelSuc_Click(object sender, EventArgs e)
        {

            SelDisponibles();
            SelDias30();
            SelProm90();
            CalculaDisponibilidad();
            gbCalcula.Enabled = true;
        }

        //Consulta cuantos folios disponibles
        private void SelDisponibles()
        {
            string id_suc_dte = cbSelSuc.SelectedValue.ToString();

            Cursor.Current = Cursors.WaitCursor;
            string cnString = "";
            string DB = "";
            DataTable dSuc = new DataTable();
            DataTable dt = new DataTable();

            dSuc = MySql.DatosSucursal(id_sucursal);

            DataRow row = dSuc.Rows[0];

            row = Seguridad.sucDataDesEncripta(row);

            DB = row["dte_db_mysql"].ToString();
            cnString = "SERVER=" + row["ip"] + ";" + "PORT=" + row["puerto_mysql"] + ";" +
            "DATABASE=" + DB + ";" + "UID=" + row["acceso_user_mysql"] + ";" + "PASSWORD=" + row["acceso_pass_mysql"] + "; Convert Zero Datetime=True;";

            try
            {
                //Conexión MySQL
                MySqlConnection connection = new MySqlConnection(cnString);

                connection.Open();

                string sql_query = string.Format("select * from resumen_folios where sucursales_id = {0};", id_suc_dte);

                MySqlDataAdapter da = new MySqlDataAdapter(sql_query, connection);

                da.Fill(dt);

            }

            catch (Exception ex)
            {
                alerta.error("Error Conexión MySQL", "No se pudo conectar con el servidor MySQL" + ex);
            }

            finally
            {
                DataRow[] libres;

                //Factura
                libres = dt.Select("tipo_doc = 33");
                if (libres.Length == 0)
                {
                    lb33.Text = "0";
                }
                else
                {
                    lb33.Text = string.Format("{0:#,##0.##}", Int32.Parse(libres[0]["disponibles"].ToString()));

                }

                //Guia
                libres = dt.Select("tipo_doc = 52");
                if (libres.Length == 0)
                {
                    lb52.Text = "0";
                }
                else
                {
                    lb52.Text = string.Format("{0:#,##0.##}", Int32.Parse(libres[0]["disponibles"].ToString()));
                }

                //NC
                libres = dt.Select("tipo_doc = 61");
                if (libres.Length == 0)
                {
                    lb61.Text = "0";
                }
                else
                {
                    lb61.Text = string.Format("{0:#,##0.##}", Int32.Parse(libres[0]["disponibles"].ToString()));
                }

                //ND
                libres = dt.Select("tipo_doc = 56");
                if (libres.Length == 0)
                {
                    lb56.Text = "0";
                }
                else
                {
                    lb56.Text = string.Format("{0:#,##0.##}", Int32.Parse(libres[0]["disponibles"].ToString()));
                }


                //BE
                libres = dt.Select("tipo_doc = 39");
                if (libres.Length == 0)
                {
                    lb39.Text = "0";
                }
                else
                {
                    lb39.Text = string.Format("{0:#,##0.##}", Int32.Parse(libres[0]["disponibles"].ToString()));
                }


                //F-Com
                libres = dt.Select("tipo_doc = 46");
                if (libres.Length == 0)
                {
                    lb46.Text = "0";
                }
                else
                {
                    lb46.Text = string.Format("{0:#,##0.##}", Int32.Parse(libres[0]["disponibles"].ToString()));

                }


                //F-Ex
                libres = dt.Select("tipo_doc = 34");
                if (libres.Length == 0)
                {
                    lb34.Text = "0";
                }
                else
                {
                    lb34.Text = string.Format("{0:#,##0.##}", Int32.Parse(libres[0]["disponibles"].ToString()));

                }
            }

        }

        //Suma los utilizados los ultimos 30 días
        private void SelDias30()
        {
            string id_suc_dte = cbSelSuc.SelectedValue.ToString();

            Cursor.Current = Cursors.WaitCursor;
            string cnString = "";
            string DB = "";
            DataTable dSuc = new DataTable();
            DataTable dt = new DataTable();

            dSuc = MySql.DatosSucursal(id_sucursal);

            DataRow row = dSuc.Rows[0];

            row = Seguridad.sucDataDesEncripta(row);

            DB = row["dte_db_mysql"].ToString();
            cnString = "SERVER=" + row["ip"] + ";" + "PORT=" + row["puerto_mysql"] + ";" +
            "DATABASE=" + DB + ";" + "UID=" + row["acceso_user_mysql"] + ";" + "PASSWORD=" + row["acceso_pass_mysql"] + "; Convert Zero Datetime=True;";

            //Folios 30 dias

            try
            {
                //Conexión MySQL
                MySqlConnection connection = new MySqlConnection(cnString);

                connection.Open();

                string sql_query = string.Format(@"SELECT

                                    FORMAT((SUM(CASE
                                        WHEN tipo_doc = 33
                                        THEN 1
                                        ELSE 0
                                    END)),0, 'de_DE') AS '33',


                                    FORMAT((SUM(CASE
                                        WHEN tipo_doc = 52
                                        THEN 1
                                        ELSE 0
                                    END)),0, 'de_DE') AS '52',

                                    FORMAT((SUM(CASE
                                        WHEN tipo_doc = 61
                                        THEN 1
                                        ELSE 0
                                    END)),0, 'de_DE') AS '61',

                                    FORMAT((SUM(CASE
                                        WHEN tipo_doc = 56
                                        THEN 1
                                        ELSE 0
                                    END)),0, 'de_DE') AS '56',

                                    FORMAT((SUM(CASE
                                        WHEN tipo_doc = 46
                                        THEN 1
                                        ELSE 0
                                    END)),0, 'de_DE') AS '46',

                                    FORMAT((SUM(CASE
                                        WHEN tipo_doc = 34
                                        THEN 1
                                        ELSE 0
                                    END)),0, 'de_DE') AS '34',

                                    FORMAT((SUM(CASE
                                        WHEN tipo_doc = 39
                                        THEN 1
                                        ELSE 0
                                    END)),0, 'de_DE') AS '39'

                                    FROM

                                    documentos

                                    WHERE

                                        is_received = 0 and
                                        sucursal_id = {0} and
                                        fch_emis between(CURDATE() - INTERVAL 1 MONTH) and CURDATE();", id_suc_dte);

                MySqlDataAdapter da1 = new MySqlDataAdapter(sql_query, connection);

                da1.Fill(dt);

                DataRow dias30 = dt.Rows[0];
                //Factura
                if (dias30["33"].ToString() == "0")
                {
                    lb3330.Text = "0";
                }
                else
                {
                    //alerta.error("", dias30["33"].ToString());
                    lb3330.Text = string.Format("{0:#,##0.##}", dias30["33"].ToString());

                }

                //Guia
                if (dias30["52"].ToString() == "0")
                {
                    lb5230.Text = "0";
                }
                else
                {
                    lb5230.Text = string.Format("{0:#,##0.##}", dias30["52"].ToString());
                }

                //NC
                if (dias30["61"].ToString() == "0")
                {
                    lb6130.Text = "0";
                }
                else
                {
                    lb6130.Text = string.Format("{0:#,##0.##}", dias30["61"].ToString());
                }

                //ND
                if (dias30["56"].ToString() == "0")
                {
                    lb5630.Text = "0";
                }
                else
                {
                    lb5630.Text = string.Format("{0:#,##0.##}", dias30["56"].ToString());
                }


                //BE
                if (dias30["39"].ToString() == "0")
                {
                    lb3930.Text = "0";
                }
                else
                {
                    lb3930.Text = string.Format("{0:#,##0.##}", dias30["39"].ToString());
                }


                //F-Com
                if (dias30["46"].ToString() == "0")
                {
                    lb4630.Text = "0";
                }
                else
                {
                    lb4630.Text = string.Format("{0:#,##0.##}", dias30["46"].ToString());

                }


                //F-Ex
                if (dias30["34"].ToString() == "0")
                {
                    lb3430.Text = "0";
                }
                else
                {
                    lb3430.Text = string.Format("{0:#,##0.##}", dias30["34"].ToString());

                }

                Tabla.Visible = true;
            }

            catch (Exception ex)
            {
                alerta.error("Error Conexión MySQL", "No se pudo conectar con el servidor MySQL" + ex);
            }

            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        //Suma y divide en 3 (promedia) los ultimo 3 meses
        private void SelProm90()
        {
            string id_suc_dte = cbSelSuc.SelectedValue.ToString();

            Cursor.Current = Cursors.WaitCursor;
            string cnString = "";
            string DB = "";
            DataTable dSuc = new DataTable();
            DataTable dt = new DataTable();

            dSuc = MySql.DatosSucursal(id_sucursal);

            DataRow row = dSuc.Rows[0];

            row = Seguridad.sucDataDesEncripta(row);

            DB = row["dte_db_mysql"].ToString();
            cnString = "SERVER=" + row["ip"] + ";" + "PORT=" + row["puerto_mysql"] + ";" +
            "DATABASE=" + DB + ";" + "UID=" + row["acceso_user_mysql"] + ";" + "PASSWORD=" + row["acceso_pass_mysql"] + "; Convert Zero Datetime=True;";

            //Folios promedio 90 dias

            try
            {
                //Conexión MySQL
                MySqlConnection connection = new MySqlConnection(cnString);

                connection.Open();

                string sql_query = string.Format(@"SELECT

                                    FORMAT((SUM(CASE
                                        WHEN tipo_doc = 33
                                        THEN 1
                                        ELSE 0
                                    END)) / 3, 1, 'de_DE' ) AS '33',


                                    FORMAT((SUM(CASE
                                        WHEN tipo_doc = 52
                                        THEN 1
                                        ELSE 0
                                    END)) / 3, 1, 'de_DE') AS '52',

                                    FORMAT((SUM(CASE
                                        WHEN tipo_doc = 61
                                        THEN 1
                                        ELSE 0
                                    END)) / 3, 1, 'de_DE') AS '61',

                                    FORMAT((SUM(CASE
                                        WHEN tipo_doc = 56
                                        THEN 1
                                        ELSE 0
                                    END)) / 3, 1, 'de_DE') AS '56',

                                    FORMAT((SUM(CASE
                                        WHEN tipo_doc = 46
                                        THEN 1
                                        ELSE 0
                                    END)) / 3, 1, 'de_DE') AS '46',

                                    FORMAT((SUM(CASE
                                        WHEN tipo_doc = 34
                                        THEN 1
                                        ELSE 0
                                    END)) / 3, 1, 'de_DE') AS '34',

                                    FORMAT((SUM(CASE
                                        WHEN tipo_doc = 39
                                        THEN 1
                                        ELSE 0
                                    END)) / 3, 1, 'de_DE') AS '39'

                                    FROM

                                    documentos

                                    WHERE

                                        is_received = 0 and
                                        sucursal_id = {0} and
                                        fch_emis between(CURDATE() - INTERVAL 3 MONTH) and CURDATE();", id_suc_dte);

                MySqlDataAdapter da1 = new MySqlDataAdapter(sql_query, connection);

                da1.Fill(dt);

                DataRow dias90 = dt.Rows[0];
                //Factura
                if (dias90["33"].ToString() == "0,0")
                {
                    lb3390.Text = "0";
                }
                else
                {
                    //alerta.error("", dias90["33"].ToString());
                    lb3390.Text = string.Format("{0:#,##0.##}", dias90["33"].ToString());

                }

                //Guia
                if (dias90["52"].ToString() == "0,0")
                {
                    lb5290.Text = "0";
                }
                else
                {
                    lb5290.Text = string.Format("{0:#,##0.##}", dias90["52"].ToString());
                }

                //NC
                if (dias90["61"].ToString() == "0,0")
                {
                    lb6190.Text = "0";
                }
                else
                {
                    lb6190.Text = string.Format("{0:#,##0.##}", dias90["61"].ToString());
                }

                //ND
                if (dias90["56"].ToString() == "0,0")
                {
                    lb5690.Text = "0";
                }
                else
                {
                    lb5690.Text = string.Format("{0:#,##0.##}", dias90["56"].ToString());
                }


                //BE
                if (dias90["39"].ToString() == "0,0")
                {
                    lb3990.Text = "0";
                }
                else
                {
                    lb3990.Text = string.Format("{0:#,##0.##}", dias90["39"].ToString());
                }


                //F-Com
                if (dias90["46"].ToString() == "0,0")
                {
                    lb4690.Text = "0";
                }
                else
                {
                    lb4690.Text = string.Format("{0:#,##0.##}", dias90["46"].ToString());

                }


                //F-Ex
                if (dias90["34"].ToString() == "0,0")
                {
                    lb3490.Text = "0";
                }
                else
                {
                    lb3490.Text = string.Format("{0:#,##0.##}", dias90["34"].ToString());

                }

                Tabla.Visible = true;

            }

            catch (Exception ex)
            {
                alerta.error("Error Conexión MySQL", "No se pudo conectar con el servidor MySQL" + ex);
            }

            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        //Obtiene un calculo de cuantos meses durará que existe ahora como disponible
        private void CalculaDisponibilidad()
        {

            double ref33 = 0;
            double ref52 = 0;
            double ref61 = 0;
            double ref56 = 0;
            double ref39 = 0;
            double ref46 = 0;
            double ref34 = 0;

            //pregunta que numero es más grande

            try
            {
                if (Convert.ToDouble(lb3330.Text) > Convert.ToDouble(lb3390.Text))
                {
                    ref33 = Convert.ToDouble(lb3330.Text);
                }
                else
                {
                    ref33 = Convert.ToDouble(lb3390.Text);
                }
            }
            catch
            { };

            try
            {
                if (Convert.ToDouble(lb5230.Text) > Convert.ToDouble(lb5290.Text))
                {
                    ref52 = Convert.ToDouble(lb5230.Text);
                }
                else
                {
                    ref52 = Convert.ToDouble(lb5290.Text);
                }
            }
            catch
            { };

            try
            {
                if (Convert.ToDouble(lb6130.Text) > Convert.ToDouble(lb6190.Text))
                {
                    ref61 = Convert.ToDouble(lb6130.Text);
                }
                else
                {
                    ref61 = Convert.ToDouble(lb6190.Text);
                }
            }
            catch
            { };

            try
            {
                if (Convert.ToDouble(lb5630.Text) > Convert.ToDouble(lb5690.Text))
                {
                    ref56 = Convert.ToDouble(lb5630.Text);
                }
                else
                {
                    ref56 = Convert.ToDouble(lb5690.Text);
                }
            }
            catch
            { };

            try
            {
                if (Convert.ToDouble(lb3930.Text) > Convert.ToDouble(lb3990.Text))
                {
                    ref39 = Convert.ToDouble(lb3930.Text);
                }
                else
                {
                    ref39 = Convert.ToDouble(lb3990.Text);
                }
            }
            catch
            { };

            try
            {
                if (Convert.ToDouble(lb4630.Text) > Convert.ToDouble(lb4690.Text))
                {
                    ref46 = Convert.ToDouble(lb4630.Text);
                }
                else
                {
                    ref46 = Convert.ToDouble(lb4690.Text);
                }
            }
            catch
            { };

            try
            {
                if (Convert.ToDouble(lb3430.Text) > Convert.ToDouble(lb3490.Text))
                {
                    ref34 = Convert.ToDouble(lb3430.Text);
                }
                else
                {
                    ref34 = Convert.ToDouble(lb3490.Text);
                }
            }
            catch
            { };

            //Calcula e imprime
            lb33d.Text = ref33 == 0 ? "0" : string.Format("{0:#,##0.##}", (Convert.ToDouble(lb33.Text) / ref33));
            if ((Convert.ToDouble(lb33.Text) / ref33) < 1)
            {
                lb33d.ForeColor = System.Drawing.Color.Red;
                lb33d.Font = new Font(lb33d.Font, FontStyle.Bold);
            }
            else
            {
                lb33d.ForeColor = System.Drawing.Color.Black;
                lb33d.Font = new Font(lb33d.Font, FontStyle.Regular);
            }

            lb52d.Text = ref52 == 0 ? "0" : string.Format("{0:#,##0.##}", (Convert.ToDouble(lb52.Text) / ref52));
            if ((Convert.ToDouble(lb52.Text) / ref52) < 1)
            {
                lb52d.ForeColor = System.Drawing.Color.Red;
                lb52d.Font = new Font(lb52d.Font, FontStyle.Bold);
            }
            else
            {
                lb52d.ForeColor = System.Drawing.Color.Black;
                lb52d.Font = new Font(lb52d.Font, FontStyle.Regular);
            }

            lb61d.Text = ref61 == 0 ? "0" : string.Format("{0:#,##0.##}", (Convert.ToDouble(lb61.Text) / ref61));
            if ((Convert.ToDouble(lb61.Text) / ref61) < 1)
            {
                lb61d.ForeColor = System.Drawing.Color.Red;
                lb61d.Font = new Font(lb61d.Font, FontStyle.Bold);
            }
            else
            {
                lb61d.ForeColor = System.Drawing.Color.Black;
                lb61d.Font = new Font(lb61d.Font, FontStyle.Regular);
            }

            lb56d.Text = ref56 == 0 ? "0" : string.Format("{0:#,##0.##}", (Convert.ToDouble(lb56.Text) / ref56));
            if ((Convert.ToDouble(lb56.Text) / ref56) < 1)
            {
                lb56d.ForeColor = System.Drawing.Color.Red;
                lb56d.Font = new Font(lb56d.Font, FontStyle.Bold);
            }
            else
            {
                lb56d.ForeColor = System.Drawing.Color.Black;
                lb56d.Font = new Font(lb56d.Font, FontStyle.Regular);
            }

            lb39d.Text = ref39 == 0 ? "0" : string.Format("{0:#,##0.##}", (Convert.ToDouble(lb39.Text) / ref39));
            if ((Convert.ToDouble(lb39.Text) / ref39) < 1)
            {
                lb39d.ForeColor = System.Drawing.Color.Red;
                lb39d.Font = new Font(lb39d.Font, FontStyle.Bold);
            }
            else
            {
                lb39d.ForeColor = System.Drawing.Color.Black;
                lb39d.Font = new Font(lb39d.Font, FontStyle.Regular);
            }

            lb46d.Text = ref46 == 0 ? "0" : string.Format("{0:#,##0.##}", (Convert.ToDouble(lb46.Text) / ref46));
            if ((Convert.ToDouble(lb46.Text) / ref46) < 1)
            {
                lb46d.ForeColor = System.Drawing.Color.Red;
                lb46d.Font = new Font(lb46d.Font, FontStyle.Bold);
            }
            else
            {
                lb46d.ForeColor = System.Drawing.Color.Black;
                lb46d.Font = new Font(lb46d.Font, FontStyle.Regular);
            }

            lb34d.Text = ref34 == 0 ? "0" : string.Format("{0:#,##0.##}", (Convert.ToDouble(lb34.Text) / ref34));
            if ((Convert.ToDouble(lb34.Text) / ref34) < 1)
            {
                lb34d.ForeColor = System.Drawing.Color.Red;
                lb34d.Font = new Font(lb34d.Font, FontStyle.Bold);
            }
            else
            {
                lb34d.ForeColor = System.Drawing.Color.Black;
                lb34d.Font = new Font(lb34d.Font, FontStyle.Regular);
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Inicia la acción de calculo
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int meses = cbMesSolicita.SelectedIndex + 1;
            //alerta.informacion("", meses.ToString());

            switch (meses)
            {
                case 0:
                    alerta.error("Atención", "Debe seleccionar una cantidad de meses");
                    break;

                default:
                    CalculaMeses(meses);
                    break;

            }
        }

        //Aquí hace una proyección, basado en el calculo mensual que que sea más alto
        private void CalculaMeses(int meses)
        {

            double ref33 = 0;
            double ref52 = 0;
            double ref61 = 0;
            double ref56 = 0;
            double ref39 = 0;
            double ref46 = 0;
            double ref34 = 0;

            try
            {
                if (Convert.ToDouble(lb3330.Text) > Convert.ToDouble(lb3390.Text))
                {
                    ref33 = Convert.ToDouble(lb3330.Text);
                }
                else
                {
                    ref33 = Convert.ToDouble(lb3390.Text);
                }
            }
            catch
            { };

            try
            {
                if (Convert.ToDouble(lb5230.Text) > Convert.ToDouble(lb5290.Text))
                {
                    ref52 = Convert.ToDouble(lb5230.Text);
                }
                else
                {
                    ref52 = Convert.ToDouble(lb5290.Text);
                }
            }
            catch
            { };

            try
            {
                if (Convert.ToDouble(lb6130.Text) > Convert.ToDouble(lb6190.Text))
                {
                    ref61 = Convert.ToDouble(lb6130.Text);
                }
                else
                {
                    ref61 = Convert.ToDouble(lb6190.Text);
                }
            }
            catch
            { };

            try
            {
                if (Convert.ToDouble(lb5630.Text) > Convert.ToDouble(lb5690.Text))
                {
                    ref56 = Convert.ToDouble(lb5630.Text);
                }
                else
                {
                    ref56 = Convert.ToDouble(lb5690.Text);
                }
            }
            catch
            { };

            try
            {
                if (Convert.ToDouble(lb3930.Text) > Convert.ToDouble(lb3990.Text))
                {
                    ref39 = Convert.ToDouble(lb3930.Text);
                }
                else
                {
                    ref39 = Convert.ToDouble(lb3990.Text);
                }
            }
            catch
            { };

            try
            {
                if (Convert.ToDouble(lb4630.Text) > Convert.ToDouble(lb4690.Text))
                {
                    ref46 = Convert.ToDouble(lb4630.Text);
                }
                else
                {
                    ref46 = Convert.ToDouble(lb4690.Text);
                }
            }
            catch
            { };

            try
            {
                if (Convert.ToDouble(lb3430.Text) > Convert.ToDouble(lb3490.Text))
                {
                    ref34 = Convert.ToDouble(lb3430.Text);
                }
                else
                {
                    ref34 = Convert.ToDouble(lb3490.Text);
                }
            }
            catch
            { };

            lb33c.Text = string.Format("{0:#,##0.##}", ((ref33 * meses) - Convert.ToDouble(lb33.Text)));
            if ((ref33 * meses) - Convert.ToDouble(lb33.Text) > 0)
            {
                lb33c.ForeColor = System.Drawing.Color.Purple;
                lb33c.Font = new Font(lb33c.Font, FontStyle.Bold);
            }
            else
            {
                lb33c.ForeColor = System.Drawing.Color.Black;
                lb33c.Font = new Font(lb33c.Font, FontStyle.Regular);

            }

            lb52c.Text = string.Format("{0:#,##0.##}", ((ref52 * meses) - Convert.ToDouble(lb52.Text)));
            if ((ref52 * meses) - Convert.ToDouble(lb52.Text) > 0)
            {
                lb52c.ForeColor = System.Drawing.Color.Purple;
                lb52c.Font = new Font(lb52c.Font, FontStyle.Bold);
            }
            else
            {
                lb52c.ForeColor = System.Drawing.Color.Black;
                lb52c.Font = new Font(lb52c.Font, FontStyle.Regular);
            }

            lb61c.Text = string.Format("{0:#,##0.##}", ((ref61 * meses) - Convert.ToDouble(lb61.Text)));
            if ((ref61 * meses) - Convert.ToDouble(lb61.Text) > 0)
            {
                lb61c.ForeColor = System.Drawing.Color.Purple;
                lb61c.Font = new Font(lb61c.Font, FontStyle.Bold);
            }
            else
            {
                lb61c.ForeColor = System.Drawing.Color.Black;
                lb61c.Font = new Font(lb61c.Font, FontStyle.Regular);
            }

            lb56c.Text = string.Format("{0:#,##0.##}", ((ref56 * meses) - Convert.ToDouble(lb56.Text)));
            if ((ref56 * meses) - Convert.ToDouble(lb56.Text) > 0)
            {
                lb56c.ForeColor = System.Drawing.Color.Purple;
                lb56c.Font = new Font(lb56c.Font, FontStyle.Bold);
            }
            else
            {
                lb56c.ForeColor = System.Drawing.Color.Black;
                lb56c.Font = new Font(lb56c.Font, FontStyle.Regular);
            }

            lb39c.Text = string.Format("{0:#,##0.##}", ((ref39 * meses) - Convert.ToDouble(lb39.Text)));
            if ((ref39 * meses) - Convert.ToDouble(lb39.Text) > 0)
            {
                lb39c.ForeColor = System.Drawing.Color.Purple;
                lb39c.Font = new Font(lb39c.Font, FontStyle.Bold);
            }
            else
            {
                lb39c.ForeColor = System.Drawing.Color.Black;
                lb39c.Font = new Font(lb39c.Font, FontStyle.Regular);
            }

            lb46c.Text = string.Format("{0:#,##0.##}", ((ref46 * meses) - Convert.ToDouble(lb46.Text)));
            if ((ref46 * meses) - Convert.ToDouble(lb46.Text) > 0)
            {
                lb46c.ForeColor = System.Drawing.Color.Purple;
                lb46c.Font = new Font(lb46c.Font, FontStyle.Bold);
            }
            else
            {
                lb46c.ForeColor = System.Drawing.Color.Black;
                lb46c.Font = new Font(lb46c.Font, FontStyle.Regular);
            }

            lb34c.Text = string.Format("{0:#,##0.##}", ((ref34 * meses) - Convert.ToDouble(lb34.Text)));
            if ((ref34 * meses) - Convert.ToDouble(lb34.Text) > 0)
            {
                lb34c.ForeColor = System.Drawing.Color.Purple;
                lb34c.Font = new Font(lb33c.Font, FontStyle.Bold);
            }
            else
            {
                lb34c.ForeColor = System.Drawing.Color.Black;
                lb34c.Font = new Font(lb33c.Font, FontStyle.Regular);
            }


            string proyTitulo = meses == 1 ? "el próximo mes" : "próximos " + meses + " meses";
            lbProyeccion.Text = "Proy. para " + proyTitulo;
            lbProyeccion.Visible = true;
            lb33c.Visible = true;
            lb52c.Visible = true;
            lb61c.Visible = true;
            lb56c.Visible = true;
            lb39c.Visible = true;
            lb46c.Visible = true;
            lb34c.Visible = true;

        }


        //Acá obtiene la información de los CAF que tengan folios disponibles
        private void btnVencimiento_Click(object sender, EventArgs e)
        {
            string id_suc_dte = cbSelSucVence.SelectedValue.ToString();

            Cursor.Current = Cursors.WaitCursor;
            string cnString = "";
            string DB = "";
            DataTable dSuc = new DataTable();
            DataTable dt = new DataTable();

            dSuc = MySql.DatosSucursal(id_sucursal);

            DataRow row = dSuc.Rows[0];
            DB = row["dte_db_mysql"].ToString();

            row = Seguridad.sucDataDesEncripta(row);


            cnString = "SERVER=" + row["ip"] + ";" + "PORT=" + row["puerto_mysql"] + ";" +
            "DATABASE=" + DB + ";" + "UID=" + row["acceso_user_mysql"] + ";" + "PASSWORD=" + row["acceso_pass_mysql"] + "; Convert Zero Datetime=True;";

            try
            {
                //Conexión MySQL
                MySqlConnection connection = new MySqlConnection(cnString);

                connection.Open();

                string sql_query = string.Format(@"SELECT STR_TO_DATE(ExtractValue(rfa.xml_folios, '//FA'), '%Y-%m-%d') as 'autorizado',
                                                DATE_ADD(STR_TO_DATE(ExtractValue(rfa.xml_folios, '//FA'), '%Y-%m-%d'), INTERVAL 6 MONTH) as vencimiento,
                                                CAST(rfa.tipo_doc as CHAR(50)) as tipo_doc,
                                                FORMAT(rfa.desde, 'de_DE') as desde,
                                                FORMAT(rfa.hasta, 'de_DE') as hasta,

                                                Format((select count(*) as cuenta 
                                                                    from detalle_folios as df 
                                                                    where df.folio between rfa.desde and rfa.hasta and df.tipo_doc = rfa.tipo_doc 
                                                                    and utilizado = 0 and sucursal_id = {0} 
                                                                    group by tipo_doc), 'de_DE') as disponibles

                                                FROM rango_folios_asignados as rfa

                                                HAVING disponibles > 0

                                                ORDER BY autorizado desc;", id_suc_dte);

                MySqlDataAdapter da = new MySqlDataAdapter(sql_query, connection);

                da.Fill(dt);

                dgvVencimientos.DataSource = dt;
                dgvVencimientos.Columns[0].HeaderText = "Fecha Autorizacion CAF";
                dgvVencimientos.Columns[1].HeaderText = "Fecha Vencimiento";
                dgvVencimientos.Columns[2].HeaderText = "Tipo Documento";
                dgvVencimientos.Columns[3].HeaderText = "Folio Inicial";
                dgvVencimientos.Columns[4].HeaderText = "Folio Final";
                dgvVencimientos.Columns[5].HeaderText = "Folios aún disponibles";


                //Recorro el datagridview
                for (int fila = 0; fila < dgvVencimientos.Rows.Count; fila++)
                {
                    //Si lleva 5 meses (pero menos de 6) vencido
                    if (DateTime.Now.AddMonths(-5) > (Convert.ToDateTime(dgvVencimientos.Rows[fila].Cells[0].Value.ToString())) &&
                        DateTime.Now.AddMonths(-6) < (Convert.ToDateTime(dgvVencimientos.Rows[fila].Cells[0].Value.ToString())))
                    {
                        //Pregunta... ojo no sea BE o Fac-Exenta p GE, porque estos documentos no vencen
                        if (dgvVencimientos.Rows[fila].Cells[2].Value.ToString() != "39" &&
                            dgvVencimientos.Rows[fila].Cells[2].Value.ToString() != "34" &&
                            dgvVencimientos.Rows[fila].Cells[2].Value.ToString() != "52")
                        {
                            //Pone la linea de color amarillo
                            dgvVencimientos.Rows[fila].DefaultCellStyle.BackColor = Color.Yellow;
                        }
                    }
                    //Si lleva 6 o más vencido
                    else if (DateTime.Now.AddMonths(-6) > (Convert.ToDateTime(dgvVencimientos.Rows[fila].Cells[0].Value.ToString())))
                    {
                        //Pregunta... ojo no sea BE o Fac-Exenta p GE, porque estos documentos no vencen
                        if (dgvVencimientos.Rows[fila].Cells[2].Value.ToString() != "39" &&
                            dgvVencimientos.Rows[fila].Cells[2].Value.ToString() != "34" &&
                            dgvVencimientos.Rows[fila].Cells[2].Value.ToString() != "52")
                        {
                            //Pone la línea de color rojo
                            dgvVencimientos.Rows[fila].DefaultCellStyle.BackColor = Color.Red;
                            dgvVencimientos.Rows[fila].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                }

                for (int fila = 0; fila < dgvVencimientos.Rows.Count; fila++)
                {
                    string tipo_doc = dgvVencimientos.Rows[fila].Cells[2].Value.ToString();
                    DateTime noVence = DateTime.MinValue;

                    switch (tipo_doc)
                    {
                        case "33":
                            dgvVencimientos.Rows[fila].Cells[2].Value = "Factura Electrónica";
                            break;

                        case "52":
                            dgvVencimientos.Rows[fila].Cells[2].Value = "Guía Electrónica";
                            dgvVencimientos.Rows[fila].Cells[1].Value = noVence;
                            break;

                        case "61":
                            dgvVencimientos.Rows[fila].Cells[2].Value = "Nota de Crédito";
                            break;

                        case "56":
                            dgvVencimientos.Rows[fila].Cells[2].Value = "Nota de Débito";
                            break;

                        case "39":
                            dgvVencimientos.Rows[fila].Cells[2].Value = "Boleta Electrónica";
                            dgvVencimientos.Rows[fila].Cells[1].Value = noVence;
                            break;

                        case "46":
                            dgvVencimientos.Rows[fila].Cells[2].Value = "Factura de Compra";
                            break;

                        case "34":
                            dgvVencimientos.Rows[fila].Cells[2].Value = "Factura Exenta";
                            dgvVencimientos.Rows[fila].Cells[1].Value = noVence;
                            break;

                    }

                }


            }

            catch (Exception ex)
            {
                alerta.error("Error Conexión MySQL", "No se pudo conectar con el servidor MySQL" + ex);
            }
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ayuda help = new ayuda("Analisis de Folios", "caf");
            help.Show();
        }

        private void AnalisisFolios_Load(object sender, EventArgs e)
        {

        }
    }
}
