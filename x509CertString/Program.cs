using System;
using System.Security.Cryptography.X509Certificates;

namespace x509CertString
{
    class Program
    {
        static void Main()
        {
            do
            {
                Console.Write("Enter pfx Cert Path: ");
                var certPath = Console.ReadLine();
                Console.Write("Enter pfx Cert Password: ");
                var certPass = Console.ReadLine();
                try
                {
                    X509Certificate cert = new X509Certificate(certPath, certPass);
                    var results = cert.GetPublicKeyString();
                    Console.WriteLine(results);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            } 
            while (1 == 1);
        }
    }
}
