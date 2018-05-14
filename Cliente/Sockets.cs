using System;
using System.Net.Sockets;
using System.Text;
using System.Xml;

namespace Cliente
{
    class Sockets
    {
<<<<<<< HEAD
        public static string Conectar(int work, string nick, string name, string edad, string genero, string contra, string amigos)
        {
            TcpClient client = new TcpClient("localhost", 113);
=======
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
>>>>>>> ce26871e79a0e822fa38d7c850e0ab12fd67706b

            if (work == 1)
            {

<<<<<<< HEAD
                string data = work.ToString() + "/" + nick + "/" + name + "/" + edad + "/" + genero + "/" + contra + "/" + amigos;
=======
                string data = work.ToString() + "/" + String1 + "/" + String2 + "/" + String3 + "/" + String4 + "/" + String5 + "/" + String6;
>>>>>>> ce26871e79a0e822fa38d7c850e0ab12fd67706b
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
<<<<<<< HEAD
=======
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
>>>>>>> ce26871e79a0e822fa38d7c850e0ab12fd67706b
            }
            return "false";
        }
    }
}
