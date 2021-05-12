using System;
using System.Collections.Generic;

namespace Observable.obervable
{
    public abstract class Subject
    {
        public Subject(String Name, double value){
            this.Name = Name;
            this.Value = Value;
        }

        protected String Name { get; set; }
        protected double Value { get; set; }  


        private List<Observer> _observables  = new List<Observer>();

        public void Attach(Observer item){

            _observables.Add(item);
        }

        public void Detach(Observer item){
            _observables.Remove(item);
        }

        public void Notify(){
            foreach(var observable in _observables){
                observable.Update(this);

            }
            Console.WriteLine("\r\n \r\n");
        }

        public double ValueState { 
            set{
                if(this.Value != value)
                {
                     this.Value = value;
                     this.Notify();
                }
            } 
            get{return this.Value;} 
        }
        public String NameState { get{return this.Name;} }
        
    }
}