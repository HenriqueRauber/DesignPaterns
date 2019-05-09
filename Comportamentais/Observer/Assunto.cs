using System;
using System.Collections.Generic;

namespace Observer
{
    public abstract class Assunto
    {
        private List<Observador> _Observadores = new List<Observador>();

        public void Anexar(Observador observado)
        {
            _Observadores.Add(observado);
        }

        public void Desanexar(Observador observado)
        {
            _Observadores.Remove(observado);
        } 

        public void Notificar()
        {
            foreach (Observador item in _Observadores)
            {
                item.Update();
            }
        }
    }
}
