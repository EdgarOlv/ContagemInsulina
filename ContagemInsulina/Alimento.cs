using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemInsulina
{
    public class Alimento
    {
        public int id;
        public String id_nome;
        public String nome;
        public int qtd_carboidrato;

        public Alimento(DataTable data)
        {
            this.id = Convert.ToInt32(data.Rows[0]["id"]);
            this.id_nome = Convert.ToString(data.Rows[0]["id_nome"]);
            this.nome = Convert.ToString(data.Rows[0]["nome"]);
            this.qtd_carboidrato = Convert.ToInt32(data.Rows[0]["qtd_carboidrato"]);
        }

    }
}
