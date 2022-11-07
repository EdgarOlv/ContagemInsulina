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

        private void alimento6_Click(object sender, EventArgs e)
        {
            Form1.qtdCarboidrato = valorCarb[0];
            Form1.nomeAlimento = nomeAlimentos[0];
            this.Hide();
        }

        private void alimento5_Click(object sender, EventArgs e)
        {
            Form1.qtdCarboidrato = valorCarb[1];
            Form1.nomeAlimento = nomeAlimentos[1];
            this.Hide();
        }

        private void alimento4_Click(object sender, EventArgs e)
        {
            Form1.qtdCarboidrato = valorCarb[2];
            Form1.nomeAlimento = nomeAlimentos[2];
            this.Hide();
        }

        private void alimento3_Click(object sender, EventArgs e)
        {
            Form1.qtdCarboidrato = valorCarb[3];
            Form1.nomeAlimento = nomeAlimentos[3];
            this.Hide();
        }

        private void alimento2_Click(object sender, EventArgs e)
        {
            Form1.qtdCarboidrato = valorCarb[4];
            Form1.nomeAlimento = nomeAlimentos[4];
            this.Hide();
        }

        private void alimento1_Click(object sender, EventArgs e)
        {
            Form1.qtdCarboidrato = valorCarb[5];
            Form1.nomeAlimento = nomeAlimentos[5];
            this.Hide();
            
        }

        public Alimentos()
        {
            InitializeComponent();
        }

        private void Alimentos_Load(object sender, EventArgs e)
        {
            //inicializar e pegar valores das refeições e deixar no banco
            //usar swith para analisar o clic
            //Alimento alimento = new Alimento(Conexao.GetAlimentos());

            List<Alimento> CarbAlimentos = Conexao.GetAlimentos();
            CarbAlimentos.ForEach(objeto =>
            {
                switch (Convert.ToInt32(objeto.id))
                {
                    case 1:
                        valorCarb[0] = objeto.qtd_carboidrato;
                        nomeAlimentos[0] = objeto.id_nome;
                        break;

                    case 2:
                        valorCarb[1] = objeto.qtd_carboidrato;
                        nomeAlimentos[1] = objeto.id_nome;
                        break;

                    case 3:
                        valorCarb[2] = objeto.qtd_carboidrato;
                        nomeAlimentos[2] = objeto.id_nome;
                        break;

                    case 4:
                        valorCarb[3] = objeto.qtd_carboidrato;
                        nomeAlimentos[3] = objeto.id_nome;
                        break;

                    case 5:
                        valorCarb[4] = objeto.qtd_carboidrato;
                        nomeAlimentos[4] = objeto.id_nome;
                        break;

                    case 6:
                        valorCarb[5] = objeto.qtd_carboidrato;
                        nomeAlimentos[5] = objeto.id_nome;
                        break;
                }
            });

        }
    }
}
