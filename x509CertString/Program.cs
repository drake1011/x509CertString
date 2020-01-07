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
                Console.Write("Enter Cert Path: ");
                var certPath = Console.ReadLine();

                try
                {
                    var cert = X509Certificate.CreateFromCertFile(certPath);
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
