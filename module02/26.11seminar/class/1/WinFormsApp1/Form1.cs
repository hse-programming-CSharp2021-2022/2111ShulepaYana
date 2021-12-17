using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] strs = new string[] { "one", "two", "three" };
        private void FirstArr_Click(object sender, EventArgs e)
        {
            ArrText.Lines = strs;
        }

        private void ChangedButton_Click(object sender, EventArgs e)
        {
            string[] str2 = ArrText.Lines;
            string.Join(" ", str2);
            MessageBox.Show(string.Join(" ", str2));
        }
        int mode = 1;
        private void ChangeSize_Click(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                if (((int)(this.Size.Width * 1.4) < this.MaximumSize.Width) && ((int)(this.Size.Height * 1.4) < this.MaximumSize.Height))
                {
                    this.Size = new Size((int)(this.Size.Width * 1.4), (int)(this.Size.Height * 1.4));
                }
                else
                {
                    mode = 2;
                    ChangeSize.Text = "Уменьшить форму";
                }
            }
            else
            {
                if (((int)(this.Size.Width / 1.4) > this.MinimumSize.Width) && ((int)(this.Size.Height / 1.4) > this.MinimumSize.Height))
                {
                    this.Size = new Size((int)(this.Size.Width / 1.4), (int)(this.Size.Height / 1.4));
                }
                else
                {
                    mode = 1;
                    ChangeSize.Text = "Увеличить форму";
                }
            }
        }
    }
 }
