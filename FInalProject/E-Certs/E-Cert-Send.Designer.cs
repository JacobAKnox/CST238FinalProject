namespace FInalProject.E_Certs
{
    partial class E_Cert_Send
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cc_send_ecert = new System.Windows.Forms.ListBox();
            this.cust_send_ecert = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.send_email_send_ecert = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.b_send_ecert = new System.Windows.Forms.Button();
            this.b_edit_group_ce = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.b_edit_group_ce, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cc_send_ecert, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cust_send_ecert, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.send_email_send_ecert, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.b_send_ecert, 1, 3);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(589, 581);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // cc_send_ecert
            // 
            this.cc_send_ecert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cc_send_ecert.FormattingEnabled = true;
            this.cc_send_ecert.ItemHeight = 24;
            this.cc_send_ecert.Location = new System.Drawing.Point(120, 283);
            this.cc_send_ecert.Name = "cc_send_ecert";
            this.cc_send_ecert.Size = new System.Drawing.Size(406, 220);
            this.cc_send_ecert.TabIndex = 17;
            // 
            // cust_send_ecert
            // 
            this.cust_send_ecert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cust_send_ecert.FormattingEnabled = true;
            this.cust_send_ecert.ItemHeight = 24;
            this.cust_send_ecert.Location = new System.Drawing.Point(120, 45);
            this.cust_send_ecert.Name = "cust_send_ecert";
            this.cust_send_ecert.Size = new System.Drawing.Size(406, 220);
            this.cust_send_ecert.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(3, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "CC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(3, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 48);
            this.label8.TabIndex = 15;
            this.label8.Text = "Customer Emails:";
            // 
            // send_email_send_ecert
            // 
            this.send_email_send_ecert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.send_email_send_ecert.Location = new System.Drawing.Point(120, 3);
            this.send_email_send_ecert.Name = "send_email_send_ecert";
            this.send_email_send_ecert.Size = new System.Drawing.Size(406, 29);
            this.send_email_send_ecert.TabIndex = 14;
            this.send_email_send_ecert.Text = "default_email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 24);
            this.label9.TabIndex = 13;
            this.label9.Text = "Send as:";
            // 
            // b_send_ecert
            // 
            this.b_send_ecert.AutoSize = true;
            this.b_send_ecert.Location = new System.Drawing.Point(122, 523);
            this.b_send_ecert.Margin = new System.Windows.Forms.Padding(5);
            this.b_send_ecert.Name = "b_send_ecert";
            this.b_send_ecert.Size = new System.Drawing.Size(396, 53);
            this.b_send_ecert.TabIndex = 8;
            this.b_send_ecert.Text = "Send E-Cert";
            this.b_send_ecert.UseVisualStyleBackColor = true;
            // 
            // b_edit_group_ce
            // 
            this.b_edit_group_ce.AutoSize = true;
            this.b_edit_group_ce.Location = new System.Drawing.Point(532, 45);
            this.b_edit_group_ce.Name = "b_edit_group_ce";
            this.b_edit_group_ce.Size = new System.Drawing.Size(41, 36);
            this.b_edit_group_ce.TabIndex = 14;
            this.b_edit_group_ce.Text = "⚙";
            this.b_edit_group_ce.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(532, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "⚙";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(532, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "🔓";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // E_Cert_Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 621);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "E_Cert_Send";
            this.Text = "E_Cert_Send";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button b_edit_group_ce;
        private System.Windows.Forms.ListBox cc_send_ecert;
        private System.Windows.Forms.ListBox cust_send_ecert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox send_email_send_ecert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button b_send_ecert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}