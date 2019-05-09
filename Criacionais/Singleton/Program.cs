using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton objeto_1 = Singleton.GetInstancia;
            objeto_1.Mensagem("Objeto 1..");


            Singleton objeto_2 = Singleton.GetInstancia;
            objeto_2.Mensagem("Objeto 2..");


            Singleton objeto_3 = Singleton.GetInstancia;
            objeto_3.Mensagem("Objeto 3..");

            Console.ReadKey();
        }
    }
}
