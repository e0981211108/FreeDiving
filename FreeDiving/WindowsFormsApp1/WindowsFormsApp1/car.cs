using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class car : Form
    {
        public car()
        {
            InitializeComponent();
        }


     

        private void car_Load(object sender, EventArgs e)
        {
            

            foreach (ArrayList mycar in Globalvar.list購物車)
            {
                string currentItemName = mycar[1].ToString();

                // 檢查是否已存在相同商品
                userbuy existingFrame = null;
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is userbuy orderFrame && orderFrame.lbl商品名稱.Text == currentItemName)
                    {
                        existingFrame = orderFrame;
                        break;
                    }
                }

                if (existingFrame != null) //購物車之前已有同品項
                {

                }
                else // 沒有同品項，建立新的
                { //建立新的商品列
                    userbuy ItemsFrame = new userbuy();
                    ItemsFrame.lbl訂購者.Text = mycar[0].ToString(); 
                    ItemsFrame.lbl商品名稱.Text = mycar[1].ToString(); 
                    ItemsFrame.lbl商品價格.Text = mycar[2].ToString(); 
                    ItemsFrame.lbl訂購數量.Text = mycar[3].ToString(); 
                    ItemsFrame.lbl商品總價.Text = mycar[5].ToString(); 

                    // 確保 mycar[4] 不是 null
                    if (mycar[4] != null && !string.IsNullOrEmpty(mycar[4].ToString()))
                    {
                        ItemsFrame.Image.Image = Image.FromFile(mycar[4].ToString());
                    }
                    else
                    {
                        // 處理 null 的情況
                        // 可以設定預設圖片或顯示錯誤訊息
                        MessageBox.Show("圖片路徑不存在");
                    }
                    //ItemsFrame.Image.Image = Image.FromFile(mycar[4].ToString());

                    // 加入到 FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(ItemsFrame);
                  
                }
                

            }


        }

        private void btnCarExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();

                using (SqlConnection conn = new SqlConnection(Globalvar.strDBConnectionString))
                {
                    conn.Open();
                    string sql = @"SELECT name, price, image, Classification FROM PD ORDER BY ID";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        userbuy userBuyControl = new userbuy();




                        // 載入圖片
                        string imagePath = reader["image"].ToString();
                        if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                        {
                            try
                            {
                                using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                                {
                                    userBuyControl.Image.Image = Image.FromStream(stream);
                                    userBuyControl.Image.SizeMode = PictureBoxSizeMode.Zoom;
                                }
                            }
                            catch
                            {
                                userBuyControl.Image.Image = null;
                            }
                        }

                        // 設定預設值
                        userBuyControl.lbl訂購數量.Text = "0";
                        userBuyControl.lbl商品總價.Text = DateTime.Now.ToString("yyyy/MM/dd");

                        // 設定控制項大小和樣式
                        userBuyControl.Width = flowLayoutPanel1.Width - 20;
                        userBuyControl.Margin = new Padding(5);

                        // 加入到 flowLayoutPanel
                        flowLayoutPanel1.Controls.Add(userBuyControl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入商品資料時發生錯誤：{ex.Message}", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 通過商品名稱獲取ProductID的輔助方法


        private void btn結帳_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count == 0)
            {
                MessageBox.Show("購物車是空的！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 計算總金額
           int totalAmount = 0;
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is userbuy orderFrame)
                {
                    int price = int.Parse(orderFrame.lbl商品價格.Text);
                    int quantity = int.Parse(orderFrame.lbl訂購數量.Text);
                    totalAmount += price * quantity;
                    int totalprice = price*quantity;
                }
            }

            DialogResult result = MessageBox.Show(
                $"確認結帳？\n總金額：NT$ {totalAmount:N0}",
                "結帳確認",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(Globalvar.strDBConnectionString))
                    {
                        conn.Open();
                        foreach (Control control in flowLayoutPanel1.Controls)
                        {
                            if (control is userbuy orderFrame)
                            {
                                string sql = @"INSERT INTO orders
                                     (CustomerName, ProductName, Price, Quantity,Status) 
                                     VALUES 
                                     (@CustomerName, @ProductName, @Price,@Quantity, @Status);SELECT SCOPE_IDENTITY();";



                                using (SqlCommand cmd = new SqlCommand(sql, conn))
                                {
                                    cmd.Parameters.AddWithValue("@CustomerName", orderFrame.lbl訂購者.Text);
                                    cmd.Parameters.AddWithValue("@ProductName", orderFrame.lbl商品名稱.Text.ToString());
                                    cmd.Parameters.AddWithValue("@Price", int.Parse(orderFrame.lbl商品價格.Text));
                                    cmd.Parameters.AddWithValue("@Quantity", int.Parse(orderFrame.lbl訂購數量.Text));
                                    cmd.Parameters.AddWithValue("@Status", "待處理");  // 訂單狀態

                                     int newOrderID = Convert.ToInt32(cmd.ExecuteScalar());
                                // 2. 建立訂單明細記錄
                                 string insertDetailSQL = @"INSERT INTO orderdetail (custumerName,productName, Quantity, uninPrice, TotalPrice) VALUES (@custumerName,@productName, @Quantity, @uninPrice,@TotalPrice)";
                                    foreach (ArrayList item in Globalvar.list購物車)
                                    {
                                        try
                                        {
                                           
                                            string username = item[0].ToString();
                                            string productname = item[1].ToString().Replace("NT$", "").Replace("$", "").Trim();
                                            int Price = Convert.ToInt32(item[2]);
                                            int quantity = Convert.ToInt32(item[3]);
                                            int totalPrice = Convert.ToInt32(item[5]);


                                            //ItemsFrame.lbl訂購者.Text = mycar[0].ToString();
                                            //ItemsFrame.lbl商品名稱.Text = mycar[1].ToString();
                                            //ItemsFrame.lbl商品價格.Text = mycar[2].ToString();
                                            //ItemsFrame.lbl訂購數量.Text = mycar[3].ToString();
                                            //ItemsFrame.lbl商品總價.Text = mycar[5].ToString();


                                            // 取得商品ID


                                            // 1. 先建立訂單明細
                                            SqlCommand cmdDetail = new SqlCommand(insertDetailSQL, conn);
                                            cmdDetail.Parameters.AddWithValue("@productName", productname);
                                            cmdDetail.Parameters.AddWithValue("@orderID", newOrderID);
                                            cmdDetail.Parameters.AddWithValue("@uninPrice", Price);
                                            cmdDetail.Parameters.AddWithValue("@Quantity", quantity);
                                            cmdDetail.Parameters.AddWithValue("@TotalPrice", totalPrice);
                                            cmdDetail.Parameters.AddWithValue("@custumerName",username);
                                            cmdDetail.ExecuteNonQuery();

                                            //string insertDetailSQL = @"INSERT INTO orderdetail (OrderID, productName, Quantity, uninPrice, TotalPrice) VALUES (@OrderID, @productName, @Quantity, @uninPrice,@TotalPrice)";

                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show($"處理訂單時發生錯誤：{ex.Message}");
                                            throw;
                                        }
                                    }
                                }
                            }
                        }

                        // 清空購物車
                        Globalvar.list購物車.Clear();
                        flowLayoutPanel1.Controls.Clear();

                        MessageBox.Show(
                            $"訂單已成功送出！\n" +
                            $"總金額：NT$ {totalAmount:N0}\n\n" +
                            $"感謝您的購買。",
                            "結帳成功",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"結帳過程發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

             
                                

                               
               
          
            }
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
