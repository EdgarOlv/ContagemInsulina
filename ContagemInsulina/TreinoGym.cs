using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemInsulina
{
    internal class TreinoGym
    {
        public String oQueFazer(int valorGlicemia)
        {
            if(valorGlicemia <= 70)
            {
                return "Adiar o treino";
            }  
            if(valorGlicemia > 70 && valorGlicemia <= 100)
            {
                return "25g a 50g Carb. antes do treino";
            }
            if (valorGlicemia > 100 && valorGlicemia <= 180)
            {
                return "20g a 50g Carb. antes do treino";
            }  
            if(valorGlicemia > 180 && valorGlicemia <= 300)
            {
                return "15g antes do treino";
            }  
            if(valorGlicemia > 300)
            {
                return "Adiar o treino";
            }
            else
            {
                return null;
            }
            
        }

        /*
         * Caso 1: x<70 =  Adiar 
         * Caso 2: 70>x<100 =  25g a 50g de carb
         * Caso 3: 100x<180 =  20g a 50g carb antes
         * Caso 4: 180x<300 =  15g antes
         * Caso 5: 300>x =   Adiar
         * 
         */

    }
}
