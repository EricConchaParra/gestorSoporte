using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorSoporte
{
    class SqLite
    {
        public static SQLiteConnection cn = new SQLiteConnection("data source=C:/SoporteManager/data/db.db");

        public static DataSet D;

        public static DataTable VerConexiones()
        {
            SQLiteCommand cmd = new SQLiteCommand(string.Format("select id, nombre from connections"), cn);

            try
            {
                cn.Open();
                SQLiteDataAdapter DA = new SQLiteDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "Connections");
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

            return D.Tables["Connections"];
        }


        public static DataTable VerDatosConexion(string id_connection)
        {
            SQLiteCommand cmd = new SQLiteCommand(string.Format("select ip, user, pass, puerto from connections where id = {0}", id_connection), cn);

            try
            {
                cn.Open();
                SQLiteDataAdapter DA = new SQLiteDataAdapter(cmd);
                D = new DataSet();
                DA.Fill(D, "Connection");
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

            return D.Tables["Connection"];
        }


    }
}
