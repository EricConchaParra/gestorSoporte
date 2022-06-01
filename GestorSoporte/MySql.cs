using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorSoporte
{
    class MySql
    {


        public static DataTable VerClientes()
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            MySqlCommand cmd = new MySqlCommand(string.Format("select c.rut as rut, c.fantasia as fantasia, c.razon_social as razon_social, f.nombre as funcionario" +
                " from clientes as c" +
                " inner join funcionarios as f on c.funcionario = f.id" +
                " where c.activo = 1 or c.activo = 2" + //Clientes "activo" o "Con Observaciones"
                " order by fantasia asc;"), cn);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "Clientes");
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

            return D.Tables["Clientes"];

        }


        public static int VerificaUsuario(string user, string pass)
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            MySqlCommand cmd = new MySqlCommand(string.Format("select count(*) as filas from usuarios where nombre = '{0}' and password = '{1}';", user, pass), cn);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "nSucursales");
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

            DataTable nSucT = D.Tables["nSucursales"];
            DataRow nSucR = nSucT.Rows[0];
            String sSuc = nSucR["filas"].ToString();
            int userOk = Int32.Parse(sSuc);

            return userOk;
        }


        public static DataRow AccesoUsuario(string user, string pass)
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            MySqlCommand cmd = new MySqlCommand(string.Format("select * from usuarios where nombre = '{0}' and password = '{1}';", user, pass), cn);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "usuario");
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

            DataTable nSucT = D.Tables["usuario"];
            DataRow nSucR = nSucT.Rows[0];
            return nSucR;
        }



        public static DataTable VerTodosClientes()
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            MySqlCommand cmd = new MySqlCommand(string.Format("select c.rut as rut, c.fantasia as fantasia, c.razon_social as razon_social, f.nombre as funcionario" +
                " from clientes as c" +
                " inner join funcionarios as f on c.funcionario = f.id" +
                " order by fantasia asc;"), cn);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "Clientes");
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

            return D.Tables["Clientes"];

        }



        public static DataTable BuscaClientes(string busqueda)
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            MySqlCommand cmd = new MySqlCommand(string.Format("select c.rut as rut, c.fantasia as fantasia, c.razon_social as razon_social, f.nombre as funcionario" +
                " from clientes as c" +
                " inner join funcionarios as f on c.funcionario = f.id" +
                " where c.activo = 1 and (c.fantasia like '%{0}%' or c.razon_social like '%{0}%' or f.nombre like '%{0}%') " +
                " order by c.fantasia asc;", busqueda), cn);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "Clientes");
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

            return D.Tables["Clientes"];

        }

        public static DataTable BuscaTodosClientes(string busqueda)
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            MySqlCommand cmd = new MySqlCommand(string.Format("select c.rut as rut, c.fantasia as fantasia, c.razon_social as razon_social, f.nombre as funcionario" +
                " from clientes as c" +
                " inner join funcionarios as f on c.funcionario = f.id" +
                " where c.fantasia like '%{0}%' or c.razon_social like '%{0}%' or f.nombre like '%{0}%' " +
                " order by c.fantasia asc;", busqueda), cn);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "Clientes");
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

            return D.Tables["Clientes"];

        }



        public static int CuentaSucursalesCliente(string id_cliente)
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            MySqlCommand cmd = new MySqlCommand(string.Format("select count(*) as nSuc from sucursales where fk_cliente = '{0}';", id_cliente), cn);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "nSucursales");
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

            DataTable nSucT = D.Tables["nSucursales"];
            DataRow nSucR = nSucT.Rows[0];
            String sSuc = nSucR["nSuc"].ToString();
            int nSuc = Int32.Parse(sSuc);

            return nSuc;
        }



        public static DataTable VerSucursalesCliente(string id_cliente)
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            MySqlCommand cmd = new MySqlCommand(string.Format("select sucursal_correl, sucursal_nombre, ip, id from sucursales where fk_cliente = '{0}';", id_cliente), cn);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "Sucursales");
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

            return D.Tables["Sucursales"];

        }


        public static DataTable Queries(string tipo_consulta)
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            //alerta.error("", string.Format("select id, nombre, query from sql_queries where tipo = '{0}';", tipo_consulta));

            MySqlCommand cmd = new MySqlCommand(string.Format("select id, nombre, query from sql_queries where tipo = '{0}';", tipo_consulta), cn);

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


        public static DataTable DatosSucursal(string id_sucursal)
        {

            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            MySqlCommand cmd = new MySqlCommand(string.Format("select * from sucursales where id = {0};",id_sucursal), cn);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "datos_sucursal");
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

            return D.Tables["datos_sucursal"];

        }


        public static DataTable DatosCasaMatriz(string id_sucursal)
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            string sCmd = string.Format("select * from sucursales where fk_cliente = '{0}' and sucursal_correl = 1;", id_sucursal);
            MySqlCommand cmd = new MySqlCommand(sCmd, cn);
            //alerta.aviso("",sCmd);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "datos_sucursal");
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

            return D.Tables["datos_sucursal"];

        }


        public static DataTable DatosCliente(string rut_cliente)
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            string sCmd = string.Format("select * from clientes where rut = '{0}';", rut_cliente);
            MySqlCommand cmd = new MySqlCommand(sCmd, cn);
            //alerta.aviso("",sCmd);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "datos_cliente");
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

            return D.Tables["datos_cliente"];

        }

        public static DataTable VerFuncionarios()
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            string sCmd = string.Format("select * from funcionarios;");
            MySqlCommand cmd = new MySqlCommand(sCmd, cn);
            //alerta.aviso("",sCmd);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "funcionarios");
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

            return D.Tables["funcionarios"];

        }


        public static void borraSucursal(string id_sucursal)
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            string sCmd = string.Format("delete from sucursales where id = {0};", id_sucursal);
            MySqlCommand cmd = new MySqlCommand(sCmd, cn);
            //alerta.aviso("",sCmd);

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
            }

        }

        public static string verNotasCliente (string id_cliente)
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            MySqlCommand cmd = new MySqlCommand(string.Format("select notas from clientes where rut = '{0}';", id_cliente), cn);

            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "notas");
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

            DataTable nSucT = D.Tables["notas"];
            DataRow nSucR = nSucT.Rows[0];
            String notas = nSucR["notas"].ToString();
            
            return notas;
        }

        public static void grabaNotasCliente(string notas1, string fk_cliente1)
        {
            DataRow conData = SelConnection.conData;
            string notas = notas1;
            string rut = fk_cliente1;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            MySqlCommand cmd = new MySqlCommand(string.Format("update clientes set notas = '{0}' where rut = '{1}';", notas, rut), cn);

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
            }

        }

        public static DataTable VerQuery(int id_query)
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            string sCmd = string.Format("select * from sql_queries where id = {0};",id_query);
            MySqlCommand cmd = new MySqlCommand(sCmd, cn);
            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "query");
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

            return D.Tables["query"];

        }

        public static void BorraQuery(int id_query)
        {
            DataRow conData = SelConnection.conData;
            int id = id_query;


            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            MySqlCommand cmd = new MySqlCommand(string.Format("delete from sql_queries where id = '{0}';", id), cn);

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
            }

        }

        public static DataTable VerEnlances()
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            string sCmd = string.Format("select * from enlaces;");
            MySqlCommand cmd = new MySqlCommand(sCmd, cn);
            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "enlaces");
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

            return D.Tables["enlaces"];

        }


        public static String Ayuda(string tema)
        {
            DataRow conData = SelConnection.conData;

            string cnString = "SERVER=" + conData["ip"] + ";" + "PORT=" + conData["puerto"] + ";" +
                                "DATABASE= s_manager" + ";" + "UID=" + conData["user"] + ";" + "PASSWORD=" + conData["pass"] + ";";

            MySqlConnection cn = new MySqlConnection(cnString);

            string sCmd = string.Format("select * from ayuda where tema = '{0}';", tema);
            MySqlCommand cmd = new MySqlCommand(sCmd, cn);
            DataSet D = new DataSet();

            try
            {
                cn.Open();
                MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "tema");
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

            DataTable dt = new DataTable();
            dt = D.Tables["tema"];
            DataRow row = dt.Rows[0];
            return row["contenido"].ToString();


        }


    }

}

