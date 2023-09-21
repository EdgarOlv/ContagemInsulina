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
    public partial class Observacao : Form
    {
        private Glicemia glicemia;

        public Observacao()
        {
            InitializeComponent();
        }

        public Observacao(Glicemia glicemia)
        {
            InitializeComponent();
            this.glicemia = glicemia;
        }

        private void Observacao_Load(object sender, EventArgs e)
        {
            campoGlicemia.Text = Convert.ToString(glicemia.valor);
            campoInsulina.Text = Convert.ToString(glicemia.valor_aplicado);
            campoObservacao.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Conexao.InsertComentario(campoObservacao.Text);
            this.Close();
        }
    }
}
