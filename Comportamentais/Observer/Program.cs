using System;

namespace Observer
{
    public class Program
    {
        static void Main(string[] args)
        {
            AssuntoConcreto s = new AssuntoConcreto();
            s.Anexar(new ObservadorConcreto(s, "x"));
            s.Anexar(new ObservadorConcreto(s, "y"));
            s.Anexar(new ObservadorConcreto(s, "z"));

            s.EstadoAssunto = "ABC";
            s.Notificar();

            Console.ReadKey();
        }
    }
}
