using System.Drawing;
using System.Windows.Forms;

namespace FInalProject.E_Certs
{
    partial class E_Cert_Gen
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 12);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 1;
            label1.Text = "PO:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(90, 12);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(177, 184);
            checkedListBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 202);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 202);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 4;
            label2.Text = "Enter Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 231);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Cert Qty:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(90, 231);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(64, 23);
            numericUpDown1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(30, 260);
            button1.Name = "button1";
            button1.Size = new Size(209, 23);
            button1.TabIndex = 8;
            button1.Text = "Generate E-Cert";
            button1.UseVisualStyleBackColor = true;
            // 
            // E-Cert-Gen-Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 450);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Name = "E-Cert-Gen-Window";
            Text = "E-Cert";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private CheckedListBox checkedListBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button button1;
    }
}