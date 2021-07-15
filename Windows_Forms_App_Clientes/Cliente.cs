using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_App_Clientes
{
    class Cliente
    {
        public string nome;
        public string telefone;
        public string cpf;

        public Cliente(string _nome, string _telefone, string _cpf)
        {
            this.nome = _nome;
            this.telefone = _telefone;
            this.cpf = _cpf;
        }
    }
}
