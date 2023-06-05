namespace FinalProject.E_Certs
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ecert_send_send_as = new System.Windows.Forms.TextBox();
            this.ecert_send_customers = new System.Windows.Forms.CheckedListBox();
            this.ecert_send_cc = new System.Windows.Forms.CheckedListBox();
            this.ecert_send_ecert = new System.Windows.Forms.Button();
            this.ecery_edit_permanant_group = new System.Windows.Forms.Button();
            this.ecert_confirm_send_data = new System.Windows.Forms.CheckBox();
            this.ecert_group_edit_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ecert_send_warning_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.98044F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.02608F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.99348F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ecert_send_send_as, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.ecert_send_customers, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ecert_send_cc, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ecert_send_ecert, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.ecery_edit_permanant_group, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.ecert_confirm_send_data, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.ecert_send_warning_label, 1, 5);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.47942F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.53282F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.98776F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(613, 634);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(3, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "CC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(3, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 48);
            this.label8.TabIndex = 15;
            this.label8.Text = "Customer Emails:";
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
            // ecert_send_send_as
            // 
            this.ecert_send_send_as.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ecert_send_send_as.Location = new System.Drawing.Point(125, 3);
            this.ecert_send_send_as.Name = "ecert_send_send_as";
            this.ecert_send_send_as.Size = new System.Drawing.Size(392, 29);
            this.ecert_send_send_as.TabIndex = 14;
            this.ecert_send_send_as.Text = "default_email";
            // 
            // ecert_send_customers
            // 
            this.ecert_send_customers.FormattingEnabled = true;
            this.ecert_send_customers.Location = new System.Drawing.Point(125, 58);
            this.ecert_send_customers.Name = "ecert_send_customers";
            this.ecert_send_customers.Size = new System.Drawing.Size(392, 220);
            this.ecert_send_customers.TabIndex = 19;
            this.ecert_send_customers.SelectedIndexChanged += new System.EventHandler(this.ecert_send_customers_SelectedIndexChanged);
            // 
            // ecert_send_cc
            // 
            this.ecert_send_cc.FormattingEnabled = true;
            this.ecert_send_cc.Location = new System.Drawing.Point(125, 284);
            this.ecert_send_cc.Name = "ecert_send_cc";
            this.ecert_send_cc.Size = new System.Drawing.Size(392, 220);
            this.ecert_send_cc.TabIndex = 20;
            this.ecert_send_cc.SelectedIndexChanged += new System.EventHandler(this.ecert_send_cc_SelectedIndexChanged);
            // 
            // ecert_send_ecert
            // 
            this.ecert_send_ecert.AutoSize = true;
            this.ecert_send_ecert.Enabled = false;
            this.ecert_send_ecert.Location = new System.Drawing.Point(127, 554);
            this.ecert_send_ecert.Margin = new System.Windows.Forms.Padding(5);
            this.ecert_send_ecert.Name = "ecert_send_ecert";
            this.ecert_send_ecert.Size = new System.Drawing.Size(388, 32);
            this.ecert_send_ecert.TabIndex = 8;
            this.ecert_send_ecert.Text = "Send E-Cert";
            this.ecert_send_ecert.UseVisualStyleBackColor = true;
            this.ecert_send_ecert.Click += new System.EventHandler(this.ecert_send_ecert_Click);
            // 
            // ecery_edit_permanant_group
            // 
            this.ecery_edit_permanant_group.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ecery_edit_permanant_group.AutoSize = true;
            this.ecery_edit_permanant_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.ecery_edit_permanant_group.Location = new System.Drawing.Point(545, 3);
            this.ecery_edit_permanant_group.Name = "ecery_edit_permanant_group";
            this.ecery_edit_permanant_group.Size = new System.Drawing.Size(65, 49);
            this.ecery_edit_permanant_group.TabIndex = 14;
            this.ecery_edit_permanant_group.Text = "⚙";
            this.ecery_edit_permanant_group.UseVisualStyleBackColor = true;
            this.ecery_edit_permanant_group.Click += new System.EventHandler(this.ecery_edit_permanant_group_Click);
            // 
            // ecert_confirm_send_data
            // 
            this.ecert_confirm_send_data.AutoSize = true;
            this.ecert_confirm_send_data.Location = new System.Drawing.Point(125, 510);
            this.ecert_confirm_send_data.Name = "ecert_confirm_send_data";
            this.ecert_confirm_send_data.Size = new System.Drawing.Size(258, 28);
            this.ecert_confirm_send_data.TabIndex = 21;
            this.ecert_confirm_send_data.Text = "Confirm recipeints of E-Cert";
            this.ecert_confirm_send_data.UseVisualStyleBackColor = true;
            this.ecert_confirm_send_data.CheckedChanged += new System.EventHandler(this.ecert_confirm_send_data_CheckedChanged);
            // 
            // ecert_send_warning_label
            // 
            this.ecert_send_warning_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ecert_send_warning_label.AutoSize = true;
            this.ecert_send_warning_label.ForeColor = System.Drawing.Color.Red;
            this.ecert_send_warning_label.Location = new System.Drawing.Point(205, 600);
            this.ecert_send_warning_label.Name = "ecert_send_warning_label";
            this.ecert_send_warning_label.Size = new System.Drawing.Size(231, 24);
            this.ecert_send_warning_label.TabIndex = 22;
            this.ecert_send_warning_label.Text = "ecert_send_warning_label";
            this.ecert_send_warning_label.Visible = false;
            // 
            // E_Cert_Send
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 645);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "E_Cert_Send";
            this.Text = "E_Cert_Send";
            this.Load += new System.EventHandler(this.E_Cert_Send_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button ecery_edit_permanant_group;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ecert_send_send_as;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ecert_send_ecert;
        private System.Windows.Forms.CheckedListBox ecert_send_customers;
        private System.Windows.Forms.CheckedListBox ecert_send_cc;
        private System.Windows.Forms.ToolTip ecert_group_edit_tooltip;
        private System.Windows.Forms.CheckBox ecert_confirm_send_data;
        private System.Windows.Forms.Label ecert_send_warning_label;
    }
}