using System;

namespace Flyweight
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---# Design Pattern Flyweight #---");
            Fabrica_Flyweight fabrica = new Fabrica_Flyweight();
            string cor = string.Empty;

            Tartaruga tartaruga;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Qual tartaruga enviar para tela: ");
                cor = Console.ReadLine();

                tartaruga = fabrica.GetTartaruga(cor);
                tartaruga.Mostra(cor);


                Console.WriteLine();
                Console.WriteLine("-------------------------------");
            }

            Console.ReadKey();
        }
    }
}
