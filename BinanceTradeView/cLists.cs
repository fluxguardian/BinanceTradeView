using BinanceTradeView.Binance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceTradeView
{
    public static class cLists
    {
        
        public static AllTrades TradeList = new AllTrades();
        public static List<Balance> Balances { get; set; }

        public static ExchangeInfo ExchangeInfos { get; set; }
    }
}
