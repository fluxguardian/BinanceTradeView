using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceTradeView
{
    public class AllTrades
    {
        public AllTrades()
        {
            Trades = new List<Trade>();
            MarketPrices = new List<MarketPrice>();
            OrderJobs = new List<OrderJob>();
        }

        public List<Trade> Trades { get; set; }
        public List<MarketPrice> MarketPrices { get; set; }
        public List<OrderJob> OrderJobs { get; set; }

        public void Save()
        {
            cHelper.JsonSave("Appsettings", this);
        }
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

    public class OrderJob
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Symbol { get; set; }
        public string Side { get; set; }
        public string Type { get; set; }
        public decimal BasePrice { get; set; }
        public decimal StopPrice { get; set; }
        public decimal LimitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal PercentageOfIncrease { get; set; }
        public bool AutoIncrease { get; set; }
        public string Error { get; set; }
        public int ErrorTryCount { get; set; }
        public bool IsActive { get; set; }

        public void IncreaseValues()
        {
            if (AutoIncrease)
            {
                var increaseRate = (PercentageOfIncrease / 100) + 1;
                BasePrice *= increaseRate;
                StopPrice *= increaseRate;
                LimitPrice *= increaseRate;
                Error = "";
                ErrorTryCount = 0;
                IsActive = true;
            }
        }
    }
}
