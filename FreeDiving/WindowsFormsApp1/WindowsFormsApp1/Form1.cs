using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static WindowsFormsApp1.Globalvar;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
        

    {
        private string connectionString = "Server=.;Database=Freediving;Trusted_Connection=True;";
        private string imagePath = @"C:\Users\iSpan\Desktop\壞壞\商品圖片";
        //private string imagePath = @"C:\Users\e2080\OneDrive\桌面\壞壞\商品圖片";//家裡
        //private string imagePath = @"D:\Line下載\壞壞\商品圖片";//by 鋒


        List<string> list面鏡= new List<string>();
        List<int> list蛙鞋 = new List<int>();
        List<string> list呼吸管 = new List<string>();

        int 訂購數量 = 0;
        int 單價 = 0;
        int 單品總價 = 0;
        string 品項名稱 = "";
     





        public Form1()
        {
            {
                InitializeComponent();

                //user11.BringToFront();

                // 初始化管理者按鈕
                btnmanager.Visible = false;  
                btnmanager.BringToFront();   
                Globalvar.MainForm=this;
                設定視窗樣式();
                



            }
        }

        public void 顯示管理者模式()
        {


            if ((Globalvar.Manager >= 1) && (Globalvar.Manager <= 3))
            { //admin權限
                btnmanager.Visible = true;
            }
            else
            {
                btnmanager.Visible = false;
            }
          
        }


        private void LoadProductsToPanel(string keyword="")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = $"SELECT name, price, image FROM Pd {keyword} order by brand,price desc";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            try
                            {
                                UserControl1 productcard = new UserControl1();


                                // 取得資料
                                string name = reader["name"].ToString().Trim();
                                int price = (int)reader["price"];
                                //string imageFile = reader["image"].ToString();
                                string imageFile = reader["image"].ToString().Trim(); //再用 nchar 型別就敲妳
                                // 設定控制項屬性 - 使用正確的控制項名稱
                                productcard.lblN.Text = name;  // 使用 lblName 而不是 lblName
                                productcard.price.Text = price.ToString("C0");  // 假設價格標籤的名稱是 price
                                productcard.price.Tag = price;
                                // 載入圖片
                                string fullImagePath = Path.Combine(imagePath, imageFile);
                                if (File.Exists(fullImagePath))
                                {
                                    using (var stream = new FileStream(fullImagePath, FileMode.Open, FileAccess.Read))
                                    {
                                        productcard.Image.Image = System.Drawing.Image.FromStream(stream);  // 圖片控制項的名稱是 Image
                                        productcard.Image.Tag = fullImagePath;
                                    }
                                }

                                // 設定控制項大小和邊距
                                //productcard.Size = new Size(227, 349);  // 使用設計器中的尺寸
                                //productcard.Margin = new Padding(10);

                                // 加入到面板
                                divingsup.Controls.Add(productcard);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"載入單個商品時發生錯誤: {ex.Message}");
                                continue;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入商品資料時發生錯誤: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //FormLogin myformLogin = new FormLogin();
            //myformLogin.ShowDialog();


            panel.Height = button1.Height;
            panel.Top = button1.Top;
            diving_Free1.BringToFront();
            顯示管理者模式();

            divingsup.AutoScroll = true;
            divingsup.Width = 1219;
            divingsup.Height = 579;
            divingsup.BackColor = Color.White;
            divingsup.BorderStyle = BorderStyle.None;
            divingsup.Padding = new Padding(0, 10, 0, 10);

            // 更新使用者名稱
            lbluserName.Text = string.IsNullOrEmpty(Globalvar.Name) ? "訪客" : Globalvar.Name;

        }




        private void 設定視窗樣式()
        {
            // 移除標準標題列
            this.FormBorderStyle = FormBorderStyle.None;

            // 移除預設的標題列
            this.ControlBox = false;
            this.Text = String.Empty;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // 為整個表單添加拖動功能
            this.MouseDown += Form_MouseDown;
            this.MouseMove += Form_MouseMove;
            this.MouseUp += Form_MouseUp;

            // 為頂部藍色區域添加拖動功能
            if (this.Controls["topPanel"] != null)
            {
                var topPanel = this.Controls["topPanel"];
                topPanel.MouseDown += Form_MouseDown;
                topPanel.MouseMove += Form_MouseMove;
                topPanel.MouseUp += Form_MouseUp;
            }
        }

        private bool isDragging = false;
        private Point lastLocation;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastLocation = e.Location;
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y
                );
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            panel.Height = button1.Height;
            panel.Top = button1.Top;
            diving_Free1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel.Height = button2.Height;
            panel.Top = button2.Top;
            myclass1.BringToFront();


        }

        private void btnSupplies_Click(object sender, EventArgs e)
        {
            divingsup.Controls.Clear();
            panel.Height = btnSupplies.Height;
            panel.Top = btnSupplies.Top;
            splitContainer1.BringToFront();
            LoadProductsToPanel();

        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            panel.Height = btnActivity.Height;
            panel.Top = btnActivity.Top;
           // diving_activities1.BringToFront();

        }

        private void btninformation_Click(object sender, EventArgs e)
        {
            panel.Height = btninformation.Height;
            panel.Top = btninformation.Top;
           // latest_news1.BringToFront();
        }

        private void btnFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.facebook.com/profile.php?id=100003921499700&locale=zh_TW",
                UseShellExecute = true
            });
        }

        private void btnIG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.instagram.com/lzhiiij/profilecard/?igsh=MTM5bDAxajhpZzZ2aQ==",
                UseShellExecute = true
            });
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://line.me/ti/p/tI6piliIbb",
                UseShellExecute = true
            });
        }





        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnmanager_Click(object sender, EventArgs e)
        {
           
            //打開Mg
            mg MYmg = new mg();

            //獨佔開啟
            MYmg.ShowDialog();

        }


       






        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(8, 194, 255), 2))
            {
                // 設定虛線樣式
                pen.DashStyle = DashStyle.Dash;  // 或 DashStyle.Dot 為點線

                e.Graphics.DrawLine(pen,
                    panel1.Width - 1, 0,
                    panel1.Width - 1, panel1.Height);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            divingsup.Controls.Clear();

            LoadProductsToPanel();
        //    divingsup.Controls.Clear();
        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {
        //            conn.Open();
        //            string sql = @"SELECT * FROM Pd 
        //                 ORDER BY brand";

            //            using (SqlCommand cmd = new SqlCommand(sql, conn))
            //            using (SqlDataReader reader = cmd.ExecuteReader())
            //            {
            //                string currentBrand = "";
            //                FlowLayoutPanel currentPanel = null;

            //                while (reader.Read())
            //                {
            //                    try
            //                    {
            //                        string brand = reader["brand"].ToString().Trim();

            //                        if (currentBrand != brand)
            //                        {
            //                            // 品牌區塊間的間距
            //                            if (!string.IsNullOrEmpty(currentBrand))
            //                            {
            //                                Panel spacer = new Panel
            //                                {
            //                                    Height = 20,
            //                                    Width = 1219,
            //                                    BackColor = Color.Transparent
            //                                };
            //                                divingsup.Controls.Add(spacer);
            //                            }

            //                            // 品牌標題
            //                            Label titleLabel = new Label
            //                            {
            //                                Text = $"▼ {brand} ▼",
            //                                Font = new Font("微軟正黑體", 16, FontStyle.Bold),
            //                                AutoSize = false,
            //                                Width = 1180,
            //                                Height = 40,
            //                                TextAlign = ContentAlignment.MiddleCenter,
            //                                BackColor = Color.FromArgb(240, 240, 240),
            //                                Margin = new Padding(20, 5, 20, 5)
            //                            };
            //                            divingsup.Controls.Add(titleLabel);

            //                            // 商品容器面板
            //                            currentPanel = new FlowLayoutPanel
            //                            {
            //                                Width = 1180,
            //                                AutoSize = true,
            //                                FlowDirection = FlowDirection.LeftToRight,
            //                                WrapContents = true,
            //                                Margin = new Padding(20, 0, 20, 0),
            //                                Padding = new Padding(0),
            //                                BackColor = Color.White
            //                            };
            //                            divingsup.Controls.Add(currentPanel);

            //                            currentBrand = brand;
            //                        }

            //                        UserControl1 productcard = new UserControl1();

            //                        // 使用原始尺寸
            //                        productcard.Size = new Size(290, 407);

            //                        // 設定間距
            //                        productcard.Margin = new Padding(0, 0, 6, 10);

            //                        // 如果是每排的最後一個，移除右邊距
            //                        if ((currentPanel.Controls.Count + 1) % 4 == 0)
            //                        {
            //                            productcard.Margin = new Padding(0, 0, 0, 10);
            //                        }

            //                        // 設定商品資訊
            //                        string name = reader["name"].ToString().Trim();
            //                        int price = (int)reader["price"];
            //                        string imageFile = reader["image"].ToString().Trim();

            //                        productcard.lblN.Text = name;
            //                        productcard.price.Text = price.ToString("C0");
            //                        productcard.price.Tag = price;



            //                        // 載入圖片
            //                        string fullImagePath = Path.Combine(imagePath, imageFile);
            //                        if (File.Exists(fullImagePath))
            //                        {
            //                            using (var stream = new FileStream(fullImagePath, FileMode.Open, FileAccess.Read))
            //                            {
            //                                productcard.Image.Image = System.Drawing.Image.FromStream(stream);
            //                                productcard.Image.SizeMode = PictureBoxSizeMode.Zoom;
            //                                productcard.Image.Tag = fullImagePath;
            //                            }
            //                        }

            //                        currentPanel.Controls.Add(productcard);
            //                    }
            //                    catch (Exception ex)
            //                    {
            //                        MessageBox.Show($"載入單個商品時發生錯誤: {ex.Message}");
            //                        continue;
            //                    }
            //                }
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"載入商品資料時發生錯誤: {ex.Message}");
            //    }
        }


        private void btnmask_Click(object sender, EventArgs e)
        {
            divingsup.Controls.Clear();
            LoadProductsToPanel("where Classification ='面鏡'");



        }

        private void btntube_Click(object sender, EventArgs e)
        {
            divingsup.Controls.Clear();
            LoadProductsToPanel("where Classification ='呼吸管'");



            
            

        }

        private void btnfins_Click(object sender, EventArgs e)
        {
            divingsup.Controls.Clear();
            LoadProductsToPanel("where Classification ='長蛙鞋'");
            //divingsup.Controls.Clear();
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        conn.Open();
            //        // 修改 SQL 查詢，加入 brand 欄位
            //        string sql = "SELECT name, price, image, brand FROM Pd WHERE Classification ='長蛙鞋' ORDER BY brand";

            //        using (SqlCommand cmd = new SqlCommand(sql, conn))
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            string currentBrand = "";
            //            FlowLayoutPanel currentPanel = null;

            //            while (reader.Read())
            //            {
            //                try
            //                {
            //                    string brand = reader["brand"].ToString().Trim();

            //                    if (currentBrand != brand)
            //                    {
            //                        // 品牌區塊間的間距
            //                        if (!string.IsNullOrEmpty(currentBrand))
            //                        {
            //                            Panel spacer = new Panel
            //                            {
            //                                Height = 20,
            //                                Width = 1219,
            //                                BackColor = Color.Transparent
            //                            };
            //                            divingsup.Controls.Add(spacer);
            //                        }

            //                        // 品牌標題
            //                        Label titleLabel = new Label
            //                        {
            //                            Text = $"▼ {brand} ▼",
            //                            Font = new Font("微軟正黑體", 16, FontStyle.Bold),
            //                            AutoSize = false,
            //                            Width = 1180,
            //                            Height = 40,
            //                            TextAlign = ContentAlignment.MiddleCenter,
            //                            BackColor = Color.FromArgb(240, 240, 240),
            //                            Margin = new Padding(20, 5, 20, 5)
            //                        };
            //                        divingsup.Controls.Add(titleLabel);

            //                        // 商品容器面板
            //                        currentPanel = new FlowLayoutPanel
            //                        {
            //                            Width = 1180,
            //                            AutoSize = true,
            //                            FlowDirection = FlowDirection.LeftToRight,
            //                            WrapContents = true,
            //                            Margin = new Padding(20, 0, 20, 0),
            //                            Padding = new Padding(0),
            //                            BackColor = Color.White
            //                        };
            //                        divingsup.Controls.Add(currentPanel);

            //                        currentBrand = brand;
            //                    }

            //                    UserControl1 productcard = new UserControl1();

            //                    // 使用原始尺寸
            //                    productcard.Size = new Size(290, 407);

            //                    // 設定間距
            //                    productcard.Margin = new Padding(0, 0, 6, 10);

            //                    // 如果是每排的最後一個，移除右邊距
            //                    if ((currentPanel.Controls.Count + 1) % 4 == 0)
            //                    {
            //                        productcard.Margin = new Padding(0, 0, 0, 10);
            //                    }

            //                    // 設定商品資訊
            //                    string name = reader["name"].ToString().Trim();
            //                    int price = (int)reader["price"];
            //                    string imageFile = reader["image"].ToString().Trim();

            //                    productcard.lblN.Text = name;
            //                    productcard.price.Text = price.ToString("C0");  // 加入貨幣格式
            //                    productcard.price.Tag = price;


            //                    // 載入圖片
            //                    string fullImagePath = Path.Combine(imagePath, imageFile);
            //                    if (File.Exists(fullImagePath))
            //                    {
            //                        using (var stream = new FileStream(fullImagePath, FileMode.Open, FileAccess.Read))
            //                        {
            //                            productcard.Image.Image = System.Drawing.Image.FromStream(stream);
            //                            productcard.Image.SizeMode = PictureBoxSizeMode.Zoom;
            //                            productcard.Image.Tag = fullImagePath;
            //                        }
            //                    }

            //                    currentPanel.Controls.Add(productcard);
            //                }
            //                catch (Exception ex)
            //                {
            //                    MessageBox.Show($"載入單個商品時發生錯誤: {ex.Message}");
            //                    continue;
            //                }
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"載入商品資料時發生錯誤: {ex.Message}");
            //}
        }






        private void btnBuy_Click(object sender, EventArgs e)
        {
            //打開購物車
            car mycar = new car();

            //獨佔開啟
            mycar.ShowDialog();
        }





        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void diving_Free1_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void divingsup_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        
            private void button3_Click(object sender, EventArgs e)  //註冊
            {
                lo2 lo2_Load = new lo2();
                lo2_Load.ShowDialog();  // 顯示註冊窗體

                // 註冊窗體關閉後，關閉當前窗體並重新啟動登入流程
                this.Close();
                Application.Restart();
            }
        
    


        private void 使用者名稱_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void diving_Free1_Load(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void F1Login_Click(object sender, EventArgs e)
        {
            FormLogin FormLogin_Load = new FormLogin();

            this.Hide();
            FormLogin_Load.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
         
            Application.Restart();
        }
    }
}
