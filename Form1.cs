using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX7WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Numero n;
            n = new Numero();

            n.SetN1(int.Parse(txtN1.Text));
            n.SetN2(int.Parse(txtN2.Text));

            txtResult.Text = n.ObterMaiorValor().ToString();
        }
    }
}
