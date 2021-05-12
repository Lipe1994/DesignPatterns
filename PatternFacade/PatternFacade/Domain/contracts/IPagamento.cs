using PatternFacade.Domain.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFacade.Domain.contracts
{
    public interface IPagamento
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
