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
            this.label1 = new System.Windows.Forms.Label();
            this.send_email_send_ecert = new System.Windows.Forms.TextBox();
            this.cust_send_ecert = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cc_send_ecert = new System.Windows.Forms.ListBox();
            this.button_send_ecert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send as:";
            // 
            // send_email_send_ecert
            // 
            this.send_email_send_ecert.Location = new System.Drawing.Point(103, 12);
            this.send_email_send_ecert.Name = "send_email_send_ecert";
            this.send_email_send_ecert.Size = new System.Drawing.Size(213, 20);
            this.send_email_send_ecert.TabIndex = 2;
            this.send_email_send_ecert.Text = "default_email";
            // 
            // cust_send_ecert
            // 
            this.cust_send_ecert.FormattingEnabled = true;
            this.cust_send_ecert.Location = new System.Drawing.Point(103, 38);
            this.cust_send_ecert.Name = "cust_send_ecert";
            this.cust_send_ecert.Size = new System.Drawing.Size(213, 82);
            this.cust_send_ecert.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customer Emails:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CC:";
            // 
            // cc_send_ecert
            // 
            this.cc_send_ecert.FormattingEnabled = true;
            this.cc_send_ecert.Location = new System.Drawing.Point(103, 126);
            this.cc_send_ecert.Name = "cc_send_ecert";
            this.cc_send_ecert.Size = new System.Drawing.Size(213, 82);
            this.cc_send_ecert.TabIndex = 7;
            // 
            // button_send_ecert
            // 
            this.button_send_ecert.Location = new System.Drawing.Point(51, 224);
            this.button_send_ecert.Name = "button_send_ecert";
            this.button_send_ecert.Size = new System.Drawing.Size(213, 33);
            this.button_send_ecert.TabIndex = 8;
            this.button_send_ecert.Text = "Send E-Cert";
            this.button_send_ecert.UseVisualStyleBackColor = true;
            // 
            // E_Cert_Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 276);
            this.Controls.Add(this.button_send_ecert);
            this.Controls.Add(this.cc_send_ecert);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cust_send_ecert);
            this.Controls.Add(this.send_email_send_ecert);
            this.Controls.Add(this.label1);
            this.Name = "E_Cert_Send";
            this.Text = "E_Cert_Send";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox send_email_send_ecert;
        private System.Windows.Forms.ListBox cust_send_ecert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox cc_send_ecert;
        private System.Windows.Forms.Button button_send_ecert;
    }
}