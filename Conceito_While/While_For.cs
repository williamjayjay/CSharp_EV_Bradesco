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
    public partial class While_For : Form
    {
        public While_For()
        {
            InitializeComponent();
        }

        private void While_For_Load(object sender, EventArgs e)
        {
            int contador;
            for (contador = 2020; contador >= 1950; contador--)
            {
                cboAno.Items.Add(contador);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Teste_For novo = new Teste_For();
            novo.Show();

            this.Visible = false;
        }

        private void cboAno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            While_While novo = new While_While();
            novo.Show();

            this.Visible = false;
        }
    }
}
