using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu5._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("尼玛个傻逼");
            button1.Enabled = false;
            button1.Visible = false;
            this.button1.Location = new Point(210, 150);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("滚你丫");
            this.button2.Size = new Size(88, 55);
            button2.BackColor = Color.Red;
            this.button2.Location = new Point(150, 211);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("有病吧");
            this.button3.Enabled = false;

        }
    }
}