using System;

namespace Proxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Requisicao();

            Console.ReadKey();
        }
    }
}
