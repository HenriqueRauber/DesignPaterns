using System;

namespace Visitor
{
    public class Program
    {
        static void Main(string[] args)
        {
            ObjectStruture o = new ObjectStruture();
            o.Anexar(new ConcreteElementA());
            o.Anexar(new ConcreteElementB());

            ConcreteVisitor1 v1 = new ConcreteVisitor1();
            ConcreteVisitor2 v2 = new ConcreteVisitor2();

            o.Accept(v1);
            o.Accept(v2);

            Console.ReadKey();
        }
    }
}
