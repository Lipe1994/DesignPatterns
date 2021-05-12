using System;
using System.Collections.Generic;
using System.Text;

namespace PatternFacade.CrossCutting.contracts
{
    public interface IPayPalGateway
    {
        public bool CommitTransaction(String cardHashKey, String orderId, decimal amount);
        public String GetCardHashKey(String serviceKey, String cartaoCredito);
        public String GetPayPalServiceKey(String apiKey, String encriptionKey);
    }
}
