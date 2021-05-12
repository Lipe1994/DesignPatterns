using System;
using design_patterns.domain.value_objects;
using design_patterns.factory.contracts;

namespace design_patterns.factory
{
    public class AbstractFactory
    {
        
        public static IFactory CreateFactory(FormType type){
            
            switch(type){
                case FormType.BUTTON:{
                    return new ButtonFactory();
                }
                case FormType.INPUT:{
                    return new InputFactory();
                }
                default:{
                    throw new ArgumentOutOfRangeException(nameof(AbstractFactory), type, "Você forneceu algum parâmetro não conhecido!");
                }
                
            }
            
        }
    }
}