using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Net;

namespace WinApt.Common
{
    public class WinAptLib
    {
        public static int NoFile = 0;
        public static int Downloaded = 1;
        public static int NewVersion = 2;
        //public enum State
        //{
        //    NoFile = 0,
        //    Downloaded = 1,
        //    NewVersion = 2
        //}
        public static void WriteToFile(object o, string fileName)
        {
            XmlSerializer x = new XmlSerializer(o.GetType());
            TextWriter writer = new StreamWriter(fileName);
            x.Serialize(writer, o);
            writer.Close();
        }

        public static object ReadFromFile(Type t, string fileName)
        {
            XmlSerializer x = new XmlSerializer(t);
            FileStream reader = new FileStream(fileName, FileMode.Open);
            object o = x.Deserialize(reader);
            reader.Close();
            return o;
        }

        public static string getPageContent(string url)
        {
            HttpWebRequest request = (HttpWebRequest)
            WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader srd = new StreamReader(response.GetResponseStream());
            string ret = srd.ReadToEnd();
            srd.Close();
            return ret;
        }

        public static object ReadFromStream(Type t, string content)
        {
            XmlSerializer x = new XmlSerializer(t);
            StringReader reader = new StringReader(content);
            object o = x.Deserialize(reader);
            reader.Close();
            return o;
        }
    }
}
