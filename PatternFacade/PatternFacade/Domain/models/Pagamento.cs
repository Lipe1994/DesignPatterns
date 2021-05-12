using PatternFacade.Domain.contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFacade.Domain.models
{
    public class Pagamento
    {
        public String Status { get; set; }
        public decimal Valor { get; set; }
        public MeioPagamento meioPagamento { get; set; }
        public string CartaoCredito { get; set; }
        public string LinhaDigitavelBoleto { get; set; }
        public string ConfirmacaoTransferencia { get; set; }

    }
}
