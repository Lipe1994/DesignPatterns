using System;
using design_patterns.domain.entity;

namespace design_patterns.domain{
    public sealed class InputWindows : Input
    {
        public InputWindows() : base("InputWindows")
        {
        }

        public override void Print()
        {
            Console.WriteLine("Eu sou um input para Windows");
        }
    }
}