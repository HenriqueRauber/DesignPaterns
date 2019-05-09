using System;

namespace Interpreter
{
    public class MilharesExpressao : Expressao
    {
        public override string Cinco()
        {
            return "D";
        }

        public override int Multiplicar()
        {
            return 1000;
        }

        public override string Nove()
        {
            return " ";// "CM";
        }

        public override string Quatro()
        {
            return " ";// "CD";
        }

        public override string Um()
        {
            return "M";
        }
    }
}
