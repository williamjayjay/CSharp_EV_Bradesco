using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conceito_While
{
    public partial class Conceito_Do_While : Form
    {
        public Conceito_Do_While()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            do
            {
                c += 1;
                lblNumero.Text = Convert.ToString(c);
                MessageBox.Show("O valor do contador é: " + c);
                lblNumero.Refresh();
            }
            while (c < 5);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Tabuada novo = new Tabuada();
            novo.Show();

            this.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Teste_For novo = new Teste_For();
            novo.Show();

            this.Visible = false;
        }
    }
}
