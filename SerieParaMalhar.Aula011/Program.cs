using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalhar.Aula11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nomes = new[] { "Rômulo", "Danilo", "Rafaela" };
            /* for(var indice = 0; indice <= nomes.Length; indice++)
              {
                  Console.WriteLine(nomes[indice]);
              }
             /* int[] numeros = new int[3];
              numeros[0] = 1;
              numeros[1] = 17;
              numeros[2] = 22;

              double n1 = Convert.ToDouble(numeros[2]);
              double n2 = Convert.ToDouble(numeros[1]);*/

            int x = 10, y = 0;
            try
            {
                double divisao = x / y;
                Console.WriteLine(divisao);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"O número {x} não pode ser dividido por zero");
            }

            /*
             * 5 minutos
             * 
             * -Dividir por zero
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             *  if(x == 0){
             *     
             *  }
             * 
             */ 
            try //tente 
            {
               //deu certo
            }
            catch (DivideByZeroException) //se der errado
            {
               //erro
            }
            finally
            {
              //padrão
            }

            Console.ReadKey();
            /*
             * Nossa tabelinha de Exceção
             * 
             * DivideByZeroException - trata o erro de divisão por zero
             * ArrayTypeMismatchException - trabalhar com matriz e elementos não aceitos
             * Arranjo - Matriz e Vetores
             * IndexOutOfRangeException - trata o acesso de um arranjo
             *  
             */

            try
            {
                int[] vetor = new int[5] { 1, 2, 3, 4, 5 };

                //[0][1][2][3][4]
                for (var i=0; i <= 5; i++)
                {
                    Console.WriteLine(vetor[i]);
                }

            }
            catch (Exception excecao)
            {
                Console.WriteLine(excecao.Message);//mostra a exceção
                Console.WriteLine(excecao.StackTrace);//mostrar detalhes, por exemplo "a linha"

            }
           
            Console.ReadKey();
        }
    }
}
