namespace BinanceTradeView
{
    partial class UCTotalBoard
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
            this.lblAssetAmount = new System.Windows.Forms.Label();
            this.lblProfitAmount = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pctTradeIcon = new System.Windows.Forms.PictureBox();
            this.pctTotalStatus = new System.Windows.Forms.PictureBox();
            this.lblCurrCode = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctTradeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTotalStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAssetAmount
            // 
            this.lblAssetAmount.AutoSize = true;
            this.lblAssetAmount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAssetAmount.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAssetAmount.Location = new System.Drawing.Point(17, 117);
            this.lblAssetAmount.Name = "lblAssetAmount";
            this.lblAssetAmount.Size = new System.Drawing.Size(22, 24);
            this.lblAssetAmount.TabIndex = 14;
            this.lblAssetAmount.Text = "0";
            // 
            // lblProfitAmount
            // 
            this.lblProfitAmount.AutoSize = true;
            this.lblProfitAmount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProfitAmount.ForeColor = System.Drawing.Color.DarkGray;
            this.lblProfitAmount.Location = new System.Drawing.Point(17, 153);
            this.lblProfitAmount.Name = "lblProfitAmount";
            this.lblProfitAmount.Size = new System.Drawing.Size(22, 24);
            this.lblProfitAmount.TabIndex = 15;
            this.lblProfitAmount.Text = "0";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAmount.Location = new System.Drawing.Point(91, 67);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(22, 24);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "0";
            // 
            // pctTradeIcon
            // 
            this.pctTradeIcon.Location = new System.Drawing.Point(11, 21);
            this.pctTradeIcon.Name = "pctTradeIcon";
            this.pctTradeIcon.Size = new System.Drawing.Size(72, 72);
            this.pctTradeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTradeIcon.TabIndex = 9;
            this.pctTradeIcon.TabStop = false;
            // 
            // pctTotalStatus
            // 
            this.pctTotalStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctTotalStatus.Location = new System.Drawing.Point(265, 21);
            this.pctTotalStatus.Name = "pctTotalStatus";
            this.pctTotalStatus.Size = new System.Drawing.Size(72, 72);
            this.pctTotalStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctTotalStatus.TabIndex = 10;
            this.pctTotalStatus.TabStop = false;
            // 
            // lblCurrCode
            // 
            this.lblCurrCode.AutoSize = true;
            this.lblCurrCode.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCurrCode.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCurrCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCurrCode.Location = new System.Drawing.Point(89, 21);
            this.lblCurrCode.Name = "lblCurrCode";
            this.lblCurrCode.Size = new System.Drawing.Size(75, 36);
            this.lblCurrCode.TabIndex = 17;
            this.lblCurrCode.Text = "XXX";
            // 
            // lblPercentage
            // 
            this.lblPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentage.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPercentage.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPercentage.Location = new System.Drawing.Point(106, 109);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(231, 78);
            this.lblPercentage.TabIndex = 18;
            this.lblPercentage.Text = "0";
            this.lblPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UCTotalBoard
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCurrCode);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblProfitAmount);
            this.Controls.Add(this.lblAssetAmount);
            this.Controls.Add(this.pctTradeIcon);
            this.Controls.Add(this.pctTotalStatus);
            this.Controls.Add(this.lblPercentage);
            this.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.True;
            this.MaximumSize = new System.Drawing.Size(350, 200);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "UCTotalBoard";
            this.Size = new System.Drawing.Size(350, 200);
            this.Load += new System.EventHandler(this.UCTotalBoard_Load);
            this.MouseHover += new System.EventHandler(this.UCTotalBoard_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pctTradeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctTotalStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctTradeIcon;
        private System.Windows.Forms.PictureBox pctTotalStatus;
        private System.Windows.Forms.Label lblAssetAmount;
        private System.Windows.Forms.Label lblProfitAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblCurrCode;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Timer timer1;
    }
}
