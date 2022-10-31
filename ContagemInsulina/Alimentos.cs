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
        public Alimentos()
        {
            InitializeComponent();
        }

        private void Alimentos_Load(object sender, EventArgs e)
        {
            Alimento alimento = new Alimento(Conexao.GetAlimentos());

        }
    }
}
