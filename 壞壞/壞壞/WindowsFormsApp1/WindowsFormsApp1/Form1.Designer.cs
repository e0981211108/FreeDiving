namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnFB;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuy = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btnmanager = new System.Windows.Forms.Button();
            this.btninformation = new System.Windows.Forms.Button();
            this.btnSupplies = new System.Windows.Forms.Button();
            this.btnActivity = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnIG = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbluserName = new System.Windows.Forms.Label();
            this.divingsup = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button4 = new System.Windows.Forms.Button();
            this.btnfins = new System.Windows.Forms.Button();
            this.btntube = new System.Windows.Forms.Button();
            this.btnmask = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.myclass1 = new WindowsFormsApp1.myclass();
            this.diving_Free1 = new WindowsFormsApp1.Diving_Free();
            btnFB = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFB
            // 
            btnFB.FlatAppearance.BorderSize = 0;
            btnFB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFB.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            btnFB.ForeColor = System.Drawing.Color.Black;
            btnFB.Image = ((System.Drawing.Image)(resources.GetObject("btnFB.Image")));
            btnFB.Location = new System.Drawing.Point(1242, 54);
            btnFB.Name = "btnFB";
            btnFB.Size = new System.Drawing.Size(60, 48);
            btnFB.TabIndex = 9;
            btnFB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnFB.UseVisualStyleBackColor = true;
            btnFB.Click += new System.EventHandler(this.btnFB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnBuy);
            this.panel1.Controls.Add(this.panel);
            this.panel1.Controls.Add(this.btnmanager);
            this.panel1.Controls.Add(this.btninformation);
            this.panel1.Controls.Add(this.btnSupplies);
            this.panel1.Controls.Add(this.btnActivity);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 656);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Location = new System.Drawing.Point(0, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 5);
            this.panel2.TabIndex = 6;
            // 
            // btnBuy
            // 
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("辰宇落雁體 Thin", 30F);
            this.btnBuy.ForeColor = System.Drawing.Color.Crimson;
            this.btnBuy.Image = ((System.Drawing.Image)(resources.GetObject("btnBuy.Image")));
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.Location = new System.Drawing.Point(16, 13);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(169, 52);
            this.btnBuy.TabIndex = 7;
            this.btnBuy.Text = "購物車";
            this.btnBuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel.Location = new System.Drawing.Point(1, 120);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(10, 52);
            this.panel.TabIndex = 4;
            // 
            // btnmanager
            // 
            this.btnmanager.FlatAppearance.BorderSize = 0;
            this.btnmanager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmanager.Font = new System.Drawing.Font("辰宇落雁體 Thin", 22.25F);
            this.btnmanager.ForeColor = System.Drawing.Color.Tomato;
            this.btnmanager.Image = ((System.Drawing.Image)(resources.GetObject("btnmanager.Image")));
            this.btnmanager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmanager.Location = new System.Drawing.Point(18, 609);
            this.btnmanager.Name = "btnmanager";
            this.btnmanager.Size = new System.Drawing.Size(168, 47);
            this.btnmanager.TabIndex = 5;
            this.btnmanager.Text = "管理者設定";
            this.btnmanager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmanager.UseVisualStyleBackColor = true;
            this.btnmanager.Click += new System.EventHandler(this.btnmanager_Click);
            // 
            // btninformation
            // 
            this.btninformation.FlatAppearance.BorderSize = 0;
            this.btninformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninformation.Font = new System.Drawing.Font("辰宇落雁體 Thin", 20F);
            this.btninformation.ForeColor = System.Drawing.Color.Black;
            this.btninformation.Image = ((System.Drawing.Image)(resources.GetObject("btninformation.Image")));
            this.btninformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninformation.Location = new System.Drawing.Point(17, 514);
            this.btninformation.Name = "btninformation";
            this.btninformation.Size = new System.Drawing.Size(169, 52);
            this.btninformation.TabIndex = 4;
            this.btninformation.Text = "最新消息";
            this.btninformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninformation.UseVisualStyleBackColor = true;
            this.btninformation.Click += new System.EventHandler(this.btninformation_Click);
            // 
            // btnSupplies
            // 
            this.btnSupplies.FlatAppearance.BorderSize = 0;
            this.btnSupplies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplies.Font = new System.Drawing.Font("辰宇落雁體 Thin", 20F);
            this.btnSupplies.ForeColor = System.Drawing.Color.Black;
            this.btnSupplies.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplies.Image")));
            this.btnSupplies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplies.Location = new System.Drawing.Point(16, 312);
            this.btnSupplies.Name = "btnSupplies";
            this.btnSupplies.Size = new System.Drawing.Size(169, 52);
            this.btnSupplies.TabIndex = 3;
            this.btnSupplies.Text = "潛水用品";
            this.btnSupplies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSupplies.UseVisualStyleBackColor = true;
            this.btnSupplies.Click += new System.EventHandler(this.btnSupplies_Click);
            // 
            // btnActivity
            // 
            this.btnActivity.FlatAppearance.BorderSize = 0;
            this.btnActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivity.Font = new System.Drawing.Font("辰宇落雁體 Thin", 18F);
            this.btnActivity.ForeColor = System.Drawing.Color.Black;
            this.btnActivity.Image = ((System.Drawing.Image)(resources.GetObject("btnActivity.Image")));
            this.btnActivity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivity.Location = new System.Drawing.Point(16, 412);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.Size = new System.Drawing.Size(169, 52);
            this.btnActivity.TabIndex = 2;
            this.btnActivity.Text = "潛水活動";
            this.btnActivity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivity.UseVisualStyleBackColor = true;
            this.btnActivity.Click += new System.EventHandler(this.btnActivity_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("辰宇落雁體 Thin", 18F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(17, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "潛水課程";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("辰宇落雁體 Thin", 22.25F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(17, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 52);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "自由潛水";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(1, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 57);
            this.button3.TabIndex = 17;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(96)))));
            this.panel4.Location = new System.Drawing.Point(204, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(107, 119);
            this.panel4.TabIndex = 2;
            this.panel4.TabStop = true;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(4, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Free Diving";
            // 
            // btnLine
            // 
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLine.ForeColor = System.Drawing.Color.Black;
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(1363, 54);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(60, 48);
            this.btnLine.TabIndex = 6;
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnIG
            // 
            this.btnIG.FlatAppearance.BorderSize = 0;
            this.btnIG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIG.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIG.ForeColor = System.Drawing.Color.Black;
            this.btnIG.Image = ((System.Drawing.Image)(resources.GetObject("btnIG.Image")));
            this.btnIG.Location = new System.Drawing.Point(1302, 54);
            this.btnIG.Name = "btnIG";
            this.btnIG.Size = new System.Drawing.Size(60, 48);
            this.btnIG.TabIndex = 8;
            this.btnIG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIG.UseVisualStyleBackColor = true;
            this.btnIG.Click += new System.EventHandler(this.btnIG_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("辰宇落雁體 Thin", 30F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(317, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 52);
            this.label2.TabIndex = 10;
            this.label2.Text = "言言Free Diving ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(-3, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1438, 10);
            this.panel3.TabIndex = 10;
            // 
            // lbluserName
            // 
            this.lbluserName.AutoSize = true;
            this.lbluserName.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbluserName.Location = new System.Drawing.Point(67, 68);
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(72, 20);
            this.lbluserName.TabIndex = 18;
            this.lbluserName.Text = "使用者";
            this.lbluserName.Click += new System.EventHandler(this.使用者名稱_Click);
            // 
            // divingsup
            // 
            this.divingsup.AutoScroll = true;
            this.divingsup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divingsup.Location = new System.Drawing.Point(0, 0);
            this.divingsup.Name = "divingsup";
            this.divingsup.Size = new System.Drawing.Size(1219, 579);
            this.divingsup.TabIndex = 21;
            this.divingsup.Paint += new System.Windows.Forms.PaintEventHandler(this.divingsup_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Location = new System.Drawing.Point(204, 119);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.btnfins);
            this.splitContainer1.Panel1.Controls.Add(this.btntube);
            this.splitContainer1.Panel1.Controls.Add(this.btnmask);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.divingsup);
            this.splitContainer1.Size = new System.Drawing.Size(1219, 649);
            this.splitContainer1.SplitterDistance = 69;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("辰宇落雁體 Thin", 27F);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(80, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(173, 52);
            this.button4.TabIndex = 11;
            this.button4.Text = "所有商品";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnfins
            // 
            this.btnfins.FlatAppearance.BorderSize = 0;
            this.btnfins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfins.Font = new System.Drawing.Font("辰宇落雁體 Thin", 27F);
            this.btnfins.Image = ((System.Drawing.Image)(resources.GetObject("btnfins.Image")));
            this.btnfins.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfins.Location = new System.Drawing.Point(980, 9);
            this.btnfins.Name = "btnfins";
            this.btnfins.Size = new System.Drawing.Size(159, 52);
            this.btnfins.TabIndex = 10;
            this.btnfins.Text = "蛙鞋";
            this.btnfins.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnfins.UseVisualStyleBackColor = true;
            this.btnfins.Click += new System.EventHandler(this.btnfins_Click);
            // 
            // btntube
            // 
            this.btntube.FlatAppearance.BorderSize = 0;
            this.btntube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntube.Font = new System.Drawing.Font("辰宇落雁體 Thin", 27F);
            this.btntube.Image = ((System.Drawing.Image)(resources.GetObject("btntube.Image")));
            this.btntube.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntube.Location = new System.Drawing.Point(693, 9);
            this.btntube.Name = "btntube";
            this.btntube.Size = new System.Drawing.Size(159, 52);
            this.btntube.TabIndex = 9;
            this.btntube.Text = "呼吸管";
            this.btntube.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntube.UseVisualStyleBackColor = true;
            this.btntube.Click += new System.EventHandler(this.btntube_Click);
            // 
            // btnmask
            // 
            this.btnmask.FlatAppearance.BorderSize = 0;
            this.btnmask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmask.Font = new System.Drawing.Font("辰宇落雁體 Thin", 27F);
            this.btnmask.Image = ((System.Drawing.Image)(resources.GetObject("btnmask.Image")));
            this.btnmask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmask.Location = new System.Drawing.Point(400, 9);
            this.btnmask.Name = "btnmask";
            this.btnmask.Size = new System.Drawing.Size(144, 52);
            this.btnmask.TabIndex = 8;
            this.btnmask.Text = "面鏡";
            this.btnmask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnmask.UseVisualStyleBackColor = true;
            this.btnmask.Click += new System.EventHandler(this.btnmask_Click);
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
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_top.Controls.Add(this.btnExit);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1423, 46);
            this.panel_top.TabIndex = 4;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(155, 63);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(38, 31);
            this.button5.TabIndex = 21;
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // myclass1
            // 
            this.myclass1.AutoScroll = true;
            this.myclass1.BackColor = System.Drawing.Color.AliceBlue;
            this.myclass1.Location = new System.Drawing.Point(204, 119);
            this.myclass1.Name = "myclass1";
            this.myclass1.Size = new System.Drawing.Size(1219, 649);
            this.myclass1.TabIndex = 20;
            // 
            // diving_Free1
            // 
            this.diving_Free1.AutoScroll = true;
            this.diving_Free1.BackColor = System.Drawing.Color.Azure;
            this.diving_Free1.Location = new System.Drawing.Point(204, 119);
            this.diving_Free1.Name = "diving_Free1";
            this.diving_Free1.Size = new System.Drawing.Size(1219, 657);
            this.diving_Free1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1423, 768);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lbluserName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(btnFB);
            this.Controls.Add(this.btnIG);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.myclass1);
            this.Controls.Add(this.diving_Free1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnActivity;
        private System.Windows.Forms.Button btnSupplies;
        private System.Windows.Forms.Button btninformation;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnIG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Button btnmanager;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbluserName;
        private Diving_Free diving_Free1;
        private myclass myclass1;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel divingsup;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnfins;
        private System.Windows.Forms.Button btntube;
        private System.Windows.Forms.Button btnmask;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button button5;
    }
}

