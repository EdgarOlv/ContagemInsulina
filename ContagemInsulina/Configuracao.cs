using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContagemInsulina
{
    internal class Configuracao
    {
        public int id;
        public String nome;
        public int valor;

        List<Configuracao> ListConfig;

        public Configuracao(int id, String nome, int valor)
        {
            this.id = id;
            this.nome = nome;
            this.valor = valor;
        }

        public Configuracao()
        {

        }

        public List<Configuracao> Load_config()
        {
            ListConfig = Conexao.GetConfigAll();
            return ListConfig;
        }


        public void btnCalcular_Click(List<Configuracao> config, int[] campos)
        {
            config.ForEach(objeto =>
            {
                switch (Convert.ToInt32(objeto.id))
                {
                    case 1: //F.S.
                        Conexao.UpdateConfig(Convert.ToInt32(objeto.id), Convert.ToInt32(campos[0]));
                        break;

                    case 2: //Alvo
                        Conexao.UpdateConfig(Convert.ToInt32(objeto.id), Convert.ToInt32(campos[1]));
                        break;

                    case 3: //Carboidrato
                        Conexao.UpdateConfig(Convert.ToInt32(objeto.id), Convert.ToInt32(campos[2]));
                        break;
                }
            });
            MessageBox.Show("Atualizado com sucesso!");

        }

    }
}
