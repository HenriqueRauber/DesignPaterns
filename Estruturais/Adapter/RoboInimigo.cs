using System;

namespace Adapter
{
    /// <summary>
    /// É o Adaptee - ele é o objeto que será adaptado.
    /// </summary>
    public class RoboInimigo
    {
        Random gerador = new Random();

        public void EsmagarComMaos()
        {
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine("O Robo inimigo causou " + danoAtaque + "de dano com o ataque de esmagar com as mãos!");
        }
        public void AndarFrente()
        {
            int movimento = this.gerador.Next(10) + 1;
            Console.WriteLine("O Robo inimigo andou " + movimento + "passos para frente!");
        }

        public void ReagirContraHumano(string piloto)
        {
            Console.WriteLine("O Robo inimigo vai contra " + piloto );
        }

    }
}
