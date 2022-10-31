using System;
using System.Windows.Forms;

namespace ContagemInsulina
{
    public partial class Form1 : Form
    {

        /*  ISSUES
         * 
         * Configurações:
         * -Carregar informações das config no banco para o Config.cs
         * -Evento para update se alterar essas configs
         * 
         * Alimentos:
         * -Classe para alimentos e CRUD geral
         * 
         * 
         * */

        int valorfs = 0;
        int valorglicemiaAlvo = 0;


        public Form1()
        {
            InitializeComponent();
            glicemiaAtual.Focus();
            checkBoxCorrecao.Checked = true;
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int valorGlicemia = 0;
            float qtdAplicar = 0;

            if (glicemiaAtual.Text != "")
            {

                valorGlicemia = Convert.ToInt32(glicemiaAtual.Text);
    

                Glicemia glicemia = new Glicemia(valorGlicemia);

                //Conexao.Add(glicemia);

                //-------------------------

                //a.Text = valorglicemiaAlvo.ToString();
                //b.Text = valorfs.ToString();

                if (checkBoxCorrecao.Checked)
                {
                    if(valorGlicemia < valorglicemiaAlvo)
                    {
                        qtdAplicar = 0;
                    }
                    else
                    {
                        qtdAplicar += (float)(valorGlicemia - valorglicemiaAlvo) / valorfs;
                    }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            Config configuracaoFS = new Config(Conexao.GetConfigFS());
            Config configuracaoAlvo = new Config(Conexao.GetConfigAlvo());

            valorglicemiaAlvo = configuracaoAlvo.valor;
            valorfs = configuracaoFS.valor;

        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Config configuracoes = new Config();
            configuracoes.ShowDialog();
        }
    }
}
