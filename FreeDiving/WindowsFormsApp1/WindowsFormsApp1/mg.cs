using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class mg : Form
    {
        public mg()
        {
            InitializeComponent();
        }

        void 顯示權限功能()
        {


            lblmg.Text = $"管理者:{Globalvar.Name} ";


            if ((Globalvar.Manager ==2))
            { //admin

                btnMg商品上架.Visible = true;
                btnMg會員維護.Visible = true;
                btnMg訂單管理.Visible = true;
                btnMg系統設定.Visible = true;
            }
            else if ((Globalvar.Manager == 3))
            { //店長


              
                btnMg商品上架.Visible = true;
                btnMg會員維護.Visible = true;
                btnMg訂單管理.Visible = true;
                btnMg系統設定.Visible = true;
            }
            else if ((Globalvar.Manager == 1))
            { //店員

               
                btnMg商品上架.Visible = false;
                btnMg會員維護.Visible = false;
                btnMg訂單管理.Visible = true;
                btnMg系統設定.Visible = false;
            }


        }

        private void btnCarExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMg訂購單_Click(object sender, EventArgs e)
        {

        }

        private void btnMg商品展示_Click(object sender, EventArgs e)
        {

        }


        private void btnMg會員維護_Click(object sender, EventArgs e)
        {
            try
            {
                // 創建會員維護視窗的實例，使用正確的類別名稱 mamber
                mamber memberForm = new mamber();

                // 以對話框形式顯示會員維護視窗
                memberForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"開啟會員維護視窗時發生錯誤：{ex.Message}", "錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void mg_Load(object sender, EventArgs e)
        {
            lblmg.Text = string.IsNullOrEmpty(Globalvar.Name) ? "訪客" : Globalvar.Name;
            顯示權限功能();
        }

        private void mg_Activated(object sender, EventArgs e)
        {
            顯示權限功能();
        }

        private void lblmg_Click(object sender, EventArgs e)
        {

        }

        private void btnMg訂單管理_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMg系統設定_Click(object sender, EventArgs e)
        {

        }
    }
}
