using System;

namespace Bridge
{
    public class Culinaria : ICanal
    {
        public string Canal()
        {
            return "Sintonizado no canal de Culinária";
        }

        public string Status()
        {
            return "Você está assistindo - Receita de bolo de laranja";
        }
    }
}
