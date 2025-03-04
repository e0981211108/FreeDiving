using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;  // 加入這行
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Globalvar;

namespace WindowsFormsApp1
{
    public partial class mamber : Form
    {
        SqlConnection conn;

        public mamber()
        {
            InitializeComponent();
            conn = new SqlConnection(Globalvar.strDBConnectionString);
        }

        private void mamber_Load(object sender, EventArgs e)
        {

        }

        private void LoadMemberList()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM Evieusers ORDER BY Name";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv會員資料列表.DataSource = dt;

                if (dgv會員資料列表.Columns.Count > 0)
                {
                    dgv會員資料列表.Columns["Id"].HeaderText = "會員編號";
                    dgv會員資料列表.Columns["Name"].HeaderText = "帳號";
                    dgv會員資料列表.Columns["Password"].HeaderText = "密碼";
                    dgv會員資料列表.Columns["Email"].HeaderText = "信箱";
                    dgv會員資料列表.Columns["Phone"].HeaderText = "電話";
                    dgv會員資料列表.Columns["Address"].HeaderText = "地址";
                    dgv會員資料列表.Columns["manager"].HeaderText = "管理員";

                    dgv會員資料列表.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"載入資料時發生錯誤：{ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void 清空欄位()
        {
            txtAccount.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // 設定點點的間距和大小
            int dotSpacing = 15; // 點與點之間的距離
            int dotSize = 2;     // 點的大小

            // 使用深灰色作為點的顏色
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(200, 200, 200)))
            {
                // 取得 panel 的寬度和高度
                int width = panel1.Width;
                int height = panel1.Height;

                // 繪製點點
                for (int x = 0; x < width; x += dotSpacing)
                {
                    for (int y = 0; y < height; y += dotSpacing)
                    {
                        e.Graphics.FillEllipse(brush, x, y, dotSize, dotSize);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn新增會員_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccount.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("帳號和密碼為必填欄位");
                return;
            }

            try
            {
                conn.Open();

                // 檢查帳號是否已存在
                string checkSql = "SELECT COUNT(*) FROM Evieusers WHERE ID = @Id";
                SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@Id", txtAccount.Text);

                int count = (int)checkCmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("此帳號已經存在，請使用其他帳號");
                    return;
                }

                // 新增會員
                string sql = @"INSERT INTO Evieusers (Name, ID, Password, Phone, Email, Address, manager) 
                      VALUES (@Name, @Id, @Password, @Phone, @Email, @address, 0)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Id", txtAccount.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("新增會員成功！");
                清空欄位();
                LoadMemberList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"新增會員時發生錯誤：{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn資料刪除_Click(object sender, EventArgs e)
        {
            if (dgv會員資料列表.SelectedRows.Count == 0)
            {
                MessageBox.Show("請選擇要刪除的會員");
                return;
            }

            if (MessageBox.Show("確定要刪除此會員資料嗎？", "確認刪除",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM Evieusers WHERE ID=@ID";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", txtAccount.Text);

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("刪除成功！");
                        LoadMemberList();
                        清空欄位();
                    }
                    else
                    {
                        MessageBox.Show("刪除失敗，找不到指定的會員");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"刪除資料時發生錯誤：{ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            if (dgv會員資料列表.SelectedRows.Count == 0)
            {
                MessageBox.Show("請選擇要修改的會員");
                return;
            }

            try
            {
                conn.Open();
                string sql = @"UPDATE Evieusers 
                      SET Name=@name, Password=@Password, 
                          phone=@Phone, Email=@Email, Address=@Address 
                      WHERE ID=@Id";



                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Id", txtAccount.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("修改成功！");
                    LoadMemberList();
                    清空欄位();
                }
                else
                {
                    MessageBox.Show("修改失敗，找不到指定的會員");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"修改資料時發生錯誤：{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn清空表格資料_Click(object sender, EventArgs e)
        {
            txtName.Text = "";      // 姓名
            txtAccount.Text = "";   // 帳號
            txtPassword.Text = "";  // 密碼
            txtPhone.Text = "";     // 電話
            txtAddress.Text = "";   // 地址
            txtEmail.Text = "";     // 信箱
        }
    


            private void btn連線_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM Evieusers ORDER BY name";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv會員資料列表.DataSource = dt;

                if (dgv會員資料列表.Columns.Count > 0)
                {
                    dgv會員資料列表.Columns["Name"].HeaderText = "姓名";
                    dgv會員資料列表.Columns["ID"].HeaderText = "帳號";
                    dgv會員資料列表.Columns["Password"].HeaderText = "密碼";
                    dgv會員資料列表.Columns["Phone"].HeaderText = "電話";
                    dgv會員資料列表.Columns["Email"].HeaderText = "信箱";
                    dgv會員資料列表.Columns["Address"].HeaderText = "地址";
                    dgv會員資料列表.Columns["Manager"].HeaderText = "管理員";
                

                    dgv會員資料列表.AutoResizeColumns();
                }
                MessageBox.Show("資料載入成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"連線或載入資料時發生錯誤：{ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btm搜尋會員_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("請輸入姓名");
                return;
            }

            try
            {
                conn.Open();
                string sql = @"SELECT * FROM Evieusers 
                      WHERE name = @name";  // 使用完全比對

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);  // 移除 % 符號

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // 將搜尋結果顯示在文字框中
                    txtName.Text = reader["Name"].ToString();
                    txtAccount.Text = reader["ID"].ToString();
                    txtPassword.Text = reader["Password"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    txtEmail.Text = reader["Email"].ToString();

                    // 在DataGridView中選取該筆資料
                    foreach (DataGridViewRow row in dgv會員資料列表.Rows)
                    {
                        if (row.Cells["Name"].Value.ToString() == txtName.Text)
                        {
                            row.Selected = true;
                            dgv會員資料列表.CurrentCell = row.Cells[0];
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("找不到符合的資料");
                    清空欄位();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"搜尋時發生錯誤：{ex.Message}");
            }
            finally
            {
                conn.Close();
            }



        }

        private void btn產生會員資料_Click(object sender, EventArgs e)
        {
            if (dgv會員資料列表.DataSource == null)
            {
                MessageBox.Show("請先連線並載入資料");
                return;
            }

            try
            {
                conn.Open();
                string sql = "SELECT * FROM Evieusers ORDER BY Name";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv會員資料列表.DataSource = dt;

                MessageBox.Show("資料已重新整理");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"重新整理資料時發生錯誤：{ex.Message}");
            }
            finally
            {
                conn.Close();
            }

        }

        private void dgv會員資料列表_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
              string MB = dgv會員資料列表.Rows[e.RowIndex].Cells[1].Value.ToString();
             conn.Open();
            string sql = "SELECT * FROM Evieusers where ID =@ID";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ID",MB);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtName.Text = reader["Name"].ToString();
                txtAccount.Text = reader["ID"].ToString();
                txtPassword.Text = reader["Password"].ToString();
                txtPhone.Text = reader["Phone"].ToString();
                txtAddress.Text = reader["Address"].ToString();
                txtEmail.Text = reader["Email"].ToString();
            }
            conn.Close();
            reader.Close();
        }
    }
    }



