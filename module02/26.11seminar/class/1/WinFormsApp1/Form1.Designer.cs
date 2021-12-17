
namespace WinFormsApp1
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
            this.FirstArr = new System.Windows.Forms.Button();
            this.ChangedButton = new System.Windows.Forms.Button();
            this.ArrText = new System.Windows.Forms.TextBox();
            this.ChangeSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstArr
            // 
            this.FirstArr.Location = new System.Drawing.Point(45, 48);
            this.FirstArr.Name = "FirstArr";
            this.FirstArr.Size = new System.Drawing.Size(238, 34);
            this.FirstArr.TabIndex = 0;
            this.FirstArr.Text = "Вывести исходный список";
            this.FirstArr.UseVisualStyleBackColor = true;
            this.FirstArr.Click += new System.EventHandler(this.FirstArr_Click);
            // 
            // ChangedButton
            // 
            this.ChangedButton.Location = new System.Drawing.Point(31, 295);
            this.ChangedButton.Name = "ChangedButton";
            this.ChangedButton.Size = new System.Drawing.Size(265, 34);
            this.ChangedButton.TabIndex = 1;
            this.ChangedButton.Text = "Показать измененный список";
            this.ChangedButton.UseVisualStyleBackColor = true;
            this.ChangedButton.Click += new System.EventHandler(this.ChangedButton_Click);
            // 
            // ArrText
            // 
            this.ArrText.Location = new System.Drawing.Point(58, 88);
            this.ArrText.Multiline = true;
            this.ArrText.Name = "ArrText";
            this.ArrText.Size = new System.Drawing.Size(212, 201);
            this.ArrText.TabIndex = 2;
            // 
            // ChangeSize
            // 
            this.ChangeSize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeSize.Location = new System.Drawing.Point(303, 172);
            this.ChangeSize.Name = "ChangeSize";
            this.ChangeSize.Size = new System.Drawing.Size(200, 30);
            this.ChangeSize.TabIndex = 3;
            this.ChangeSize.Text = "Уменьшить форму";
            this.ChangeSize.UseVisualStyleBackColor = true;
            this.ChangeSize.Click += new System.EventHandler(this.ChangeSize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChangeSize);
            this.Controls.Add(this.ArrText);
            this.Controls.Add(this.ChangedButton);
            this.Controls.Add(this.FirstArr);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(220, 100);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FirstArr;
        private System.Windows.Forms.Button ChangedButton;
        private System.Windows.Forms.TextBox ArrText;
        private System.Windows.Forms.Button ChangeSize;
    }
}

