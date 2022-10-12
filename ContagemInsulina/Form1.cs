using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContagemInsulina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            glicemiaAtual.Focus();
            tabControl1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valorGlicemia = 0;
            int valorfs = 0;
            int valorglicemiaAlvo = 0;
            float b;

            valorGlicemia = Convert.ToInt32(glicemiaAtual.Text);
            valorfs = Convert.ToInt32(fs.Text);
            valorglicemiaAlvo = Convert.ToInt32(glicemiaAlvo.Text);

            b = (float)(valorGlicemia - valorglicemiaAlvo) / valorfs;

            aplicarInsulina.Text = string.Format("{0:0.0} ", b);
        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            int valorGlicemia = 0;
            valorGlicemia = Convert.ToInt32(glicemiaAnalise.Text);



        }
    }
}
