using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    partial class EmailWarning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.yes_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.textBox1.Location = new System.Drawing.Point(203, 77);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(409, 78);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "\r\nAre you sure that you want to permanently\r\ndelete this email address? ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yes_button
            // 
            this.yes_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.yes_button.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.yes_button.Location = new System.Drawing.Point(255, 206);
            this.yes_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yes_button.Name = "yes_button";
            this.yes_button.Size = new System.Drawing.Size(131, 44);
            this.yes_button.TabIndex = 1;
            this.yes_button.Text = "Yes";
            this.yes_button.UseVisualStyleBackColor = false;
            this.yes_button.Click += new System.EventHandler(this.yesButtonClick);
            // 
            // cancel_button
            // 
            this.cancel_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cancel_button.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.cancel_button.Location = new System.Drawing.Point(431, 206);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(131, 44);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = false;
            this.cancel_button.Click += new System.EventHandler(this.cancelButtonClick);
            // 
            // EmailWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.yes_button);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailWarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warning Window";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox textBox1;
        private Button yes_button;
        private Button cancel_button;
    }
}