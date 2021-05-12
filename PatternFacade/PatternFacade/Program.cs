using Microsoft.Extensions.DependencyInjection;
using PatternFacade.CrossCutting;
using PatternFacade.CrossCutting.contracts;
using PatternFacade.Domain;
using PatternFacade.Domain.contracts;
using PatternFacade.Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            //DI maroto kkkkkl, pq essa implementação sem DI é de doer...
            var serviceProvider = new ServiceCollection()
                .AddScoped<IConfigurationManager, ConfigurationManager>()
                .AddScoped<IPayPalGateway, PayPalGateway>()
                .AddScoped<IPagamento, PagamentoCartaoService>()
                .AddScoped<IPagamentoCartaoFacade, PagamentoCartaoFacade>()
                .BuildServiceProvider();

            var produtos = new List<Produto>
            {
                new Produto{ Nome = "produto 01", Valor = 10.50M},
                new Produto{ Nome = "produto 02", Valor = 1.50M},
                new Produto{ Nome = "produto 03", Valor = 8.50M},
            };

            var pedido = new Pedido
            {
                Id = Guid.NewGuid(),
                Produtos = produtos
            };

            var pagamento = new Pagamento
            {
                CartaoCredito = "5555 2222 8888 1111"
            };


            var pagamentoService = serviceProvider.GetService<IPagamento>();

            var result = pagamentoService.RealizarPagamento(pedido, pagamento);
            Console.WriteLine(result.Status);

		}
    }
}
