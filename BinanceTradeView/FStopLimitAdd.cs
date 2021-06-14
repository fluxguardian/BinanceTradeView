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
using BinanceTradeView.Binance;

namespace BinanceTradeView
{
    public partial class FStopLimitAdd : DevExpress.XtraEditors.XtraForm
    {
        private Balance selectedBalance;

        private string[] tickSize = { "#,##0.##", "0" };
        private string[] lotSize = { "#,##0.##", "0" };

        //public string[] TickSize
        //{
        //    get { return tickSize; }
        //    set { tickSize = value; }
        //}

        private string GetSymbol()
        {
            if (string.IsNullOrEmpty(cHelper.ObjToStr(leAssets.EditValue)))
                return "";
            if (string.IsNullOrEmpty(txtSellCoin.Text))
                return "";


            return cHelper.ObjToStr(leAssets.EditValue).ToUpper() + txtSellCoin.Text.ToUpper();
        }

        public FStopLimitAdd()
        {
            InitializeComponent();
            btnPer25.StyleController = null;
            btnPer50.StyleController = null;
            btnPer75.StyleController = null;
            btnPer100.StyleController = null;
            btnPer25.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            btnPer50.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            btnPer75.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            btnPer100.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            btnPer100.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            btnPer100.AppearancePressed.BorderColor = Color.Transparent;
            btnPer100.Appearance.BorderColor = Color.Transparent;

            leAssets.Properties.DataSource = cLists.Balances.Where(p => p.free > 0 || p.locked > 0);
            timer1.Enabled = true;
        }

        private void btnPer25_Click(object sender, EventArgs e)
        {
            UpdatePercentage(25, btnPer25);
        }

        private void UpdatePercentage(int per, params SimpleButton[] buttons)
        {
            ClearPercentage();

            var result = selectedBalance?.free * per / 100;

            if (per == 100)
            {
                var len = result.ToString().Length;
                var index = result.ToString().IndexOf(',') + 1;
                if ((len - index) > cHelper.ObjToInt(lotSize[1]))
                {
                    result = cHelper.ObjToDecimal(result.ToString().Substring(0, index + cHelper.ObjToInt(lotSize[1])));
                }
            }

            txtAmount.Text = result?.ToString(lotSize[0]);

            if (result == null)
                ClearPercentage();
            else
                foreach (var button in buttons)
                    button.Appearance.BackColor = Color.Firebrick;
        }

        private void ClearPercentage()
        {
            btnPer25.Appearance.BackColor = Color.Empty;
            btnPer50.Appearance.BackColor = Color.Empty;
            btnPer75.Appearance.BackColor = Color.Empty;
            btnPer100.Appearance.BackColor = Color.Empty;
        }

        private void btnPer50_Click(object sender, EventArgs e)
        {
            UpdatePercentage(50, btnPer25, btnPer50);
        }

        private void btnPer75_Click(object sender, EventArgs e)
        {
            UpdatePercentage(75, btnPer25, btnPer50, btnPer75);
        }

        private void btnPer100_Click(object sender, EventArgs e)
        {
            UpdatePercentage(100, btnPer25, btnPer50, btnPer75, btnPer100);
        }

        private void leAssets_EditValueChanged(object sender, EventArgs e)
        {
            selectedBalance = cLists.Balances.FirstOrDefault(p => p.asset == leAssets.EditValue.ToString());
            lblAssetAmount.Text = "Kullanılabilir miktar : 0";
            lblAssetAmount.Text = "Kullanılabilir miktar : " + cHelper.ObjToDecimal(selectedBalance?.free).ToString();
            ClearForNewCoin();
        }

        private void ClearForNewCoin()
        {
            txtBasePrice.Text = "0";
            txtStopPrice.Text = "0";
            txtLimitPrice.Text = "0";
            seStopPercentage.Value = 0;
            seLimitPercentage.Value = 0;
            txtAmount.Text = "0";
            sePerOfIncrease.Value = 0;

            tickSize[0] = null;
            tickSize[1] = "2";

            lotSize[0] = null;
            lotSize[1] = "2";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (leAssets.EditValue != null && !string.IsNullOrEmpty(txtSellCoin.Text))
            {
                if (string.IsNullOrEmpty(tickSize[0]))
                {
                    tickSize = cHelper.GetSize(cLists.ExchangeInfos.symbols.FirstOrDefault(p => p.symbol == GetSymbol())?.filters.FirstOrDefault(p => p.filterType == "PRICE_FILTER")?.tickSize);
                    lotSize = cHelper.GetSize(cLists.ExchangeInfos.symbols.FirstOrDefault(p => p.symbol == GetSymbol())?.filters.FirstOrDefault(p => p.filterType == "LOT_SIZE")?.stepSize);
                }

                var result = cBinance.GetPrice(cHelper.ObjToStr(leAssets.EditValue).ToUpper() + txtSellCoin.Text.ToUpper());
                lblMarketPrice.Text = result == 0 ? "Satışı Yok" : result.ToString(tickSize[0]);
            }
            else
            {
                lblMarketPrice.Text = "Satışı Yok";
            }
        }

        private void lblMarketPrice_Click(object sender, EventArgs e)
        {
            var result = cBinance.GetPrice(cHelper.ObjToStr(leAssets.EditValue).ToUpper() + txtSellCoin.Text.ToUpper());
            txtBasePrice.Text = result == 0 ? "0" : result.ToString(tickSize[0]);
        }

        private void txtAmount_EditValueChanged(object sender, EventArgs e)
        {
            ClearPercentage();
        }

        private void Calculate()
        {
            var basePrice = cHelper.ObjToDecimal(txtBasePrice.Text);
            txtStopPrice.Text = (basePrice + (basePrice * cHelper.ObjToDecimal(seStopPercentage.Value) / 100)).ToString(tickSize[0]);
            txtLimitPrice.Text = (basePrice + (basePrice * cHelper.ObjToDecimal(seLimitPercentage.Value) / 100)).ToString(tickSize[0]);
        }

        private void txtBasePrice_EditValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void seStopPercentage_EditValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void seLimitPercentage_EditValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void chckOtoIncrease_CheckedChanged(object sender, EventArgs e)
        {
            sePerOfIncrease.Enabled = chckOtoIncrease.Checked;

            sePerOfIncrease.Value = 0;
        }

        private void officeNavigationBar1_ItemClick(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            if (e.Item == btnCancel)
            {
                this.DialogResult = DialogResult.Cancel;
            }

            if (e.Item == btnSave)
            {
                if (CreateOrder())
                {
                    var order = new OrderJob();
                    order.Symbol = GetSymbol();
                    order.Side = "SELL";
                    order.Type = "STOP_LOSS_LIMIT";
                    order.LimitPrice = cHelper.ObjToDecimal(txtLimitPrice.Text);
                    order.StopPrice = cHelper.ObjToDecimal(txtStopPrice.Text);
                    order.AutoIncrease = chckOtoIncrease.Checked;
                    order.PercentageOfIncrease = cHelper.ObjToDecimal(sePerOfIncrease.EditValue);
                    order.IsActive = chckOtoIncrease.Checked;
                    order.BasePrice = cHelper.ObjToDecimal(txtBasePrice.Text);
                    order.Quantity = cHelper.ObjToDecimal(txtAmount.Text);

                    var str = $"{order.Symbol} Stop limit emrini \n{order.StopPrice} stop fiyatından \n{order.LimitPrice} limit fiyatı ile \n{order.Quantity} miktar \nsatmak için oluşturmak istediğinize emin misiniz?";
                    DialogResult karar = MessageBox.Show(str,"Onay",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    if (karar == DialogResult.Yes)
                    {
                        string error = "";
                        var orderId = cBinance.AddStopLossLimit(order, ref error);

                        if (!string.IsNullOrEmpty(error))
                        {
                            MessageBox.Show("Hata nedeniyle emir oluşturulamadı.\n" + error);
                        }
                        else
                        {
                            order.Id = cLists.TradeList.OrderJobs.Any() ? cLists.TradeList.OrderJobs.Max(p => p.Id) + 1 : 1;
                            order.OrderId = orderId;

                            order.IncreaseValues();

                            cLists.TradeList.OrderJobs.Add(order);
                            cHelper.JsonSave("Appsettings", cLists.TradeList);
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
        }

        private bool CreateOrder()
        {
            var errors = "";
            if (string.IsNullOrEmpty(GetSymbol()))
                errors += "İşlem yapılacak coin çiftini belirtiniz.\n";

            var symbolInfos = cLists.ExchangeInfos.symbols.FirstOrDefault(p => p.symbol == GetSymbol());
            if (symbolInfos != null)
            {
                var priceFilters = symbolInfos.filters.FirstOrDefault(p => p.filterType == "PRICE_FILTER");
                if (priceFilters != null)
                {
                    if (cHelper.ObjToDecimal(txtBasePrice.Text) < cHelper.ObjToDecimal(priceFilters.minPrice))
                        errors += "Baz fiyatı coinin minimum satış fiyatından düşük olamaz.\n";
                    if (cHelper.ObjToDecimal(txtStopPrice.Text) < cHelper.ObjToDecimal(priceFilters.minPrice))
                        errors += "Stop fiyatı coinin minimum satış fiyatından düşük olamaz.\n";
                    if (cHelper.ObjToDecimal(txtLimitPrice.Text) < cHelper.ObjToDecimal(priceFilters.minPrice))
                        errors += "Limit fiyatı coinin minimum satış fiyatından düşük olamaz.\n";
                    if (cHelper.ObjToDecimal(txtBasePrice.Text) > cHelper.ObjToDecimal(priceFilters.maxPrice))
                        errors += "Baz fiyatı coinin maximum satış fiyatından yüksek olamaz.\n";
                    if (cHelper.ObjToDecimal(txtStopPrice.Text) > cHelper.ObjToDecimal(priceFilters.maxPrice))
                        errors += "Stop fiyatı coinin maximum satış fiyatından yüksek olamaz.\n";
                    if (cHelper.ObjToDecimal(txtLimitPrice.Text) > cHelper.ObjToDecimal(priceFilters.maxPrice))
                        errors += "Limit fiyatı coinin maximum satış fiyatından yüksek olamaz.\n";
                }

                var lotFilters = symbolInfos.filters.FirstOrDefault(p => p.filterType == "LOT_SIZE");

                if (lotFilters != null)
                {
                    if (cHelper.ObjToDecimal(txtAmount.Text) < cHelper.ObjToDecimal(lotFilters.minQty))
                        errors += "Satış miktarı coinin minimum değerinden küçük olamaz.\n";
                    if (cHelper.ObjToDecimal(txtAmount.Text) > cHelper.ObjToDecimal(lotFilters.maxQty))
                        errors += "Satış miktarı coinin maximum değerinden büyük olamaz.\n";
                }
                if (selectedBalance?.free < cHelper.ObjToDecimal(txtAmount.Text))
                    errors += "Satış miktarı kullanılabilir miktardan büyük olamaz.\n";

                if (cHelper.ObjToDecimal(txtLimitPrice.Text) == cHelper.ObjToDecimal(txtStopPrice.Text))
                    errors += "Limit fiyatın stop fiyat ile aynı olması işlemin gerçkelşem esnasında satışın kaçırılmasına sebep olabilir.\n";

                if (cHelper.ObjToDecimal(txtLimitPrice.Text) > cHelper.ObjToDecimal(txtStopPrice.Text))
                    errors += "Limit fiyatın stop fiyattan düşük olması işlemin gerçkelşem esnasında satışın kaçırılmasına sebep olabilir.\n";
            }

            if (!string.IsNullOrEmpty(errors))
            {
                MessageBox.Show(errors);
                return false;
            }

            return true;
        }

        private void TickSizeValidator(object sender, EventArgs e)
        {
            var control = (sender as TextEdit);
            if (control == txtAmount)
                control.EditValue = Math.Round(cHelper.ObjToDecimal(control.EditValue), cHelper.ObjToInt(lotSize[1]), MidpointRounding.AwayFromZero).ToString(lotSize[0]);
            else
                control.EditValue = Math.Round(cHelper.ObjToDecimal(control.EditValue), cHelper.ObjToInt(tickSize[1])).ToString(tickSize[0]);
        }

        private void txtSellCoin_EditValueChanged(object sender, EventArgs e)
        {
            ClearForNewCoin();
        }
    }
}