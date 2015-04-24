using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace richh_txt_box_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile( " C:/Users/user/Desktop/rtbf.txt",RichTextBoxStreamType.PlainText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(" C:/Users/user/Desktop/rtbf.txt", RichTextBoxStreamType.PlainText);
        }
    }
}
