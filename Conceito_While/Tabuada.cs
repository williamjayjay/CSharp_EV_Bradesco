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
    public partial class Tabuada : Form
    {
        public Tabuada()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();

            this.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero, resultado, i;
            i = 1;
            numero = int.Parse(txtNumero.Text);

            while (i <= 10)
            {
                resultado = i * numero;
                lstTabuada.Items.Add(String.Concat(numero, " * ", i, " = ", resultado));
                i += 1;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear();
        }

        private void lstTabuada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Conceito_Do_While novo = new Conceito_Do_While();
            novo.Show();

            this.Visible = false;
        }
    }
}
