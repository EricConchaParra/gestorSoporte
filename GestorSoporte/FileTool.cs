using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorSoporte
{
    internal class FileTool
    {
        public static string readFile(string ruta)
        {
            //string fileString = File.ReadAllText(@"C:\desarrollo\ControlSala\ControlSala\config.json");
            string fileString = File.ReadAllText(ruta);
            return fileString;
        }

        public static void modifyFile(string ruta, string newText)
        {
            File.WriteAllText(ruta, newText);
        }

    }
}
