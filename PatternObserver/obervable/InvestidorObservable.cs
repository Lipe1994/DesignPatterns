using System;

namespace Observable.obervable
{
    public class InvestidorObservable : Observer
    {
        public InvestidorObservable(string Name){ this.Name = Name;}
        public String Name { get; set; }

        public override void Update(Subject subject)
        {
            Console.WriteLine($"\r\n Cliente {Name}, Alteração em {subject.NameState}, agora está em torno de {String.Format("{0:00.00}",subject.ValueState)}R$");
        }
    }
}