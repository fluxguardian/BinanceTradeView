namespace BinanceTradeView
{
    partial class UCTickerBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCTickerBoard));
            this.lblCurrCode = new System.Windows.Forms.Label();
            this.lblUSDT = new System.Windows.Forms.Label();
            this.lblTRY = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ımageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.txtAssetAmount = new System.Windows.Forms.Label();
            this.txtGain = new System.Windows.Forms.Label();
            this.pctProfit = new System.Windows.Forms.PictureBox();
            this.pctPurchase = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPurchaseInfo = new System.Windows.Forms.Label();
            this.pctTradeStatus = new DevExpress.XtraEditors.PictureEdit();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPurchase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTradeStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrCode
            // 
            this.lblCurrCode.AutoSize = true;
            this.lblCurrCode.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrCode.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCurrCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCurrCode.Location = new System.Drawing.Point(64, 9);
            this.lblCurrCode.Name = "lblCurrCode";
            this.lblCurrCode.Size = new System.Drawing.Size(75, 36);
            this.lblCurrCode.TabIndex = 0;
            this.lblCurrCode.Text = "XXX";
            this.lblCurrCode.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // lblUSDT
            // 
            this.lblUSDT.AutoSize = true;
            this.lblUSDT.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUSDT.ForeColor = System.Drawing.Color.DarkGray;
            this.lblUSDT.Location = new System.Drawing.Point(31, 79);
            this.lblUSDT.Name = "lblUSDT";
            this.lblUSDT.Size = new System.Drawing.Size(22, 24);
            this.lblUSDT.TabIndex = 0;
            this.lblUSDT.Text = "0";
            this.lblUSDT.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // lblTRY
            // 
            this.lblTRY.AutoSize = true;
            this.lblTRY.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTRY.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTRY.Location = new System.Drawing.Point(31, 113);
            this.lblTRY.Name = "lblTRY";
            this.lblTRY.Size = new System.Drawing.Size(22, 24);
            this.lblTRY.TabIndex = 0;
            this.lblTRY.Text = "0";
            this.lblTRY.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ımageCollection1
            // 
            this.ımageCollection1.ImageSize = new System.Drawing.Size(25, 25);
            this.ımageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ımageCollection1.ImageStream")));
            this.ımageCollection1.Images.SetKeyName(0, "down.png");
            this.ımageCollection1.Images.SetKeyName(1, "up.png");
            // 
            // txtAssetAmount
            // 
            this.txtAssetAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssetAmount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAssetAmount.ForeColor = System.Drawing.Color.DarkGray;
            this.txtAssetAmount.Location = new System.Drawing.Point(131, 79);
            this.txtAssetAmount.Name = "txtAssetAmount";
            this.txtAssetAmount.Size = new System.Drawing.Size(136, 24);
            this.txtAssetAmount.TabIndex = 8;
            this.txtAssetAmount.Text = "0";
            this.txtAssetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtAssetAmount.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // txtGain
            // 
            this.txtGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGain.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGain.ForeColor = System.Drawing.Color.DarkGray;
            this.txtGain.Location = new System.Drawing.Point(131, 111);
            this.txtGain.Name = "txtGain";
            this.txtGain.Size = new System.Drawing.Size(136, 24);
            this.txtGain.TabIndex = 9;
            this.txtGain.Text = "0";
            this.txtGain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtGain.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // pctProfit
            // 
            this.pctProfit.Image = global::BinanceTradeView.reso.profit_graph;
            this.pctProfit.Location = new System.Drawing.Point(273, 115);
            this.pctProfit.Name = "pctProfit";
            this.pctProfit.Size = new System.Drawing.Size(20, 20);
            this.pctProfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctProfit.TabIndex = 7;
            this.pctProfit.TabStop = false;
            this.pctProfit.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // pctPurchase
            // 
            this.pctPurchase.Image = global::BinanceTradeView.reso.BUSD;
            this.pctPurchase.Location = new System.Drawing.Point(271, 79);
            this.pctPurchase.Name = "pctPurchase";
            this.pctPurchase.Size = new System.Drawing.Size(24, 24);
            this.pctPurchase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPurchase.TabIndex = 6;
            this.pctPurchase.TabStop = false;
            this.pctPurchase.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // lblPurchaseInfo
            // 
            this.lblPurchaseInfo.AutoSize = true;
            this.lblPurchaseInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPurchaseInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPurchaseInfo.Location = new System.Drawing.Point(67, 47);
            this.lblPurchaseInfo.Name = "lblPurchaseInfo";
            this.lblPurchaseInfo.Size = new System.Drawing.Size(14, 16);
            this.lblPurchaseInfo.TabIndex = 10;
            this.lblPurchaseInfo.Text = "0";
            this.lblPurchaseInfo.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // pctTradeStatus
            // 
            this.pctTradeStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.pctTradeStatus.Location = new System.Drawing.Point(222, 21);
            this.pctTradeStatus.Name = "pctTradeStatus";
            this.pctTradeStatus.Properties.AllowFocused = false;
            this.pctTradeStatus.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pctTradeStatus.Properties.Appearance.Options.UseBackColor = true;
            this.pctTradeStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pctTradeStatus.Properties.Caption.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pctTradeStatus.Properties.Caption.Appearance.Options.UseTextOptions = true;
            this.pctTradeStatus.Properties.Caption.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.pctTradeStatus.Properties.Caption.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.pctTradeStatus.Properties.Caption.Offset = new System.Drawing.Point(0, 0);
            this.pctTradeStatus.Properties.NullText = " ";
            this.pctTradeStatus.Properties.ReadOnly = true;
            this.pctTradeStatus.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pctTradeStatus.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pctTradeStatus.Size = new System.Drawing.Size(68, 54);
            this.pctTradeStatus.TabIndex = 11;
            this.pctTradeStatus.MouseHover += new System.EventHandler(this.MouseHoverControl);
            // 
            // lblPercentage
            // 
            this.lblPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPercentage.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPercentage.Location = new System.Drawing.Point(222, 9);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(68, 19);
            this.lblPercentage.TabIndex = 12;
            this.lblPercentage.Text = "0";
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPercentage.MouseHover += new System.EventHandler(this.MouseHoverControl);
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
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText;
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
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.Size = new System.Drawing.Size(298, 0);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // UCTickerBoard
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.Appearance.BorderColor = System.Drawing.Color.Lime;
            this.Appearance.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblPurchaseInfo);
            this.Controls.Add(this.pctProfit);
            this.Controls.Add(this.pctPurchase);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblTRY);
            this.Controls.Add(this.lblUSDT);
            this.Controls.Add(this.lblCurrCode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtGain);
            this.Controls.Add(this.txtAssetAmount);
            this.Controls.Add(this.pctTradeStatus);
            this.LookAndFeel.SkinName = "Office 2016 Dark";
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.True;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.MinimumSize = new System.Drawing.Size(300, 150);
            this.Name = "UCTickerBoard";
            this.Size = new System.Drawing.Size(298, 148);
            this.Click += new System.EventHandler(this.UCTickerBoard_Click);
            this.MouseHover += new System.EventHandler(this.MouseHoverControl);
            ((System.ComponentModel.ISupportInitialize)(this.ımageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPurchase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTradeStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrCode;
        private System.Windows.Forms.Label lblUSDT;
        private System.Windows.Forms.Label lblTRY;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private DevExpress.Utils.ImageCollection ımageCollection1;
        private System.Windows.Forms.PictureBox pctPurchase;
        private System.Windows.Forms.PictureBox pctProfit;
        private System.Windows.Forms.Label txtAssetAmount;
        private System.Windows.Forms.Label txtGain;
        private System.Windows.Forms.Label lblPurchaseInfo;
        private DevExpress.XtraEditors.PictureEdit pctTradeStatus;
        private System.Windows.Forms.Label lblPercentage;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}
