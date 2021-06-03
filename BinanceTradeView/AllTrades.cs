using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceTradeView
{
    public class AllTrades
    {
        public List<Trade> Trades { get; set; }
        public List<MarketPrice> MarketPrices { get; set; }
    }

    public class Trade
    {
        public Trade()
        {
            Symbols = new List<SymbolCurr>();
        }
        public int Id { get; set; }
        public string TradeCode { get; set; }
        public List<SymbolCurr> Symbols { get; set; }
        public decimal PurchasePrice { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Amount { get; set; }
        public decimal PurchaseTotal { get; set; }
        public string PurchaseCode { get; set; }

        public decimal AssetAmount
        {
            get
            {
                if (Symbols.Any(p => p.Symbol == TradeCode + PurchaseCode))
                {
                    return Symbols.FirstOrDefault(p => p.Symbol == TradeCode + PurchaseCode).Price * Amount * (1 - cBinance.binanceCommission);
                }

                return 0;
            }
        }
    }

    public class SymbolCurr
    {
        public string Symbol { get; set; }
        public decimal Price { get; set; }
    }

    public class MarketPrice
    {
        public int Id { get; set; }
        public string MarketCode { get; set; }
        public string ExchangeCode { get; set; }
        public string Symbol { get; set; }
        public decimal PriceChange { get; set; }
        public decimal PriceChangePercent { get; set; }
        public decimal HighPrice { get; set; }
        public decimal LowPrice { get; set; }
        public decimal QuoteVolume { get; set; }

    }
}
