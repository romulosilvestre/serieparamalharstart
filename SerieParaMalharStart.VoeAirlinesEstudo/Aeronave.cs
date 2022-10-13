using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.VoeAirlinesEstudo
{
    public class Aeronave
    {
        //variável padrão: camelCase com "_"
        public string _fabricante;
        public string _modelo;
        public string _codigo;

        //propriedade automática: PascalCase
        /*public string Fabricante { get; set; } 
        public string Modelo { get; set; }
        public string Codigo { get; set; }*/

        //Método - com retorno
        //(    ) - parâmetros
        //(int x) - passando por valor (int,float,double)
        //(Aeronave aeronave) - passando por referência (objeto)
        //string - referência

        /*
         * Porque que eu não coloco o if no principal?
         */
        public bool ValidarCodigo(string codigo)
        {         
            if(codigo == null)
            {
                return false;
            }else if (codigo.Equals("EMB-100"))
            {
                //retorno
                return true;
            }

            //retorno
            return false;
        }

    }
}
