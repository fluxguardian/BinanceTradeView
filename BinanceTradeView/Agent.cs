using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BinanceTradeView
{
    public static class Agent
    {
        public static void CheckAutoIncreaseStopLossLimit()
        {
            try
            {
                foreach (var order in cLists.TradeList.OrderJobs.Where(p => p.IsActive && p.AutoIncrease && p.PercentageOfIncrease > 0 && p.ErrorTryCount <= 10))
                {
                    if (cHelper.ObjToDecimal(cBinance.PriceList.FirstOrDefault(p => p.symbol == order.Symbol)?.price) >= order.BasePrice)
                    {
                        string error = "";
                        if (cBinance.DeleteOrder(order.Symbol, order.OrderId, ref error))
                        {
                            var orderId = cBinance.AddStopLossLimit(order, ref error);

                            if (string.IsNullOrEmpty(error))
                            {
                                order.OrderId = orderId;
                                order.IncreaseValues();
                            }
                            else
                            {
                                order.Error = error;
                                order.ErrorTryCount++;
                            }
                        }
                        else
                        {
                            order.Error = error;
                            order.ErrorTryCount++;
                        }
                        cHelper.JsonSave("Appsettings", cLists.TradeList);
                    }
                }
            }
            catch
            {

            }
        }

        private static Timer MyTimer;

        public static void StartService()
        {
            Task.Run(() =>
            {
                MyTimer = new Timer
                {
                    Enabled = true,
                    Interval = 1000,
                    AutoReset = true
                };
                MyTimer.AutoReset = true;
                MyTimer.Elapsed += myTimer_Tick;
                MyTimer.Start();
            });
        }

        private static void myTimer_Tick(object sender, EventArgs e)
        {

            CheckAutoIncreaseStopLossLimit();

        }
    }
}
