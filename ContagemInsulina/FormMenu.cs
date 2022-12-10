﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ContagemInsulina
{
    public partial class FormMenu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        public FormMenu()
        {
            InitializeComponent();
            glicemiaAtual.Focus();
            checkBoxCorrecao.Checked = true;
            checkBoxAlimentar.Checked = true;
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnGlicemia_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

            //Criar classe config nova e popular campos

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;

        }

        //===============================================================================

        int valorfs = 0;
        int valorglicemiaAlvo = 0;
        int valorRelacaoCarb = 0;
        String glicemiaAnterior = "";
        private object sender;
        private EventArgs e;
        int contador = 0;

        public static class campoTextoAlimento
        {
            public static string nomeAlimento { get; set; }

        }

        internal static int qtdCarboidrato { get; set; }

        private void FormMenu_Load_1(object sender, EventArgs e)
        {
            IniciarCampoFoco(sender, e);
            AnaliseHorario();
            CarregarConfiguracoes();
            CarregarAlimentos();

        }

        private void IniciarCampoFoco(object sender, EventArgs e)
        {
            btnConfig_Click(sender, e);
            btnGlicemia_Click(sender, e);
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
                alimento.alimento1_Click(sender, e);
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

        private void glicemiaAtual_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnCalcular_Click_1(sender, e);
            }
        }

        public void ExibirNomeAlimento()
        {
            refeicao.Text = campoTextoAlimento.nomeAlimento;
        }

        private void checkBoxAlimentar_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxAlimentar.Checked && contador != 0)
            {
                Alimentos formAlimentos = new Alimentos(this);
                formAlimentos.ShowDialog();
            }
            contador = 1;
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            CalcularAcaoGlicemia(1);
        }

        private void glicemiaAtual_Click(object sender, EventArgs e)
        {
            glicemiaAtual.Text = "";
            glicemiaAtual.ForeColor = Color.Black;
        }

        private void CalcularAcaoGlicemia(int usaDB)
        {
            int valorGlicemia = 0;
            float qtdCorrecao = 0;
            float qtdAlimentacao = 0;

            try
            {
                valorGlicemia = Convert.ToInt32(glicemiaAtual.Text);

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

                    if (usaDB == 1) Conexao.Add(glicemia);

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
            catch
            {
                MessageBox.Show("Insira a glicêmia corretamente!");
            }
        }

    }
}