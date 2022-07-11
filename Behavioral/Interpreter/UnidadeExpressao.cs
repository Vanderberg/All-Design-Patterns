﻿namespace Interpreter
{
    public class UnidadeExpressao : Expressao
    {
        public override string Um()
        {
            return "I";
        }

        public override string Quatro()
        {
            return "IV";
        }

        public override string Cinco()
        {
            return "V";
        }

        public override string Nove()
        {
            return "IX";
        }

        public override int Multiplicar()
        {
            return 1;
        }
    }
}