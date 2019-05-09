using System;

namespace Builder
{
    public interface ICelular
    {
        void BuidTela();
        void BuidBateria();
        void BuildSistema();
        void buildCamera();
        Celular Celular { get; }
    }
}
