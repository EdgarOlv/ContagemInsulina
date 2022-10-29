using System;
using System.Windows.Forms;

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

            if (glicemiaAtual.Text != "")
            {

                valorGlicemia = Convert.ToInt32(glicemiaAtual.Text);
                valorfs = Convert.ToInt32(fs.Text);
                valorglicemiaAlvo = Convert.ToInt32(glicemiaAlvo.Text);



                Glicemia glicemia = new Glicemia(valorGlicemia);

                Conexao.Add(glicemia);

                //-------------------------

                if (checkBoxCorrecao.Checked)
                {
                    qtdAplicar += (float)(valorGlicemia - valorglicemiaAlvo) / valorfs;

                }

                aplicarInsulina.Text = string.Format("Aplicar {0:0.0} U.I.", qtdAplicar);
            }
            else
            {
                MessageBox.Show("Digite o valor da glicemia", "Glicemia não inserida");
            }

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
