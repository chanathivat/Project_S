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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private List<PP> print = new List<PP>();
        private void button1_Click(object sender, EventArgs e)
        {
            print.Clear();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ประวัติการขายทั้งหมด", new Font("supermarket", 20, FontStyle.Bold), Brushes.Black, new Point(330, 50));
            e.Graphics.DrawString("PANDA SHOP", new Font("supermarket", 24, FontStyle.Bold), Brushes.Black, new Point(300, 90));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(525, 150));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 285));
            e.Graphics.DrawString("    ลำดับ                ชื่อผู้ซื้อ                ชื่อสินค้า                           จำนวน                                 เวลา", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 315));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 345));
            int y = 345;
            datacheck();
            int number = 1;
            foreach (var i in print)
            {
                y = y + 35;
                e.Graphics.DrawString("   " + number.ToString(), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                e.Graphics.DrawString("   " + i.username, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(180, y));
                e.Graphics.DrawString("   " + i.name, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(280, y));
                e.Graphics.DrawString("   " + i.amount, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(500, y));
                e.Graphics.DrawString("   " + i.time, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(655, y));

                number = number + 1;
            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, y + 30));
        }
        private void datacheck()
        {
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_s;");

            conn.Open();
            if (checkBox1.Checked)
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM his WHERE time between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'and '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'", conn);
                MySqlDataReader adapter = cmd.ExecuteReader();

                while (adapter.Read())
                {
                    Program.username = adapter.GetString("username");
                    Program.name = adapter.GetString("Name");
                    Program.amount = adapter.GetString("Amount");
                    Program.time = adapter.GetString("time");

                    PP item = new PP()
                    {
                        username = Program.username,
                        name = Program.name,
                        amount = Program.amount,
                        time = Program.time,

                    };
                    print.Add(item);
                }
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM his  ", conn);
                MySqlDataReader adapter = cmd.ExecuteReader();

                while (adapter.Read())
                {
                    Program.username = adapter.GetString("username");
                    Program.name = adapter.GetString("Name");
                    Program.amount = adapter.GetString("Amount");
                    Program.time = adapter.GetString("time");

                    PP item = new PP()
                    {
                        username = Program.username,
                        name = Program.name,
                        amount = Program.amount,
                        time = Program.time,

                    };
                    print.Add(item);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            print.Clear();
            printPreviewDialog1.Document = printDocument2;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ประวัติการขายรายคน", new Font("supermarket", 20, FontStyle.Bold), Brushes.Black, new Point(330, 50));
            e.Graphics.DrawString("PANDA SHOP", new Font("supermarket", 24, FontStyle.Bold), Brushes.Black, new Point(300, 90));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(525, 150));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 285));
            e.Graphics.DrawString("    ลำดับ                ชื่อผู้ซื้อ                ชื่อสินค้า                           จำนวน                                 เวลา", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 315));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 345));
            int y = 345;
            datacheck2();
            int number = 1;
            foreach (var i in print)
            {
                y = y + 35;
                e.Graphics.DrawString("   " + number.ToString(), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                e.Graphics.DrawString("   " + i.username, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(180, y));
                e.Graphics.DrawString("   " + i.name, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(280, y));
                e.Graphics.DrawString("   " + i.amount, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(500, y));
                e.Graphics.DrawString("   " + i.time, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(655, y));

                number = number + 1;
            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, y + 30));
        }
        private void datacheck2()
        {

            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_s;");

            conn.Open();
            if (checkBox1.Checked)
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM his WHERE username = '" + textBox1.Text + "'AND time between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'and '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'", conn);
                MySqlDataReader adapter = cmd.ExecuteReader();

                while (adapter.Read())
                {
                    Program.username = adapter.GetString("username");
                    Program.name = adapter.GetString("Name");
                    Program.amount = adapter.GetString("Amount");
                    Program.time = adapter.GetString("time");

                    PP item = new PP()
                    {
                        username = Program.username,
                        name = Program.name,
                        amount = Program.amount,
                        time = Program.time,

                    };
                    print.Add(item);
                }
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand($"SELECT * FROM his WHERE username = '" + textBox1.Text + "' ", conn);
                MySqlDataReader adapter = cmd.ExecuteReader();

                while (adapter.Read())
                {
                    Program.username = adapter.GetString("username");
                    Program.name = adapter.GetString("Name");
                    Program.amount = adapter.GetString("Amount");
                    Program.time = adapter.GetString("time");

                    PP item = new PP()
                    {
                        username = Program.username,
                        name = Program.name,
                        amount = Program.amount,
                        time = Program.time,

                    };
                    print.Add(item);
                }
            }
        }
    }
}
