using System;

namespace Memento
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ponto de entrada..
            Originator o = new Originator();
            o.State = "On";

            //Armazenando o estado..
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            //Modificando o estado..
            o.State = "Off";

            //Voltando o estado armazenado..
            o.SetMemento(c.Memento);

            Console.ReadKey();
        }
    }
}
