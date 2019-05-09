using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instancia = null;

        private static readonly object instanciaLock = new object();
        public static Singleton GetInstancia
        {
            get {
                lock(instanciaLock)
                    if (instancia == null)
                        lock (instanciaLock)
                            instancia = new Singleton(); 
                return instancia;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
