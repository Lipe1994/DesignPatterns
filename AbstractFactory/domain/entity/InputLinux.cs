using System;
using design_patterns.domain.entity;

namespace design_patterns.domain{
    public sealed class InputLinux : Input
    {
        public InputLinux() : base("InputLinux")
        {
        }

        public override void Print()
        {
            Console.WriteLine("Eu sou um input para Linux");
        }
    }
}