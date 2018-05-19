using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Xml;

namespace Cliente
{
    class Sockets
    {
        internal Properties.Settings Settings
        {
            get => default(Properties.Settings);
            set
            {
            }
        }

        public static object data { get; private set; }

        static void metodo()
        {
            Console.WriteLine("hola");
        }
        public static string Conectar(int work, string String1, string String2, string String3, string String4, string String5, string String6)
        {
            TcpClient client = new TcpClient("localhost",5000);//"192.168.100.13"
            if (work == 0)
            {
                string data = work.ToString()+"0";
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

            if (work == 10)
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
            if (work == 12)
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
            if (work == 13)
            {
                string data = "33"+ String1+"/" + Path.GetFileName(String2) +"/"+ Convert.ToBase64String(File.ReadAllBytes(String2));
                byte[] buf = Encoding.UTF8.GetBytes(data + "/n");
                NetworkStream stream = client.GetStream();
                hola hola = new hola(stream, buf, data);
                Thread t = new Thread(new ThreadStart(hola.Sad));
                t.Start();
                while (t.IsAlive) { }
                client.Close();
                return "true";
            }
            if(work == 17)
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
            if (work == 18)
            {
                string data = work.ToString() + "/" + String1;
                byte[] buf;
                buf = Encoding.UTF8.GetBytes(data + "\n");
                NetworkStream stream = client.GetStream();
                stream.Write(buf, 0, data.Length + 1);
                buf = new byte[10000];
                stream.Read(buf, 0, 10000);
                string xml = Encoding.UTF8.GetString(buf);
                xml = xml.Substring(0, xml.IndexOf(char.ConvertFromUtf32(0)));
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                return doc.DocumentElement.InnerText;
            }
            if (work == 19)
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
                return doc.DocumentElement.InnerText;
            }
            if (work == 20)
            {
                string data = work.ToString()+String2 + "/" + String1;
                byte[] buf;
                buf = Encoding.UTF8.GetBytes(data + "\n");
                NetworkStream stream = client.GetStream();
                stream.Write(buf, 0, data.Length + 1);
                buf = new byte[100000];
                stream.Read(buf, 0, 100000);
                string xml = Encoding.UTF8.GetString(buf);
                xml = xml.Substring(0, xml.IndexOf(char.ConvertFromUtf32(0)));
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                return doc.DocumentElement.InnerText;
            }
            if (work == 23)
            {
                string data = work.ToString() + "/" + String1 + "/" + String2;
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
