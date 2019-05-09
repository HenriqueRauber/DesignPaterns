using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria o fabricante
            Fabricante fabricante = new Fabricante();

            //Permite que a classe Builder esteja pronta
            ICelular celularBuilder = null;

            //Agora vampos criar um telefone Android
            //celularBuilder = new AndroidBuilder();
            //Agora vampos criar um telefone Iphone
            celularBuilder = new IphoneBuilder();
            fabricante.Construtor(celularBuilder);
            Console.WriteLine("Um novo celular foi contruido: {0}", celularBuilder.Celular.Nome);

            Console.ReadKey();
        }
    }
}
