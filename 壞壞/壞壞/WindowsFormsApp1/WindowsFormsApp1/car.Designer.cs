namespace WindowsFormsApp1
{
    partial class car
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(car));
            this.panel_top = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCarExit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn結帳 = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.LightBlue;
            this.panel_top.Controls.Add(this.btnCarExit);
            this.panel_top.Controls.Add(this.button1);
            this.panel_top.Controls.Add(this.btnExit);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1073, 60);
            this.panel_top.TabIndex = 5;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("辰宇落雁體 Thin", 30F);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(403, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "言言Free Diving    購物車";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCarExit
            // 
            this.btnCarExit.FlatAppearance.BorderSize = 0;
            this.btnCarExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarExit.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCarExit.ForeColor = System.Drawing.Color.Black;
            this.btnCarExit.Image = ((System.Drawing.Image)(resources.GetObject("btnCarExit.Image")));
            this.btnCarExit.Location = new System.Drawing.Point(1018, 3);
            this.btnCarExit.Name = "btnCarExit";
            this.btnCarExit.Size = new System.Drawing.Size(52, 45);
            this.btnCarExit.TabIndex = 18;
            this.btnCarExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarExit.UseVisualStyleBackColor = true;
            this.btnCarExit.Click += new System.EventHandler(this.btnCarExit_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(1371, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 38);
            this.btnExit.TabIndex = 16;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1045, 500);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // btn結帳
            // 
            this.btn結帳.FlatAppearance.BorderSize = 0;
            this.btn結帳.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn結帳.Font = new System.Drawing.Font("辰宇落雁體 Thin", 30F);
            this.btn結帳.Image = ((System.Drawing.Image)(resources.GetObject("btn結帳.Image")));
            this.btn結帳.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn結帳.Location = new System.Drawing.Point(920, 584);
            this.btn結帳.Name = "btn結帳";
            this.btn結帳.Size = new System.Drawing.Size(153, 52);
            this.btn結帳.TabIndex = 9;
            this.btn結帳.Text = "結帳";
            this.btn結帳.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn結帳.UseVisualStyleBackColor = true;
            this.btn結帳.Click += new System.EventHandler(this.btn結帳_Click);
            // 
            // car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 648);
            this.Controls.Add(this.btn結帳);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "car";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.car_Load);
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCarExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn結帳;
        private System.Windows.Forms.Button button1;
    }
}