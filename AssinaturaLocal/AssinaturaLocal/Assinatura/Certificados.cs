using System;
using System.Security.Cryptography.X509Certificates;

namespace AssinaturaLocal
{
    class Certificados
    {
        public Certificados(){}

        public X509Certificate2 buscaCertificado(String cnpj)
        {
            X509Certificate2Collection lcerts;
            X509Store lStore = new X509Store(StoreName.My, StoreLocation.CurrentUser);
            
            lStore.Open(OpenFlags.ReadOnly);
            
            lcerts = lStore.Certificates;
            X509Certificate2 cert = null;
            foreach (X509Certificate2 elemento in lcerts)
            {
                if (elemento.Subject.Contains(cnpj))
                {
                    cert = elemento;
                    lStore.Close();
                    return cert;
                }
            }
            lStore.Close();
            return cert;
        }


    }
}
