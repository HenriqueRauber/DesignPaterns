using System;

namespace State
{
    public class Program
    {
        static void Main(string[] args)
        {
            Context c = new Context(new ConcreteStateA());

            c.Request();
            c.Request();
            c.Request();
            c.Request();



            Console.ReadKey();
        }
    }
}
