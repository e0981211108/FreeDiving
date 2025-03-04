namespace WindowsFormsApp1
{
    partial class UserControl1
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Image = new System.Windows.Forms.PictureBox();
            this.price = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lblN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(7, 16);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(277, 263);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 0;
            this.Image.TabStop = false;
            this.Image.Click += new System.EventHandler(this.Image_Click);
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.price.ForeColor = System.Drawing.Color.Red;
            this.price.Location = new System.Drawing.Point(46, 332);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(211, 19);
            this.price.TabIndex = 2;
            this.price.Text = "NT$商品價格";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MistyRose;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(70, 354);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 44);
            this.button4.TabIndex = 8;
            this.button4.Text = "加入購物車";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblN
            // 
            this.lblN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblN.Font = new System.Drawing.Font("細明體-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblN.Location = new System.Drawing.Point(8, 300);
            this.lblN.Multiline = true;
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(277, 40);
            this.lblN.TabIndex = 9;
            this.lblN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblN.TextChanged += new System.EventHandler(this.lblN_TextChanged);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.price);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Image);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(290, 407);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.PictureBox Image;
        public System.Windows.Forms.Label price;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox lblN;
    }
}
