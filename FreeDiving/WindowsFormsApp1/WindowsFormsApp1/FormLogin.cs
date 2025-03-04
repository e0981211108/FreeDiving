using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Globalvar;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            設定視窗樣式();

        }

        private void 設定視窗樣式()
        {

           // 為整個表單添加拖動功能
            this.MouseDown += FormLogin_MouseDown;
            this.MouseMove += FormLogin_MouseMove;
            this.MouseUp += FormLogin_MouseUp;

       
        }








        private void FormLogin_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "Freediving";
            scsb.IntegratedSecurity = true;
            Globalvar.strDBConnectionString= scsb.ConnectionString.ToString();
            



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            string intID = txt_id.Text;
            string strpassword = txt_password.Text.Trim();

            if (string.IsNullOrEmpty(intID) || string.IsNullOrEmpty(strpassword))
            {
                MessageBox.Show("請輸入帳號及密碼，或使用訪客模式", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(Globalvar.strDBConnectionString))
            {
                try
                {
                    con.Open();
                    string strSQL = @"IF EXISTS (SELECT 1 FROM Evieusers WHERE ID = @searchID AND password = @searchPassword)
                    BEGIN
                        SELECT 'Evieusers' as UserType, Name, ID, Password, manager, Phone, Email, Address
                        FROM Evieusers 
                        WHERE ID = @searchID AND password = @searchPassword
                        END
                        ELSE
                        BEGIN


                        SELECT 'Evieusers' as UserType, 
                               Name, Account as ID, Password, 
                               0 as manager, Phone, Email, Address
                        FROM Evieusers
                        WHERE Account = @searchID AND Password = @searchPassword
                    END";

                    using (SqlCommand cmd = new SqlCommand(strSQL, con))
                    {
                        cmd.Parameters.AddWithValue("@searchID", intID);
                        cmd.Parameters.AddWithValue("@searchPassword", strpassword);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string userType = reader["UserType"].ToString();
                                Globalvar.is登入成功 = true;
                                Globalvar.isLoggedIn = true; 
                                Globalvar.Name = reader["Name"].ToString();
                                Globalvar.Password = reader["Password"].ToString();
                                Globalvar.ID = reader["ID"].ToString();
                                Globalvar.Manager = (int)reader["manager"];
                                
                                MessageBox.Show($"登入成功！\n歡迎 {Globalvar.Name}");

                                this.Close();  // 只需要關閉登入窗體
                            }
                        
                            else
                            {
                                MessageBox.Show("帳號或密碼錯誤！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                txt_id.Text = "";
                                txt_password.Text = "";
                                txt_id.Focus();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"登入時發生錯誤：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

            private void btn訪客_Click(object sender, EventArgs e)
            {
                Globalvar.Name = "訪客";
                Globalvar.isLoggedIn = false;  // 訪客模式設為 false
                Close();
            }
           
           
        

        private void btn註冊_Click(object sender, EventArgs e)
        {
            // 建立並顯示 lo2 表單
            lo2 lo2_Load = new lo2();
            
            this.Hide();
            lo2_Load.ShowDialog();

            // 隱藏當前的 MainForm（或使用 this.Close() 關閉）
            
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void FormLogin_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
