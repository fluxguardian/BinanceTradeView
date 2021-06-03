using BinanceTradeView.Binance;
using BinanceTradeView.Core;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraLayout;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinanceTradeView
{
    public partial class FMain : DevExpress.XtraEditors.XtraForm
    {
        public FMain()
        {
            InitializeComponent();
            string xmlFile = Directory.GetCurrentDirectory() + "\\MainState.xml";
            if (File.Exists(xmlFile))
                dockManager1.RestoreLayoutFromXml(xmlFile);

            btnBtnShowHide.ImageOptions.Image = ımageCollection1.Images[Convert.ToInt32(CUtils.ShowValues)];
            
            GetAppsettings();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        public void GetMarketCoins()
        {
            lcgMarket.Clear();

            lcMarket.BeginUpdate();
            foreach (var market in cLists.TradeList.MarketPrices)
            {
                UCMarketBoard marketBoard = new UCMarketBoard();
                marketBoard.MarketPriceValues = market;
                LayoutControlItem item = lcgMarket.AddItem();
                item.TextVisible = false;
                item.Control = marketBoard;
            }
            lcMarket.EndUpdate();
        }

        public void GetTickerCoins()
        {
            lcgTicker.Clear();

            lcgTotal.Clear();

            lcTicker.BeginUpdate();
            lcTotal.BeginUpdate();

            foreach (var trade in cLists.TradeList.Trades)
            {
                UCTickerBoard tickerBoard = new UCTickerBoard();
                tickerBoard.TradeValues = trade;
                LayoutControlItem item = lcgTicker.AddItem();
                item.TextVisible = false;
                item.Control = tickerBoard;
            }
            lcTicker.EndUpdate();

            foreach (var code in (from x in cLists.TradeList.Trades select x.PurchaseCode).Distinct().ToList())
            {
                UCTotalBoard totalBoard = new UCTotalBoard { Anchor = (AnchorStyles.Left | AnchorStyles.Right) };
                totalBoard.TradeCode = code;
                LayoutControlItem item = lcgTotal.AddItem();
                item.TextVisible = false;
                item.Control = totalBoard;
            }
            lcTotal.EndUpdate();
        }

        public void GetAppsettings()
        {
            cLists.TradeList = JsonConvert.DeserializeObject<AllTrades>(File.ReadAllText(Directory.GetCurrentDirectory() + "/Appsettings.json"));
            GetMarketCoins();
            GetTickerCoins();
        }

        private async void GetTradeValues()
        {
            cBinance.PriceList = await GetTradePrice();
        }

        private async Task<List<Price>> GetTradePrice()
        {
            return cBinance.GetTradePrices();
        }

        private async void GetTrade24hrValues()
        {
            cBinance.Trade24hrList = await GetTrade24hr();
        }

        private async Task<List<Trade24hr>> GetTrade24hr()
        {
            return cBinance.GetLast24hr();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Task.Run(() =>
                    {
                        GetTradeValues();
                    });
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                GetTrade24hrValues();
            });
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string xmlFile = Directory.GetCurrentDirectory() + "\\MainState.xml";
            dockManager1.SaveLayoutToXml(xmlFile);
        }


        private void barBtnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            popupMenu1.ShowPopup(new Point(MousePosition.X-78, MousePosition.Y - 75));
            //flyoutPanel1.ShowBeakForm(new Point(MousePosition.X, MousePosition.Y-20));
        }

        private void barBtnStopLimit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnBtnShowHide_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CUtils.ShowValues = !CUtils.ShowValues;

            btnBtnShowHide.ImageOptions.Image = ımageCollection1.Images[Convert.ToInt32(CUtils.ShowValues)];
        }

        private void barBtnSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GetAppsettings();
        }

        private void barBtnAddMarketCoin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FAddMarketCoin fAdd = new FAddMarketCoin(0);

            if (fAdd.ShowDialog() == DialogResult.OK)
                GetMarketCoins();
        }

        private void barBtnAddPurchase_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FAddPurchase fAdd = new FAddPurchase(0);

            if (fAdd.ShowDialog() == DialogResult.OK)
            {
                GetMarketCoins();
                GetTickerCoins();
            }
        }
    }
}
