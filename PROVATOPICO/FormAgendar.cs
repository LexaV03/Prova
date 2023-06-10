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
    public partial class FormAgendar : Form
    {
        public FormAgendar()
        {
            InitializeComponent();
        }

        private void FormAgendar_Load(object sender, EventArgs e)
        {

        }

        private void btAgendar_Click(object sender, EventArgs e)
        {
            agendar cad = new agendar(txtID.Text, txtDia.Text, txtHorario.Text);
            MessageBox.Show(cad.mensagem);
        }

        private void btVoltar2_Click(object sender, EventArgs e)
        {
            FormPrinci FormPri = new FormPrinci();
            FormPri.Show();
            this.Hide();
        }
    }
}
