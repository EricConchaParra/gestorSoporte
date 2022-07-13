using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GestorSoporte
{
    public static class Seguridad
    {

        public static string Encriptar(string texto)
        {
            try
            {
                string key = JsonTool.searchJsonFor(FileTool.readFile("config.json"), "key"); //llave para encriptar datos

                byte[] keyArray;

                byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);

                //Se utilizan las clases de encriptación MD5

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                //Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateEncryptor();

                byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);

                tdes.Clear();

                //se regresa el resultado en forma de una cadena
                texto = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);

            }
            catch (Exception)
            {

            }
            return texto;
        }

        public static string DesEncriptar(string textoEncriptado)
        {
            try
            {
                string key = JsonTool.searchJsonFor(FileTool.readFile("config.json"), "key"); //llave para encriptar datos
                byte[] keyArray;
                byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);

                //algoritmo MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();

                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));

                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();

                byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);

                tdes.Clear();
                textoEncriptado = UTF8Encoding.UTF8.GetString(resultArray);

            }
            catch (Exception)
            {

            }
            return textoEncriptado;
        }

        public static DataRow sucDataDesEncripta (DataRow sucData1)
        {
            DataRow sucData = sucData1;

            sucData["ip"] = DesEncriptar(sucData["ip"].ToString());
            sucData["root_user"] = DesEncriptar(sucData["root_user"].ToString());
            sucData["root_pass"] = DesEncriptar(sucData["root_pass"].ToString());
            sucData["regular_user"] = DesEncriptar(sucData["regular_user"].ToString());
            sucData["regular_pass"] = DesEncriptar(sucData["regular_pass"].ToString());
            sucData["root_user_mysql"] = DesEncriptar(sucData["root_user_mysql"].ToString());
            sucData["root_pass_mysql"] = DesEncriptar(sucData["root_pass_mysql"].ToString());
            sucData["acceso_user_mysql"] = DesEncriptar(sucData["acceso_user_mysql"].ToString());
            sucData["acceso_pass_mysql"] = DesEncriptar(sucData["acceso_pass_mysql"].ToString());
            sucData["gestor_dte_user"] = DesEncriptar(sucData["gestor_dte_user"].ToString());
            sucData["gestor_dte_pass"] = DesEncriptar(sucData["gestor_dte_pass"].ToString());
            return sucData;
        }


        public static DataRow sucDataEncripta(DataRow sucData1)
        {
            DataRow sucData = sucData1;

            sucData["ip"] = Encriptar(sucData["ip"].ToString());
            sucData["root_user"] = Encriptar(sucData["root_user"].ToString());
            sucData["root_pass"] = Encriptar(sucData["root_pass"].ToString());
            sucData["regular_user"] = Encriptar(sucData["regular_user"].ToString());
            sucData["regular_pass"] = Encriptar(sucData["regular_pass"].ToString());
            sucData["root_user_mysql"] = Encriptar(sucData["root_user_mysql"].ToString());
            sucData["root_pass_mysql"] = Encriptar(sucData["root_pass_mysql"].ToString());
            sucData["acceso_user_mysql"] = Encriptar(sucData["acceso_user_mysql"].ToString());
            sucData["acceso_pass_mysql"] = Encriptar(sucData["acceso_pass_mysql"].ToString());
            sucData["gestor_dte_user"] = Encriptar(sucData["gestor_dte_user"].ToString());
            sucData["gestor_dte_pass"] = Encriptar(sucData["gestor_dte_pass"].ToString());
            return sucData;
        }

    }


}
