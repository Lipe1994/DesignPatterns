using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAdapter
{
    public class TransacaoService
    {
        private readonly Ilogger _logger;

        public TransacaoService(Ilogger logger)
        {
            this._logger = logger;
        }

        public void realizarTransacao()
        {
            _logger.Log("Transacao realizada");
        }
    }
}
