using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1
{
    public class Singleton
    {
        public static CrmServiceClient GetService()
        {
            string url = "org874f1a45";
            string clientId = "3cfe7f41-6f45-4509-9ba4-e3f63c80dfb2";
            string clientSecret = "XB28Q~8q_eu_ocAEJSlAP9ma5NJHMnoR.WN6_aNJ";

            CrmServiceClient serviceClient = new CrmServiceClient($"AuthType=ClientSecret;Url=https://{url}.crm2.dynamics.com/;AppId={clientId};ClientSecret={clientSecret};");

            if (!serviceClient.CurrentAccessToken.Equals(null))
                Console.WriteLine("Conexão Realizada com Sucesso");
            else
                Console.WriteLine("Erro na conexão");

            return serviceClient;
        }
    }
}
