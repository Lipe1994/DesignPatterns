using System;
using System.Threading;
using Observable.obervable;

namespace Observable
{
    class Program
    {
        static void Main()
        {
            //Empresas
            var empresaNaBolsa =  new BolsaSubject("Magazine Luiza", 26.50);
            var empresa2NaBolsa =  new BolsaSubject("Usiminas", 21.0);

            //investidores
            var investidor1 = new InvestidorObservable("Filipe Ferreira");
            var investidor2 = new InvestidorObservable("Laura Ferreira");

            empresaNaBolsa.Attach(investidor1);
            empresaNaBolsa.Attach(investidor2);

            empresa2NaBolsa.Attach(investidor2);



            for(int i =0; i < 100; i++){
                empresaNaBolsa.ValueState = NewValue();
                empresa2NaBolsa.ValueState = NewValue();

                if(i > 3){
                    empresaNaBolsa.Detach(investidor2);
                }
            }

            Console.ReadKey();

        }

        static double NewValue(){
            Thread.Sleep(3000);
            var random =  new Random();
            return random.Next(20, 25);
        }
    }
}
