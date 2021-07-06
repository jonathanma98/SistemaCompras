using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CapaUtilidades
{
    //en esta clase se resiven los datos los cuales deseamos encriptar antes de enviar a la base de datos 
    //Install-Package System.Security.Cryptography.Cng -Version 5.0.0 
    //Algoritmo sacado de https://hdeleon.net/funcion-para-encriptar-en-sha256-en-c-net/
    public class csEncryp
    {
        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
    }
}
