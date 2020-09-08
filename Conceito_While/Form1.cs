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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            int c = 0;
            while (c < 1000)
            {
                c += 1;
                lblNumero.Text = Convert.ToString(c);
                lblNumero.Refresh(); 

                /*
                 Declaração de variavel c, inicializada com zero. ##Condição: enquanto o c for menor que 10000 será
                executado o laço. ##Incremento. ##Refresh é utilizado para que haja a variação dos números.
                 */
            }

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();

            novo.Show();
            this.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
