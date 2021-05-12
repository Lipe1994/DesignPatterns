using System;
using design_patterns.domain.contracts;
using design_patterns.domain.value_objects;
using design_patterns.factory;

namespace design_patterns
{
    class Program
    {
        static void Main()
        {

            var InputFactory = AbstractFactory.CreateFactory(FormType.INPUT);
            var ButtonFactory = AbstractFactory.CreateFactory(FormType.BUTTON);

            var inputWindows = InputFactory.CreateForm(SO.WINDOWS);
            var inputLinux = InputFactory.CreateForm(SO.LINUX);

            var ButtonWindows = ButtonFactory.CreateForm(SO.WINDOWS);
            var ButtomLinux = ButtonFactory.CreateForm(SO.LINUX);


            //--->
            PrintName(inputWindows.GetName());
            inputWindows.Print();

            PrintName(inputLinux.GetName());
            inputLinux.Print();
            
            PrintName(ButtonWindows.GetName());
            ButtonWindows.Print();

            PrintName(ButtomLinux.GetName());
            ButtomLinux.Print();

            
            void PrintName(String name){
                Console.Write($"{name} diz: ");
            };
            
        }
    }
}
