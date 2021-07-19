using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyPainter2
{
    public partial class StringWrite : Form
    {
        public string strwrite;
        public bool Check;
        public StringWrite()
        {
            InitializeComponent();
            Check = false;       //判断是否选择字体
            strwrite = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strwrite = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            strwrite = textBox1.Text;
            Check = true;
            this.Close();
        }
    }
}
