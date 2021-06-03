using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BinanceTradeView
{
    public partial class FAddMarketCoin : DevExpress.XtraEditors.XtraForm
    {
        public MarketPrice _marketPrice { get; set; }

        public FAddMarketCoin(int Id)
        {
            InitializeComponent();
            _marketPrice = cLists.TradeList.MarketPrices.FirstOrDefault(p => p.Id == Id) ?? new MarketPrice();
            GetValues();
        }
        private void GetValues()
        {
            if (_marketPrice.Id > 0)
            {
                txtMarketCode.Text = _marketPrice.MarketCode;
                txtExchangeCode.Text = _marketPrice.ExchangeCode;
            }
        }
        private void officeNavigationBar1_ItemClick(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            if (e.Item == btnSave)
            {
                if (CheckCoin())
                {
                    _marketPrice.Id = _marketPrice.Id == 0 ? cLists.TradeList.MarketPrices.Max(p => p.Id) + 1 : _marketPrice.Id;

                    _marketPrice.MarketCode = txtMarketCode.Text.ToUpper();
                    _marketPrice.ExchangeCode = txtExchangeCode.Text.ToUpper();
                    _marketPrice.Symbol = txtMarketCode.Text.ToUpper() + txtExchangeCode.Text.ToUpper();

                    if (!cLists.TradeList.MarketPrices.Any(p => p.Id == _marketPrice.Id))
                        cLists.TradeList.MarketPrices.Add(_marketPrice);

                    cHelper.JsonSave("Appsettings", cLists.TradeList);
                    this.DialogResult = DialogResult.OK;

                }
            }

            if (e.Item == btnCancel)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private bool CheckCoin()
        {

            if (!cBinance.PriceList.Any(p => p.symbol == txtMarketCode.Text.ToUpper() + txtExchangeCode.Text.ToUpper()))
            {
                MessageBox.Show("Girmiş olduğunuz coin çifti Binance kayıtlarında bulunamadı.");
                return false;
            }
            return true;
        }
    }
}