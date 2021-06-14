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

    public class Order
    {
        public string symbol { get; set; }
        public int orderId { get; set; }
        public int orderListId { get; set; }
        public string clientOrderId { get; set; }
        public string price { get; set; }
        public string origQty { get; set; }
        public string executedQty { get; set; }
        public string cummulativeQuoteQty { get; set; }
        public string status { get; set; }
        public string timeInForce { get; set; }
        public string type { get; set; }
        public string side { get; set; }
        public string stopPrice { get; set; }
        public string icebergQty { get; set; }
        public long time { get; set; }
        public long updateTime { get; set; }
        public bool isWorking { get; set; }
        public string origQuoteOrderQty { get; set; }

        public DateTime getTime => cHelper.GetDate(time);
    }

    #region Balance
    public class Balance
    {
        public string asset { get; set; }
        public decimal free { get; set; }
        public decimal locked { get; set; }
    }

    public class BalanceRoot
    {
        public int makerCommission { get; set; }
        public int takerCommission { get; set; }
        public int buyerCommission { get; set; }
        public int sellerCommission { get; set; }
        public bool canTrade { get; set; }
        public bool canWithdraw { get; set; }
        public bool canDeposit { get; set; }
        public long updateTime { get; set; }
        public string accountType { get; set; }
        public List<Balance> balances { get; set; }
        public List<string> permissions { get; set; }
    } 
    #endregion

    #region exchangeInfo
    public class RateLimit
    {
        public string rateLimitType { get; set; }
        public string interval { get; set; }
        public int intervalNum { get; set; }
        public int limit { get; set; }
    }

    public class Filter
    {
        public string filterType { get; set; }
        public string minPrice { get; set; }
        public string maxPrice { get; set; }
        public string tickSize { get; set; }
        public string multiplierUp { get; set; }
        public string multiplierDown { get; set; }
        public int? avgPriceMins { get; set; }
        public string minQty { get; set; }
        public string maxQty { get; set; }
        public string stepSize { get; set; }
        public string minNotional { get; set; }
        public bool? applyToMarket { get; set; }
        public int? limit { get; set; }
        public int? maxNumOrders { get; set; }
        public int? maxNumAlgoOrders { get; set; }
    }

    public class Symbol
    {
        public string symbol { get; set; }
        public string status { get; set; }
        public string baseAsset { get; set; }
        public int baseAssetPrecision { get; set; }
        public string quoteAsset { get; set; }
        public int quotePrecision { get; set; }
        public int quoteAssetPrecision { get; set; }
        public int baseCommissionPrecision { get; set; }
        public int quoteCommissionPrecision { get; set; }
        public List<string> orderTypes { get; set; }
        public bool icebergAllowed { get; set; }
        public bool ocoAllowed { get; set; }
        public bool quoteOrderQtyMarketAllowed { get; set; }
        public bool isSpotTradingAllowed { get; set; }
        public bool isMarginTradingAllowed { get; set; }
        public List<Filter> filters { get; set; }
        public List<string> permissions { get; set; }
    }

    public class ExchangeInfo
    {
        public string timezone { get; set; }
        public long serverTime { get; set; }
        public List<RateLimit> rateLimits { get; set; }
        public List<object> exchangeFilters { get; set; }
        public List<Symbol> symbols { get; set; }
    } 
    #endregion
}
