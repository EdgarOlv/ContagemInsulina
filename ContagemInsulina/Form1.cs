using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ContagemInsulina
{
    public partial class Form1 : Form
    {

        /*  ISSUES
         * 
         * Configurações:
         * -Conseguir pegar ulmima leitura (pode esquecer quanto aplicar)
         * -Poder colocar hora diferente
         * 
         * -Evento salvar no banco configurações alimentos
         * 
         * 
         * */

        int valorfs = 0;
        int valorglicemiaAlvo = 0;
        int valorRelacaoCarb = 0;

        internal static int qtdCarboidrato { get; set; }
        internal static String nomeAlimento { get; set; }


        public Form1()
        {
            InitializeComponent();
            glicemiaAtual.Focus();
            checkBoxCorrecao.Checked = true;
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valorGlicemia = 0;
            float qtdCorrecao = 0;
            float qtdAlimentacao = 0;

            aplicarInsulina.Text = string.Format("Aplicar");

            if (glicemiaAtual.Text != "")
            {
                valorGlicemia = Convert.ToInt32(glicemiaAtual.Text);
    
                Glicemia glicemia = new Glicemia(valorGlicemia);


                if (checkBoxCorrecao.Checked)
                {

                    if (valorGlicemia < valorglicemiaAlvo)
                    {
                        qtdCorrecao = 0;
                    }
                    else
                    {
                        qtdCorrecao += (float)(valorGlicemia - valorglicemiaAlvo) / valorfs;
                    }
                    aplicarInsulina.Text += string.Format(" Correção {0:0.0}UI ", qtdCorrecao);

                }

                //Conexao.Add(glicemia);
                MessageBox.Show("Registro inserido!");
            }

            if (checkBoxAlimentar.Checked)
            {
                qtdAlimentacao += (float)qtdCarboidrato / valorRelacaoCarb;

                aplicarInsulina.Text += string.Format(" Alimento {0:0.0}UI ", qtdAlimentacao);

            }

            totalAplicar.Text = string.Format(" Aplicar: {0:0.0}UI ", qtdCorrecao + qtdAlimentacao);

        }

        private void checkBoxAlimentar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAlimentar.Checked)
            {
                Alimentos formAlimentos = new Alimentos();
                formAlimentos.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarConfiguracoes();
            CarregarAlimentos();
        }

        private void CarregarConfiguracoes()
        {
            List<Config> ListConfig = Conexao.GetConfigAll();

            ListConfig.ForEach(objeto =>
            {
                switch (Convert.ToInt32(objeto.id))
                {
                    case 1: //F.S.
                        valorfs = Convert.ToInt32(objeto.valor);
                        break;

                    case 2: //Alvo
                        valorglicemiaAlvo = Convert.ToInt32(objeto.valor);
                        break;

                    case 3: //Alvo
                        valorRelacaoCarb = Convert.ToInt32(objeto.valor);
                        break;
                }
            });
        }

        private void CarregarAlimentos()
        {
            if(nomeAlimento != "")
            {
                refeicao.Text = nomeAlimento;
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Config configuracoes = new Config();
            this.Hide();
            configuracoes.ShowDialog();
        }

        private void glicemiaAtual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnCalcular_Click(sender, e);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
            */
        }

        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(qtdCarboidrato));
            MessageBox.Show(Convert.ToString(nomeAlimento));
            refeicao.Text = nomeAlimento;
        }
        
    }
}
