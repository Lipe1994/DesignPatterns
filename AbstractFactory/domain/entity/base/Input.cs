using System;
using design_patterns.domain.contracts;

namespace design_patterns.domain.entity
{
   public abstract class Input : IForm
   {
      public Input(string name){
         this.Name = name;
      }

      public String GetName(){
         return this.Name;
      }

      public String Name{ get; set; }
      public String Entrada{ get; set; }
      public abstract void Print();
   }
    
}