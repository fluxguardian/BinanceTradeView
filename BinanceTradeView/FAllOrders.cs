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
    public partial class FAllOrders : DevExpress.XtraEditors.XtraForm
    {
        public string Symbol { get; set; }
        public List<Order> allOrders { get; set; }

        public decimal Price { get; set; }
        public decimal PurchaseAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        public FAllOrders(string symbol)
        {
            InitializeComponent();
            Symbol = symbol;
        }

        private void FAllOrders_Load(object sender, EventArgs e)
        {
            allOrders = cBinance.GetAllOrders(Symbol).Where(p=>p.status == "FILLED").OrderByDescending(p=>p.getTime).ToList();

            foreach (var order in allOrders)
                if (cHelper.ObjToDecimal(order.price) == 0)
                    order.price = (cHelper.ObjToDecimal(order.cummulativeQuoteQty) / cHelper.ObjToDecimal(order.executedQty)).ToString("#0.00000000").Replace(",",".");

            GcOrders.DataSource = allOrders;
            GvOrders.RefreshData();
        }

        private void officeNavigationBar1_ItemClick(object sender, DevExpress.XtraBars.Navigation.NavigationBarItemEventArgs e)
        {
            if (e.Item == btnSelect)
            {
                Select();
            }
            if (e.Item == btnCancel)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void Select()
        {
            List<int> ids = new List<int>();
            foreach (var row in GvOrders.GetSelectedRows())
                ids.Add(cHelper.ObjToInt(GvOrders.GetRowCellValue(row, "orderId")));

            var orders = allOrders.Where(p => ids.Contains(p.orderId)).OrderBy(p => p.getTime).ToList();

            if (CheckOrders(orders))
            {
                foreach (var order in orders)
                {
                    var orderPrice = cHelper.ObjToDecimal(order.price);
                    var orderExecuteQty = cHelper.ObjToDecimal(order.executedQty);
                    var orderCummulativeQty = cHelper.ObjToDecimal(order.cummulativeQuoteQty);

                    if (order.side == "SELL")
                    {
                        PurchaseAmount -= orderExecuteQty;
                        TotalAmount -= (Price * orderExecuteQty);
                    }
                    else
                    {
                        PurchaseAmount += orderExecuteQty;
                        TotalAmount += orderCummulativeQty;
                    }

                    PurchaseAmount = PurchaseAmount < 0 ? 0 : PurchaseAmount;
                    TotalAmount = TotalAmount < 0 ? 0 : TotalAmount;
                    CalculatePrice();
                    PurchaseDate = order.getTime;
                }

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Price = 0;
                PurchaseAmount = 0;
                TotalAmount = 0;
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CalculatePrice()
        {
            Price = (TotalAmount==0 ||PurchaseAmount==0)? 0 : TotalAmount / PurchaseAmount;
        }

        private bool CheckOrders(List<Order> orders)
        {
            if (orders.Any(p => p.side == "BUY"))
            {
                var sellTotal = 0.00m;
                var buyTotal = 0.00m;

                foreach (var order in orders.Where(p => p.side == "SELL"))
                    sellTotal += cHelper.ObjToDecimal(order.executedQty);
                foreach (var order in orders.Where(p => p.side == "BUY"))
                    buyTotal += cHelper.ObjToDecimal(order.executedQty);

                if (sellTotal >= buyTotal)
                    return false;

                var minOrderId = orders.Where(p => p.side == "BUY").Min(p => p.orderId);
                orders = orders.Where(p => p.orderId >= minOrderId).ToList();
                return true;
            }
            else
                return false;
        }
    }
}