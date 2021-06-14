namespace BinanceTradeView
{
    partial class FAddMarketCoin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtExchangeCode = new DevExpress.XtraEditors.TextEdit();
            this.txtMarketCode = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.btnSave = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.btnCancel = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtExchangeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarketCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtExchangeCode);
            this.layoutControl1.Controls.Add(this.txtMarketCode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(223, 97);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtExchangeCode
            // 
            this.txtExchangeCode.EditValue = "USDT";
            this.txtExchangeCode.Location = new System.Drawing.Point(92, 49);
            this.txtExchangeCode.Name = "txtExchangeCode";
            this.txtExchangeCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtExchangeCode.Properties.Appearance.Options.UseFont = true;
            this.txtExchangeCode.Properties.AutoHeight = false;
            this.txtExchangeCode.Size = new System.Drawing.Size(119, 33);
            this.txtExchangeCode.StyleController = this.layoutControl1;
            this.txtExchangeCode.TabIndex = 5;
            // 
            // txtMarketCode
            // 
            this.txtMarketCode.EditValue = "BTC";
            this.txtMarketCode.Location = new System.Drawing.Point(92, 12);
            this.txtMarketCode.Name = "txtMarketCode";
            this.txtMarketCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMarketCode.Properties.Appearance.Options.UseFont = true;
            this.txtMarketCode.Properties.AutoHeight = false;
            this.txtMarketCode.Size = new System.Drawing.Size(119, 33);
            this.txtMarketCode.StyleController = this.layoutControl1;
            this.txtMarketCode.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(223, 97);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtMarketCode;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(0, 37);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(119, 37);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(203, 37);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "Coin";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(77, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtExchangeCode;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 37);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(0, 37);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(119, 37);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(203, 40);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Değişim Coini";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 16);
            // 
            // officeNavigationBar1
            // 
            this.officeNavigationBar1.AutoSize = false;
            this.officeNavigationBar1.CustomizationButtonVisibility = DevExpress.XtraBars.Navigation.CustomizationButtonVisibility.Hidden;
            this.officeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar1.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.officeNavigationBar1.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.btnSave,
            this.btnCancel});
            this.officeNavigationBar1.Location = new System.Drawing.Point(0, 97);
            this.officeNavigationBar1.Name = "officeNavigationBar1";
            this.officeNavigationBar1.Size = new System.Drawing.Size(223, 46);
            this.officeNavigationBar1.TabIndex = 2;
            this.officeNavigationBar1.Text = "officeNavigationBar1";
            this.officeNavigationBar1.ItemClick += new DevExpress.XtraBars.Navigation.NavigationBarItemClickEventHandler(this.officeNavigationBar1_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Name = "btnSave";
            this.btnSave.Text = "Kaydet";
            // 
            // btnCancel
            // 
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Vazgeç";
            // 
            // FAddMarketCoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 143);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.officeNavigationBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FAddMarketCoin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piyasa Takibi Ekleme";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtExchangeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarketCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtExchangeCode;
        private DevExpress.XtraEditors.TextEdit txtMarketCode;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem btnSave;
        private DevExpress.XtraBars.Navigation.NavigationBarItem btnCancel;
    }
}