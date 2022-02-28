using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6_3
{
    public partial class Form1 : Form
    {

        string[] aryStr = { "多聽多看少說話", "快手快腳慢用錢" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Lines = aryStr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Lines[0];
            label2.Text = textBox1.Lines[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Dock = DockStyle.Top;
            label2.Dock = DockStyle.Bottom;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label1.Dock = DockStyle.None;
            label2.Dock = DockStyle.None;
        }
    }
}
