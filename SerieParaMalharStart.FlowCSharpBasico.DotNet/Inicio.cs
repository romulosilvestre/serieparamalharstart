using System;
namespace SerieParaMalharStart.FlowCSharpBasico.DotNet
{
    public class Inicio
    {
        //Default
        public String MostrarHistoria()
        {
            return "Criador da linguagem C# .NET: Anders Hejlsberg";
        }
        public String MostrarDotNet()
        {
            //O que é Framework?
             //Um conjunto de padrões, técnicas, códigos
             //Implementa uma forma, um padrão
             //Entity Framework - ORM
             //DAO - Classes .NET
             //Biblioteca->Bootstrap
               //HTML,CSS,JAVASCRIPT + MEDIA QUERIES.
            //O que é .NET?
             //Framework .NET
               //Objetos
                //Dados
                 //Segurança
                   //Web
                    //Exceções
                     //Reflection
                       //Serviços
                        //Web API
                         //MSIL
                          //C# - J#  VB.NET PYTHON.NET
                           //CLR (Common Language Runtime) - Máquina Virtual

            //Criando uma biblioteca
               //Class Library
               //O que é ?
               //Para que serve?
               //Quais as vantagens
               //Framework x Biblioteca?
            return "A biblioteca reune um conjunto de funções" +
                "e recursos, enquanto dentro de um framework," +
                " temos um conjunto de bibliotecas," +
                " recursos e padrões de desenvolvimento," +
                "para melhorar a produtividade do desenvolvedor";
        }

        public String MostrarDotNetCore()
        {
            return "Nosso projeto final utilizará o .NET CORE," +
                "Ele é Open Source," +
                "Módular e Multiplataforma: Linux,Mac e Windows";
        }
        public String AloMundo(int idioma)
        {
            var r = "";
            //Estrutrua de Seleção
            switch (idioma)
            {
                case 1:r = "Alô Mundo!";break;
                case 2:r = "Hello World!";break;
                default:
                    r = "sistema em manutenção para outros idiomas";break;
                    
            }
            return r;
        }
    }
}
