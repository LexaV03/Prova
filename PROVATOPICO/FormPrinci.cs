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
    public partial class FormPrinci : Form
    {
        public FormPrinci()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FormPaciente FormPaci = new FormPaciente();
            FormPaci.Show();
            this.Hide();
        }

        

        

        private void btAgendar_Click(object sender, EventArgs e)
        {
            FormAgendar FormAgi = new FormAgendar();
            FormAgi.Show();
            this.Hide();
        }
    }
}
