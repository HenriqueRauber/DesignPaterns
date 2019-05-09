using System;

namespace Proxy
{
    public class Proxy : Subject
    {
        public RealSubject realSubject;
        public override void Requisicao()
        {
            if(this.realSubject == null)
            {
                this.realSubject = new RealSubject();
            }

            this.realSubject.Requisicao();
        }
    }
}
