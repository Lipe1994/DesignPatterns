using PatternFacade.Domain.contracts;
using PatternFacade.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternFacade.Domain
{
    public class PagamentoCartaoService : IPagamento
    {
        private readonly IPagamentoCartaoFacade pagamentoCartaoFacade;

        public PagamentoCartaoService(IPagamentoCartaoFacade pagamentoCartaoFacade)
        {
            this.pagamentoCartaoFacade = pagamentoCartaoFacade;
        }
        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);

            Console.WriteLine($"Valor: {pagamento.Valor}");

            if (pagamentoCartaoFacade.RealizarPagamento(pedido, pagamento)) 
            {

                pagamento.Status = "OK";
                return pagamento;
            }

            pagamento.Status = "ERROR";
            return pagamento;
        }
    }
}
