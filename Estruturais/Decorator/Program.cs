using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar um Livro
            Livro livro = new Livro("João","Design Patterns", 10);
            livro.Exibe();

            //Criar um Video
            Video video = new Video("Rodrigo", "Video aulas avançadas", 25, 3);
            video.Exibe();

            //Vou emprestar um video e mostrar na tela
            Console.WriteLine("\nEmprestando um Vídeo:");
            Emprestado emprestado = new Emprestado(video);
            emprestado.EmprestarItem("Carlos");
            emprestado.EmprestarItem("Maria");
            emprestado.Exibe();

            Console.WriteLine("\nDevolvendo um Vídeo:");
            emprestado.DevolverItem("Carlos");
            emprestado.Exibe();

            Console.ReadKey();
        }
    }
}
