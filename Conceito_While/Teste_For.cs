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
    public partial class Teste_For : Form
    {
        public Teste_For()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int contador = 0; contador < 5; contador++)
            {
                MessageBox.Show("O valor do contador é: " + contador);
                //Console.WriteLine("O valor do contador é: " + contador);
                //Aqui acima irá exibir no console.
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Conceito_Do_While novo= new Conceito_Do_While();
            novo.Show();

            this.Visible = false;
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            While_For novo = new While_For();
            novo.Show();

            this.Visible = false;
        }
    }
}
