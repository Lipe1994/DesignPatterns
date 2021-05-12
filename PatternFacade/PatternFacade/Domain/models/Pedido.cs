using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFacade.Domain.models
{
    public class Pedido
    {
        public Guid Id { get; set; }

        public decimal Valor { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
