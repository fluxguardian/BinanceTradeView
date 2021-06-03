using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Net;

namespace BinanceTradeView
{
    public partial class UCMarketBoard : DevExpress.XtraEditors.XtraUserControl
    {
        private MarketPrice marketPriceValues;
        public MarketPrice MarketPriceValues
        {
            get { return marketPriceValues; }
            set
            {
                marketPriceValues = value;
                GetValues();
            }
        }

        public int ShowStatusBar { get; set; }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set
            {
                price = value;
                lblPrice.Text = value.ToString("#,##0.##########");
            }
        }

        private decimal quoteVolume;
        public decimal QuoteVolume
        {
            get { return quoteVolume; }
            set
            {
                quoteVolume = value;
                lbl24HrQuoteVolume.Text = value.ToString("#,##0.##");
            }
        }

        private decimal price24HrPriceChange;
        public decimal Price24HrPriceChange
        {
            get { return price24HrPriceChange; }
            set
            {
                price24HrPriceChange = value;
                lbl24hrPriceChange.Text = value.ToString("#,##0.##########");

                if (value>0)
                {
                    pctTradeStatus.Image = reso.up;
                    lbl24hrPriceChange.ForeColor = Color.DarkGreen;
                    lbl24hrPriceChangePer.ForeColor = Color.DarkGreen;
                }

                if (value == 0)
                {
                    pctTradeStatus.Image = null;
                    lbl24hrPriceChange.ForeColor = Color.DarkGray;
                    lbl24hrPriceChangePer.ForeColor = Color.DarkGray;
                }

                if (value <0)
                {
                    pctTradeStatus.Image = reso.down;
                    lbl24hrPriceChange.ForeColor = Color.DarkRed;
                    lbl24hrPriceChangePer.ForeColor = Color.DarkRed;
                }
            }
        }

        private decimal price24HrPriceChangePer;
        public decimal Price24HrPriceChangePer
        {
            get { return price24HrPriceChangePer; }
            set
            {
                price24HrPriceChangePer = value;
                lbl24hrPriceChangePer.Text = (value/100).ToString("#,##0.## %");
            }
        }

        private decimal highPrice;
        public decimal HighPrice
        {
            get { return highPrice; }
            set
            {
                highPrice = value;
                lblHighPrice.Text = value.ToString("#,##0.##########");
            }
        }

        private decimal lowPrice;
        public decimal LowPrice
        {
            get { return lowPrice; }
            set
            {
                lowPrice = value;
                lblLowPrice.Text = value.ToString("#,##0.##########");
            }
        }

        public UCMarketBoard()
        {
            InitializeComponent();
        }

        private void GetValues()
        {
            lblCurrCode.Text = marketPriceValues.Symbol;
            pctMarketLogo.Image = (Bitmap)reso.ResourceManager.GetObject(marketPriceValues.MarketCode);
            Price24HrPriceChange = marketPriceValues.PriceChange;
            Price24HrPriceChangePer = marketPriceValues.PriceChangePercent;
            Price = 0;
            HighPrice = marketPriceValues.HighPrice;
            LowPrice = marketPriceValues.LowPrice;
            QuoteVolume = marketPriceValues.QuoteVolume;

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ShowStatusBar >= 0 && ShowStatusBar <= 3)
                ShowStatusBar--;

            if (ShowStatusBar == 0)
                ribbonStatusBar1.Visible = false;

            if (cBinance.PriceList != null && cBinance.PriceList.Any())
            {
                Price = cBinance.GetPrice(marketPriceValues.Symbol);
            }

            if (cBinance.Trade24hrList != null && cBinance.Trade24hrList.Any())
            {
                var values = cBinance.GetLast24hr(marketPriceValues.Symbol);

                Price24HrPriceChange = Convert.ToDecimal(values.priceChange.Replace(".",","));
                Price24HrPriceChangePer = Convert.ToDecimal(values.priceChangePercent.Replace(".", ","));
                HighPrice = Convert.ToDecimal(values.highPrice.Replace(".", ","));
                LowPrice = Convert.ToDecimal(values.lowPrice.Replace(".", ","));
                QuoteVolume = Convert.ToDecimal(values.quoteVolume.Replace(".", ","));
            }
        }

        private void MouseHoverControl(object sender, EventArgs e)
        {
            ribbonStatusBar1.Visible = true;
            ShowStatusBar = 3;
        }

        private void ribbonStatusBar1_MouseHover(object sender, EventArgs e)
        {
            ShowStatusBar = 10;
        }

        private void ribbonStatusBar1_MouseLeave(object sender, EventArgs e)
        {
            ShowStatusBar = 3;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show($"{marketPriceValues.MarketCode} piyasa verisini silmek istediğinize emin misiniz?",
                "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cLists.TradeList.MarketPrices.Remove(marketPriceValues);
                cHelper.JsonSave("Appsettings", cLists.TradeList);
                (Form.ActiveForm as FMain).GetMarketCoins();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FAddMarketCoin fAdd = new FAddMarketCoin(marketPriceValues.Id);

            if (fAdd.ShowDialog() == DialogResult.OK)
                (Form.ActiveForm as FMain).GetMarketCoins();
        }
    }
}
