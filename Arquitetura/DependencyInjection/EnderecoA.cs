using System;

namespace DependencyInjection
{
    public class EnderecoA : IObjetoEndereco
    {
        public String Rua { get; set; }
        public int Numero { get; set; }
    }
}
