using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_App_Clientes
{
    public partial class Form1 : Form
    {
        List<Funcionarios> todos = BancoFuncionarios.funcionarios;
        public Form1()
        {
            InitializeComponent();
            BancoFuncionarios.verificarFunionarios();
            BancoClientes.lerClientes();
        }

        private void buttonAcesso_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            Program.name = name;
            string senha = txtSenha.Text;
            bool autorizado = BancoFuncionarios.verificarAutorizacao(name, senha);
            if (autorizado)
            {
                Form2 tela_Inicial = new Form2(this);
                tela_Inicial.Show();
                this.Enabled = false;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Acesso Negado...");
                txtName.Clear();
                txtSenha.Clear();
                txtName.Focus();
            }
        }
    }
}
