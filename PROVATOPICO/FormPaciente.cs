using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROVATOPICO
{
    public partial class FormPaciente : Form
    {
        public FormPaciente()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, EventArgs e)
        {
            cadastrar cad = new cadastrar(txtCPF.Text, txtNome.Text, txtTelefone.Text);
            MessageBox.Show(cad.mensagem);
        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btVoltar1_Click(object sender, EventArgs e)
        {
            FormPrinci FormPri = new FormPrinci();
            FormPri.Show();
            this.Hide();
        }
    }
}
