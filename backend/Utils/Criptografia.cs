using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text;

namespace backend.Utils
{
    public class Criptografia
    {
        public string CriarHash(string txt)
        {
            var md5 = MD5.Create();
            byte[] bytes = Encoding.ASCII.GetBytes(txt);
            byte[] hash = md5.ComputeHash(bytes);

            string sb = string.Empty;

            for(int i = 0; i < hash.Length; i++ )
            {
                sb += hash[i].ToString("X2");
            }

            return sb;
        }     // Testar 
    }
}