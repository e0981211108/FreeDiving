namespace WindowsFormsApp1
{
    partial class userbuy
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userbuy));
            this.Image = new System.Windows.Forms.PictureBox();
            this.lbl_Line = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn刪除 = new System.Windows.Forms.Button();
            this.lbl_carname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl商品名稱 = new System.Windows.Forms.Label();
            this.lbl商品價格 = new System.Windows.Forms.Label();
            this.lbl訂購數量 = new System.Windows.Forms.Label();
            this.lbl商品總價 = new System.Windows.Forms.Label();
            this.lbl訂購者 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(13, 14);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(254, 230);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 1;
            this.Image.TabStop = false;
            this.Image.Click += new System.EventHandler(this.Image_Click);
            // 
            // lbl_Line
            // 
            this.lbl_Line.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lbl_Line.Location = new System.Drawing.Point(0, -7);
            this.lbl_Line.Name = "lbl_Line";
            this.lbl_Line.Size = new System.Drawing.Size(1002, 10);
            this.lbl_Line.TabIndex = 11;
            this.lbl_Line.Click += new System.EventHandler(this.lbl_Line_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn刪除
            // 
            this.btn刪除.FlatAppearance.BorderSize = 0;
            this.btn刪除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn刪除.Font = new System.Drawing.Font("辰宇落雁體 Thin", 30F);
            this.btn刪除.Image = ((System.Drawing.Image)(resources.GetObject("btn刪除.Image")));
            this.btn刪除.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn刪除.Location = new System.Drawing.Point(844, 196);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(153, 52);
            this.btn刪除.TabIndex = 15;
            this.btn刪除.Text = "結帳";
            this.btn刪除.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn刪除.UseVisualStyleBackColor = true;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click_1);
            // 
            // lbl_carname
            // 
            this.lbl_carname.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_carname.Location = new System.Drawing.Point(277, 29);
            this.lbl_carname.Name = "lbl_carname";
            this.lbl_carname.Size = new System.Drawing.Size(144, 46);
            this.lbl_carname.TabIndex = 2;
            this.lbl_carname.Text = "商品名稱:";
            this.lbl_carname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "訂購者:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "商品價格:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "訂購數量:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "商品總價:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl商品名稱
            // 
            this.lbl商品名稱.AutoSize = true;
            this.lbl商品名稱.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl商品名稱.Location = new System.Drawing.Point(405, 39);
            this.lbl商品名稱.Name = "lbl商品名稱";
            this.lbl商品名稱.Size = new System.Drawing.Size(110, 31);
            this.lbl商品名稱.TabIndex = 7;
            this.lbl商品名稱.Text = "商品名稱";
            this.lbl商品名稱.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl商品名稱.Click += new System.EventHandler(this.lbl商品名稱_Click);
            // 
            // lbl商品價格
            // 
            this.lbl商品價格.AutoSize = true;
            this.lbl商品價格.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl商品價格.Location = new System.Drawing.Point(407, 115);
            this.lbl商品價格.Name = "lbl商品價格";
            this.lbl商品價格.Size = new System.Drawing.Size(78, 31);
            this.lbl商品價格.TabIndex = 8;
            this.lbl商品價格.Text = "(價格)";
            this.lbl商品價格.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl商品價格.Click += new System.EventHandler(this.lbl商品價格_Click);
            // 
            // lbl訂購數量
            // 
            this.lbl訂購數量.AutoSize = true;
            this.lbl訂購數量.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl訂購數量.Location = new System.Drawing.Point(408, 155);
            this.lbl訂購數量.Name = "lbl訂購數量";
            this.lbl訂購數量.Size = new System.Drawing.Size(78, 31);
            this.lbl訂購數量.TabIndex = 9;
            this.lbl訂購數量.Text = "(數量)";
            this.lbl訂購數量.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl訂購數量.Click += new System.EventHandler(this.lbl訂購數量_Click);
            // 
            // lbl商品總價
            // 
            this.lbl商品總價.AutoSize = true;
            this.lbl商品總價.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl商品總價.Location = new System.Drawing.Point(408, 196);
            this.lbl商品總價.Name = "lbl商品總價";
            this.lbl商品總價.Size = new System.Drawing.Size(78, 31);
            this.lbl商品總價.TabIndex = 10;
            this.lbl商品總價.Text = "(總價)";
            this.lbl商品總價.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl商品總價.Click += new System.EventHandler(this.lbl訂單日期_Click);
            // 
            // lbl訂購者
            // 
            this.lbl訂購者.AutoSize = true;
            this.lbl訂購者.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl訂購者.Location = new System.Drawing.Point(407, 79);
            this.lbl訂購者.Name = "lbl訂購者";
            this.lbl訂購者.Size = new System.Drawing.Size(86, 31);
            this.lbl訂購者.TabIndex = 14;
            this.lbl訂購者.Text = "訂購者";
            this.lbl訂購者.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl訂購者.Click += new System.EventHandler(this.lbl訂購者_Click_1);
            // 
            // userbuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn刪除);
            this.Controls.Add(this.lbl訂購者);
            this.Controls.Add(this.lbl_Line);
            this.Controls.Add(this.lbl商品總價);
            this.Controls.Add(this.lbl訂購數量);
            this.Controls.Add(this.lbl商品價格);
            this.Controls.Add(this.lbl商品名稱);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_carname);
            this.Controls.Add(this.Image);
            this.Name = "userbuy";
            this.Size = new System.Drawing.Size(1000, 259);
            this.Load += new System.EventHandler(this.userbuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox Image;
        private System.Windows.Forms.Label lbl_Line;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn刪除;
        public System.Windows.Forms.Label lbl_carname;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbl商品名稱;
        public System.Windows.Forms.Label lbl商品價格;
        public System.Windows.Forms.Label lbl訂購數量;
        public System.Windows.Forms.Label lbl商品總價;
        public System.Windows.Forms.Label lbl訂購者;
    }
}
