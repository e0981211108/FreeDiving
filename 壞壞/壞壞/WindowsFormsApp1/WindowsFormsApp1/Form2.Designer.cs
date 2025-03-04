namespace WindowsFormsApp5
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn訂購單 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn訂單管理 = new System.Windows.Forms.Button();
            this.btn商品展示 = new System.Windows.Forms.Button();
            this.btn會員維護 = new System.Windows.Forms.Button();
            this.btn系統設定 = new System.Windows.Forms.Button();
            this.lbluserName = new System.Windows.Forms.Label();
            this.btn登出 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn訂購單
            // 
            this.btn訂購單.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn訂購單.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂購單.Location = new System.Drawing.Point(43, 107);
            this.btn訂購單.Name = "btn訂購單";
            this.btn訂購單.Size = new System.Drawing.Size(168, 111);
            this.btn訂購單.TabIndex = 0;
            this.btn訂購單.Text = "訂購單";
            this.btn訂購單.UseVisualStyleBackColor = false;
            this.btn訂購單.Click += new System.EventHandler(this.btn訂購單_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(289, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "系統主選單";
            // 
            // btn訂單管理
            // 
            this.btn訂單管理.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn訂單管理.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單管理.Location = new System.Drawing.Point(43, 280);
            this.btn訂單管理.Name = "btn訂單管理";
            this.btn訂單管理.Size = new System.Drawing.Size(168, 111);
            this.btn訂單管理.TabIndex = 2;
            this.btn訂單管理.Text = "訂單管理";
            this.btn訂單管理.UseVisualStyleBackColor = false;
            this.btn訂單管理.Click += new System.EventHandler(this.btn訂單管理_Click);
            // 
            // btn商品展示
            // 
            this.btn商品展示.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn商品展示.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn商品展示.Location = new System.Drawing.Point(295, 107);
            this.btn商品展示.Name = "btn商品展示";
            this.btn商品展示.Size = new System.Drawing.Size(168, 111);
            this.btn商品展示.TabIndex = 3;
            this.btn商品展示.Text = "商品展示";
            this.btn商品展示.UseVisualStyleBackColor = false;
            this.btn商品展示.Click += new System.EventHandler(this.btn商品展示_Click);
            // 
            // btn會員維護
            // 
            this.btn會員維護.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn會員維護.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn會員維護.Location = new System.Drawing.Point(536, 107);
            this.btn會員維護.Name = "btn會員維護";
            this.btn會員維護.Size = new System.Drawing.Size(168, 111);
            this.btn會員維護.TabIndex = 4;
            this.btn會員維護.Text = "會員維護";
            this.btn會員維護.UseVisualStyleBackColor = false;
            this.btn會員維護.Click += new System.EventHandler(this.btn會員維護_Click);
            // 
            // btn系統設定
            // 
            this.btn系統設定.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn系統設定.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn系統設定.Location = new System.Drawing.Point(295, 280);
            this.btn系統設定.Name = "btn系統設定";
            this.btn系統設定.Size = new System.Drawing.Size(168, 111);
            this.btn系統設定.TabIndex = 5;
            this.btn系統設定.Text = "系統設定";
            this.btn系統設定.UseVisualStyleBackColor = false;
            this.btn系統設定.Click += new System.EventHandler(this.btn系統設定_Click);
            // 
            // lbluserName
            // 
            this.lbluserName.AutoSize = true;
            this.lbluserName.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbluserName.Location = new System.Drawing.Point(549, 22);
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(69, 19);
            this.lbluserName.TabIndex = 6;
            this.lbluserName.Text = "使用者";
            // 
            // btn登出
            // 
            this.btn登出.BackColor = System.Drawing.Color.LightGray;
            this.btn登出.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登出.Location = new System.Drawing.Point(714, 9);
            this.btn登出.Name = "btn登出";
            this.btn登出.Size = new System.Drawing.Size(74, 30);
            this.btn登出.TabIndex = 7;
            this.btn登出.Text = "登出";
            this.btn登出.UseVisualStyleBackColor = false;
            this.btn登出.Click += new System.EventHandler(this.btn登出_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.btn登出);
            this.Controls.Add(this.lbluserName);
            this.Controls.Add(this.btn系統設定);
            this.Controls.Add(this.btn會員維護);
            this.Controls.Add(this.btn商品展示);
            this.Controls.Add(this.btn訂單管理);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn訂購單);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "系統主選單";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn訂購單;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn訂單管理;
        private System.Windows.Forms.Button btn商品展示;
        private System.Windows.Forms.Button btn會員維護;
        private System.Windows.Forms.Button btn系統設定;
        private System.Windows.Forms.Label lbluserName;
        private System.Windows.Forms.Button btn登出;
    }
}

