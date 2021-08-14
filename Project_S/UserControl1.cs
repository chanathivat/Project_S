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
    public partial class UserControl1 : UserControl
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Project_S;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM user WHERE username = '" + username.Text + "'AND password = '" + password.Text + "'";

            MySqlDataReader row = cmd.ExecuteReader();
            
            

            if (row.HasRows)
            {
                row.Read();
                Program.user = row.GetString("username");
                password.ResetText();
                label4.ResetText();
                Form2 a = new Form2();
                a.ShowDialog();

                
            }
            else
            {
                label4.Text = "บัญชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง";
            }
            conn.Close();
            this.Size = new Size(387, 378);
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            password.PasswordChar = '\0';
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 122) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
