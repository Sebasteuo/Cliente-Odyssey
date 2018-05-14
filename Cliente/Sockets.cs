using System;
using System.Net.Sockets;
using System.Text;
using System.Xml;

namespace Cliente
{
    class Sockets
    {
        public static string Conectar(int work, string String1, string String2, string String3, string String4, string String5, string String6)
        {
            TcpClient client = new TcpClient("localhost", 8000);
            if (work == 0)
            {
                string data = work.ToString();
                byte[] buf;
                buf = Encoding.UTF8.GetBytes(data + "\n");
                NetworkStream stream = client.GetStream();
                stream.Write(buf, 0, data.Length + 1);
                buf = new byte[100];
                stream.Read(buf, 0, 100);
                string xml = Encoding.UTF8.GetString(buf);
                xml = xml.Substring(0, xml.IndexOf(char.ConvertFromUtf32(0)));
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                string nombre = doc.DocumentElement.InnerText;
                return nombre;
            }

            if (work == 1)
            {

                string data = work.ToString() + "/" + String1 + "/" + String2 + "/" + String3 + "/" + String4 + "/" + String5 + "/" + String6;
                byte[] buf;
                buf = Encoding.UTF8.GetBytes(data + "\n");
                NetworkStream stream = client.GetStream();
                stream.Write(buf, 0, data.Length + 1);
                buf = new byte[100];
                stream.Read(buf, 0, 100);
                string xml = Encoding.UTF8.GetString(buf);
                xml = xml.Substring(0, xml.IndexOf(char.ConvertFromUtf32(0)));
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);

                Console.WriteLine(doc.DocumentElement.Name);
                if (doc.DocumentElement.Name == "true")
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            if (work == 2)
            {
                string data = work.ToString() + "/" +  String1 + "/" + String2;
                byte[] buf;
                buf = Encoding.UTF8.GetBytes(data + "\n");
                NetworkStream stream = client.GetStream();
                stream.Write(buf, 0, data.Length + 1);
                buf = new byte[100];
                stream.Read(buf, 0, 100);
                string xml = Encoding.UTF8.GetString(buf);
                xml = xml.Substring(0, xml.IndexOf(char.ConvertFromUtf32(0)));
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                return doc.DocumentElement.Name;
            }
            if(work == 7)
            {
                string data = work.ToString() + "/" + String1 + "/" + String2 + "/" + String3;
                byte[] buf;
                buf = Encoding.UTF8.GetBytes(data + "\n");
                NetworkStream stream = client.GetStream();
                stream.Write(buf, 0, data.Length + 1);
                buf = new byte[100];
                stream.Read(buf, 0, 100);
                string xml = Encoding.UTF8.GetString(buf);
                xml = xml.Substring(0, xml.IndexOf(char.ConvertFromUtf32(0)));
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                return doc.DocumentElement.Name;
            }
            if (work == 8)
            {

            }
            if (work == 9)
            {
                string data = work.ToString() + "/" + String1 ;
                byte[] buf;
                buf = Encoding.UTF8.GetBytes(data + "\n");
                NetworkStream stream = client.GetStream();
                stream.Write(buf, 0, data.Length + 1);
                buf = new byte[100];
                stream.Read(buf, 0, 100);
                string xml = Encoding.UTF8.GetString(buf);
                xml = xml.Substring(0, xml.IndexOf(char.ConvertFromUtf32(0)));
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                return doc.DocumentElement.Name;
            }
            return "false";
        }
    }
}
