using System;

namespace Builder
{
    public class Fabricante
    {
        public void Construtor(ICelular celularBuilder)
        {
            celularBuilder.BuidBateria();
            celularBuilder.BuildSistema();
            celularBuilder.BuidTela();
            celularBuilder.buildCamera();
        }
    }
}
