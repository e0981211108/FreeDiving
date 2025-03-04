using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class userbuy : UserControl
    {
        private Color originalBackColor;

  

        public userbuy()
        {
            InitializeComponent();
            SetupControl();


        }
        private void SetupControl()
        {

            this.BackColor = Color.White;
    this.Size = new Size(1000, 259);
    this.BorderStyle = BorderStyle.FixedSingle; 

    // 設定刪除按鈕樣式
    if (btn刪除 != null)
    {
        btn刪除.FlatStyle = FlatStyle.Flat;
        btn刪除.FlatAppearance.BorderSize = 0;
        btn刪除.BackColor = Color.FromArgb(231, 76, 60);
        btn刪除.ForeColor = Color.White;
        btn刪除.Font = new Font("微軟正黑體", 14F, FontStyle.Bold); 
        btn刪除.Size = new Size(120, 45); 
        btn刪除.Location = new Point(850, 110);
        btn刪除.Text = "移除";
        btn刪除.Cursor = Cursors.Hand;

        // 按鈕圓角效果
        btn刪除.Region = new Region(GetRoundedRect(btn刪除.ClientRectangle, 10));
    }
}

// 僅用於按鈕圓角的輔助方法
private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
{
    GraphicsPath path = new GraphicsPath();
    int diameter = radius * 2;

    path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
    path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
    path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
    path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
    path.CloseFigure();

    return path;
}

private void btn刪除_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "確定要刪除此商品嗎？",
                    "刪除確認",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    
                    for (int i = Globalvar.list購物車.Count - 1; i >= 0; i--)
                    {
                        ArrayList item = Globalvar.list購物車[i];
                        if (item[1].ToString() == lbl商品名稱.Text) 
                        {
                            Globalvar.list購物車.RemoveAt(i);
                            break;
                        }
                    }

                   
                    this.Parent.Controls.Remove(this);
                    this.Dispose();

                    MessageBox.Show("商品已成功從購物車中移除！", "刪除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除商品時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void lbl商品名稱_Click(object sender, EventArgs e)
        {

        }

        private void lbl訂購者_Click(object sender, EventArgs e)
        {

        }

        private void lbl商品價格_Click(object sender, EventArgs e)
        {

        }

        private void lbl訂購數量_Click(object sender, EventArgs e)
        {

        }

        private void lbl訂單日期_Click(object sender, EventArgs e)
        {

        }

        private void userbuy_Load(object sender, EventArgs e)
        {

        }

        private void lbl訂購者_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_Line_Click(object sender, EventArgs e)
        {

        }

        private void Image_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn結帳_Click(object sender, EventArgs e)
        {
        }




        private void btn刪除_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 確認是否要刪除
                DialogResult result = MessageBox.Show(
                    "確定要刪除此商品嗎？",
                    "刪除確認",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // 從 Globalvar.list購物車 中找到並移除對應的項目
                    for (int i = Globalvar.list購物車.Count - 1; i >= 0; i--)
                    {
                        ArrayList item = Globalvar.list購物車[i];
                        if (item[1].ToString() == lbl商品名稱.Text) // 用商品名稱比對
                        {
                            Globalvar.list購物車.RemoveAt(i);
                            break;
                        }
                    }

                    // 從畫面上移除此控制項
                    this.Parent.Controls.Remove(this);
                    this.Dispose();

                    MessageBox.Show("商品已成功從購物車中移除！", "刪除成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"刪除商品時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
    
    

