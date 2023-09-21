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
    public partial class InserirGlicemia : Form
    {
        public InserirGlicemia()
        {
            InitializeComponent();
        }

        private void btnInserirGlicemia_Click(object sender, EventArgs e)
        {
            var valor = Convert.ToInt32(valorGlicemia.Text);
            var data = Convert.ToDateTime(dataGlicemia.Text);

            Glicemia glicemia = new Glicemia(valor, data);
            Conexao.Add(glicemia);
            MessageBox.Show("Registro inserido!");
            this.Close();
        }
    }
}
