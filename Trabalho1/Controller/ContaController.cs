using Microsoft.Crm.Sdk.Messages;
using Microsoft.Rest;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1
{
    public class ContaController
    {
        public CrmServiceClient ServiceClient { get; set; }
        public Conta Conta { get; set; }

        public ContaController(CrmServiceClient crmServiceCliente)
        {
            ServiceClient = crmServiceCliente;
            this.Conta = new Conta(ServiceClient);
        }

        public Guid Create()
        {
            return Conta.Create();
        }

        //public bool Update(Guid accountId, string telephone1)
        //{
        //    return Conta.Update(accountId, telephone1);
        //}

        //public bool Delete(Guid accountId)
        //{
        //    return Conta.Delete(accountId);
        //}

        public Entity GetAccountByName(string name)
        {
            return Conta.GetAccountByName(name);
        }

        //public void UpsertMultipleRequest(EntityCollection entityCollection)
        //{
        //    Conta.UpsertMultipleRequest(entityCollection);
        //}
    }
}
