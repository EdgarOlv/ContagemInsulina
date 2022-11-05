using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace ContagemInsulina
{

    public partial class Config : Form
    {

        public int id;
        public String nome;
        public int valor;

        public Config()
        {
            InitializeComponent();
        }

        public Config(int id, String nome, int valor)
        {
            this.id = id;
            this.nome = nome;
            this.valor = valor;
        }

        /*public String getValor(int id)
        {
            while(id != this.id)
            {
                id--;
            }
            if(id == this.id) {
                return Convert.ToString(this.valor);
            }
        }*/


        private void Config_Load(object sender, EventArgs e)
        {
            List<Config> ListConfig = Conexao.GetConfigAll();

            ListConfig.ForEach(objeto =>
            {
                switch (Convert.ToInt32(objeto.id))
                {
                    case 1: //F.S.
                        fs.Text = Convert.ToString(objeto.valor);
                        break;

                    case 2: //Alvo
                        glicemiaAlvo.Text = Convert.ToString(objeto.valor);
                        break;

                    case 3: //Carboidrato
                        carb.Text = Convert.ToString(objeto.valor);
                        break;
                }
            });

            //fs.Text = Convert.ToString(configuracaoFS.valor);
            //glicemiaAlvo.Text = Convert.ToString(configuracaoAlvo.valor);
        }
    }
}
