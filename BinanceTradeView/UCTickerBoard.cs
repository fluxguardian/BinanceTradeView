using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BinanceTradeView.Core;

namespace BinanceTradeView
{
    public partial class UCTickerBoard : DevExpress.XtraEditors.XtraUserControl
    {

        private decimal usdtTRY;
        public decimal UsdtTRY
        {
            get { return usdtTRY; }
            set { usdtTRY = value; }
        }

        private decimal priceTRY;
        public decimal PriceTRY
        {
            get { return priceTRY; }
            set
            {
                priceTRY = value == 0 ? PriceUSDT * usdtTRY : value;
                lblTRY.Text = priceTRY < 1 ? priceTRY.ToString("#,##0.########") : priceTRY.ToString("#,##0.##");
            }
        }

        private decimal priceUSDT;

        public decimal PriceUSDT
        {
            get { return priceUSDT; }
            set
            {
                priceUSDT = value;
                lblUSDT.Text = priceUSDT < 1 ? priceUSDT.ToString("#,##0.########") : priceUSDT.ToString("#,##0.##");
            }
        }

        private decimal marketPrice;

        public decimal MarketPrice
        {
            get { return marketPrice; }
            set
            {
                marketPrice = value;
            }
        }

        private decimal purchasePrice;

        public decimal PurchasePrice
        {
            get { return purchasePrice; }
            set
            {
                purchasePrice = value;
                lblPurchaseInfo.Text = (purchasePrice < 1 ? purchasePrice.ToString("#,##0.########") : purchasePrice.ToString("#,##0.##")) + " | " + (purchaseAmount < 1 ? purchaseAmount.ToString("#,##0.########") : purchaseAmount.ToString("#,##0.##"));
            }
        }

        private decimal purchaseAmount;

        public decimal PurchaseAmount
        {
            get { return purchaseAmount; }
            set
            {
                purchaseAmount = value;
                lblPurchaseInfo.Text = (purchasePrice < 1 ? purchasePrice.ToString("#,##0.########") : purchasePrice.ToString("#,##0.##")) + " | " + (purchaseAmount < 1 ? purchaseAmount.ToString("#,##0.########") : purchaseAmount.ToString("#,##0.##"));
            }
        }

        private decimal assetAmount;
        public decimal AssetAmount
        {
            get { return assetAmount; }
            set
            {
                assetAmount = value;
                if (assetAmount == 0)
                {
                    assetAmount = marketPrice * tradeValues.Amount;
                }
            }
        }

        private Trade tradeValues;
        public Trade TradeValues
        {
            get { return tradeValues; }
            set {
                tradeValues = value;
                GetValues();
            }
        }

        public int ShowStatusBar { get; set; }

        public UCTickerBoard()
        {
            InitializeComponent();
            pictureBox2.Image = reso.BUSD;
            pictureBox3.Image = reso.TRY;
        }

        private void GetValues()
        {
            lblCurrCode.Text = tradeValues.TradeCode;
            pictureBox1.Image = (Bitmap) reso.ResourceManager.GetObject(tradeValues.TradeCode);
            pctPurchase.Image = (Bitmap) reso.ResourceManager.GetObject(tradeValues.PurchaseCode);
            PriceUSDT = tradeValues.Symbols.FirstOrDefault(p => p.Symbol == (tradeValues.TradeCode + "USDT")).Price;
            PriceTRY = tradeValues.Symbols.FirstOrDefault(p => p.Symbol == (tradeValues.TradeCode + "TRY"))?.Price ?? 0;
            //PurchasePrice = tradeValues.Symbols.FirstOrDefault(p => p.Symbol == (tradeValues.TradeCode + tradeValues.PurchaseCode))?.Price??0;
            PurchasePrice = tradeValues.PurchasePrice;
            PurchaseAmount = tradeValues.Amount;

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ShowStatusBar>=0 && ShowStatusBar<=3)
                ShowStatusBar--;

            if (ShowStatusBar==0)
                ribbonStatusBar1.Visible = false;

            if (cBinance.PriceList != null && cBinance.PriceList.Any())
            {
                UsdtTRY = cBinance.GetPrice("USDTTRY");
                PriceUSDT = cBinance.GetPrice(tradeValues.TradeCode + "USDT");
                PriceTRY = cBinance.GetPrice(tradeValues.TradeCode + "TRY");
                MarketPrice = cBinance.GetPrice(tradeValues.TradeCode + tradeValues.PurchaseCode);

                foreach (var symbol in tradeValues.Symbols)
                    symbol.Price = cBinance.GetPrice(symbol.Symbol);

                AssetAmount = tradeValues.AssetAmount;

                if (CUtils.ShowValues)
                {
                    txtAssetAmount.Text = assetAmount.ToString("#,##0.##");
                    txtGain.Text = (assetAmount - tradeValues.PurchaseTotal).ToString("#,##0.##");
                    lblPercentage.Text = ((assetAmount - tradeValues.PurchaseTotal) / tradeValues.PurchaseTotal).ToString("#0.## %");
                }
                else
                {
                    txtAssetAmount.Text = "******";
                    txtGain.Text = "******";
                    lblPercentage.Text = "*** %";
                }

                if (assetAmount == 0)
                {
                    pctTradeStatus.Image = null;
                    txtGain.ForeColor = txtAssetAmount.ForeColor = lblPercentage.ForeColor = Color.DarkGray;
                    pctProfit.Image = null;
                    
                }
                if (assetAmount > tradeValues.PurchaseTotal)
                {
                    pctTradeStatus.Image = reso.up;
                    txtGain.ForeColor = txtAssetAmount.ForeColor = lblPercentage.ForeColor = Color.DarkGreen;
                    pctProfit.Image = reso.up_arrow2;
                }
                if (assetAmount < tradeValues.PurchaseTotal)
                {
                    pctTradeStatus.Image = reso.down;
                    txtGain.ForeColor = txtAssetAmount.ForeColor = lblPercentage.ForeColor = Color.DarkRed;
                    pctProfit.Image = reso.down_arrow1;
                }
            }
        }

        private void UCTickerBoard_Click(object sender, EventArgs e)
        {
            //this.BackColor = Color.FromArgb(34,33,44);
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
            if (MessageBox.Show($"{tradeValues.TradeCode} takip verisini silmek istediğinize emin misiniz?",
                "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cLists.TradeList.Trades.Remove(tradeValues);
                cHelper.JsonSave("Appsettings", cLists.TradeList);
                (Form.ActiveForm as FMain).GetTickerCoins();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FAddPurchase fAdd = new FAddPurchase(tradeValues.Id);

            if (fAdd.ShowDialog() == DialogResult.OK)
                (Form.ActiveForm as FMain).GetTickerCoins();
        }
    }
}
