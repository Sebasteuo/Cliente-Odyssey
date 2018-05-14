using System;
using System.Net.Sockets;
using System.Text;
using System.Xml;

namespace Cliente
{
    class Sockets
    {
        public static string Conectar(int work, string nick, string name, string edad, string genero, string contra, string amigos)
        {
            TcpClient client = new TcpClient("localhost", 113);

            if (work == 1)
            {

                string data = work.ToString() + "/" + nick + "/" + name + "/" + edad + "/" + genero + "/" + contra + "/" + amigos;
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
            return "false";
        }
    }
}
