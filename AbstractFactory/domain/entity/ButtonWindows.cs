using System;
using design_patterns.domain.entity;

namespace design_patterns.domain{

    public sealed class ButtonWindows : Button
    {
        public ButtonWindows():base("ButtonWindows"){}

        public override void Action()
        {
            throw new System.NotImplementedException();
        }

        public override void Print()
        {
            Console.WriteLine("Eu sou um botão para windows");
        }
    }

}