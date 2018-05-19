using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cliente
{
    class hola
    {
        NetworkStream stream;
        byte[] buf;
        string data;

        public hola(NetworkStream stream, byte[] buf, string data)
        {
            this.buf = buf;
            this.data = data;
            this.stream = stream;
        }
        public void Sad()
        {
            Console.WriteLine("hola");
            stream.Write(buf, 0, data.Length + 1);
        }
    }
}
