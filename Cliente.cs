using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastroClientes
{
    class Cliente
    {
        public string nome;
        public string telefone;
        public string cpf;

        /*public static List<Cliente> lerClientes()
        {
            var clientes = new List<Cliente>(); 
            return clientes;
        }*/

        public void gravar()
        {

        }

        static List<Cliente> clientes = new List<Cliente>();
        static StreamReader leitor = new StreamReader(caminhoDBCliente());
        //StreamWriter escritor = new(caminhoDBCliente());

        public static string caminhoDBCliente()
        {
            string caminho = @"C:\Users\Shadow\Documents\things progaming\c#\arquivo\file1.txt";
            return caminho;
        }

        public static List<Cliente> lerClientes()
        {
            if (File.Exists(caminhoDBCliente()))
            {
                using (StreamReader leitor = new StreamReader(caminhoDBCliente()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = leitor.ReadLine()) != null)
                    {
                        i++;
                        if (i > 1)
                        {
                            var clienteArquivo = linha.Split(';');
                            Cliente cliente = new Cliente();

                            cliente.nome = clienteArquivo[0];
                            cliente.telefone = clienteArquivo[1];
                            cliente.cpf = clienteArquivo[2];
                            clientes.Add(cliente);
                        }

                    }
                }
            }
            return clientes;
        }

        public static void verClientes()
        { 
            int id;
            int cont = clientes.Count();
            for (id = 0; id < cont; id++)
            {
                Console.WriteLine("Cliente {0}", id);
                Console.WriteLine("Nome......: {0}", clientes[id].nome);
                Console.WriteLine("Telefone..: {0}", clientes[id].telefone);
                Console.WriteLine("CPF.......: {0}", clientes[id].cpf);
            }
        }

        public static void fecharInputs()
        {
            leitor.Close();
            //escritor.Close();
        }
    }
}
