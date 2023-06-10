using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROVATOPICO
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string User = "admin";
            string Password = "admin";
            if (textUsuario.Text == User & textUsuario.Text == Password)
            {
                MessageBox.Show("Bem vindo de volta!");
                FormPrinci FormMain = new FormPrinci();
                FormMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha invalidos, favor tentar novamente");
            }
        }
    }
}
