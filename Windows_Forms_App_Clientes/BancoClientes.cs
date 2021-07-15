using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Windows_Forms_App_Clientes
{
    class BancoClientes
    {
        static List<Cliente> clientes = new List<Cliente>();

        //metodo salvar para clientes no arquivo txt
        public static void gravar(Cliente c)
        {
            clientes.Add(c);
            using (StreamWriter escritor = new StreamWriter(caminhoDBCliente()))
            {
                string linha = "nome;telefone;cpf;";
                if (File.Exists(caminhoDBCliente()))
                {
                    escritor.WriteLine(linha);
                    foreach (Cliente cl in clientes)
                    {
                        linha = cl.nome + ";" + cl.telefone + ";" + cl.cpf + ";";
                        escritor.WriteLine(linha);
                    }
                    escritor.Close();
                }
            }
        }


        //caminho do txt a ser ultilizado
        public static string caminhoDBCliente()
        {
            string caminho = @"../../db/file1.txt";
            return caminho;
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
        public static string verClientes()
        {
            string clientes_cadastrados = "";
            int id;
            int cont = clientes.Count();
            for (id = 0; id < cont; id++)
            {
                clientes_cadastrados += "-------------------------------------------\n";
                clientes_cadastrados += "Cliente "+ id+"\n";
                clientes_cadastrados += "Nome......: " + clientes[id].nome+"\n";
                clientes_cadastrados += "Telefone..: " + clientes[id].telefone+"\n";
                clientes_cadastrados += "CPF.......: " + clientes[id].cpf + "\n";
                clientes_cadastrados += "-------------------------------------------\n";
            }
            return clientes_cadastrados;
        }
    }
}
