using System;

namespace Builder
{
    public class IphoneBuilder : ICelular
    {
        Celular celular;
        public Celular Celular
        {
            get
            {
                return this.celular;
            }
        }
        public IphoneBuilder()
        {
            this.celular = new Celular("Iphone");
        }

        public void BuidBateria()
        {
            this.celular.bateria = "MAH_1000";
        }

        public void buildCamera()
        {
            this.celular.camera = "16 MP";
        }

        public void BuildSistema()
        {
            this.celular.sistema = "IOS 11";
        }
        public void BuidTela()
        {
            this.celular.tela = "9";
        }
    }
}
