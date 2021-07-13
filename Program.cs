using System.IO;
using System;
using System.Threading.Tasks;

namespace cadastroClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente.lerClientes();

            Cliente jonisvaldo = new Cliente();
            jonisvaldo.nome = "Jonisvaldo";
            jonisvaldo.telefone = "36221994";
            jonisvaldo.cpf = "49481828859";
            jonisvaldo.gravar();

            Cliente creuza = new Cliente();
            creuza.nome = "Creuza";
            creuza.telefone = "12445796";
            creuza.cpf = "21543487";
            creuza.gravar();

            Cliente.verClientes();
            Cliente.fecharInputs();
            Console.Read();

        }
        
    }
}
