using System;
using design_patterns.domain.contracts;

namespace design_patterns.domain.entity
{
   public abstract class Button : IForm
   {
      public Button(string name){
         this.Name = name;
      }

      public String Name{ get; set; }   

      public String GetName(){
         return this.Name;
      }

      public abstract void Action();
      public abstract void Print();

   }
}