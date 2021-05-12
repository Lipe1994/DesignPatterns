using System;
using System.Collections.Generic;
using System.Text;

namespace PatternCommand
{
    internal abstract class Commander
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}
