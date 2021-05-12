using System;
using design_patterns.domain.entity;

namespace design_patterns.domain{

    public sealed class ButtonLinux : Button
    {
        public ButtonLinux():base("ButtonLinux"){}

        public override void Action()
        {
            throw new System.NotImplementedException();
        }

        public override void Print()
        {
            Console.WriteLine("Eu sou um botão para Linux");
        }
    }

}