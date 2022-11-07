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

        List<Config> ListConfig;

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

        private void Config_Load(object sender, EventArgs e)
        {
            ListConfig = Conexao.GetConfigAll();
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
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var teste = ListConfig;
            ListConfig.ForEach(objeto =>
            {
                switch (Convert.ToInt32(objeto.id))
                {
                    case 1: //F.S.
                        Conexao.UpdateConfig(Convert.ToInt32(objeto.id), Convert.ToInt32(fs.Text));
                        break;

                    case 2: //Alvo
                        Conexao.UpdateConfig(Convert.ToInt32(objeto.id), Convert.ToInt32(glicemiaAlvo.Text));
                        break;

                    case 3: //Carboidrato
                        Conexao.UpdateConfig(Convert.ToInt32(objeto.id), Convert.ToInt32(carb.Text));
                        break;
                }
            });
            MessageBox.Show("Atualizado com sucesso!");
            
            this.Close();
        }

        private void Config_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditAlimentos editAli = new EditAlimentos();
            editAli.ShowDialog();
        }
    }
}
