using System;
using design_patterns.domain.contracts;
using design_patterns.domain.value_objects;

namespace design_patterns.factory.contracts
{
    public interface IFactory
    {

        IForm CreateForm(SO system);
    }
}