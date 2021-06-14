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
        public static string binanceApiKey = "yAfpZEqUlYzLGmst3uCwu7NMCgh6Qyi9Yk76EF71yo86oI3cORnBIY5zPjROtNoX";
        public static string binanceApiSecretKey = "jDHkFQrMZy7rciIj0mpbGyRKO1xOzamomZ8ggUnjbdAdvOP8FPuBEyWmifWHGOKa";

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

        public static List<Order> GetOpenOrders()
        {
            try
            {
                var client = new RestClient(binanceUrl);
                client.Timeout = -1;
                var request = new RestRequest("/api/v3/openOrders");
                request.AddHeader("X-MBX-APIKEY", binanceApiKey);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("timestamp", cBinance.GetServerTime(), ParameterType.QueryString);
                request.AddParameter("signature", cHelper.GetSignature(request.Parameters), ParameterType.QueryString);
                
                //IRestResponse response = client.Execute(request);
                var str = client.Get(request).Content;
                return JsonConvert.DeserializeObject<Order[]>(str)?.ToList();
            }
            catch (Exception ex)
            {
                return new List<Order>();
            }
        }

        public static List<Balance> GetBalances()
        {
            try
            {
                var client = new RestClient(binanceUrl);
                client.Timeout = -1;
                var request = new RestRequest("/api/v3/account");
                request.AddHeader("X-MBX-APIKEY", binanceApiKey);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("timestamp", cBinance.GetServerTime(), ParameterType.QueryString);
                request.AddParameter("signature", cHelper.GetSignature(request.Parameters), ParameterType.QueryString);

                var str = client.Get(request).Content;
                return JsonConvert.DeserializeObject<BalanceRoot>(str)?.balances;
            }
            catch (Exception ex)
            {
                return new List<Balance>();
            }
        }

        public static bool DeleteOrder(Order order)
        {
            try
            {
                var client = new RestClient(binanceUrl);
                client.Timeout = -1;
                var request = new RestRequest("/api/v3/order");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("X-MBX-APIKEY", binanceApiKey);
                request.AddParameter("symbol", order.symbol, ParameterType.QueryString);
                request.AddParameter("orderId", order.orderId, ParameterType.QueryString);
                request.AddParameter("timestamp", GetServerTime(), ParameterType.QueryString);
                request.AddParameter("signature", cHelper.GetSignature(request.Parameters), ParameterType.QueryString);
                var response = client.Delete(request).Content;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static bool DeleteOrder(string symbol,int orderId, ref string error)
        {
            try
            {
                var client = new RestClient(binanceUrl);
                client.Timeout = -1;
                var request = new RestRequest("/api/v3/order");
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("X-MBX-APIKEY", binanceApiKey);
                request.AddParameter("symbol", symbol, ParameterType.QueryString);
                request.AddParameter("orderId", orderId, ParameterType.QueryString);
                request.AddParameter("timestamp", GetServerTime(), ParameterType.QueryString);
                request.AddParameter("signature", cHelper.GetSignature(request.Parameters), ParameterType.QueryString);
                var response = JsonConvert.DeserializeObject<dynamic>(client.Delete(request).Content);

                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public static long GetServerTime()
        {
            try
            {
                var client = new RestClient(binanceUrl + "/api/v3/time");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(request);
                var result = JsonConvert.DeserializeObject<dynamic>(response.Content);
                return Convert.ToInt64(result.serverTime);
            }
            catch
            {
                return 0;
            }
        }

        public static int AddStopLossLimit(OrderJob order, ref string error)
        {
            try
            {
                var client = new RestClient(binanceUrl);
                client.Timeout = -1;
                var request = new RestRequest("/api/v3/order");
                request.AddHeader("X-MBX-APIKEY", binanceApiKey);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("symbol", order.Symbol, ParameterType.QueryString);
                request.AddParameter("side", order.Side, ParameterType.QueryString);
                request.AddParameter("type", order.Type, ParameterType.QueryString);
                request.AddParameter("timeInForce", "GTC", ParameterType.QueryString);
                request.AddParameter("quantity", order.Quantity.ToString().Replace(".","").Replace(",","."), ParameterType.QueryString);
                request.AddParameter("price", order.LimitPrice.ToString().Replace(".", "").Replace(",", "."), ParameterType.QueryString);
                request.AddParameter("stopPrice", order.StopPrice.ToString().Replace(".", "").Replace(",", "."), ParameterType.QueryString);
                request.AddParameter("timestamp", cBinance.GetServerTime(), ParameterType.QueryString);
                request.AddParameter("signature", cHelper.GetSignature(request.Parameters), ParameterType.QueryString);

                var result = JsonConvert.DeserializeObject<dynamic>(client.Post(request).Content);

                try
                {
                    return result.orderId;
                }
                catch
                {
                    error = result.msg;
                    return 0;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return 0;
            }
        }

        public static ExchangeInfo GetExchangeInfos()
        {
            try
            {
                var client = new RestClient(binanceUrl + "/api/v3/exchangeInfo");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Content-Type", "application/json");
                IRestResponse response = client.Execute(request);
                return JsonConvert.DeserializeObject<ExchangeInfo>(response.Content);
            }
            catch
            {
                return new ExchangeInfo();
            }
        }

        public static List<Order> GetAllOrders(string symbol)
        {
            try
            {
                var client = new RestClient(binanceUrl);
                client.Timeout = -1;
                var request = new RestRequest("/api/v3/allOrders");
                request.AddHeader("X-MBX-APIKEY", binanceApiKey);
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("symbol", symbol, ParameterType.QueryString);
                request.AddParameter("limit", 500, ParameterType.QueryString);
                request.AddParameter("timestamp", cBinance.GetServerTime(), ParameterType.QueryString);
                request.AddParameter("signature", cHelper.GetSignature(request.Parameters), ParameterType.QueryString);

                //IRestResponse response = client.Execute(request);
                var str = client.Get(request).Content;
                return JsonConvert.DeserializeObject<Order[]>(str)?.ToList();
            }
            catch (Exception ex)
            {
                return new List<Order>();
            }
        }
    }
}
