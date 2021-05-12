using System;
using System.Collections.Generic;
using System.Text;

namespace PatternCommand
{
    internal class Calc
    {
        private int _currentValue;

        public void Operations(char operation, int value)
        {
            switch (operation)
            {
                case '+': _currentValue += value; break;
                case '-': _currentValue -= value; break;
                case '*': _currentValue *= value; break;
                case '/': _currentValue /= value; break;
            }

            Console.WriteLine($"(dado {operation} {value}) -> Valor atual = {_currentValue}");

        }
    }
}
