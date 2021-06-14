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
    public partial class FLimitForm : DevExpress.XtraEditors.XtraForm
    {
        private bool UpdateOpenOrders = false;

        private List<Order> openOrders;

        public List<Order> OpenOrders
        {
            get { return openOrders; }
            set
            {
                openOrders = value;
            }
        }

        public FLimitForm()
        {
            InitializeComponent();
            gcOpenOrders.DataSource = OpenOrders;
            timer1.Enabled = true;
            
            GetStopLimitOrders();

            cHelper.GetBalances();
            cHelper.GetExhangeInfos();
        }

        private void GetStopLimitOrders()
        {
            gcStopLimits.DataSource = cLists.TradeList.OrderJobs;
            tvStopLimits.RefreshData();
        }

        private void officeNavigationBar1_ItemClick(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            if (e.Item.Text == "Açık Emirler")
            {
                GetOpenOrders();
            }
        }

        private void GetOpenOrders()
        {
            Task.Run(() =>
            {
                OpenOrders = cBinance.GetOpenOrders();
                UpdateOpenOrders = true;
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (UpdateOpenOrders)
            {
                gcOpenOrders.DataSource = openOrders;
                tvOpenOrders.RefreshData();
                UpdateOpenOrders = false;
            }
        }

        private void tvOpenOrders_ItemCustomize(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemCustomizeEventArgs e)
        {
            if (e.Item.Elements[11].Text == "SELL")
            {
                e.Item.Elements[11].Text = "Satış Limiti";
                e.Item.Elements[11].Appearance.Normal.ForeColor = Color.Red;
            }
        }

        private void tvOpenOrders_ContextButtonClick(object sender, DevExpress.Utils.ContextItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Emri silmek istediğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row = (e.DataItem as DevExpress.XtraGrid.Views.Tile.TileViewItem).RowHandle;
                int id = cHelper.ObjToInt(tvOpenOrders.GetRowCellValue(row, "orderId"));

                if (id > 0)
                {
                    cBinance.DeleteOrder(openOrders.First(p => p.orderId == id));
                    GetOpenOrders();
                }
            }
        }

        private void pctAddStopLimit_Click(object sender, EventArgs e)
        {
            FStopLimitAdd fStopLimitAdd = new FStopLimitAdd();
            if (fStopLimitAdd.ShowDialog() == DialogResult.OK)
            {
                GetStopLimitOrders();
            }
        }

        private void FLimitForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}