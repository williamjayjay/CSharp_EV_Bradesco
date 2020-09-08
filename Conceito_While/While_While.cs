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
    public partial class While_While : Form
    {
        public While_While()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            While_For novo = new While_For();
            novo.Show();

            this.Visible = false;
        }

        private void While_While_Load(object sender, EventArgs e)
        {
            int contador;
            contador = 2020;
            while (contador >= 1950)
            {
                cboAno.Items.Add(contador);
                contador-- ;
            }
        }
    }
}
