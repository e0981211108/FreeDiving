namespace WindowsFormsApp1
{
    partial class mamber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mamber));
            this.lbl會員id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn產生會員資料 = new System.Windows.Forms.Button();
            this.dgv會員資料列表 = new System.Windows.Forms.DataGridView();
            this.btn資料修改 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn新增會員 = new System.Windows.Forms.Button();
            this.btn資料刪除 = new System.Windows.Forms.Button();
            this.btn連線 = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btm搜尋會員 = new System.Windows.Forms.Button();
            this.btn清空表格資料 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員資料列表)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl會員id
            // 
            this.lbl會員id.AutoSize = true;
            this.lbl會員id.BackColor = System.Drawing.Color.Aquamarine;
            this.lbl會員id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl會員id.Location = new System.Drawing.Point(-72, 378);
            this.lbl會員id.Margin = new System.Windows.Forms.Padding(0);
            this.lbl會員id.Name = "lbl會員id";
            this.lbl會員id.Size = new System.Drawing.Size(73, 26);
            this.lbl會員id.TabIndex = 71;
            this.lbl會員id.Text = "會員id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aquamarine;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(-72, -30);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 26);
            this.label1.TabIndex = 59;
            this.label1.Text = "滿千可成為會員，會員可打九五折。";
            // 
            // btn產生會員資料
            // 
            this.btn產生會員資料.FlatAppearance.BorderSize = 0;
            this.btn產生會員資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn產生會員資料.Font = new System.Drawing.Font("辰宇落雁體 Thin", 30F);
            this.btn產生會員資料.Image = ((System.Drawing.Image)(resources.GetObject("btn產生會員資料.Image")));
            this.btn產生會員資料.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn產生會員資料.Location = new System.Drawing.Point(135, 6);
            this.btn產生會員資料.Margin = new System.Windows.Forms.Padding(0);
            this.btn產生會員資料.Name = "btn產生會員資料";
            this.btn產生會員資料.Size = new System.Drawing.Size(267, 66);
            this.btn產生會員資料.TabIndex = 72;
            this.btn產生會員資料.Text = "產生會員列表";
            this.btn產生會員資料.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn產生會員資料.UseVisualStyleBackColor = true;
            this.btn產生會員資料.Click += new System.EventHandler(this.btn產生會員資料_Click);
            // 
            // dgv會員資料列表
            // 
            this.dgv會員資料列表.BackgroundColor = System.Drawing.Color.Linen;
            this.dgv會員資料列表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv會員資料列表.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.dgv會員資料列表.Location = new System.Drawing.Point(103, 72);
            this.dgv會員資料列表.Margin = new System.Windows.Forms.Padding(0);
            this.dgv會員資料列表.Name = "dgv會員資料列表";
            this.dgv會員資料列表.RowHeadersWidth = 51;
            this.dgv會員資料列表.RowTemplate.Height = 27;
            this.dgv會員資料列表.Size = new System.Drawing.Size(336, 553);
            this.dgv會員資料列表.TabIndex = 73;
            this.dgv會員資料列表.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv會員資料列表_CellClick);
            // 
            // btn資料修改
            // 
            this.btn資料修改.FlatAppearance.BorderSize = 0;
            this.btn資料修改.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn資料修改.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btn資料修改.Image = ((System.Drawing.Image)(resources.GetObject("btn資料修改.Image")));
            this.btn資料修改.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn資料修改.Location = new System.Drawing.Point(929, 406);
            this.btn資料修改.Margin = new System.Windows.Forms.Padding(0);
            this.btn資料修改.Name = "btn資料修改";
            this.btn資料修改.Size = new System.Drawing.Size(210, 60);
            this.btn資料修改.TabIndex = 74;
            this.btn資料修改.Text = "資料修改";
            this.btn資料修改.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn資料修改.UseVisualStyleBackColor = true;
            this.btn資料修改.Click += new System.EventHandler(this.btn資料修改_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Location = new System.Drawing.Point(467, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 686);
            this.panel1.TabIndex = 75;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn新增會員
            // 
            this.btn新增會員.FlatAppearance.BorderSize = 0;
            this.btn新增會員.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn新增會員.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btn新增會員.Image = ((System.Drawing.Image)(resources.GetObject("btn新增會員.Image")));
            this.btn新增會員.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn新增會員.Location = new System.Drawing.Point(929, 187);
            this.btn新增會員.Margin = new System.Windows.Forms.Padding(0);
            this.btn新增會員.Name = "btn新增會員";
            this.btn新增會員.Size = new System.Drawing.Size(210, 60);
            this.btn新增會員.TabIndex = 76;
            this.btn新增會員.Text = "新增會員";
            this.btn新增會員.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn新增會員.UseVisualStyleBackColor = true;
            this.btn新增會員.Click += new System.EventHandler(this.btn新增會員_Click);
            // 
            // btn資料刪除
            // 
            this.btn資料刪除.FlatAppearance.BorderSize = 0;
            this.btn資料刪除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn資料刪除.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btn資料刪除.Image = ((System.Drawing.Image)(resources.GetObject("btn資料刪除.Image")));
            this.btn資料刪除.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn資料刪除.Location = new System.Drawing.Point(929, 298);
            this.btn資料刪除.Margin = new System.Windows.Forms.Padding(0);
            this.btn資料刪除.Name = "btn資料刪除";
            this.btn資料刪除.Size = new System.Drawing.Size(210, 60);
            this.btn資料刪除.TabIndex = 77;
            this.btn資料刪除.Text = "資料刪除";
            this.btn資料刪除.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn資料刪除.UseVisualStyleBackColor = true;
            this.btn資料刪除.Click += new System.EventHandler(this.btn資料刪除_Click);
            // 
            // btn連線
            // 
            this.btn連線.BackColor = System.Drawing.Color.Transparent;
            this.btn連線.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            this.btn連線.FlatAppearance.BorderSize = 0;
            this.btn連線.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn連線.Font = new System.Drawing.Font("辰宇落雁體 Thin", 31F);
            this.btn連線.Image = ((System.Drawing.Image)(resources.GetObject("btn連線.Image")));
            this.btn連線.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn連線.Location = new System.Drawing.Point(9, 348);
            this.btn連線.Margin = new System.Windows.Forms.Padding(0);
            this.btn連線.Name = "btn連線";
            this.btn連線.Size = new System.Drawing.Size(84, 277);
            this.btn連線.TabIndex = 78;
            this.btn連線.Text = "連\r\n線\r\n測\r\n試";
            this.btn連線.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn連線.UseVisualStyleBackColor = false;
            this.btn連線.Click += new System.EventHandler(this.btn連線_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.Location = new System.Drawing.Point(582, 346);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(304, 27);
            this.txtPhone.TabIndex = 90;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.lbl4.ForeColor = System.Drawing.Color.Black;
            this.lbl4.Location = new System.Drawing.Point(492, 339);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(81, 33);
            this.lbl4.TabIndex = 89;
            this.lbl4.Text = "電話:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(582, 424);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(302, 27);
            this.txtAddress.TabIndex = 88;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.Transparent;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.lbl5.ForeColor = System.Drawing.Color.Black;
            this.lbl5.Location = new System.Drawing.Point(493, 415);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(81, 33);
            this.lbl5.TabIndex = 87;
            this.lbl5.Text = "地址:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmail.Location = new System.Drawing.Point(583, 496);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(303, 27);
            this.txtEmail.TabIndex = 86;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.Transparent;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.lbl6.ForeColor = System.Drawing.Color.Black;
            this.lbl6.Location = new System.Drawing.Point(493, 489);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(81, 33);
            this.lbl6.TabIndex = 85;
            this.lbl6.Text = "信箱:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(496, 127);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(81, 33);
            this.lbl1.TabIndex = 83;
            this.lbl1.Text = "姓名:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.lbl2.ForeColor = System.Drawing.Color.Black;
            this.lbl2.Location = new System.Drawing.Point(493, 195);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(81, 33);
            this.lbl2.TabIndex = 82;
            this.lbl2.Text = "帳號:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassword.Location = new System.Drawing.Point(580, 272);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(304, 27);
            this.txtPassword.TabIndex = 81;
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAccount.Location = new System.Drawing.Point(583, 202);
            this.txtAccount.Multiline = true;
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(303, 27);
            this.txtAccount.TabIndex = 80;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F);
            this.lbl3.ForeColor = System.Drawing.Color.Black;
            this.lbl3.Location = new System.Drawing.Point(493, 265);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(81, 33);
            this.lbl3.TabIndex = 79;
            this.lbl3.Text = "密碼:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(569, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 435);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(583, 133);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(303, 27);
            this.txtName.TabIndex = 84;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btm搜尋會員
            // 
            this.btm搜尋會員.FlatAppearance.BorderSize = 0;
            this.btm搜尋會員.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm搜尋會員.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btm搜尋會員.Image = ((System.Drawing.Image)(resources.GetObject("btm搜尋會員.Image")));
            this.btm搜尋會員.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btm搜尋會員.Location = new System.Drawing.Point(624, 40);
            this.btm搜尋會員.Margin = new System.Windows.Forms.Padding(0);
            this.btm搜尋會員.Name = "btm搜尋會員";
            this.btm搜尋會員.Size = new System.Drawing.Size(196, 69);
            this.btm搜尋會員.TabIndex = 93;
            this.btm搜尋會員.Text = "搜尋會員";
            this.btm搜尋會員.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btm搜尋會員.UseVisualStyleBackColor = true;
            this.btm搜尋會員.Click += new System.EventHandler(this.btm搜尋會員_Click);
            // 
            // btn清空表格資料
            // 
            this.btn清空表格資料.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(185)))));
            this.btn清空表格資料.FlatAppearance.BorderSize = 0;
            this.btn清空表格資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn清空表格資料.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn清空表格資料.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn清空表格資料.Location = new System.Drawing.Point(640, 559);
            this.btn清空表格資料.Margin = new System.Windows.Forms.Padding(0);
            this.btn清空表格資料.Name = "btn清空表格資料";
            this.btn清空表格資料.Size = new System.Drawing.Size(216, 46);
            this.btn清空表格資料.TabIndex = 94;
            this.btn清空表格資料.Text = "清除表格資料";
            this.btn清空表格資料.UseVisualStyleBackColor = false;
            this.btn清空表格資料.Click += new System.EventHandler(this.btn清空表格資料_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1088, -11);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 60);
            this.button2.TabIndex = 95;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mamber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1148, 650);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn清空表格資料);
            this.Controls.Add(this.btm搜尋會員);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn連線);
            this.Controls.Add(this.btn資料刪除);
            this.Controls.Add(this.btn新增會員);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn資料修改);
            this.Controls.Add(this.dgv會員資料列表);
            this.Controls.Add(this.btn產生會員資料);
            this.Controls.Add(this.lbl會員id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "mamber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mamber";
            this.Load += new System.EventHandler(this.mamber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv會員資料列表)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl會員id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn產生會員資料;
        private System.Windows.Forms.DataGridView dgv會員資料列表;
        private System.Windows.Forms.Button btn資料修改;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn新增會員;
        private System.Windows.Forms.Button btn資料刪除;
        private System.Windows.Forms.Button btn連線;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.Label lbl4;
        public System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.Label lbl5;
        public System.Windows.Forms.TextBox txtEmail;
        public System.Windows.Forms.Label lbl6;
        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label lbl2;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtAccount;
        public System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtName;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button btm搜尋會員;
        private System.Windows.Forms.Button btn清空表格資料;
        private System.Windows.Forms.Button button2;
    }
}