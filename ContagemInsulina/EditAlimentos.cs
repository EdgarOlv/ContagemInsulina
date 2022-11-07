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
    public partial class EditAlimentos : Form
    {
        public EditAlimentos()
        {
            InitializeComponent();
        }

        private void EditAlimentos_Load(object sender, EventArgs e)
        {
            List<Alimento> CarbAlimentos = Conexao.GetAlimentos();
            CarbAlimentos.ForEach(objeto =>
            {
                switch (Convert.ToInt32(objeto.id))
                {
                    case 6: //F.S.
                        text1.Text = Convert.ToString(objeto.qtd_carboidrato);
                        break;

                    case 5: //Alvo
                        text2.Text = Convert.ToString(objeto.qtd_carboidrato);
                        break;

                    case 4: //Carboidrato
                        text3.Text = Convert.ToString(objeto.qtd_carboidrato);
                        break;

                    case 3: //Carboidrato
                        text4.Text = Convert.ToString(objeto.qtd_carboidrato);
                        break;

                    case 2: //Carboidrato
                        text5.Text = Convert.ToString(objeto.qtd_carboidrato);
                        break;

                    case 1: //Carboidrato
                        text6.Text = Convert.ToString(objeto.qtd_carboidrato);
                        break;
                }
            });
        }
    }
}
