using System;
using System.Linq;
using System.Windows.Forms;

namespace BinanceTradeView
{
    public partial class FAddPurchase : DevExpress.XtraEditors.XtraForm
    {
        public Trade _trade { get; set; }

        public FAddPurchase(int Id)
        {
            InitializeComponent();
            dePurchaseDate.EditValue = DateTime.Now;
            _trade = cLists.TradeList.Trades.FirstOrDefault(p=>p.Id == Id) ?? new Trade();
            GetValues();
        }

        private void GetValues()
        {
            if (_trade.Id>0)
            {
                txtTradeCode.Text = _trade.TradeCode;
                txtPurchaseCode.Text = _trade.PurchaseCode;
                txtCurrPrice.Text = _trade.PurchasePrice.ToString();
                txtPurchaseAmount.Text = _trade.Amount.ToString();
                txtTotalPrice.Text = _trade.PurchaseTotal.ToString();
                dePurchaseDate.EditValue = _trade.PurchaseDate;
            }
        }

        private void officeNavigationBar1_ItemClick(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            if (e.Item.Name == btnSave.Name)
            {
                if (CheckValues())
                    SaveValues();
            }
            else
            {
                this.Close();
            }
        }

        private bool CheckValues()
        {
            if (cHelper.ObjToDecimal(txtCurrPrice.Text)<=0)
            {
                MessageBox.Show("Alış fiyatı sıfırdan büyük olmalıdır.");
                return false;
            }
            if (cHelper.ObjToDecimal(txtPurchaseAmount.Text) <= 0)
            {
                MessageBox.Show("Alınan miktar sıfırdan büyük olmalıdır.");
                return false;
            }
            if (cHelper.ObjToDecimal(txtTotalPrice.Text) <= 0)
            {
                MessageBox.Show("Toplam fiyat sıfırdan büyük olmalıdır.");
                return false;
            }

            if (!cBinance.PriceList.Any(p => p.symbol == txtTradeCode.Text + txtPurchaseCode.Text))
            {
                MessageBox.Show("Girmiş olduğunuz coin çifti Binance kayıtlarında bulunamadı.");
                return false;
            }

            if (MessageBox.Show("Girmiş olduğunuz bilgilerle coin çiftini sisteme eklemek istediğinize emin misiniz?","Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                return false;
            
            return true;
        }

        private void SaveValues()
        {
            _trade.Amount = cHelper.ObjToDecimal(txtPurchaseAmount.Text);
            _trade.TradeCode = txtTradeCode.Text.ToUpper();
            _trade.Id = _trade.Id > 0 ? _trade.Id : cLists.TradeList.Trades.Max(p => p.Id) + 1;
            _trade.PurchaseCode = txtPurchaseCode.Text.ToUpper();
            _trade.PurchaseDate = dePurchaseDate.DateTime.Date;
            _trade.PurchasePrice = cHelper.ObjToDecimal(txtCurrPrice.Text);
            _trade.PurchaseTotal = cHelper.ObjToDecimal(txtTotalPrice.Text);

            if (!_trade.Symbols.Any(p => p.Symbol == (_trade.TradeCode + _trade.PurchaseCode)))
                _trade.Symbols.Add(new SymbolCurr { Price = 0m, Symbol = _trade.TradeCode + _trade.PurchaseCode});
            if (!_trade.Symbols.Any(p=>p.Symbol == (_trade.TradeCode + "TRY")))
                _trade.Symbols.Add(new SymbolCurr {Price = 0m, Symbol = _trade.TradeCode + "TRY"});
            if (!_trade.Symbols.Any(p => p.Symbol == (_trade.TradeCode + "USDT")))
                _trade.Symbols.Add(new SymbolCurr { Price = 0m, Symbol = _trade.TradeCode + "USDT" });
            if (!_trade.Symbols.Any(p => p.Symbol == (_trade.TradeCode + "BUSD")))
                _trade.Symbols.Add(new SymbolCurr { Price = 0m, Symbol = _trade.TradeCode + "BUSD" });

            if (!cLists.TradeList.Trades.Any(p=>p.Id == _trade.Id))
                cLists.TradeList.Trades.Add(_trade);

            if (chckAddMarketCoin.Checked)
            {
                if (!cLists.TradeList.MarketPrices.Any(p=>p.Symbol == (_trade.TradeCode + _trade.PurchaseCode)))
                {
                    MarketPrice marketPrice = new MarketPrice
                    {
                        Id = cLists.TradeList.MarketPrices.Max(p => p.Id) + 1,
                        ExchangeCode = _trade.PurchaseCode,
                        MarketCode = _trade.TradeCode,
                        Symbol = _trade.TradeCode + _trade.PurchaseCode,
                    };

                    cLists.TradeList.MarketPrices.Add(marketPrice);
                }
            }

            cHelper.JsonSave("Appsettings", cLists.TradeList);
            this.DialogResult = DialogResult.OK;
        }
    }
}