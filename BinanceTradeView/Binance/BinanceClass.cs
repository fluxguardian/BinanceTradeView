using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceTradeView.Binance
{
    
    public class Price
    {
        public string symbol { get; set; }
        public string price { get; set; }
    }

    public class Trade24hr
    {
        public string symbol { get; set; }
        public string priceChange { get; set; }
        public string priceChangePercent { get; set; }
        public string highPrice { get; set; }
        public string lowPrice { get; set; }
        public string quoteVolume { get; set; }
    }
}
