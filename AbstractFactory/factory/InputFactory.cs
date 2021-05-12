using System;
using design_patterns.domain;
using design_patterns.domain.contracts;
using design_patterns.domain.value_objects;
using design_patterns.factory.contracts;

namespace design_patterns.factory
{
    public class InputFactory : IFactory
    {
        public IForm CreateForm(SO system)
        {
            switch(system){
                case SO.WINDOWS: {
                    return new InputWindows();
                }
                case SO.LINUX:{
                    return new InputLinux();
                }
                default:{
                    throw new ArgumentOutOfRangeException();
                } 
            }
        }
    }
}