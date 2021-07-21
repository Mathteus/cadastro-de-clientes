using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Clientes_Console
{
    class UI
    {
        private const int VER = 1;
        private const int ADD = 2;
        private const int REM = 3;
        private const int SAI = 4;

        static private bool fim = true, autorizado = false;
        static private int resposta = 0;
        

        private static void topo()
        {
            Console.Clear();
            Console.WriteLine("=============================================================");
            Console.WriteLine("                        Sistema DB txt");
            Console.WriteLine("=============================================================");
        }

        private static void verClientes()
        {
            foreach (Cliente client in BancoClientes.listaClientes())
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Cliente {0}", client.getId()); ;
                Console.WriteLine("Nome......: {0}", client.getNome());
                Console.WriteLine("Telefone..: {0}", client.getTelefone());
                Console.WriteLine("CPF.......: {0}", client.getCpf());
                Console.WriteLine("-------------------------------------------");
            }
            Console.Write("Precionesse qualquer tecla para continuar...");
            teclado();
        }

        private static void addClientes()
        {
            Console.Write("Digite o nome do cliente a ser cadastrado: ");
            string n = teclado();
            string nomeC = n.Trim();
            topo();
            Console.Write("Digite o telefone do {0}: ", nomeC);
            string t = teclado();
            string telefonec = t.Trim();
            topo();
            Console.Write("Digite o CPF do {0}: ", nomeC);
            string c = teclado();
            string cpfc = c.Trim();
            topo();
            Console.WriteLine("Nome......: {0}", nomeC);
            Console.WriteLine("Telefone..: {0}", telefonec);
            Console.WriteLine("CPF.......: {0}", cpfc);
            Console.Write("As Informaçoes estao Corretas\n[1]Sim -- [2]Nao\nR: ");
            string r = teclado();
            if (r == "1")
            {
                topo();
                BancoClientes.gravar(new Cliente(nomeC, telefonec, cpfc, 0));
                Console.Write("Cliente Cadastrado...");
                teclado();
            }
        }

        private static void removerClientes()
        {
            verClientes();
            Console.Write("Digite o id do cliente que deseja remover: ");
            int identificaor = Convert.ToInt32(teclado());
            Console.Write("tem certeza que seja remover " + BancoClientes.ident(identificaor) + " [1]sim -- [2]nao\nR:");
            int res = Convert.ToInt32(teclado());
            if (res == 1)
            {
                BancoClientes.retirarCliente(identificaor);
            }
        }

        private static void sair()
        {
            Console.WriteLine("Saindo do sistema...");
            teclado();
            System.Environment.Exit(-1);
        }

        private static void autorizar()
        {
            Console.Write("Digite Seu Nome para Acesso: ");
            string nm = teclado();
            string name = nm.Replace(" ", "");
            topo();
            Console.Write("Digite sua Senha Para Acesso: ");
            string sn = teclado();
            string senha = sn.Replace(" ", "");
            autorizado = BancoFuncionarios.verificarAutorizacao(name, senha);
            topo();
            if (autorizado)
            {
                UI.topo();
                Console.WriteLine("Acesso Autorizado...");
                Console.ReadLine();
            }
            else
            {
                UI.topo();
                Console.WriteLine("Acesso Negado...");
                Console.ReadLine();
            }
        }

        private static void inicio()
        {
            Console.Write("[1]Visualizar Clientes Cadastrados\n[2]Add Cliente\n[3]Remover Cliente Cadastrado\n[4]Sair\nR:");
            resposta = Convert.ToInt32(teclado());
        }


        private static string teclado()
        {
            return Console.ReadLine();
        }

        public static void menu()
        {
            BancoClientes.atualizarClientes();
            topo();
            do
            {
                if (autorizado)
                {
                    topo();
                    inicio();
                    switch (resposta)
                    {
                        case ADD:
                            topo();
                            addClientes();
                            break;

                        case VER:
                            topo();
                            verClientes();
                            break;

                        case REM:
                            topo();
                            removerClientes();
                            break;

                        case SAI:
                            topo();
                            sair();
                            break;
                    }
                }
                else
                {
                    topo();
                    autorizar();
                }
            } while (fim);
        }
    }
}
