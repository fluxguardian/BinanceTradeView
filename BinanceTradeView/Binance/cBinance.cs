using BinanceTradeView.Binance;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinanceTradeView
{
    public static class cBinance
    {
        public static decimal binanceCommission = 0.00750M;
        public static string binanceUrl = "https://api.binance.com";
        public static List<Price> PriceList = new List<Price>();
        public static List<Trade24hr> Trade24hrList = new List<Trade24hr>();

        public static decimal GetPrice(string symbol)
        {
            if (PriceList.Any(p=>p.symbol == symbol))
            {
                return Convert.ToDecimal(PriceList.FirstOrDefault(p => p.symbol == symbol).price.Replace(".",","));
            }

            return 0;
        }

        public static Trade24hr GetLast24hr(string symbol)
        {
            if (Trade24hrList.Any(p => p.symbol == symbol))
            {
                return Trade24hrList.First(p=>p.symbol == symbol);
            }

            return new Trade24hr();
        }

        public static decimal GetTradePrice(string symbol)
        {
            try
            {
                var client = new RestClient(binanceUrl + "/api/v3/ticker/price?symbol=" + symbol);
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var result = JsonConvert.DeserializeObject<Price>(response.Content);
                return Convert.ToDecimal(result.price.Replace(".",","));
            }
            catch 
            {
                return 0;
            }
        }

        public static List<Price> GetTradePrices()
        {
            try
            {
                var client = new RestClient(binanceUrl + "/api/v3/ticker/price");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var result = JsonConvert.DeserializeObject<List<Price>>(response.Content);
                return result;
            }
            catch
            {
                return null;
            }
        }

        public static List<Trade24hr> GetLast24hr()
        {
            try
            {
                var client = new RestClient(binanceUrl + "/api/v3/ticker/24hr");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                var result = JsonConvert.DeserializeObject<List<Trade24hr>>(response.Content);
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
