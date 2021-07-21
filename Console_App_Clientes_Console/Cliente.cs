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
        private string email;
        private string nome;
        private string telefone;
        private string cpf;
        private int id;

        public Cliente(string _nome, string _telefone, string _cpf, int _id)
        {
            this.email = "@Hotmail.com"
            this.nome = _nome;
            this.telefone = _telefone;
            this.cpf = _cpf;
            this.id = _id;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getTelefone()
        {
            return this.telefone;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public int getId()
        {
            return this.id;
        }
    }
}
