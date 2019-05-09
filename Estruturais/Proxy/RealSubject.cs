using System;

namespace Proxy
{
    public class RealSubject : Subject
    {
        public override void Requisicao()
        {
            Console.WriteLine("Chamando um RealSubject.Requisicao");
        }
    }
}
