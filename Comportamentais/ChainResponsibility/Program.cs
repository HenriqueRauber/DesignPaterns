using System;

namespace ChainResponsibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            Handler h3 = new ConcreteHandler3();

            h1.SetSucessor(h2);
            h2.SetSucessor(h3); 

            int[] requests = { 2, 5, 31, 24, 22, 18, 3, 27, 20};

            foreach (int request in requests)
            {
                h1.HandlerRequest(request);
            }

            Console.ReadKey();
        }

        //Result:
        //ConcreteHandler1 Handled request 2
        //ConcreteHandler1 Handled request 5
        //ConcreteHandler3 Handled request 24
        //ConcreteHandler3 Handled request 22
        //ConcreteHandler2 Handled request 18
        //ConcreteHandler1 Handled request 3
        //ConcreteHandler3 Handled request 27
        //ConcreteHandler3 Handled request 20



    }
}
