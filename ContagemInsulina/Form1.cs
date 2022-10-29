using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ContagemInsulina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            glicemiaAtual.Focus();
            checkBoxCorrecao.Checked = true;
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valorGlicemia = 0;
            int valorfs = 0;
            int valorglicemiaAlvo = 0;
            float qtdAplicar = 0;

            valorGlicemia = Convert.ToInt32(glicemiaAtual.Text);
            valorfs = Convert.ToInt32(fs.Text);
            valorglicemiaAlvo = Convert.ToInt32(glicemiaAlvo.Text);

            
            //-------------------------

            if (checkBoxCorrecao.Checked)
            {
                qtdAplicar += (float)(valorGlicemia - valorglicemiaAlvo) / valorfs;

            }

            aplicarInsulina.Text = string.Format("Aplicar {0:0.0} U.I.", qtdAplicar);

        }

        private void btnAnalisar_Click(object sender, EventArgs e)
        {
            int valorGlicemia = 0;
            //valorGlicemia = Convert.ToInt32(glicemiaAnalise.Text);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Glicemia glicemia = new Glicemia();

            glicemia.valor = Convert.ToInt32(glicemiaAtual.Text);

            Conexao.Add(glicemia);

        }

        private void checkBoxAlimentar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAlimentar.Checked)
            {
                Alimentos formAlimentos = new Alimentos();
                formAlimentos.ShowDialog();
            }
        }
    }
}
