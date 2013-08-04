using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TkMultiMonitoringBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new Point(Convert.ToInt16(textBox1.Text), Convert.ToInt16(textBox2.Text));
            this.Size = new Size(Convert.ToInt16(textBox3.Text), Convert.ToInt16(textBox4.Text));

            groupBox1.Visible = false;
            webBrowser1.Visible = true;
            webBrowser1.Url = new Uri(textBox5.Text);
           // webBrowser1.

        }
    }
}
