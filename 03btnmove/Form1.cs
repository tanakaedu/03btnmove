using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _03btnmove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // textBoxからintの変数に値を取得
                int vx = int.Parse(textBox1.Text);
                int vy = int.Parse(textBox2.Text);

                // ラベルの座標に加算
                label1.Left = label1.Left + vx;
                label1.Top = label1.Top + vy;

                if ((label1.Left < 0) || (label1.Left+label1.Width > ClientSize.Width)){
                    label1.Left -= vx;
                    textBox1.Text = (-vx).ToString();
                }
            }
            catch (Exception ee) 
            { 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "-15";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-15";
            textBox2.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "15";
            textBox2.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "15";
        }
    }
}
