using System;

namespace PatternAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var transacaoLogPadrao = new TransacaoService(new Logger());
            transacaoLogPadrao.realizarTransacao();


            var transacaoLogCustomizado = new TransacaoService(new LogAdapter(new LogNetMaster()));
            transacaoLogCustomizado.realizarTransacao();
        }
    }
}
