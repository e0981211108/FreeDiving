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
    public partial class UserControl1 : UserControl
    {
        public new BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set { base.BorderStyle = value; }
        }

        private ToolTip tooltip; // 宣告 ToolTip



        private ToolTip toolTip1;  
        private void UpdateAllShoppingControls()
        {
            bool isGuest = (lblName.Text == "訪客");

            button4.Enabled = !isGuest;  

            if (isGuest)
            {
                // 訪客狀態
                button4.Cursor = Cursors.No;


                // 設定提示文字
                toolTip1.SetToolTip(button4, "請先註冊會員才能使用購物功能");


                // 設定灰色外觀
                button4.BackColor = Color.Gray;

            }
            else
            {
                // 會員狀態
                button4.Cursor = Cursors.Hand;


                // 清除提示文字
                toolTip1.SetToolTip(button4, "");


                // 恢復原本顏色
                button4.BackColor = Color.FromName("原本的顏色");

            }
        }



        private Label lblPrice;
        private PictureBox pictureBox;

        //public Label lbl商品名稱 { get; set; }
        //public Label lbl訂購者 { get; set; }
        //public Label lbl商品價格 { get; set; }
        //public Label lbl訂購數量 { get; set; }
        //public Label lbl訂單日期 { get; set; }
        //public PictureBox pictureBox商品圖片 { get; set; }

        public UserControl1()
        {
            InitializeComponent();
           

            // 設置基本屬性
            this.BackColor = Color.White;

            // 初始化圓角
            ApplyRoundedCorners();
        }

      


        private void ApplyRoundedCorners()
        {
            int radius = 2; // 圓角半徑，可以根據需要調整
            GraphicsPath path = new GraphicsPath();

            // 添加圓角路徑
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);                   // 左上角
            path.AddArc(Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);  // 右上角
            path.AddArc(Width - radius * 2, Height - radius * 2, radius * 2, radius * 2, 0, 90);   // 右下角
            path.AddArc(0, Height - radius * 2, radius * 2, radius * 2, 90, 90);  // 左下角
            path.CloseFigure();

            this.Region = new Region(path);
        }

        // 當控件大小改變時重新設置圓角
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
           
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            Paint += (s, pe) =>
            {
                // 設置邊框顏色和寬度
                Color borderColor = Color.LightGray;  // 改成其他顏色
                float borderWidth = 3;             // 調整邊框寬度

                // 繪製圓角邊框
                using (Pen pen = new Pen(borderColor, borderWidth))
                {
                    // 留出一點空間，避免邊框被切掉
                    Rectangle rect = new Rectangle(2,2, this.Width -3 , this.Height - 3);
                    int radius = 20; // 圓角半徑，需要和之前設置的圓角一致

                    GraphicsPath path = new GraphicsPath();
                    path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
                    path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
                    path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
                    path.CloseFigure();

                    pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    pe.Graphics.DrawPath(pen, path);
                }
            };
        }



        private void button4_Click(object sender, EventArgs e)
        {

            if (Globalvar.isLoggedIn != true)
            {
                MessageBox.Show("請先登入會員！\n\n或是點擊「訪客」文字旁的「使用者圖像」進行註冊。",
                               "需要會員登入",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                return;
            }

            ArrayList mycar = new ArrayList();

            mycar.Add(Globalvar.Name);
            mycar.Add(lblN.Text);
            mycar.Add(price.Tag);
            mycar.Add(1);
            mycar.Add(Image.Tag);
            mycar.Add(price.Tag);
            Globalvar.list購物車.Add(mycar);

            // 格式化價格顯示
            string formattedPrice = Convert.ToInt32(price.Tag).ToString("C0");

            MessageBox.Show($"已加入購物車：\n\n" +
                           $"商品名稱：{lblN.Text}\n" +
                           $"商品價格：{formattedPrice}\n" +
                           $"數量：1\n\n" +
                           $"您可以繼續購物或前往購物車結帳。",
                           "加入成功",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);

            Console.WriteLine($"{Image.Tag}");
        }

    

        private void Image_Click(object sender, EventArgs e)
        {

        }

        private void lblN_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
