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
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.b_gen_cert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gen_ecert_progress_bar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "PO:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(99, 5);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(228, 220);
            this.checkedListBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(99, 240);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(3, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(3, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cert Qty:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDown1.Location = new System.Drawing.Point(99, 288);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(5);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(82, 29);
            this.numericUpDown1.TabIndex = 7;
            // 
            // b_gen_cert
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.b_gen_cert, 2);
            this.b_gen_cert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.b_gen_cert.Location = new System.Drawing.Point(5, 327);
            this.b_gen_cert.Margin = new System.Windows.Forms.Padding(5);
            this.b_gen_cert.Name = "b_gen_cert";
            this.b_gen_cert.Size = new System.Drawing.Size(306, 33);
            this.b_gen_cert.TabIndex = 8;
            this.b_gen_cert.Text = "Generate E-Cert";
            this.b_gen_cert.UseVisualStyleBackColor = true;
            this.b_gen_cert.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.48101F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.51899F));
            this.tableLayoutPanel1.Controls.Add(this.gen_ecert_progress_bar, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.b_gen_cert, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 385);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // gen_ecert_progress_bar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.gen_ecert_progress_bar, 2);
            this.gen_ecert_progress_bar.Location = new System.Drawing.Point(3, 368);
            this.gen_ecert_progress_bar.Name = "gen_ecert_progress_bar";
            this.gen_ecert_progress_bar.Size = new System.Drawing.Size(326, 14);
            this.gen_ecert_progress_bar.TabIndex = 13;
            // 
            // E_Cert_Gen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 404);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "E_Cert_Gen";
            this.Text = "E-Cert";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private CheckedListBox checkedListBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button b_gen_cert;
        private TableLayoutPanel tableLayoutPanel1;
        private ProgressBar gen_ecert_progress_bar;
    }
}