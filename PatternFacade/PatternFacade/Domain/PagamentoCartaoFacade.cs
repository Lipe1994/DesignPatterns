using PatternFacade.CrossCutting.contracts;
using PatternFacade.Domain.contracts;
using PatternFacade.Domain.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFacade.Domain
{
    public class PagamentoCartaoFacade : IPagamentoCartaoFacade
    {
        private readonly IPayPalGateway payPalGateway;
        private readonly IConfigurationManager configurationManager;

        public PagamentoCartaoFacade(IPayPalGateway payPalGateway, IConfigurationManager configurationManager)
        {
            this.payPalGateway = payPalGateway;
            this.configurationManager = configurationManager;
        }

        public bool RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            //faz varias coisas, depende do gateway...

            var apiKey = configurationManager.GetValue("apiKey");
            var encriptionKey = configurationManager.GetValue("encriptionKey");

            var serviceKey = payPalGateway.GetPayPalServiceKey(apiKey, encriptionKey);
            var cardHashKey = payPalGateway.GetCardHashKey(serviceKey, pagamento.CartaoCredito);

            var pagamentoResult = payPalGateway.CommitTransaction(cardHashKey, pedido.Id.ToString(), pagamento.Valor);

            return pagamentoResult;
        }
    }
}
