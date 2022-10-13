using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieParaMalharStart.Algoritmo28
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Siglas sigla = new Siglas();
            sigla.Descricao = "SENAI";
            Console.WriteLine(sigla.mostrarSiginificado());
            Console.ReadKey();
            
        }
    }
}
