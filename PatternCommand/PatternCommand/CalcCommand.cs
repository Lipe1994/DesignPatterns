using System;
using System.Collections.Generic;
using System.Text;

namespace PatternCommand
{
    internal class CalcCommand : Commander
    {
        private char _operator;
        private int _value;
        private readonly Calc _calc;

        public CalcCommand(Calc calc, char _operator, int value)
        {
            this._operator = _operator;
            _calc = calc;
            _value = value;
        }

        public char Operator
        {
            set => _operator = value;
        }

        public int Value
        {
            set => _value = value;
        }


        public override void Execute()
        {
            _calc.Operations(_operator, _value);
        }

        public override void Undo()
        {
            _calc.Operations(Undo(_operator), _value);
        }

        private static char Undo(char __operator)
        {
            switch (__operator) 
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("Operador inválido");
            }
        }
    }
}
