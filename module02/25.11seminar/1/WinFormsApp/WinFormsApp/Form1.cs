using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstButton.Visible = false;
            SecondButton.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecondButton.Visible = false;
            ThirdButton.Visible = true;
        }
        int p1 = 1;
        int p2 = 2;

        private void button1_Click_1(object sender, EventArgs e)
        {
            int p3 = p1 + p2;
            label1.Text = "Член ряда Пелла: " + p3;
            p1 = p2;
            p2 = p3;
            if (p3 < 0)
            {
                p1 = 1; p2 = 2; p3 = 1;
                MessageBox.Show("Емае");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Enabled)
                label1.Text = "Ну и зачем...";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FifthButton.Visible = false;
            FirstButton.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ThirdButton.Visible = false;
            ForthButton.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ForthButton.Visible = false;
            FifthButton.Visible = true;
        }
    }
}
