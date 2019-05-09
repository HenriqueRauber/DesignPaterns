using System;

namespace Command
{
    public class Program
    {
        static void Main(string[] args)
        {
            Receiver reciver = new Receiver();
            Command command = new ConcreteCommand(reciver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();


            Console.ReadKey();
        }
    }
}