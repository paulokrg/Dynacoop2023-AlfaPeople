using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Trabalho1
{
    class Program
    {
        static void Main(string[] args)
        {
            CrmServiceClient serviceClient = Singleton.GetService();

            ContaController contaController = new ContaController(serviceClient);

            RetrieveMethods(contaController);

            //EntityCollection accountsToExecute = new EntityCollection();

            //Entity account1 = new Entity("account");
            //account1["name"] = "Conta 1";
            //accountsToExecute.Entities.Add(account1);

            //Entity account2 = new Entity("account", new Guid("81883308-7ad5-ea11-a813-000d3a33f3b4"));
            //account2["name"] = "Conta 2";
            //accountsToExecute.Entities.Add(account2);

            //contaController.UpsertMultipleRequest(accountsToExecute);

            //Console.WriteLine("Contas Criadas e Atualizadas com Sucesso");

            Console.ReadKey();
        }

        private static void RetrieveMethods(ContaController contaController)
        {
            MakeCreateAndUpdate(contaController);

            Console.WriteLine("Por favor informe o nome da Conta");
            var accountName = Console.ReadLine();
            accountName = "Conta Teste 1";

            Entity account = contaController.GetAccountByName(accountName);
            ShowAccountName(account);

            //Console.WriteLine("Por favor informe o campo1");
            //var campo1 = Console.ReadLine();
            //Console.WriteLine("Por favor informe o campo2");
            //var campo2 = Console.ReadLine();
            //Console.WriteLine("Por favor informe o campo3");
            //var campo3 = Console.ReadLine();
            //Console.WriteLine("Por favor informe o campo4");
            //var campo4 = Console.ReadLine();

            //Console.WriteLine("Você deseja criar um contato para essa conta? (S/N)");

            Console.ReadKey();
        }

        private static void ShowAccountName(Entity account)
        {
            Console.WriteLine($"A conta recuperada se chama {account["name"].ToString()}");
        }

        //private static void CreateUpdateDelete(ContaController contaController)
        //{
        //    Console.WriteLine("Digite 1 para Create/Update");
        //    Console.WriteLine("Digite 2 para Delete");

        //    var answerWhatToDo = Console.ReadLine();

        //    if (answerWhatToDo.ToString() == "1")
        //    {
        //        MakeCreateAndUpdate(contaController);
        //    }
        //    else
        //    {
        //        if (answerWhatToDo.ToString() == "2")
        //        {
        //            MakeDelete(contaController);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Opção inválida, reinicie o aplicativo");
        //        }
        //    }
        //}

        //private static void MakeDelete(ContaController contaController)
        //{
        //    Console.WriteLine("Digite o id da conta que você quer deletar");
        //    var accountId = Console.ReadLine();
        //    contaController.Delete(new Guid(accountId));
        //    Console.WriteLine("Deletado com sucesso!");
        //}

        private static void MakeCreateAndUpdate(ContaController contaController)
        {
            Console.WriteLine("Aguarde enquanto a nova Conta é criada");
            Guid accountId = contaController.Create();
            Console.WriteLine("Conta criada com sucesso");

            Console.WriteLine($"https://org874f1a45.crm2.dynamics.com/main.aspx?appid=4d306bb3-f4a9-ed11-9885-000d3a888f48&pagetype=entityrecord&etn=account&id={accountId}");

            //Console.WriteLine("Você deseja criar um contato para essa conta? (S/N)");
            //var answerToUpdate = Console.ReadLine();

            //if (answerToUpdate.ToString().ToUpper() == "S")
            //{
            //    Console.WriteLine("Por favor informe o novo telefone");
            //    var newTelephone = Console.ReadLine();
            //    bool contaAtualizada = contaController.Update(accountId, newTelephone);

            //    if (contaAtualizada)
            //        Console.WriteLine("Conta atualizada com sucesso");
            //    else
            //        Console.WriteLine("Erro na atualização da conta");
            //}
        }
    }
}
