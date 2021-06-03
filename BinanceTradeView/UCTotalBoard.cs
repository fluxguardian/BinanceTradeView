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
    public partial class UCTotalBoard : DevExpress.XtraEditors.XtraUserControl
    {
        private string tradeCode;

        public string TradeCode
        {
            get { return tradeCode; }
            set
            {
                tradeCode = value;
                pctTradeIcon.Image = (Bitmap)reso.ResourceManager.GetObject(tradeCode);
                lblCurrCode.Text = tradeCode;
            }
        }

        private decimal amount;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private decimal assetAmount;

        public decimal AssetAmount
        {
            get { return assetAmount; }
            set { assetAmount = value; }
        }

        private decimal profitAmount;

        public decimal ProfitAmount
        {
            get { return profitAmount; }
            set { profitAmount = value; }
        }


        public decimal Percentage
        {
            get { return Amount == 0 ? 0 : (ProfitAmount/Amount); }
        }


        public UCTotalBoard()
        {
            InitializeComponent();
        }

        private void UCTotalBoard_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Amount = cLists.TradeList.Trades.Where(p => p.PurchaseCode == tradeCode).Sum(p => p.PurchaseTotal);
            AssetAmount = cLists.TradeList.Trades.Where(p => p.PurchaseCode == tradeCode).Sum(p => p.AssetAmount);
            ProfitAmount = AssetAmount - Amount;

            if (CUtils.ShowValues)
            {
                lblAmount.Text = Amount.ToString("#,##0.##");
                lblAssetAmount.Text = AssetAmount.ToString("#,##0.##");
                lblProfitAmount.Text = ProfitAmount.ToString("#,##0.##");
                lblPercentage.Text = Percentage.ToString("#,##0.## %");
            }
            else
            {
                lblAmount.Text = "******";
                lblAssetAmount.Text = "******";
                lblProfitAmount.Text = "******";
                lblPercentage.Text = Percentage.ToString("*** %");
            }

            if (ProfitAmount == 0)
            {
                pctTotalStatus.Image = null;
                lblProfitAmount.ForeColor = lblAmount.ForeColor = lblAssetAmount.ForeColor = lblPercentage.ForeColor = Color.DarkGray;
            }

            if (ProfitAmount > 0)
            {
                pctTotalStatus.Image = reso.up;
                lblProfitAmount.ForeColor = lblAmount.ForeColor = lblAssetAmount.ForeColor = lblPercentage.ForeColor = Color.DarkGreen;
            }

            if (ProfitAmount < 0)
            {
                pctTotalStatus.Image = reso.down;
                lblProfitAmount.ForeColor = lblAmount.ForeColor = lblAssetAmount.ForeColor = lblPercentage.ForeColor = Color.DarkRed;
            }
        }

        private void UCTotalBoard_MouseHover(object sender, EventArgs e)
        {
        }
    }
}
