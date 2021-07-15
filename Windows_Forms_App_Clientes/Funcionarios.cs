using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_App_Clientes
{
    class Funcionarios
    {
        public string name;
        public string senha;


        public Funcionarios(string _name, string _senha)
        {
            this.name = _name;
            this.senha = _senha;
        }
    }
}
