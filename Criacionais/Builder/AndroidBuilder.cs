using System;

namespace Builder
{
    public class AndroidBuilder : ICelular
    {
        Celular celular;
        public Celular Celular
        {
            get
            {
                return this.celular;
            }
        }
        public AndroidBuilder()
        {
            this.celular = new Celular("Android");
        }
        
        public void BuidBateria()
        {
            this.celular.bateria = "MAH_1500";
        }

        public void buildCamera()
        {
            this.celular.camera = "15 MP";
        }

        public void BuildSistema()
        {
            this.celular.sistema = "Android 4.5";
        }
        public void BuidTela()
        {
            this.celular.tela = "7";
        }        
    }
}
