using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo28
{
    //Classe -> a parte mais importante,ela organiza todo o corpo da programação
    //É um conjunto de objetos

    internal class Siglas
    {
      

        //Dados - Propriedades automáticas. Set - atribuir   Get - pegar
        public int Id { get; set; }
        public string Descricao { get; set; }

        //Métodos - aconteceu na API
        public string mostrarSiginificado()
        {
            string resultado = "OUTRA SIGLA";
            //código desacoplado principalmente da **Interface**
            if (Descricao.Equals("SENAI"))
            {
                resultado = "SERVIÇO NACIONAL DE APRENDIZAGEM INDUSTRIAL";          
             
            }
            else
            {
                resultado= "SERVIÇO NACIONAL DE APRENDIZAGEM RURAL";
            }
            return resultado;
        }




    }
}
