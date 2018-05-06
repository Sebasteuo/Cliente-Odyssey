using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Cliente
{
    class Class1
    {
        public void Conectar()
        {
            TcpClient client = new TcpClient("localhost", 113);


            String name = "hola";
            byte[] buf;
            buf = Encoding.UTF8.GetBytes(name + "\n");
            NetworkStream stream = client.GetStream();
            stream.Write(buf, 0, name.Length + 1);
            buf = new byte[100];
            stream.Read(buf, 0, 100);
            string xml = Encoding.UTF8.GetString(buf);
            xml = xml.Substring(0, xml.IndexOf(char.ConvertFromUtf32(0)));

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            Console.WriteLine(doc.DocumentElement.Name);

            if (doc.DocumentElement.Name == "error")
            {
                Console.WriteLine("error");
            }
            else if (doc.DocumentElement.Name == "good")
            {
                Console.WriteLine("good");
            }
        }
    }
}
