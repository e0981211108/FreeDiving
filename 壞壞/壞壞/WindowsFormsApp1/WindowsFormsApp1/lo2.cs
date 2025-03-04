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

namespace WindowsFormsApp1
{
    public partial class lo2 : Form
    {
        private string connectionString = @"Server=.;Database=FreeDiving;Trusted_Connection=True;";


        private void 送出_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // 基本驗證
                    if (string.IsNullOrEmpty(txtName.Text) ||
                        string.IsNullOrEmpty(txtID.Text) ||
                        string.IsNullOrEmpty(txtPassword.Text))
                    {
                        MessageBox.Show("請填寫所有欄位", "提示");
                        return;
                    }

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string insertQuery = @"INSERT INTO Evieusers (name, ID, password,email,phone,address) 
                                 VALUES (@name, @ID, @password, @phone,@email, @address)";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {

                            // 選填欄位
                            cmd.Parameters.AddWithValue("@email",
                                string.IsNullOrEmpty(txtEmail.Text) ? DBNull.Value : (object)txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@address",
                                string.IsNullOrEmpty(txtAddress.Text) ? DBNull.Value : (object)txtAddress.Text.Trim());
                            cmd.Parameters.AddWithValue("@name",
                              string.IsNullOrEmpty(txtName.Text) ? DBNull.Value : (object)txtEmail.Text.Trim());
                            cmd.Parameters.AddWithValue("@ID",
                                string.IsNullOrEmpty(txtID.Text) ? DBNull.Value : (object)txtID.Text.Trim());
                            cmd.Parameters.AddWithValue("@phone",
                              string.IsNullOrEmpty(txtPhone.Text) ? DBNull.Value : (object)txtPhone.Text.Trim());
                            cmd.Parameters.AddWithValue("@Password",
                             string.IsNullOrEmpty(txtPassword.Text) ? DBNull.Value : (object)txtPassword.Text.Trim());




                            try
                            {
                                int result = cmd.ExecuteNonQuery();
                                if (result > 0)
                                {
                                    MessageBox.Show("註冊成功！", "成功");
                                    ClearInputs();
                                }
                                else
                                {
                                    MessageBox.Show("註冊失敗，請稍後再試。", "錯誤");
                                }
                            }
                            catch (SqlException sqlEx)
                            {
                                MessageBox.Show($"數據庫錯誤：{sqlEx.Message}", "錯誤");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"發生錯誤：{ex.Message}", "錯誤");
                }
            }
        }
        public lo2()
        {
            InitializeComponent();
            this.送出.Click += new System.EventHandler(this.送出_Click);
            foreach (Control control in this.Controls)
            {
                if (control is Label)
                {
                    Label label = (Label)control;
                    label.BackColor = Color.Transparent;
                    // 確保文字能夠正常顯示
                    label.Parent = this;  // 將 Label 直接設置為窗體的子控件
                }
            }

        }
       




        private void ClearInputs()
        {
            txtName.Text = string.Empty;
            txtID.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }



        private void lo2_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  // 直接關閉註冊窗體即可
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
       
}


