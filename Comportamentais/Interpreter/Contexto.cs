using System;

namespace Interpreter
{
    public class Contexto
    {
        public string Input { get; set; }
        public int Output { get; set; }

        public Contexto(string input)
        {
            Input = input;
        }
    }
}
