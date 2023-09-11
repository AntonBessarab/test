using System;
using System.Security.Cryptography;

namespace Lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rndNumberGenerator = new RNGCryptoServiceProvider();
            var randomNumber = new byte[3];
            rndNumberGenerator.GetBytes(randomNumber);
            string base64String = Convert.ToBase64String(randomNumber);
            Console.WriteLine(base64String);
        }
    }
}
