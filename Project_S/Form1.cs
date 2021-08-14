using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Visible = true;
            userControl21.Visible = false;
            Size = new Size(449, 392);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.Visible = true;
            userControl21.Visible = false;
            Size = new Size(449, 392);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl11.Visible = false;
            userControl21.Visible = true;
            Size = new Size(449, 528);
        }
    }
}
