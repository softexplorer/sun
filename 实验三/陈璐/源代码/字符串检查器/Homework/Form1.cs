using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random ();
            label1.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            label2.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            label3.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            label4.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            label5.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            label6.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
            label7.ForeColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox3.Text.Length == 0)
                MessageBox.Show("请先输入要计算的数");
            else
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox3.Text);
                double sum = Math.Log(a, b);
                textBox2.Text = sum.ToString();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox3.Text.Length == 0)
                MessageBox.Show("请先输入要计算的数");
            else
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox3.Text);
                double sum = Math.Pow(a, 1.0 / b);
                textBox2.Text = sum.ToString();
            }
        }
    }
}
