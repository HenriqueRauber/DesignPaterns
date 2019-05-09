using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod fm = new FactoryMethod();

            Console.WriteLine("LiuKang | SubZero | Scorpion");
            Console.WriteLine();
            Console.WriteLine("Escolha seu personagem");
            string escolha = Console.ReadLine();

            IPersonagem personagem = fm.Escolher_Personagem(escolha);
            Console.WriteLine();

            Console.WriteLine("Você vai jogar com ");
            personagem.Escolhido();

            Console.ReadKey();
        }
    }
}
