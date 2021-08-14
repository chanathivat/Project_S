using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_S
{
    public partial class UserControl2 : UserControl
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Project_S;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
            password2.PasswordChar = '*';
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            password.PasswordChar = '\0';
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            password2.PasswordChar = '\0';
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            password2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text == "" || password.Text == "" || password2.Text == "" || email.Text == "" || name.Text == "" || surname.Text == "" || phone.Text == "" || address.Text == "") 
                {
                    MessageBox.Show("ข้อมูลไม่ครบ");
                }
                else
                {
                    if (!this.email.Text.Contains('@') || !this.email.Text.Contains(".com"))
                    {
                        MessageBox.Show("อีเมลไม่ถูกต้อง", "ระบบ");
                    }
                    else
                    {
                        if (password.TextLength < 6)
                        {
                            MessageBox.Show("กรุณากรอก Password อย่างน้อย 6 ตัว");
                        }
                        else
                        {
                            if(phone.TextLength == 10)
                            {
                                if (password.Text == password2.Text)
                                {
                                    MySqlConnection conn = databaseConnection();
                                    String sql = "INSERT INTO user(username,password,email,name,surname,phone,address)VALUES('" + username.Text + "','" + password.Text + "','" + email.Text + "','" + name.Text + "','" + surname.Text + "','" + phone.Text + "','" + address.Text + "')";
                                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                                    conn.Open();
                                    int rows = cmd.ExecuteNonQuery();

                                    conn.Close();

                                    if (rows > 0)
                                    {
                                        MessageBox.Show(" ลงทะเบียนสำเร็จ");
                                        Form1 a = new Form1();
                                        this.Hide();
                                        a.Show();
                                        this.Size = new Size(387, 378);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("password ไม่ตรงกัน");
                                }
                            }
                            else
                            {
                                MessageBox.Show("หมายเลขโทรศัพท์ไม่ถูกต้อง");
                            }
                        }
                    }
                }
            }
            
            catch
            {
                MessageBox.Show(" Username ถูกใช้แล้ว ");
            }
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 122) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 45 || e.KeyChar > 122) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
