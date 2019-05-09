using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// é o Adapter - O adaptador do objeto Robo com Tanque
    /// </summary>
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        RoboInimigo robo;
        
        //Passa para o método contrutor o robo que será adaptado (adaptee)
        public RoboInimigoAdapter(RoboInimigo novo_robo)
        {
            robo = novo_robo;
        }

        public void ArmaFogo()
        {
            robo.EsmagarComMaos();
        }

        public void movimenta()
        {
            robo.AndarFrente();
        }

        public void Pilotar(string piloto)
        {
            robo.ReagirContraHumano(piloto);
        }
    }
}
