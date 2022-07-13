using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GestorSoporte
{
    internal class JsonTool
    {
        public static string searchJsonFor(string json, string field)
        {
            JObject rss = JObject.Parse(json);
            //Para un dato dentro de otro objeto usar 👇
            //string data = (string)rss["channel"]["title"];
            string data = (string)rss[field];
            return data;
        }
        public static string createJson(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }

        public static string editJson(string json, string clave, string newValue)
        {
            JObject rss = JObject.Parse(json);

            rss[clave] = newValue;

            return rss.ToString();
        }



    }
}
