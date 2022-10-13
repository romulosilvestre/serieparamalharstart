using SerieParaMalharStart.FlowCSharpBasico.DotNet;
using SerieParaMalharStart.VoeAirlinesEstudo;
using SerieParaMalharStart.VoeAirlinesSobrecarga;
using System;


namespace SerieParaMalharStart.FlowCSharpBasico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio inicio = new Inicio();
            Console.WriteLine("Tour .NET!");
            Console.WriteLine("Deseja viajar para aonde?");
            Console.WriteLine("1-História " +
                "2-.NET Framework " +
                "3-.NET Core " +
                "4-Trainning 01 " +
                "5-VoeArilines " +
                "6-Sobrecarga - Descrição " +
                "7-Sobrecarga - qtdePassageiros 8-Sobregarga - Data");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine(inicio.MostrarHistoria());break;
                case 5:
                    Console.WriteLine("Olá,você chegou no módulo POO");
                    Console.WriteLine("Voe Airlines voando com você!");
                    Aeronave aeronave = new Aeronave();
                    aeronave._fabricante = "Embraer";
                    aeronave._modelo = "Bandeirante";
                    aeronave._codigo = "E195-E2";
                    Console.WriteLine("Fabricante" + aeronave._fabricante);
                    //Múltiplos Dispositivos
                    //Console
                    //Windows Forms
                    //Sexta-Feira: ASPN NET CORE
                    Console.WriteLine("Resultado Código:" + aeronave.ValidarCodigo(aeronave._codigo));
                    break;
                case 6:
                    Agenda a = new Agenda();
                    bool r =a.RegistrarVoo(null);
                    Console.WriteLine(r);
                    break;
                case 7:
                    Agenda a2 = new Agenda();
                    Console.WriteLine(a2.RegistrarVoo(25));
                    break;
                case 8:

                    Console.WriteLine(new Agenda().RegistrarVoo().ToString());
                    break;


            }
            Console.ReadKey();
                        
            

        }
    }
}
