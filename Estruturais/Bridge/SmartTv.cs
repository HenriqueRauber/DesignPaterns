using System;

namespace Bridge
{
	
    public class SmartTv
    {
        public ICanal canal_atual { get; set; }

        public void ExibeCanalSintonizado()
        {
            if(canal_atual != null)
            {
                Console.WriteLine(canal_atual.Canal());
            }
            else
            {
				Console.WriteLine("Por favor, selecione um canal!");
            }
        }
		
		public void PlayTv()
		{			
            if(canal_atual != null)
            {
                Console.WriteLine(canal_atual.Status());
            }
            else
            {
				Console.WriteLine("Por favor, selecione um canal!");
            }
		}
    }
}
