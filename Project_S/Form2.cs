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
using System.IO;

namespace Project_S
{
    public partial class Form2 : Form
    {
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=Project_S;";

            MySqlConnection conn = new MySqlConnection(connectionString);

            return conn;
        }
        private void refcountxz()
        {

            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE products SET Amount = Amount +'" + Convert.ToInt32(amountx.Text) + "'WHERE Name = '" + delname.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

        }
        private void refcount()
        {

            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE products SET Amount = Amount+count WHERE Name = '" + delname.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

        }
        private void refcount2()
        {

            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE products SET Amount = Amount+count ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

        }
        private void refcount3()
        {

            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE products SET Amount = Amount-count WHERE Name = '" + delname.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

        }
        private void recount()
        {

            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE products SET count = '" + Convert.ToInt32("0") + "'WHERE Name = '" + delname.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();
        }
        private void recountx()
        {

            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE products SET count = '" + Convert.ToInt32(amountx.Text) + "'WHERE Name = '" + delname.Text + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();
        }
        private void recount2()
        {

            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE products SET count = '" + Convert.ToInt32("0") + "' ";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            printhis.Visible = false;
            groupBox1.Visible = false;
            basketpan.Size = new Size(1082, 149);
            upanel.Size = new Size(1082, 149);
            adpanel.Size = new Size(1082, 149);
            panelh.Visible = false;
            clearhis.Visible = false;
            checkBox1.Visible = false;
            ad.Visible = false;
            adpanel.Visible = false;
            upanel.Visible = true;
            basketpan.Visible = false;
            uname.Text = Program.user;
            showall();
            if (uname.Text == "admin" | label1.Text == "Admin")
            {
                ad.Visible = true;
                groupBox2.Visible = true;
            }
            else
            { 
                ad.Visible = false;
                groupBox2.Visible = false;
            }

        }



        private void exit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            String sql = "DELETE FROM basket";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();
            refcount2();
            recount2();
            MessageBox.Show("ออกจากระบบสำเร็จ", "ระบบ");
            this.Close();
        }

        private void hat_Click(object sender, EventArgs e)
        {
            printhis.Visible = false;
            groupBox1.Visible = false;
            panelh.Visible = false;
            clearhis.Visible = false;
            basketpan.Visible = false;
            checkBox1.Visible = false;
            adpanel.Visible = false;
            upanel.Visible = true;
            yu.Text = "หมวก";
            label3.Text = "หมวก";
            show();
            wantu.ResetText();
            textnameu.ResetText();
            textsizeu.ResetText();
            textamountu.ResetText();
            texttypeu.ResetText();
            textpriceu.ResetText();
            textnamead.ResetText();
            textsizead.ResetText();
            textamountad.ResetText();
            texttypead.ResetText();
            textpricead.ResetText();
            pictureBox2.Image = null;

        }

        private void top_Click(object sender, EventArgs e)
        {
            printhis.Visible = false;
            groupBox1.Visible = false;
            panelh.Visible = false;
            clearhis.Visible = false;
            basketpan.Visible = false;
            checkBox1.Visible = false;
            adpanel.Visible = false;
            upanel.Visible = true;
            yu.Text = "เสื้อ";
            label3.Text = "เสื้อ";
            show();
            wantu.ResetText();
            textnameu.ResetText();
            textsizeu.ResetText();
            textamountu.ResetText();
            texttypeu.ResetText();
            textpriceu.ResetText();
            textnamead.ResetText();
            textsizead.ResetText();
            textamountad.ResetText();
            texttypead.ResetText();
            textpricead.ResetText();
            pictureBox2.Image = null;
        }

        private void pants_Click(object sender, EventArgs e)
        {
            printhis.Visible = false;
            groupBox1.Visible = false;
            panelh.Visible = false;
            clearhis.Visible = false;
            basketpan.Visible = false;
            checkBox1.Visible = false;
            adpanel.Visible = false;
            upanel.Visible = true;
            yu.Text = "กางเกง";
            label3.Text = "กางเกง";
            show();
            wantu.ResetText();
            textnameu.ResetText();
            textsizeu.ResetText();
            textamountu.ResetText();
            texttypeu.ResetText();
            textpriceu.ResetText();
            textnamead.ResetText();
            textsizead.ResetText();
            textamountad.ResetText();
            texttypead.ResetText();
            textpricead.ResetText();
            pictureBox2.Image = null;
        }
        private void showall()
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();

            if (label3.Text == "หมวก")
                cmd.CommandText = "SELECT ID,Name,Type,Price,Amount FROM products";
            else
                cmd.CommandText = "SELECT ID,Name,Type,Price,Size,Amount FROM products";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataGrid.DataSource = ds.Tables[0].DefaultView;
        }
        private void show()
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID,Name,Type,Price,Size,Amount FROM products WHERE Type = '" + label3.Text + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataGrid.DataSource = ds.Tables[0].DefaultView;
        }
        private void show2()
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID,Name,Type,Price,Size,Amount FROM products WHERE Type = '" + texttypead.Text + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataGrid.DataSource = ds.Tables[0].DefaultView;
        }

        private void showbasket()
        {
            MySqlConnection conn = databaseConnection();


            DataSet ds = new DataSet();

            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Name,Size,Type,Price,Amount,รวม FROM basket WHERE username = '" + uname.Text + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataGrid.DataSource = ds.Tables[0].DefaultView;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            checkBox1.Visible = false;
            adpanel.Visible = false;
            upanel.Visible = true;
            basketpan.Visible = false;
            yu.Text = "All";
            label3.Text = "สินค้าทั้งหมด";
            showall();
        }

        private void ad_Click(object sender, EventArgs e)
        {
            printhis.Visible = false;
            groupBox1.Visible = false;
            panelh.Visible = false;
            texttypead.Items.Clear();
            texttypead.Items.Add("ทั้งหมด");
            texttypead.Items.Add("เสื้อ");
            texttypead.Items.Add("กางเกง");
            texttypead.Items.Add("หมวก");
            clearhis.Visible = false;
            checkBox1.Visible = false;
            basketpan.Visible = false;
            yu.Text = "Admin";
            label3.Text = "สินค้าทั้งหมด";
            showall();
            adpanel.Visible = true;
            upanel.Visible = false;
            textnamead.ResetText();
            textamountad.ResetText();
            textsizead.ResetText();
            textpricead.ResetText();
            texttypead.ResetText();
            fileBox.ResetText();
            pictureBox2.Image = null;
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = databaseConnection();

                byte[] image = null;
                pictureBox2.ImageLocation = fileBox.Text;
                string filepath = fileBox.Text;
                FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                image = br.ReadBytes((int)fs.Length);

                String sql = "INSERT INTO products (Name,Type,Price,Size,Amount,image) VALUES('" + textnamead.Text + "','" + texttypead.Text + "','" + textpricead.Text + "','" + textsizead.Text + "','" + textamountad.Text + "',@Imgg)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                cmd.Parameters.Add(new MySqlParameter("@Imgg", image));
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    MessageBox.Show("เพิ่มข้อมูลสำเร็จ", "ระบบ");
                    showall();
                }
                textnamead.ResetText();
                textnamead.ResetText();
                textamountad.ResetText();
                texttypead.ResetText();
                textpricead.ResetText();
            }
            catch
            {
                MessageBox.Show("เลือกรูป");
            }


        }
        private void editimg()
        {
            int selectedRow = dataGrid.CurrentCell.RowIndex;
            string editn = Convert.ToString(dataGrid.Rows[selectedRow].Cells["Name"].Value);

            byte[] image = null;
            pictureBox2.ImageLocation = fileBox.Text;
            string filepath = fileBox.Text;
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            image = br.ReadBytes((int)fs.Length);
            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE products SET image = @Imgg WHERE Name = '" + editn + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            cmd.Parameters.Add(new MySqlParameter("@Imgg", image));
            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("แก้ไขข้อมูลสำเร็จ", "ระบบ");
            showall();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGrid.CurrentCell.RowIndex;
            int editId = Convert.ToInt32(dataGrid.Rows[selectedRow].Cells["id"].Value);


            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE products SET Name = '" + textnamead.Text + "',Type = '" + texttypead.Text + "',Price = '" + textpricead.Text + "',Size = '" + textsizead.Text + "',Amount = '" + textamountad.Text + "' WHERE id = '" + editId + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            conn.Open();
            int rows = cmd.ExecuteNonQuery();

            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ", "ระบบ");
                showall();
            }

            textnamead.ResetText();
            textamountad.ResetText();
            texttypead.ResetText();
            textpricead.ResetText();
        }

        private void dele_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGrid.CurrentCell.RowIndex;
            int deleteId = Convert.ToInt32(dataGrid.Rows[selectedRow].Cells["id"].Value);

            MySqlConnection conn = databaseConnection();
            String sql = "DELETE FROM products WHERE id = '" + deleteId + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                MessageBox.Show("ลบข้อมูลสำเร็จ");
                showall();
            }
            textnamead.ResetText();
            textamountad.ResetText();
            texttypead.ResetText();
            textpricead.ResetText();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGrid.CurrentRow.Selected = true;
                delname.Text = dataGrid.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                amountx.Text = dataGrid.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();

                textnamead.Text = dataGrid.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                textamountad.Text = dataGrid.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();
                textpricead.Text = dataGrid.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                texttypead.Text = dataGrid.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();
                textsizead.Text = dataGrid.Rows[e.RowIndex].Cells["Size"].FormattedValue.ToString();

                textnameu.Text = dataGrid.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                textamountu.Text = dataGrid.Rows[e.RowIndex].Cells["Amount"].FormattedValue.ToString();
                textpriceu.Text = dataGrid.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                texttypeu.Text = dataGrid.Rows[e.RowIndex].Cells["Type"].FormattedValue.ToString();
                textsizeu.Text = dataGrid.Rows[e.RowIndex].Cells["Size"].FormattedValue.ToString();

                if (textamountu.Text == "0")
                    ABC.Enabled = false;
                else
                    ABC.Enabled = true;

                if (texttypead.Text == "เสื้อ" || texttypeu.Text == "เสื้อ")
                {
                    textsizeu.Items.Clear();
                    textsizeu.Items.Add("SS");
                    textsizeu.Items.Add("S");
                    textsizeu.Items.Add("M");
                    textsizeu.Items.Add("L");
                    textsizeu.Items.Add("XL");
                    textsizeu.Items.Add("2XL");
                    textsizeu.Items.Add("3XL");
                    textsizead.Items.Clear();
                    textsizead.Items.Add("SS");
                    textsizead.Items.Add("S");
                    textsizead.Items.Add("M");
                    textsizead.Items.Add("L");
                    textsizead.Items.Add("XL");
                    textsizead.Items.Add("2XL");
                    textsizead.Items.Add("3XL");
                }
                if (texttypead.Text == "กางเกง" || texttypeu.Text == "กางเกง")
                {
                    textsizeu.Items.Clear();
                    textsizeu.Items.Add("S");
                    textsizeu.Items.Add("M");
                    textsizeu.Items.Add("L");
                    textsizeu.Items.Add("XL");
                    textsizeu.Items.Add("2XL");
                    textsizead.Items.Clear();
                    textsizead.Items.Add("S");
                    textsizead.Items.Add("M");
                    textsizead.Items.Add("L");
                    textsizead.Items.Add("XL");
                    textsizead.Items.Add("2XL");
                }

                wantu.Text = "1";
                wantu.Items.Clear();
                for (int i = 1; i <= Convert.ToInt32(textamountad.Text); i++)
                {
                    wantu.Items.Add(i);
                }
                if (texttypead.Text == "หมวก" || textpriceu.Text == "หมวก")
                {
                    textsizead.Enabled = false;
                    textsizeu.Enabled = false;
                }
                else
                {
                    textsizead.Enabled = true;
                    textsizeu.Enabled = true;
                }
                string connection = "datasource=127.0.0.1;port=3306;username=root;password=;database=project_s;";
                MySqlConnection conn = new MySqlConnection(connection);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT image FROM products WHERE Name = '" + textnamead.Text + "'", conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["image"]);
                    pictureBox2.Image = new Bitmap(ms);
                }

                int selectedRow = dataGrid.CurrentCell.RowIndex;
                string editsize = Convert.ToString(dataGrid.Rows[selectedRow].Cells["Type"].Value);
                if (label3.Text == "ตะกร้า" || editsize == "เสื้อ" || editsize == "กางเกง")
                {
                    if (editsize == "หมวก")
                    {
                        bksize.Items.Clear();
                        bksize.ResetText();
                    }
                    else
                    {
                        bksize.Text = dataGrid.Rows[e.RowIndex].Cells["Size"].FormattedValue.ToString();
                        bksize.Items.Clear();
                        bksize.Items.Add("S");
                        bksize.Items.Add("M");
                        bksize.Items.Add("L");
                        bksize.Items.Add("XL");
                        bksize.Items.Add("2XL");
                    }
                }
                else { bksize.Text = ""; bksize.Items.Clear(); bksize.ResetText(); }
            }
            catch { }
        }

        private void search2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM products WHERE Name='{textnamead.Text}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            dataGrid.DataSource = ds.Tables[0].DefaultView;
        }

        private void search_Click_1(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM products WHERE Name like '%{textnameu.Text}%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            dataGrid.DataSource = ds.Tables[0].DefaultView;
        }
        private void basket1()
        {
            int xx = Convert.ToInt32(wantu.Text);
            int xx2 = Convert.ToInt32(textamountu.Text);
            string time = DateTime.Now.ToString("dd/MM/yyyy");
            MySqlConnection conn = databaseConnection();
            String sql = "INSERT INTO basket (Name,Size,Type,Price,Amount,รวม,username,time) VALUES('" + textnameu.Text + "','" + textsizeu.Text + "','" + texttypeu.Text + "','" + textpriceu.Text + "','" + wantu.Text + "',Price*Amount,'" + uname.Text + "','"+ time +"')";

            String sql2 = "UPDATE products SET Amount = '" + Convert.ToInt32(xx2 - xx) + "',count = '" + wantu.Text + "' WHERE Name = '" + textnameu.Text + "'AND Size = '" + textsizeu.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();
            int rows2 = cmd2.ExecuteNonQuery();

            conn.Close();
            if (rows > 0 || rows2 > 0)
            {
                
                MessageBox.Show("สินค้าถูกนำใส่ตะกร้าแล้ว", "ระบบ");
                if (label3.Text == "สินค้าทั้งหมด")
                    showall();
                else
                    show();
            }

            wantu.ResetText();
            textnameu.ResetText();
            textsizeu.ResetText();
            textamountu.ResetText();
            texttypeu.ResetText();
            textpriceu.ResetText();
            textnamead.ResetText();
            textsizead.ResetText();
            textamountad.ResetText();
            texttypead.ResetText();
            textpricead.ResetText();

        }


        private void ABC_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = databaseConnection();
                conn.Open();
                MySqlCommand cmd;

                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM products WHERE Name = '" + textnameu.Text + "'AND Size = '" + textsizeu.Text + "'";

                MySqlDataReader row = cmd.ExecuteReader();

                if (row.HasRows)
                {
                    basket1();
                }
                else
                {
                    MessageBox.Show("ไม่มีไซส์", "ระบบ");
                }
            }
            catch
            {
                MessageBox.Show("ระบุจำนวนเงิน", "ระบบ");
            }


        }

        private void XYZ_Click(object sender, EventArgs e)
        {
            printhis.Visible = false;
            groupBox1.Visible = false;
            panelh.Visible = false;
            pictureBox2.Image = null;
            MySqlConnection conn = databaseConnection();


            DataSet ds = new DataSet();

            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Name,Size,Type,Price,Amount,รวม FROM basket WHERE username = '" + uname.Text + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataGrid.DataSource = ds.Tables[0].DefaultView;

            int sum = 0;
            for (int i = 0; i < dataGrid.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGrid.Rows[i].Cells["รวม"].Value);
            }
            mn.Text = sum.ToString();

            delname.ResetText();
            clearhis.Visible = false;
            basketpan.Visible = true;
            checkBox1.Visible = false;
            adpanel.Visible = false;
            upanel.Visible = false;
            yu.Text = "ตะกร้า";
            label3.Text = "ตะกร้า";
            wantu.ResetText();
            textnameu.ResetText();
            textsizeu.ResetText();
            textamountu.ResetText();
            texttypeu.ResetText();
            textpriceu.ResetText();
            textnamead.ResetText();
            textsizead.ResetText();
            textamountad.ResetText();
            texttypead.ResetText();
            textpricead.ResetText();

        }

        private void his_Click(object sender, EventArgs e)
        {
            printhis.Visible = true;
            groupBox1.Visible = true;
            panelh.Visible = true;
            pictureBox2.Image = null;
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            if (checkBox1.Checked)
                cmd.CommandText = "SELECT username,Name,Size,Type,Price,Amount,time รวม FROM his";
            else
                cmd.CommandText = "SELECT Name,Size,Type,Price,Amount,รวม,username,time FROM his WHERE username = '" + uname.Text + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataGrid.DataSource = ds.Tables[0].DefaultView;



            if (uname.Text == "admin" | label1.Text == "Admin")
                checkBox1.Visible = true;
            else
                checkBox1.Visible = false;

            clearhis.Visible = true;
            basketpan.Visible = false;
            adpanel.Visible = false;
            upanel.Visible = false;
            yu.Text = "ประวัติ";
            label3.Text = "ประวัติ";
            wantu.ResetText();
            textnameu.ResetText();
            textsizeu.ResetText();
            textamountu.ResetText();
            texttypeu.ResetText();
            textpriceu.ResetText();
            textnamead.ResetText();
            textsizead.ResetText();
            textamountad.ResetText();
            texttypead.ResetText();
            textpricead.ResetText();

        }

        private void bil_Click(object sender, EventArgs e)
        {
            try
            {
                int m1 = Convert.ToInt32(money.Text);
                int m2 = Convert.ToInt32(mn.Text);
                if (m1 >= m2)
                {
                    MessageBox.Show("ชำระเงินสำเร็จ เงินทอน " + Convert.ToString(m1 - m2) + " บาท ", "ระบบ");
                    rmoney.Text = Convert.ToString(m1 - m2);
                    allbill.Clear();
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();

                    MySqlConnection conn = databaseConnection();
                    String sql = "INSERT INTO his SELECT * FROM basket";
                    String sql2 = "DELETE FROM basket";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                    conn.Open();

                    int rows = cmd.ExecuteNonQuery();
                    int rows2 = cmd2.ExecuteNonQuery();

                    conn.Close();
                    if (rows > 0 || rows2 > 0)
                        showbasket();

                    conn.Close();
                    /*refcount();*/
                    recount2();
                    mn.ResetText();
                    money.ResetText();
                    delname.ResetText();

                }
                else
                {
                    MessageBox.Show("จำนวนเงินไม่พอจ่าย!", "ระบบ");
                }
            }
            catch { MessageBox.Show("ระบุจำนวนเงิน", "ระบบ"); }
        }

        private void basketdel_Click(object sender, EventArgs e)
        {
            dataGrid.CurrentRow.Selected = true;
            int selectedRow = dataGrid.CurrentCell.RowIndex;
            string deletename = Convert.ToString(dataGrid.Rows[selectedRow].Cells["Name"].Value);
            int deleteamo = Convert.ToInt32(dataGrid.Rows[selectedRow].Cells["Amount"].Value);

            MySqlConnection conn = databaseConnection();
            String sql = "DELETE FROM basket WHERE Name = '" + deletename + "' AND Amount = '" + deleteamo + "'AND username = '" + uname.Text + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();

            conn.Close();

            if (rows > 0)
            {
                showbasket();
            }

            refcount();
            recount();
            delname.ResetText();
        }
        private void hiss()
        {
            MySqlConnection conn = databaseConnection();

            DataSet ds = new DataSet();

            conn.Open();

            MySqlCommand cmd;

            cmd = conn.CreateCommand();
            if (checkBox1.Checked)
                cmd.CommandText = "SELECT username,Name,Size,Type,Price,Amount,รวม,time FROM his";
            else
                cmd.CommandText = "SELECT Name,Size,Type,Price,Amount,รวม,time FROM his WHERE username = '" + uname.Text + "'";

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            conn.Close();

            dataGrid.DataSource = ds.Tables[0].DefaultView;
        }
        private void clearhis_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();

            String sql = "DELETE FROM his WHERE username = '" + uname.Text + "'";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            conn.Open();

            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                hiss();
            }

            conn.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            hiss();
        }

        private void money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void texttypead_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            if (texttypead.Text == "ทั้งหมด")
                cmd.CommandText = $"SELECT * FROM products";
            else
                cmd.CommandText = $"SELECT * FROM products WHERE Type like '%{texttypead.Text}%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            dataGrid.DataSource = ds.Tables[0].DefaultView;
        }

        private void bro_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(open.FileName);
                fileBox.Text = open.FileName;
            }
        }

        private void editam_Click(object sender, EventArgs e)
        {

            int selectedRow = dataGrid.CurrentCell.RowIndex;
            string editn = Convert.ToString(dataGrid.Rows[selectedRow].Cells["Name"].Value);

            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE basket SET Amount = '" + amountx.Text + "' WHERE Name = '" + editn + "'";
            String sql2 = "UPDATE basket SET รวม = Price*Amount WHERE Name = '" + editn + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            conn.Open();

            int rows = cmd.ExecuteNonQuery();
            int rows2 = cmd2.ExecuteNonQuery();
            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("แก้ไขข้อมูลสำเร็จ", "ระบบ");
                showbasket();
            }
            int sum = 0;
            for (int i = 0; i < dataGrid.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGrid.Rows[i].Cells["รวม"].Value);
            }
            mn.Text = sum.ToString();
            refcount();
            recountx();
            refcount3();

        }
        private List<PP> allbill = new List<PP>();
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int m1 = Convert.ToInt32(money.Text);
            int m2 = Convert.ToInt32(mn.Text);
            {
                e.Graphics.DrawString("ใบเสร็จ", new Font("supermarket", 20, FontStyle.Bold), Brushes.Black, new Point(400, 50));
                e.Graphics.DrawString("PANDA SHOP", new Font("supermarket", 24, FontStyle.Bold), Brushes.Black, new Point(300, 90));
                e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(525, 150));
                e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 285));
                e.Graphics.DrawString("    ลำดับ      ชื่อสินค้า                                             ราคา(บาท)       จำนวน", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 315));
                e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 345));
                int y = 345;
                loaddata();
                int number = 1;
                foreach (var i in allbill)
                {
                    y = y + 35;
                    e.Graphics.DrawString("   " + number.ToString(), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                    e.Graphics.DrawString("   " + i.name, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(180, y));
                    e.Graphics.DrawString("   " + i.amount, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(480, y));
                    e.Graphics.DrawString("   " + i.price, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(380, y));

                    number = number + 1;
                }
                e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, y + 30));
                e.Graphics.DrawString("รวมทั้งสิ้น         " + mn.Text + " บาท", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(570, (y + 30) + 45));
                e.Graphics.DrawString("ชื่อผู้ใช้บริการ        " + uname.Text, new Font("supermarket", 16, FontStyle.Bold), Brushes.Black, new Point(80, (y + 30) + 45));
                e.Graphics.DrawString("รับเงิน            " + money.Text + " บาท", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(570, ((y + 30) + 45) + 45));
                e.Graphics.DrawString("เงินทอน            " + Convert.ToString(m1 - m2) + " บาท", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(570, (((y + 30) + 45) + 45) + 45));

            }
        }
        private void loaddata()
        {
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_s;");

            conn.Open();

            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM basket  ", conn);
            MySqlDataReader adapter = cmd.ExecuteReader();

            while (adapter.Read())
            {
                Program.name = adapter.GetString("Name");
                Program.amount = adapter.GetString("Amount");
                Program.price = adapter.GetString("Price");

                PP item = new PP()
                {
                    name = Program.name,
                    amount = Program.amount,
                    price = Program.price,

                };
                allbill.Add(item);
            }
        }

        private void eimg_Click(object sender, EventArgs e)
        {
            editimg();
        }

        private void ab1_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
        }

        private void ab2_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
        }

        private void searcht_Click(object sender, EventArgs e)
        {

            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            if (texttypead.Text == "ทั้งหมด")
                cmd.CommandText = $"SELECT * FROM products";
            else
                cmd.CommandText = $"SELECT * FROM products WHERE Type='{texttypead.Text}'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            dataGrid.DataSource = ds.Tables[0].DefaultView;
        }

        private void editbksize()
        {
            int selectedRow = dataGrid.CurrentCell.RowIndex;
            string name = Convert.ToString(dataGrid.Rows[selectedRow].Cells["Name"].Value);
            string size = Convert.ToString(dataGrid.Rows[selectedRow].Cells["Size"].Value);
            int amount = Convert.ToInt32(dataGrid.Rows[selectedRow].Cells["Amount"].Value);

            MySqlConnection conn = databaseConnection();
            String sql = "UPDATE basket SET Size = '" + bksize.Text + "' WHERE Name = '" + name + "' AND Size = '" + size + "'";
            String sql2 = "UPDATE products SET Amount = Amount +'" + amount + "' WHERE Name = '" + name + "' AND Size = '" + size + "'";
            String sql3 = "UPDATE products SET Amount = Amount -'" + amount + "' WHERE Name = '" + name + "' AND Size = '" + bksize.Text + "'";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
            MySqlCommand cmd3 = new MySqlCommand(sql3, conn);

            conn.Open();
            int rows2 = cmd2.ExecuteNonQuery();
            int rows3 = cmd3.ExecuteNonQuery();
            int rows = cmd.ExecuteNonQuery();

            conn.Close();
            if (rows > 0)
            {
                MessageBox.Show("แก้ไขไซส์สำเร็จ", "ระบบ");
                showbasket();
            }
        }

        private void esize_Click(object sender, EventArgs e)
        {
            int selectedRow = dataGrid.CurrentCell.RowIndex;
            string name = Convert.ToString(dataGrid.Rows[selectedRow].Cells["Name"].Value);


            MySqlConnection conn = databaseConnection();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT * FROM products WHERE Name = '" + name + "'AND Size = '" + bksize.Text + "'";

            MySqlDataReader row = cmd.ExecuteReader();

            if (row.HasRows)
            {
                editbksize();
            }
            else
            {
                MessageBox.Show("ไม่มี", "ระบบ");
            }
            conn.Close();
        }

        private void checkstock_Click(object sender, EventArgs e)
        {
            allbill.Clear();
            printPreviewDialog1.Document = printcheckstock;
            printPreviewDialog1.ShowDialog();
        }

        private void printcheckstock_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("จำนวนสินค้า", new Font("supermarket", 20, FontStyle.Bold), Brushes.Black, new Point(330, 50));
            e.Graphics.DrawString("PANDA SHOP", new Font("supermarket", 24, FontStyle.Bold), Brushes.Black, new Point(300, 90));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(525, 150));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 285));
            e.Graphics.DrawString("    ลำดับ                ชื่อสินค้า                                             จำนวน(เหลือ)", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 315));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 345));
            int y = 345;
            datacheck();
            int number = 1;
            foreach (var i in allbill)
            {
                y = y + 35;
                e.Graphics.DrawString("   " + number.ToString(), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                e.Graphics.DrawString("   " + i.name, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(180, y));
                e.Graphics.DrawString("   " + i.amount, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(480, y));

                number = number + 1;
            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, y + 30));

        }
        private void datacheck()
        {
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_s;");

            conn.Open();

            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM products  ", conn);
            MySqlDataReader adapter = cmd.ExecuteReader();

            while (adapter.Read())
            {
                Program.name = adapter.GetString("Name");
                Program.amount = adapter.GetString("Amount");

                PP item = new PP()
                {
                    name = Program.name,
                    amount = Program.amount,

                };
                allbill.Add(item);
            }
        }

        private void basketpan_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ประวัติการซื้อ", new Font("supermarket", 20, FontStyle.Bold), Brushes.Black, new Point(310, 50));
            e.Graphics.DrawString("PANDA SHOP", new Font("supermarket", 24, FontStyle.Bold), Brushes.Black, new Point(300, 90));
            e.Graphics.DrawString("พิมพ์เมื่อ " + System.DateTime.Now.ToString("dd/MM/yyyy HH : mm : ss น."), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(525, 150));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 285));
            e.Graphics.DrawString("    ลำดับ             ชื่อผู้ซื้อ                   ชื่อสินค้า                           จำนวน            ราคา          เวลา", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 315));
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------------------", new Font("supermarket", 12, FontStyle.Regular), Brushes.Black, new Point(80, 345));
            int y = 345;
            datacheck2();
            int number = 1;
            foreach (var i in allbill)
            {
                y = y + 35;
                e.Graphics.DrawString("   " + number.ToString(), new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(100, y));
                e.Graphics.DrawString("   " + i.username, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(160, y));
                e.Graphics.DrawString("   " + i.name, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(280, y));
                e.Graphics.DrawString("   " + i.amount, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(500, y));
                e.Graphics.DrawString("   " + i.price, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(590, y));
                e.Graphics.DrawString("   " + i.time, new Font("supermarket", 14, FontStyle.Regular), Brushes.Black, new PointF(655, y));

                number = number + 1;
            }
            e.Graphics.DrawString("-----------------------------------------------------------------------------", new Font("supermarket", 16, FontStyle.Regular), Brushes.Black, new Point(80, y + 30));
        }
        private void datacheck2()
        {
            MySqlConnection conn = new MySqlConnection("host=127.0.0.1;username=root;password=;database=project_s;");

            conn.Open();

            MySqlCommand cmd = new MySqlCommand($"SELECT * FROM his WHERE username = '"+ uname.Text +"' ", conn);
            MySqlDataReader adapter = cmd.ExecuteReader();

            while (adapter.Read())
            {
                Program.username = adapter.GetString("username");
                Program.name = adapter.GetString("Name");
                Program.amount = adapter.GetString("Amount");
                Program.price = adapter.GetString("Price");
                Program.time = adapter.GetString("time");

                PP item = new PP()
                {
                    username = Program.username,
                    name = Program.name,
                    amount = Program.amount,
                    price = Program.price,
                    time = Program.time,

                };
                allbill.Add(item);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            if (checkBox1.Checked)
                cmd.CommandText = $"SELECT * FROM his WHERE time = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'";
            else
                cmd.CommandText = $"SELECT * FROM his WHERE time = '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'AND username = '" + uname.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            dataGrid.DataSource = ds.Tables[0].DefaultView;

        }
        private void searchhis_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            if(checkBox1.Checked)
                if(textBox1.Text == "")
                    cmd.CommandText = $"SELECT * FROM his WHERE time between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'and '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'";
                else
                    cmd.CommandText = $"SELECT * FROM his WHERE Name = '" + textBox1.Text + "'AND time between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'and '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'";
            else
                 if (textBox1.Text == "")
                    cmd.CommandText = $"SELECT * FROM his WHERE username = '" + uname.Text + "'AND time between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'and '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'";
                else
                    cmd.CommandText = $"SELECT * FROM his WHERE Name = '" + textBox1.Text + "'AND username = '" + uname.Text + "'AND time between '" + dateTimePicker1.Value.ToString("dd/MM/yyyy") + "'and '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            dataGrid.DataSource = ds.Tables[0].DefaultView;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            if (checkBox1.Checked)
                cmd.CommandText = $"SELECT * FROM his WHERE time = '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'";
            else
                cmd.CommandText = $"SELECT * FROM his WHERE time = '" + dateTimePicker2.Value.ToString("dd/MM/yyyy") + "'AND username = '" + uname.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            dataGrid.DataSource = ds.Tables[0].DefaultView;
        }

        private void printhis_Click(object sender, EventArgs e)
        {
            allbill.Clear();
            printPreviewDialog1.Document = printDocument2;
            printPreviewDialog1.ShowDialog();
        }

        private void textnameu_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM products WHERE Name like '%{textnameu.Text}%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            dataGrid.DataSource = ds.Tables[0].DefaultView;
        }

        private void textnamead_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM products WHERE Name like '%"+textnamead.Text+"%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            dataGrid.DataSource = ds.Tables[0].DefaultView;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            if(checkBox1.Checked)
                cmd.CommandText = $"SELECT * FROM his WHERE Name like '%{textBox1.Text}%'OR username like '%{textBox1.Text}%'";
            else
                cmd.CommandText = $"SELECT * FROM his WHERE Name like '%{textBox1.Text}%' AND username = '" + uname.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);

            dataGrid.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
