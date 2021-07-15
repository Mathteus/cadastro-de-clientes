using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Clientes_Console
{
    class Central
    {
        public string name;
        public string senha;
        static List<Central> central = new List<Central>();

        public Central(string _name, string _senha)
        {
            this.name = _name;
            this.senha = _senha;
        }

        //caminho para funcionarios autorizados
        public static string caminhoDBFuncionarios()
        {
            string caminho = @"../../db/file2.txt";
            return caminho;
        }


        // metodo para ler todos os funcionarios cadastrados dentro do txt
        public static void verificarFunionarios()
        {
            if (File.Exists(caminhoDBFuncionarios()))
            {
                string linha;
                int i = 0;
                using (StreamReader leitor = new StreamReader(caminhoDBFuncionarios()))
                {
                    while ((linha = leitor.ReadLine()) != null)
                    {
                        i++;
                        if (i > 1)
                        {
                            var funcionario = linha.Split(';');
                            central.Add(new Central(funcionario[0], funcionario[1]));
                        }

                    }
                    leitor.Close();
                }
            }
        }

        //verificar acesso do funcionario
        public static bool verificarAutorizacao(string nome, string snha)
        {
            verificarFunionarios();
            bool acesso=false;
            int cont = central.Count;
            for(int i=0; i < cont;i++)
            {
                if(nome == central[i].name.ToLower() && snha == central[i].senha.ToLower())
                {
                    acesso = true;
                }
            }
            if (acesso)
            {
                Program.topo();
                Console.WriteLine("Acesso Autorizado...");
                Console.ReadLine();
            } 
            else
            {
                Program.topo();
                Console.WriteLine("Acesso Negado...");
                Console.ReadLine();
            }
            return acesso;
        }
    }
}
