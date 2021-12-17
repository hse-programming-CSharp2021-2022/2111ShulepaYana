using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rate rt = new Rate(0, 0);
        private void button_Click(object sender, EventArgs e)
        {
            rt.Hits++;
            hitsLabel.Text = rt.Hits.ToString();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            rt.Fails++;
            failsLabel.Text = rt.Fails.ToString();
        }
        int count = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                button.Visible = false;
            }
            else
            {
                button.Visible = true;
            }
            count++;
        }
    }
    class Rate
    {
        public uint Hits { get; set; }
        public uint Fails { get; set; }
        public Rate(uint h, uint f)
        {
            Hits = h;
            Fails = f;
        }
    }
}
