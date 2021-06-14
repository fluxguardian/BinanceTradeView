namespace BinanceTradeView
{
    partial class FAllOrders
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions7 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            this.officeNavigationBar1 = new DevExpress.XtraBars.Navigation.OfficeNavigationBar();
            this.btnSelect = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.btnCancel = new DevExpress.XtraBars.Navigation.NavigationBarItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.GcOrders = new DevExpress.XtraGrid.GridControl();
            this.GvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // officeNavigationBar1
            // 
            this.officeNavigationBar1.CustomizationButtonVisibility = DevExpress.XtraBars.Navigation.CustomizationButtonVisibility.Hidden;
            this.officeNavigationBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.officeNavigationBar1.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.officeNavigationBar1.Items.AddRange(new DevExpress.XtraBars.Navigation.NavigationBarItem[] {
            this.btnSelect,
            this.btnCancel});
            this.officeNavigationBar1.Location = new System.Drawing.Point(0, 323);
            this.officeNavigationBar1.Name = "officeNavigationBar1";
            this.officeNavigationBar1.Size = new System.Drawing.Size(883, 45);
            this.officeNavigationBar1.TabIndex = 0;
            this.officeNavigationBar1.Text = "officeNavigationBar1";
            this.officeNavigationBar1.ItemClick += new DevExpress.XtraBars.Navigation.NavigationBarItemClickEventHandler(this.officeNavigationBar1_ItemClick);
            // 
            // btnSelect
            // 
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Text = "Seç";
            // 
            // btnCancel
            // 
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Vazgeç";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.GcOrders);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(883, 323);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(883, 323);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // GcOrders
            // 
            this.GcOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GcOrders.Location = new System.Drawing.Point(12, 12);
            this.GcOrders.MainView = this.GvOrders;
            this.GcOrders.Name = "GcOrders";
            this.GcOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.GcOrders.Size = new System.Drawing.Size(859, 299);
            this.GcOrders.TabIndex = 6;
            this.GcOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GvOrders});
            // 
            // GvOrders
            // 
            this.GvOrders.Appearance.Empty.BackColor = System.Drawing.Color.Black;
            this.GvOrders.Appearance.Empty.Options.UseBackColor = true;
            this.GvOrders.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GvOrders.Appearance.EvenRow.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GvOrders.Appearance.EvenRow.ForeColor = System.Drawing.Color.White;
            this.GvOrders.Appearance.EvenRow.Options.UseBackColor = true;
            this.GvOrders.Appearance.EvenRow.Options.UseFont = true;
            this.GvOrders.Appearance.EvenRow.Options.UseForeColor = true;
            this.GvOrders.Appearance.FocusedRow.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GvOrders.Appearance.FocusedRow.Options.UseFont = true;
            this.GvOrders.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Black;
            this.GvOrders.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Transparent;
            this.GvOrders.Appearance.HeaderPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.GvOrders.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Silver;
            this.GvOrders.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.GvOrders.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.GvOrders.Appearance.HeaderPanel.Options.UseFont = true;
            this.GvOrders.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.GvOrders.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GvOrders.Appearance.OddRow.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GvOrders.Appearance.OddRow.ForeColor = System.Drawing.Color.White;
            this.GvOrders.Appearance.OddRow.Options.UseBackColor = true;
            this.GvOrders.Appearance.OddRow.Options.UseFont = true;
            this.GvOrders.Appearance.OddRow.Options.UseForeColor = true;
            this.GvOrders.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GvOrders.Appearance.Row.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GvOrders.Appearance.Row.ForeColor = System.Drawing.Color.White;
            this.GvOrders.Appearance.Row.Options.UseBackColor = true;
            this.GvOrders.Appearance.Row.Options.UseFont = true;
            this.GvOrders.Appearance.Row.Options.UseForeColor = true;
            this.GvOrders.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Silver;
            this.GvOrders.Appearance.SelectedRow.Options.UseForeColor = true;
            this.GvOrders.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.GvOrders.ColumnPanelRowHeight = 35;
            this.GvOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.GvOrders.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.GvOrders.GridControl = this.GcOrders;
            this.GvOrders.Name = "GvOrders";
            this.GvOrders.OptionsBehavior.ReadOnly = true;
            this.GvOrders.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.GvOrders.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.GvOrders.OptionsSelection.MultiSelect = true;
            this.GvOrders.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.GvOrders.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.GvOrders.OptionsView.AllowGlyphSkinning = true;
            this.GvOrders.OptionsView.EnableAppearanceEvenRow = true;
            this.GvOrders.OptionsView.ShowAutoFilterRow = true;
            this.GvOrders.OptionsView.ShowGroupPanel = false;
            this.GvOrders.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GvOrders.OptionsView.ShowIndicator = false;
            this.GvOrders.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.GvOrders.PaintStyleName = "Web";
            this.GvOrders.RowHeight = 35;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "İşlem Çifti";
            this.gridColumn1.FieldName = "symbol";
            this.gridColumn1.MaxWidth = 100;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Fiyat";
            this.gridColumn2.FieldName = "price";
            this.gridColumn2.MaxWidth = 100;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 100;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Alınan Miktar";
            this.gridColumn3.FieldName = "executedQty";
            this.gridColumn3.MaxWidth = 150;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 150;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Ödenen Miktar";
            this.gridColumn4.FieldName = "cummulativeQuoteQty";
            this.gridColumn4.MaxWidth = 150;
            this.gridColumn4.MinWidth = 10;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 150;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "İşlem Türü";
            this.gridColumn5.FieldName = "type";
            this.gridColumn5.MaxWidth = 100;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 100;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn6.Caption = "İşlem Tipi";
            this.gridColumn6.FieldName = "side";
            this.gridColumn6.MaxWidth = 100;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 100;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "İşlem Zamanı";
            this.gridColumn7.FieldName = "getTime";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 100;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Detay", -1, true, true, false, editorButtonImageOptions7)});
            this.repositoryItemButtonEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.GcOrders;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(863, 303);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "OrderId";
            this.gridColumn8.FieldName = "orderId";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // FAllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 368);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.officeNavigationBar1);
            this.Name = "FAllOrders";
            this.Text = "FAllOrders";
            this.Load += new System.EventHandler(this.FAllOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.officeNavigationBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GcOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Navigation.OfficeNavigationBar officeNavigationBar1;
        private DevExpress.XtraBars.Navigation.NavigationBarItem btnSelect;
        private DevExpress.XtraBars.Navigation.NavigationBarItem btnCancel;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl GcOrders;
        public DevExpress.XtraGrid.Views.Grid.GridView GvOrders;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
    }
}