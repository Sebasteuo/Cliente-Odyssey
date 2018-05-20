using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Xml;

namespace Cliente
{
    /// <summary>
    /// Logica de la coneccion cliente-servidor
    /// </summary>
    class Sockets
    {
        internal Properties.Settings Settings
        {
            get => default(Properties.Settings);
            set
            {
            }
        }
        /// <summary>
        /// Inicia la coneccion
        /// </summary>
        /// <param name="work"> intiger que dice que hacer con la informacion </param>
        /// <param name="String1"> informacion </param>
        /// <param name="String2"> informacion </param>
        /// <param name="String3"> informacion </param>
        /// <param name="String4"> informacion </param>
        /// <param name="String5"> informacion </param>
        /// <param name="String6"> informacion </param>
        /// <returns></returns>
        public static string Conectar(int work, string String1, string String2, string String3, string String4, string String5, string String6)
        {
            TcpClient client = new TcpClient("localhost",3000);//"192.168.100.13"
            if (work == 0)
            {
                string data = work.ToString()+"0";
                byte[] buf;
                buf = Encoding.UTF8.GetBytes(data + "\n");
                NetworkStream stream = client.GetStream();
                stream.Write(buf, 0, data.Length + 1);
                buf = new byte[100];
                stream.Read(buf, 0, 100);
                // obtengo la informacion del servidor en UTF8
                string xml = Encoding.UTF8.GetString(buf);
                // xml va a tener la logica de un documento xml
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
                string data = "13"+ String1+"/" + Path.GetFileName(String2) +"/"+ Convert.ToBase64String(File.ReadAllBytes(String2));
                byte[] buf = Encoding.UTF8.GetBytes(data + "/n");
                NetworkStream stream = client.GetStream();
                hola hola = new hola(stream, buf, data);
                Thread t = new Thread(new ThreadStart(hola.Sad));
                t.Start();t.Join();
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
            if(work == 22)
            {
                string data = work.ToString() + String1 + "/" + String2;
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
            if (work == 33)
            {
                string data = work.ToString() + "/" + String1 + "/" + String2;
                byte[] buf;
                buf = Encoding.UTF8.GetBytes(data + "\n");
                NetworkStream stream = client.GetStream();
                stream.Write(buf, 0, data.Length + 1);
                buf = new byte[100000000];
                stream.Read(buf, 0, 100000000);
                string xml = Encoding.UTF8.GetString(buf);
                Console.WriteLine(buf[1]);
                Console.WriteLine(buf[0]);
                Console.WriteLine(xml);
                //Console.WriteLine(Base64Decode(xml));
            }
            return "false";
        }
        public static string Base64Decode(string cadena)
        {
            var encoder = new System.Text.UTF8Encoding();
            var utf8Decode = encoder.GetDecoder();

            byte[] cadenaByte = Convert.FromBase64String(cadena);
            int charCount = utf8Decode.GetCharCount(cadenaByte, 0, cadenaByte.Length);
            char[] decodedChar = new char[charCount];
            utf8Decode.GetChars(cadenaByte, 0, cadenaByte.Length, decodedChar, 0);
            string result = new String(decodedChar);
            return result;
        }

    }
}
