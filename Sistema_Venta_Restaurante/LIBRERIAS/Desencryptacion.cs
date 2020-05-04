using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Sistema_Venta_Restaurante.LIBRERIAS
{
    class Desencryptacion
    {
        static private AES aes = new AES();
        static public string cnString;
        static string dbcnString;
        static public string appPwdUnique = "Hanazono.Genki.Guitar";
        public static object checkServer()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("ConnectionString.xml");
            XmlElement root = doc.DocumentElement;
            dbcnString = root.Attributes[0].Value;
            cnString = (aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256")));
            return cnString;
        }
        internal class label
        {

        }
        public static object UsuariosEncryp()
        {
            XmlDocument doc = new XmlDocument();
            label root = new label();
            dbcnString = root.ToString();
            cnString = (aes.Decrypt(dbcnString, appPwdUnique, int.Parse("256")));
            return cnString;
        }
    }
}