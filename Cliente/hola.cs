using System;
using System.Net.Sockets;

namespace Cliente
{
    /// <summary>
    /// Envia la cancion
    /// </summary>
    class hola
    {
        NetworkStream stream;
        byte[] buf;
        string data;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="stream"> coneccion </param>
        /// <param name="buf"> los byte de la cancion </param>
        /// <param name="data"> string base64 </param>
        public hola(NetworkStream stream, byte[] buf, string data)
        {
            this.buf = buf;
            this.data = data;
            this.stream = stream;
        }
        /// <summary>
        /// Envia los byte de la cancion
        /// </summary>
        public void Sad()
        {
            stream.Write(buf, 0, data.Length + 1);
        }
    }
}
