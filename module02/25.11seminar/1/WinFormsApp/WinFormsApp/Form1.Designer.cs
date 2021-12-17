
namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstButton = new System.Windows.Forms.Button();
            this.SecondButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ThirdButton = new System.Windows.Forms.Button();
            this.ForthButton = new System.Windows.Forms.Button();
            this.FifthButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(143, 30);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(132, 34);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "Нажмите пж\r\n";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SecondButton
            // 
            this.SecondButton.Location = new System.Drawing.Point(504, 30);
            this.SecondButton.Name = "SecondButton";
            this.SecondButton.Size = new System.Drawing.Size(140, 34);
            this.SecondButton.TabIndex = 1;
            this.SecondButton.Text = "Нажмите пж 2";
            this.SecondButton.UseVisualStyleBackColor = true;
            this.SecondButton.Visible = false;
            this.SecondButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Член ряда Пелла: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Следующий член ряда";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 409);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(145, 29);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Не нажимать";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ThirdButton
            // 
            this.ThirdButton.Location = new System.Drawing.Point(605, 312);
            this.ThirdButton.Name = "ThirdButton";
            this.ThirdButton.Size = new System.Drawing.Size(158, 34);
            this.ThirdButton.TabIndex = 5;
            this.ThirdButton.Text = "Нажмите пж 3";
            this.ThirdButton.UseVisualStyleBackColor = true;
            this.ThirdButton.Visible = false;
            this.ThirdButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ForthButton
            // 
            this.ForthButton.Location = new System.Drawing.Point(54, 159);
            this.ForthButton.Name = "ForthButton";
            this.ForthButton.Size = new System.Drawing.Size(146, 34);
            this.ForthButton.TabIndex = 6;
            this.ForthButton.Text = "Нажмите пж 4";
            this.ForthButton.UseVisualStyleBackColor = true;
            this.ForthButton.Visible = false;
            this.ForthButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // FifthButton
            // 
            this.FifthButton.Location = new System.Drawing.Point(631, 100);
            this.FifthButton.Name = "FifthButton";
            this.FifthButton.Size = new System.Drawing.Size(144, 34);
            this.FifthButton.TabIndex = 7;
            this.FifthButton.Text = "Нажмите пж 5";
            this.FifthButton.UseVisualStyleBackColor = true;
            this.FifthButton.Visible = false;
            this.FifthButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FifthButton);
            this.Controls.Add(this.ForthButton);
            this.Controls.Add(this.ThirdButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecondButton);
            this.Controls.Add(this.FirstButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button SecondButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ThirdButton;
        private System.Windows.Forms.Button ForthButton;
        private System.Windows.Forms.Button FifthButton;
    }
}

