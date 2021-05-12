using System;

namespace PatternCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            user.Add('+', 250);
            Console.ReadKey();
            user.Add('-', 50);
            Console.ReadKey();
            user.Add('*', 2);
            Console.ReadKey();
            user.Add('/', 4);
            Console.ReadKey();
            
            user.Undo(3);
            Console.ReadKey();

            user.Retorn(2);
            Console.ReadKey();
            
            user.Retorn(1);
            Console.ReadKey();

        }
    }
}
