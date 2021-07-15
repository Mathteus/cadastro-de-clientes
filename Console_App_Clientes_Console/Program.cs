using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Console_App_Clientes_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente.lerClientes();
            bool fim=true, autorizado=false;
            int resposta=0;
            topo();
            do
            {
                if (autorizado)
                {
                    topo();
                    Console.WriteLine("[1]ADD Clientes\n[2]Veficar Clientes Cadastrados\n[3]Sair");
                    resposta = Convert.ToInt32(Console.ReadLine());
                    if (resposta == 1)
                    {
                        topo();
                        Console.Write("Digite o nome do cliente a ser cadastrado: ");
                        string nomeC = Console.ReadLine();
                        topo();
                        Console.Write("Digite o telefone do {0}: ",nomeC);
                        string telefonec = Console.ReadLine();
                        topo();
                        Console.Write("Digite o CPF do {0}: ",nomeC);
                        string cpfc = Console.ReadLine();
                        Cliente.gravar(new Cliente(nomeC, telefonec, cpfc));
                        topo();
                        Console.Write("Cliente Cadastrado...");
                        Console.ReadLine();
                    }
                    else if (resposta == 2)
                    {
                        topo();
                        Cliente.verClientes();
                        Console.ReadLine();
                    }
                    else if(resposta == 3)
                    {
                        topo();
                        Console.WriteLine("Saindo do sistema...");
                        Console.ReadLine();
                        break;
                    }
                } 
                else
                {
                    topo();
                    Console.Write("Digite Seu Nome para Acesso: ");
                    string name = Console.ReadLine();
                    topo();
                    Console.Write("Digite sua Senha Para Acesso: ");
                    string senha = Console.ReadLine();
                    autorizado = Central.verificarAutorizacao(name, senha);
                }
            } while (fim);

        }

        public static void topo()
        {
            Console.Clear();
            Console.WriteLine("=============================================================");
            Console.WriteLine("                        Sistema DB txt");
            Console.WriteLine("=============================================================");
        }

    }
}