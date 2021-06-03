namespace BinanceTradeView
{
    partial class UCMarketBoard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMarketBoard));
            this.lbl24HrQuoteVolume = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCurrCode = new System.Windows.Forms.Label();
            this.lbl24hrPriceChange = new System.Windows.Forms.Label();
            this.lbl24hrPriceChangePer = new System.Windows.Forms.Label();
            this.lblHighPrice = new System.Windows.Forms.Label();
            this.lblLowPrice = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctTradeStatus = new System.Windows.Forms.PictureBox();
            this.pctMarketLogo = new System.Windows.Forms.PictureBox();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTradeStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMarketLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl24HrQuoteVolume
            // 
            this.lbl24HrQuoteVolume.AutoSize = true;
            this.lbl24HrQuoteVolume.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl24HrQuoteVolume.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl24HrQuoteVolume.Location = new System.Drawing.Point(42, 141);
            this.lbl24HrQuoteVolume.Name = "lbl24HrQuoteVolume";
            this.lbl24HrQuoteVolume.Size = new System.Drawing.Size(22, 24);
            this.lbl24HrQuoteVolume.TabIndex = 4;
            this.lbl24HrQuoteVolume.Text = "0";
            this.lbl24HrQuoteVolume.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPrice.Location = new System.Drawing.Point(66, 47);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(22, 24);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "0";
            this.lblPrice.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // lblCurrCode
            // 
            this.lblCurrCode.AutoSize = true;
            this.lblCurrCode.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrCode.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCurrCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCurrCode.Location = new System.Drawing.Point(65, 10);
            this.lblCurrCode.Name = "lblCurrCode";
            this.lblCurrCode.Size = new System.Drawing.Size(75, 36);
            this.lblCurrCode.TabIndex = 6;
            this.lblCurrCode.Text = "XXX";
            this.lblCurrCode.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // lbl24hrPriceChange
            // 
            this.lbl24hrPriceChange.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl24hrPriceChange.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl24hrPriceChange.Location = new System.Drawing.Point(129, 80);
            this.lbl24hrPriceChange.Name = "lbl24hrPriceChange";
            this.lbl24hrPriceChange.Size = new System.Drawing.Size(161, 24);
            this.lbl24hrPriceChange.TabIndex = 11;
            this.lbl24hrPriceChange.Text = "0";
            this.lbl24hrPriceChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl24hrPriceChange.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // lbl24hrPriceChangePer
            // 
            this.lbl24hrPriceChangePer.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl24hrPriceChangePer.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl24hrPriceChangePer.Location = new System.Drawing.Point(133, 110);
            this.lbl24hrPriceChangePer.Name = "lbl24hrPriceChangePer";
            this.lbl24hrPriceChangePer.Size = new System.Drawing.Size(157, 24);
            this.lbl24hrPriceChangePer.TabIndex = 11;
            this.lbl24hrPriceChangePer.Text = "0";
            this.lbl24hrPriceChangePer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl24hrPriceChangePer.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // lblHighPrice
            // 
            this.lblHighPrice.AutoSize = true;
            this.lblHighPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHighPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.lblHighPrice.Location = new System.Drawing.Point(42, 80);
            this.lblHighPrice.Name = "lblHighPrice";
            this.lblHighPrice.Size = new System.Drawing.Size(22, 24);
            this.lblHighPrice.TabIndex = 12;
            this.lblHighPrice.Text = "0";
            this.lblHighPrice.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // lblLowPrice
            // 
            this.lblLowPrice.AutoSize = true;
            this.lblLowPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLowPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.lblLowPrice.Location = new System.Drawing.Point(42, 110);
            this.lblLowPrice.Name = "lblLowPrice";
            this.lblLowPrice.Size = new System.Drawing.Size(22, 24);
            this.lblLowPrice.TabIndex = 14;
            this.lblLowPrice.Text = "0";
            this.lblLowPrice.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BinanceTradeView.reso.down_arrow1;
            this.pictureBox2.Location = new System.Drawing.Point(9, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BinanceTradeView.reso.up_arrow2;
            this.pictureBox1.Location = new System.Drawing.Point(9, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // pctTradeStatus
            // 
            this.pctTradeStatus.Location = new System.Drawing.Point(222, 17);
            this.pctTradeStatus.Name = "pctTradeStatus";
            this.pctTradeStatus.Size = new System.Drawing.Size(68, 55);
            this.pctTradeStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTradeStatus.TabIndex = 10;
            this.pctTradeStatus.TabStop = false;
            this.pctTradeStatus.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // pctMarketLogo
            // 
            this.pctMarketLogo.Location = new System.Drawing.Point(8, 17);
            this.pctMarketLogo.Name = "pctMarketLogo";
            this.pctMarketLogo.Size = new System.Drawing.Size(55, 55);
            this.pctMarketLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMarketLogo.TabIndex = 7;
            this.pctMarketLogo.TabStop = false;
            this.pctMarketLogo.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(298, 26);
            this.ribbonStatusBar1.Visible = false;
            this.ribbonStatusBar1.MouseLeave += new System.EventHandler(this.ribbonStatusBar1_MouseLeave);
            this.ribbonStatusBar1.MouseHover += new System.EventHandler(this.ribbonStatusBar1_MouseHover);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 26);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(298, 0);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // UCMarketBoard
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblLowPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHighPrice);
            this.Controls.Add(this.pctTradeStatus);
            this.Controls.Add(this.lbl24HrQuoteVolume);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCurrCode);
            this.Controls.Add(this.pctMarketLogo);
            this.Controls.Add(this.lbl24hrPriceChange);
            this.Controls.Add(this.lbl24hrPriceChangePer);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.True;
            this.MaximumSize = new System.Drawing.Size(300, 175);
            this.MinimumSize = new System.Drawing.Size(300, 175);
            this.Name = "UCMarketBoard";
            this.Size = new System.Drawing.Size(298, 173);
            this.MouseHover += new System.EventHandler(this.MouseHoverControl);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTradeStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMarketLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl24HrQuoteVolume;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCurrCode;
        private System.Windows.Forms.PictureBox pctMarketLogo;
        private System.Windows.Forms.PictureBox pctTradeStatus;
        private System.Windows.Forms.Label lbl24hrPriceChange;
        private System.Windows.Forms.Label lbl24hrPriceChangePer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHighPrice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblLowPrice;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
    }
}
