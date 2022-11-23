using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ContagemInsulina
{
    public partial class Form1 : Form
    {

        /*  ISSUES
         * 
         * Configurações:
         * -Conseguir pegar ulmima leitura (pode esquecer quanto aplicar)
         * -Poder colocar hora diferente de aferição
         * -Módulo de log, para registrar quanto aplicou e o que fez(alimentou, malhou)
         * -
         * 
         * -Evento salvar no banco configurações alimentos
         * 
         * Assistente de voz (StandBy pronto para abrir / Athena, glicemia de 100)
         * - https://www.youtube.com/watch?v=rjT-IxcAheQ&ab_channel=C%C3%B3digoLogo
         * 
         * */

        int valorfs = 0;
        int valorglicemiaAlvo = 0;
        int valorRelacaoCarb = 0;
        private object sender;
        private EventArgs e;
        int contador = 0;

        internal static int qtdCarboidrato { get; set; }
        //internal static String nomeAlimento { get; set; }


        public Form1()
        {
            InitializeComponent();
            glicemiaAtual.Focus();
            checkBoxCorrecao.Checked = true;
            checkBoxAlimentar.Checked = true;
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

                    qtdCorrecao = (float)(valorGlicemia - valorglicemiaAlvo) / valorfs;
  
                    aplicarInsulina.Text += string.Format(" Correção {0:0.0}UI ", qtdCorrecao);

                    Conexao.Add(glicemia);
                    

                }                
            }

            if (checkBoxAlimentar.Checked)
            {
                qtdAlimentacao += (float)qtdCarboidrato / valorRelacaoCarb;

                aplicarInsulina.Text += string.Format(" Alimento {0:0.0}UI ", qtdAlimentacao);

            }
            var checkMalhar = checkBoxMalhar.Checked;

            if (checkMalhar) qtdCorrecao = qtdCorrecao / 2;

            totalAplicar.Text = string.Format(" Aplicar: {0:0.0}UI ", qtdCorrecao + qtdAlimentacao);

            if (checkMalhar)
            {
                TreinoGym treino = new TreinoGym();
     
                totalAplicar.Text += string.Format(" e ");
                totalAplicar.Text += treino.oQueFazer(Convert.ToInt32(glicemiaAtual.Text));

            }
            glicemiaAtual.Text = "";
        }

        private void checkBoxAlimentar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAlimentar.Checked && contador != 0)
            {
                Alimentos formAlimentos = new Alimentos(this);
                formAlimentos.ShowDialog();
            }
            contador = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarConfiguracoes();
            CarregarAlimentos();
            AnaliseHorario();
        }

        public void AnaliseHorario()
        {
            TimeSpan horario = new TimeSpan(00, 00, 00);
            TimeSpan horario2 = new TimeSpan(09, 00, 00);
            TimeSpan horario3 = new TimeSpan(12, 00, 00);
            TimeSpan horario4 = new TimeSpan(15, 00, 00);
            TimeSpan horario5 = new TimeSpan(18, 00, 00);
            TimeSpan horario6 = new TimeSpan(21, 00, 00);

            TimeSpan horaAtual = DateTime.Now.TimeOfDay;
            Alimentos alimento = new Alimentos(this);

            if (horaAtual >= horario && horaAtual <= horario2)
            {
                alimento.alimento1_Click(sender,e);
            }
            if (horaAtual >= horario2 && horaAtual <= horario3)
            {
                alimento.alimento2_Click(sender, e);
            }
            if (horaAtual >= horario3 && horaAtual <= horario4)
            {
                alimento.alimento3_Click(sender, e);
            }
            if (horaAtual >= horario4 && horaAtual <= horario5)
            {
                alimento.alimento4_Click(sender, e);
            }
            if (horaAtual >= horario5 && horaAtual <= horario6)
            {
                alimento.alimento5_Click(sender, e);
            }
            if (horaAtual >= horario6)
            {
                alimento.alimento6_Click(sender, e);
            }
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
            
            if (campoTextoAlimento.nomeAlimento != "")
            {
                refeicao.Text = campoTextoAlimento.nomeAlimento;

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

        public void ExibirNomeAlimento()
        {
            //MessageBox.Show(Convert.ToString(qtdCarboidrato));
           // MessageBox.Show(Convert.ToString(campoTextoAlimento.nomeAlimento));
            refeicao.Text = campoTextoAlimento.nomeAlimento;
        }


        public static class campoTextoAlimento
        {
            public static string nomeAlimento { get; set; }

        }
        protected static void reiniciar()
        {
            
        }
    }
}
