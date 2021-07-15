using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_App_Clientes
{
    class BancoFuncionarios
    {
        public static List<Funcionarios> funcionarios = new List<Funcionarios>();

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
                            funcionarios.Add(new Funcionarios(funcionario[0], funcionario[1]));
                        }

                    }
                    leitor.Close();
                }
            }
        }

        //verificar acesso do funcionario
        public static bool verificarAutorizacao(string nome, string senha)
        {
            bool acesso = false;
            int cont = funcionarios.Count;
            for (int i = 0; i < cont; i++)
            {
                if (nome == funcionarios[i].name.ToLower() && senha == funcionarios[i].senha.ToLower())
                {
                    acesso = true;
                }
            }
            return acesso;
        }
    }
}
