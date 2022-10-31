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

    public partial class Config : Form
    {

        public int id;
        public String nome;
        public int valor;

        public Config()
        {
            InitializeComponent();
        }

        public Config(DataTable data)
        {
            this.id = Convert.ToInt32(data.Rows[0]["id"]);
            this.nome = Convert.ToString(data.Rows[0]["nome"]);
            this.valor = Convert.ToInt32(data.Rows[0]["valor"]);
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
            Config configuracaoFS = new Config(Conexao.GetConfigFS());
            Config configuracaoAlvo = new Config(Conexao.GetConfigAlvo());

            fs.Text = Convert.ToString(configuracaoFS.valor);
            glicemiaAlvo.Text = Convert.ToString(configuracaoAlvo.valor);
        }
    }
}
