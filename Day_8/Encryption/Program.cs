using System;
using System.Security.Cryptography;
using System.Text;

namespace Encryption
{
    internal class Program
    {
        
    }
}



/*static void Main(string[] args)
        {
            string Hashvalue = Hashpassword("Samar@123");
            Console.WriteLine(Hashvalue);
        }
        public static string Hashpassword(string password)
        {
            using (SHA256 shal = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password);
                var hash = shal.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }*/