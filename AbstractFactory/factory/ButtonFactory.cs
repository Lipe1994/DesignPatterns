using System;
using design_patterns.domain;
using design_patterns.domain.contracts;
using design_patterns.domain.value_objects;
using design_patterns.factory.contracts;

namespace design_patterns.factory
{
    public class ButtonFactory : IFactory
    {
        public IForm CreateForm(SO system)
        {
            switch(system){
                case SO.WINDOWS: {
                    return new ButtonWindows();
                }
                case SO.LINUX:{
                    return new ButtonLinux();
                }
                default:{
                    throw new ArgumentOutOfRangeException();
                } 
            }
        }
    }
}