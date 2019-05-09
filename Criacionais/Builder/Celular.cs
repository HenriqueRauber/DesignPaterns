using System;

namespace Builder
{
    public class Celular
    { 
        public Celular(String nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public string tela { get; set; }
        public string bateria { get; set; }
        public string sistema { get; set; }
        public string camera { get; set; }
    }
}
