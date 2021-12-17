
namespace _10
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
            this.components = new System.ComponentModel.Container();
            this.button = new System.Windows.Forms.Button();
            this.failsLabel = new System.Windows.Forms.Label();
            this.hitsLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(313, 144);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(157, 67);
            this.button.TabIndex = 0;
            this.button.Text = "Нажми";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // failsLabel
            // 
            this.failsLabel.AutoSize = true;
            this.failsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.failsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.failsLabel.Location = new System.Drawing.Point(150, 302);
            this.failsLabel.Name = "failsLabel";
            this.failsLabel.Size = new System.Drawing.Size(22, 25);
            this.failsLabel.TabIndex = 1;
            this.failsLabel.Text = "0";
            // 
            // hitsLabel
            // 
            this.hitsLabel.AutoSize = true;
            this.hitsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.hitsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hitsLabel.Location = new System.Drawing.Point(561, 302);
            this.hitsLabel.Name = "hitsLabel";
            this.hitsLabel.Size = new System.Drawing.Size(22, 25);
            this.hitsLabel.TabIndex = 2;
            this.hitsLabel.Text = "0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hitsLabel);
            this.Controls.Add(this.failsLabel);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label failsLabel;
        private System.Windows.Forms.Label hitsLabel;
        private System.Windows.Forms.Timer timer;
    }
}

