using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorSoporte
{
    internal class ErpTool
    {
        public static string checkCondComerciales(string rut)
        {
            DataTable pagosAtrasados = ErpTool.pagosAtrasados(rut);
            string nombreCliente = ErpTool.nombreCliente(rut);
            string datoAtrazos = "";

            if (pagosAtrasados.Rows.Count > 0)
            {
                string cuentasAtrasadas = "";

                foreach (DataRow dr in pagosAtrasados.Rows)
                {
                    DateTime fch = DateTime.Parse(dr["VENCE"].ToString());
                    int saldo = Int32.Parse(dr["Saldo"].ToString());

                    cuentasAtrasadas += "$" + saldo.ToString("N0") + " " + dr["DOCUMENTO"].ToString() + " " + dr["NUMERO"].ToString() +
                        ", vencida el " + fch.ToString("dd-MM-yyyy") + "\r\n";
                }
                alerta.error("Atención", nombreCliente + " presenta atraso en el pago de los siguientes documentos:\n\n" + cuentasAtrasadas);
                datoAtrazos += nombreCliente + " presenta atraso en el pago de los siguientes documentos:\r\n" + cuentasAtrasadas + "\r\n";
                
                return datoAtrazos;
            }

            return "";

        }

        public static DataTable pagosAtrasados(string rut)
        {
            DataTable dt = new DataTable();

            dt = query(string.Format("SELECT " +
                "(select FANTASIA from DOCMTOS where CODIGO = DOCUMENT) AS DOCUMENTO, " +
                "NUMERO,(select FANTASIA from DOCMTOS where CODIGO = TIPO) AS TIPO, " +
                "VENCE, " +
                "VALOR, " +
                "SALDO " +
                "FROM MOVCTA " +
                "WHERE RUT like '%{0}' AND ESTADO = 'A' AND VENCE < NOW();",rut));
            
            return dt;
        }

        public static string nombreCliente(string rut)
        {
            DataTable dt = new DataTable();

            dt = query(string.Format("select RAZON from CLIENTES where RUT like '%{0}'", rut));
            
            return dt.Rows[0]["RAZON"].ToString();
        }



        // ==================================================================================
        //MySQL para ERP
        public static DataRow datosSrv()
        {
            //Consulta los datos para conectar DB
            string json = FileTool.readFile("config.json"); //Usar la "@" permite una ruta con single "\"

            //Crea una datatable
            DataTable coneccion = new DataTable();
            coneccion.Columns.Add("ip");
            coneccion.Columns.Add("puerto");
            coneccion.Columns.Add("user");
            coneccion.Columns.Add("pass");
            coneccion.Columns.Add("database");
            DataRow data = coneccion.NewRow();

            DataTable dtERP = MySql.selectQuery("select * from config");
            DataRow datosERP = dtERP.Rows[0];

            data["ip"] = datosERP["erp_ip"].ToString();
            data["puerto"] = datosERP["erp_port"].ToString();

            data["user"] = Seguridad.DesEncriptar(datosERP["erp_user"].ToString());
            data["pass"] = Seguridad.DesEncriptar(datosERP["erp_pass"].ToString());

            data["database"] = datosERP["erp_database"].ToString();

            coneccion.Rows.Add(data);

            return coneccion.Rows[0];

        }

        public static string connectString()
        {
            string cnString = "";
            DataRow conData = datosSrv();

            cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE=" + conData["database"] + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            return cnString;
        }

        public static DataTable query(string consulta)
        {
            string cnString = connectString();

            MySqlConnection cn = new MySqlConnection(cnString);

            //alerta.error("", string.Format("select id, nombre, query from sql_queries where tipo = '{0}';", tipo_consulta));

            MySqlCommand cmd = new MySqlCommand(consulta,cn);

            //alerta.error("Error", consulta);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "queries");
                cn.Close();
            }

            catch (Exception)
            {
                throw;
            }

            finally
            {
                cn.Close();
            }

            return D.Tables["queries"];

        }

    }
}
