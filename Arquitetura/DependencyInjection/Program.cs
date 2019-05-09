using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            EnderecoA endA = new EnderecoA();
            endA.Rua = "Rua Endereço A";
            endA.Numero = 1;

            EnderecoB endB = new EnderecoB();
            endB.Cidade = "São Paulo";
            endB.UF = "SP";

            Empresa_Constructor empresa1 = new Empresa_Constructor(endA);
            Empresa_Constructor empresa2 = new Empresa_Constructor(endB);

            Console.ReadKey();
        }
    }
}
