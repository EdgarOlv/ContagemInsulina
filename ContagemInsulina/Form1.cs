using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ContagemInsulina
{
    public partial class Form1 : Form
    {

        /*  ISSUES
         * 
         * Configurações:
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
        String glicemiaAnterior = "";
        private object sender;
        private EventArgs e;
        int contador = 0;

        internal static int qtdCarboidrato { get; set; }

        public Form1()
        {
            InitializeComponent();
            glicemiaAtual.Focus();
            checkBoxCorrecao.Checked = true;
            checkBoxAlimentar.Checked = true;
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularAcaoGlicemia(1);
        }

        private void CalcularAcaoGlicemia(int usaDB)
        {
            int valorGlicemia = 0;
            float qtdCorrecao = 0;
            float qtdAlimentacao = 0;

            try
            {
                valorGlicemia = Convert.ToInt32(glicemiaAtual.Text);
            }
            catch
            {
                MessageBox.Show("Insira a glicêmia corretamente!");
            }

            if (glicemiaAtual.Text != "" || valorGlicemia > 0)
            {

                aplicarInsulina.Text = string.Format("Aplicar");
                var checkMalhar = checkBoxMalhar.Checked;

                Glicemia glicemia = new Glicemia(valorGlicemia);

                if (checkBoxCorrecao.Checked)
                {

                    qtdCorrecao = (float)(valorGlicemia - valorglicemiaAlvo) / valorfs;

                    aplicarInsulina.Text += string.Format(" Correção {0:0.0}UI ", qtdCorrecao);

                    if (checkMalhar) qtdCorrecao = qtdCorrecao / 2;

                }

                if (checkBoxAlimentar.Checked)
                {
                    qtdAlimentacao += (float)qtdCarboidrato / valorRelacaoCarb;

                    aplicarInsulina.Text += string.Format(" Alimento {0:0.0}UI ", qtdAlimentacao);

                }

                totalAplicar.Text = string.Format(" Aplicar: {0:0.0}UI ", qtdCorrecao + qtdAlimentacao);
                glicemia.Valor_aplicado = Convert.ToInt32(qtdCorrecao + qtdAlimentacao);

                if(usaDB == 1) Conexao.Add(glicemia);

                if (checkMalhar)
                {
                    TreinoGym treino = new TreinoGym();

                    totalAplicar.Text += string.Format(" e ");
                    totalAplicar.Text += treino.oQueFazer(Convert.ToInt32(glicemiaAtual.Text));

                }

                glicemiaAtual.Text = string.Format(" Ultima glicemia: {0} ", valorGlicemia);
                glicemiaAtual.ForeColor = Color.Gray;
            }
            else
            {
                MessageBox.Show("Insira a glicêmia!");
            }
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

        public void ExibirNomeAlimento()
        {
            refeicao.Text = campoTextoAlimento.nomeAlimento;
        }

        public static class campoTextoAlimento
        {
            public static string nomeAlimento { get; set; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcularAcaoGlicemia(0);
        }

        private void glicemiaAtual_Enter(object sender, EventArgs e)
        {
            glicemiaAtual.Text = "";
            glicemiaAtual.ForeColor = Color.Black;
        }

    }
}
