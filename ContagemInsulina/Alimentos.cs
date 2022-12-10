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
    public partial class Alimentos : Form
    {
        int[] valorCarb = new int[10];
        String[] nomeAlimentos = new String[10];
        FormMenu FormMenu;  

        public void alimento6_Click(object sender, EventArgs e)
        {
            FormMenu.qtdCarboidrato = valorCarb[0];
            FormMenu.campoTextoAlimento.nomeAlimento = nomeAlimentos[0];
            this.FormMenu.ExibirNomeAlimento();
            this.Hide();
        }

        public void alimento5_Click(object sender, EventArgs e)
        {
            FormMenu.qtdCarboidrato = valorCarb[1];
            FormMenu.campoTextoAlimento.nomeAlimento = nomeAlimentos[1];
            this.FormMenu.ExibirNomeAlimento();
            this.Hide();
        }

        public void alimento4_Click(object sender, EventArgs e)
        {
            FormMenu.qtdCarboidrato = valorCarb[2];
            FormMenu.campoTextoAlimento.nomeAlimento = nomeAlimentos[2];
            this.FormMenu.ExibirNomeAlimento();
            this.Hide();
        }

        public void alimento3_Click(object sender, EventArgs e)
        {
            FormMenu.qtdCarboidrato = valorCarb[3];
            FormMenu.campoTextoAlimento.nomeAlimento = nomeAlimentos[3];
            this.FormMenu.ExibirNomeAlimento();
            this.Hide();
        }

        public void alimento2_Click(object sender, EventArgs e)
        {
            FormMenu.qtdCarboidrato = valorCarb[4];
            FormMenu.campoTextoAlimento.nomeAlimento = nomeAlimentos[4];
            this.FormMenu.ExibirNomeAlimento();
            this.Hide();
        }

        public void alimento1_Click(object sender, EventArgs e)
        {
            FormMenu.qtdCarboidrato = valorCarb[5];
            FormMenu.campoTextoAlimento.nomeAlimento = nomeAlimentos[5];
            this.FormMenu.ExibirNomeAlimento();
            this.Hide();
            
        }

        public Alimentos()
        {
            InitializeComponent();
        }

        public Alimentos(FormMenu FormMenu)
        {
            this.FormMenu = FormMenu;
            InitializeComponent();
            InicializaDadosAlimentos();
        }

        private void Alimentos_Load(object sender, EventArgs e)
        {
            //inicializar e pegar valores das refeições e deixar no banco
            //usar swith para analisar o clic
            //Alimento alimento = new Alimento(Conexao.GetAlimentos());

            TimeSpan horario = new TimeSpan(00, 00, 00);
            TimeSpan horario2 = new TimeSpan(09, 00, 00);
            TimeSpan horario3 = new TimeSpan(12, 00, 00);
            TimeSpan horario4 = new TimeSpan(15, 00, 00);
            TimeSpan horario5 = new TimeSpan(18, 00, 00);
            TimeSpan horario6 = new TimeSpan(21, 00, 00);

            TimeSpan horaAtual = DateTime.Now.TimeOfDay;

            if (horaAtual >= horario && horaAtual <= horario2)
            {
                this.ActiveControl = alimento1;
            }
            if (horaAtual >= horario2 && horaAtual <= horario3)
            {
                this.ActiveControl = alimento2;
            }
            if (horaAtual >= horario3 && horaAtual <= horario4)
            {
                this.ActiveControl = alimento3;
            }
            if (horaAtual >= horario4 && horaAtual <= horario5)
            {
                this.ActiveControl = alimento4;
            }
            if (horaAtual >= horario5 && horaAtual <= horario6)
            {
                this.ActiveControl = alimento5;
            }
            if (horaAtual >= horario6)
            {
                this.ActiveControl = alimento6;
            }

            InicializaDadosAlimentos();

        }

        private void InicializaDadosAlimentos()
        {
            List<Alimento> CarbAlimentos = Conexao.GetAlimentos();
            CarbAlimentos.ForEach(objeto =>
            {
                switch (Convert.ToInt32(objeto.id))
                {
                    case 1:
                        valorCarb[0] = objeto.qtd_carboidrato;
                        nomeAlimentos[0] = objeto.nome;
                        break;

                    case 2:
                        valorCarb[1] = objeto.qtd_carboidrato;
                        nomeAlimentos[1] = objeto.nome;
                        break;

                    case 3:
                        valorCarb[2] = objeto.qtd_carboidrato;
                        nomeAlimentos[2] = objeto.nome;
                        break;

                    case 4:
                        valorCarb[3] = objeto.qtd_carboidrato;
                        nomeAlimentos[3] = objeto.nome;
                        break;

                    case 5:
                        valorCarb[4] = objeto.qtd_carboidrato;
                        nomeAlimentos[4] = objeto.nome;
                        break;

                    case 6:
                        valorCarb[5] = objeto.qtd_carboidrato;
                        nomeAlimentos[5] = objeto.nome;
                        break;
                }
            });
        }
    }
}
