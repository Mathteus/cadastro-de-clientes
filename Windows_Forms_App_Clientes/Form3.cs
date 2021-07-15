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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string telefone = txtTelefone.Text;
            string cpf = txtCpf.Text;
            var resposta = MessageBox.Show("as informaçoôes estão corretas", "ref", MessageBoxButtons.YesNo).ToString();
            MessageBox.Show(resposta);
        }
    }
}
