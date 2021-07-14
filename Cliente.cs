using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Console_App_Clientes_Console
{
    class Cliente
    {
        public string nome;
        public string telefone;
        public string cpf;
        static List<Cliente> clientes = new List<Cliente>();

        public Cliente(string _nome, string _telefone, string _cpf)
        {
            this.nome = _nome;
            this.telefone = _telefone;
            this.cpf = _cpf;
        }


        //metodo salvar para clientes no arquivo txt
        public static void gravar(Cliente c)
        {
            clientes.Add(c);
            retornaClientes();
            lerClientes();
        }


        //caminho do txt a ser ultilizado
        public static string caminhoDBCliente()
        {
            string caminho = @"../../db/file1.txt";
            return caminho;
        }


        //metodo para retorna todos os clientes ja escritos no txt
        private static void retornaClientes()
        {
            using (StreamWriter escritor = new StreamWriter(caminhoDBCliente()))
            {
                string linha = "nome;telefone;cpf;";
                if (File.Exists(caminhoDBCliente()))
                {
                    escritor.WriteLine(linha);
                    foreach (Cliente c in clientes)
                    {
                        linha = c.nome + ";" + c.telefone + ";" + c.cpf + ";";
                        escritor.WriteLine(linha);
                    }
                    escritor.Close();
                }
            }
        }

        // metodo para ler todos os clinetes dentro do txt
        public static void lerClientes()
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
                            clientes.Add(new Cliente(clienteArquivo[0], clienteArquivo[1], clienteArquivo[2]));
                        }

                    }
                    leitor.Close();
                }
            }
            //return clientes;
        }

        //metodo para mostrar todos os clientes no txt
        public static void verClientes()
        {
            int id;
            int cont = clientes.Count();
            for (id = 0; id < cont; id++)
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Cliente {0}", id);
                Console.WriteLine("Nome......: {0}", clientes[id].nome);
                Console.WriteLine("Telefone..: {0}", clientes[id].telefone);
                Console.WriteLine("CPF.......: {0}", clientes[id].cpf);
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}
