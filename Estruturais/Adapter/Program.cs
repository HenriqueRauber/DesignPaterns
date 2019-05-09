using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo rx2018 = new TanqueInimigo();
            RoboInimigo r2d2 = new RoboInimigo();

            IAtaqueInimigo robo_Adapter = new RoboInimigoAdapter(r2d2);

            Console.WriteLine(" ========== ROBO ========== ");
            r2d2.ReagirContraHumano("Rodrigo");
            r2d2.AndarFrente();
            r2d2.EsmagarComMaos();

            Console.WriteLine(" ========== TANQUE ========== ");
            rx2018.Pilotar("João");
            rx2018.movimenta();
            rx2018.ArmaFogo();

            Console.WriteLine(" ========== ROBO ADAPTER ======= ");
            robo_Adapter.Pilotar("Rodrigo");
            robo_Adapter.movimenta();
            robo_Adapter.ArmaFogo();

            Console.ReadKey();
        }
    }
}
