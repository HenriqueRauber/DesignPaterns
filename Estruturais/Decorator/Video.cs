using System;

namespace Decorator
{
    public class Video : ItemBiblioteca
    {
        public string Diretor { get; set; }
        public string Titulo { get; set; }
        public int MinutosDuracao { get; set; }

        public Video(string diretor, string titulo, int minutosDuracao, int numeroCopias)
        {
            this.Diretor = diretor;
            this.Titulo = titulo;
            this.MinutosDuracao = minutosDuracao;
            this.NumeroCopias = numeroCopias;
        }

        public override void Exibe()
        {
            Console.WriteLine("\nVideo: ----");
            Console.WriteLine($" Diretor: {this.Diretor}");
            Console.WriteLine($" Titulo: {this.Titulo}");
            Console.WriteLine($" Duração: {this.MinutosDuracao}");
            Console.WriteLine($" # Cópias: {this.NumeroCopias}");
        }
    }
}
