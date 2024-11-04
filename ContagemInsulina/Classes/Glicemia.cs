using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemInsulina
{
    public class Glicemia
    {
        public int id { get; set; }
        public int valor { get; set; }
        public int valor_aplicado { get; set; }
        public DateTime data { get; set; }
        public String obs { get; set; }

        public Glicemia()
        {
        }

        public Glicemia(DataTable data)
        {
            this.id = Convert.ToInt32(data.Rows[0]["id"]);
            this.valor = Convert.ToInt32(data.Rows[0]["valor"]);
            this.valor_aplicado = Convert.ToInt32(data.Rows[0]["insulina_aplicada"]);
            this.data = Convert.ToDateTime(data.Rows[0]["data"]);
        }

        public Glicemia(int valorGlicemia)
        {
            DateTime now = DateTime.Now;
            DateTime now2 = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute,now.Second);

            this.valor = valorGlicemia;
            this.data = now2;
        }

        public Glicemia(int valorGlicemia, DateTime data)
        {
            this.valor = valorGlicemia;
            this.data = data;
        }

        public Glicemia(int valor, int valor_aplicado, DateTime data, String obs)
        {
            this.valor = valor;
            this.valor_aplicado = valor_aplicado;
            this.data = data;
            this.obs = obs;
        }

        public int getValor
        {
            get { return valor; }
        }

        public DateTime getData
        {
            get { return data; }
        }

        public int Valor_aplicado { get => valor_aplicado; set => valor_aplicado = value; }
    }

    public class GlicemiaClean
    {
        public int valor { get; set; }
        public int insulina_aplicada { get; set; }
        public String data { get; set; }
        public String obs { get; set; }
        public String loc { get; set; }

        public GlicemiaClean()
        {
        }
    }

    }
