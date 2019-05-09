using System;
using System.Collections.Generic;

namespace Visitor
{
    public class ObjectStruture
    {
        private List<Element> _elementos = new List<Element>();

        public void Anexar(Element elemento)
        {
            this._elementos.Add(elemento);
        }

        public void desanexar(Element elemento)
        {
            this._elementos.Remove(elemento);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element elemento in this._elementos)
            {
                elemento.Accept(visitor);
            }
        }
    }
}
