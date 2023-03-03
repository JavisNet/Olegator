using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace School_System.Class
{
    internal class Module
    {
        public static string MOD(string sourceStr)
        {
            var sha = new SHA1Managed();
            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(sourceStr));
            return Convert.ToBase64String(hash);
        }
    }
}
