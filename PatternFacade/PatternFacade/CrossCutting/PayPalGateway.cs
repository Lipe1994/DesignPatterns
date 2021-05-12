using PatternFacade.CrossCutting.contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternFacade.CrossCutting
{
    public class PayPalGateway : IPayPalGateway
    {
        public bool CommitTransaction(String cardHashKey, String orderId, decimal amount)
        {
            return new Random().Next(2) == 0;
        }

        public String GetCardHashKey(String serviceKey, String cartaoCredito)
        {
            return new String(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10).Select(s => s[new Random().Next(s.Length)]).ToArray() );
        }

        public String GetPayPalServiceKey(String apiKey, String encriptionKey)
        {
            return new String(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10).Select(s => s[new Random().Next(s.Length)]).ToArray() );
        }
    }
}
