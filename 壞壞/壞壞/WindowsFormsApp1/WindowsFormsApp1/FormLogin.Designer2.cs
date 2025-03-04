namespace WindowsFormsApp5
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt登入欄位1 = new System.Windows.Forms.TextBox();
            this.txt登入欄位2 = new System.Windows.Forms.TextBox();
            this.lbl回應訊息 = new System.Windows.Forms.GroupBox();
            this.btn登入 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "登入";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "會員ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "電話";
            // 
            // txt登入欄位1
            // 
            this.txt登入欄位1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt登入欄位1.Location = new System.Drawing.Point(101, 76);
            this.txt登入欄位1.Multiline = true;
            this.txt登入欄位1.Name = "txt登入欄位1";
            this.txt登入欄位1.Size = new System.Drawing.Size(205, 34);
            this.txt登入欄位1.TabIndex = 3;
            this.txt登入欄位1.TextChanged += new System.EventHandler(this.txt登入欄位1_TextChanged);
            // 
            // txt登入欄位2
            // 
            this.txt登入欄位2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt登入欄位2.Location = new System.Drawing.Point(101, 124);
            this.txt登入欄位2.Multiline = true;
            this.txt登入欄位2.Name = "txt登入欄位2";
            this.txt登入欄位2.Size = new System.Drawing.Size(205, 34);
            this.txt登入欄位2.TabIndex = 4;
            this.txt登入欄位2.TextChanged += new System.EventHandler(this.txt登入欄位2_TextChanged);
            // 
            // lbl回應訊息
            // 
            this.lbl回應訊息.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl回應訊息.BackColor = System.Drawing.Color.Bisque;
            this.lbl回應訊息.Font = new System.Drawing.Font("標楷體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl回應訊息.Location = new System.Drawing.Point(16, 180);
            this.lbl回應訊息.Name = "lbl回應訊息";
            this.lbl回應訊息.Size = new System.Drawing.Size(290, 233);
            this.lbl回應訊息.TabIndex = 5;
            this.lbl回應訊息.TabStop = false;
            this.lbl回應訊息.Text = "回應訊息";
            this.lbl回應訊息.Enter += new System.EventHandler(this.lbl回應訊息_Enter);
            // 
            // btn登入
            // 
            this.btn登入.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn登入.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn登入.Location = new System.Drawing.Point(89, 419);
            this.btn登入.Name = "btn登入";
            this.btn登入.Size = new System.Drawing.Size(152, 48);
            this.btn登入.TabIndex = 6;
            this.btn登入.Text = "登入";
            this.btn登入.UseVisualStyleBackColor = false;
            this.btn登入.Click += new System.EventHandler(this.btn登入_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(326, 612);
            this.Controls.Add(this.btn登入);
            this.Controls.Add(this.lbl回應訊息);
            this.Controls.Add(this.txt登入欄位2);
            this.Controls.Add(this.txt登入欄位1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "使用者登入";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt登入欄位1;
        private System.Windows.Forms.TextBox txt登入欄位2;
        private System.Windows.Forms.Button btn登入;
        public System.Windows.Forms.GroupBox lbl回應訊息;
    }
}