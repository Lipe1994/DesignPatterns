using System;
using System.Collections.Generic;
using System.Text;

namespace PatternCommand
{
    public class User
    {
        private readonly Calc _calc = new Calc();
        private readonly List<Commander> _commanders = new List<Commander>();
        private int _totalOfCommands;

        public void Add(char __operator, int value)
        {
            Commander command = new CalcCommand(_calc, __operator, value);
            command.Execute();

            _commanders.Add(command);
            _totalOfCommands++;
        }

        public void Undo(int levels)
        {
            Console.WriteLine($"\n ---- Desfazendo {levels} levels");

            for(var i=0; i<levels; i++) 
            {
                if (_totalOfCommands <= 0) 
                {
                    continue;
                }

                var command = _commanders[--_totalOfCommands];
                command.Undo();
            }
        } 
        
        public void Retorn(int levels)
        {
            Console.WriteLine($"\n ---- Retornando {levels} levels");

            for(var i=0; i<levels; i++) 
            {
                if (_totalOfCommands > _commanders.Count-1) 
                {
                    continue;
                }

                var command = _commanders[_totalOfCommands++];
                command.Execute();
            }
        } 
    }
}
