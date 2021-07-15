using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Windows_Forms_App_Clientes
{
    public partial class Form2 : Form
    {
        DateTime tempo = new DateTime();
        
        Form1 form;
        public Form2(Form1 f)
        {
            InitializeComponent();
            form = f;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempo = DateTime.Now;
            timer1.Start();
            string horas = tempo.ToLocalTime().ToString();
            label1.Text = horas;

        }

        private void fecha()
        {
            if(form.Visible == false && this.Visible == false)
            {
                Program.fechar();
            }
        }

        private void verMeuPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string retorno = "Funcionario Logado "; retorno += Program.name;
            MessageBox.Show(retorno, "Ref", MessageBoxButtons.OK);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            fecha();
        }

        private void verClientesCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string clientes_cadastrados = BancoClientes.verClientes();
            BancoClientes.verClientes();
            MessageBox.Show(clientes_cadastrados);
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
