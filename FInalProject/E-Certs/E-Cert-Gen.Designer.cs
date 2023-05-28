using System.Drawing;
using System.Windows.Forms;

namespace FinalProject.E_Certs
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
            this.po_gen_ecert = new System.Windows.Forms.CheckedListBox();
            this.ecert_send_as_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ecert_make_qty = new System.Windows.Forms.NumericUpDown();
            this.b_gen_cert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ecert_make_qty)).BeginInit();
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
            // po_gen_ecert
            // 
            this.po_gen_ecert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.po_gen_ecert.FormattingEnabled = true;
            this.po_gen_ecert.Items.AddRange(new object[] {
            "1234",
            "5678",
            "91011"});
            this.po_gen_ecert.Location = new System.Drawing.Point(93, 5);
            this.po_gen_ecert.Margin = new System.Windows.Forms.Padding(5);
            this.po_gen_ecert.Name = "po_gen_ecert";
            this.po_gen_ecert.Size = new System.Drawing.Size(272, 124);
            this.po_gen_ecert.TabIndex = 2;
            // 
            // ecert_send_as_input
            // 
            this.ecert_send_as_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ecert_send_as_input.Location = new System.Drawing.Point(93, 159);
            this.ecert_send_as_input.Margin = new System.Windows.Forms.Padding(5);
            this.ecert_send_as_input.Name = "ecert_send_as_input";
            this.ecert_send_as_input.Size = new System.Drawing.Size(228, 29);
            this.ecert_send_as_input.TabIndex = 3;
            this.ecert_send_as_input.Text = "name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(3, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 48);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(3, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cert Qty:";
            // 
            // ecert_make_qty
            // 
            this.ecert_make_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ecert_make_qty.Location = new System.Drawing.Point(93, 236);
            this.ecert_make_qty.Margin = new System.Windows.Forms.Padding(5);
            this.ecert_make_qty.Name = "ecert_make_qty";
            this.ecert_make_qty.Size = new System.Drawing.Size(82, 29);
            this.ecert_make_qty.TabIndex = 7;
            this.ecert_make_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // b_gen_cert
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.b_gen_cert, 2);
            this.b_gen_cert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.b_gen_cert.Location = new System.Drawing.Point(5, 313);
            this.b_gen_cert.Margin = new System.Windows.Forms.Padding(5);
            this.b_gen_cert.Name = "b_gen_cert";
            this.b_gen_cert.Size = new System.Drawing.Size(374, 33);
            this.b_gen_cert.TabIndex = 8;
            this.b_gen_cert.Text = "Generate E-Cert";
            this.b_gen_cert.UseVisualStyleBackColor = true;
            this.b_gen_cert.Click += new System.EventHandler(this.b_gen_cert_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.91667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.08334F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.po_gen_ecert, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ecert_send_as_input, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ecert_make_qty, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.b_gen_cert, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 385);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // E_Cert_Gen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 378);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "E_Cert_Gen";
            this.Text = "E-Cert";
            ((System.ComponentModel.ISupportInitialize)(this.ecert_make_qty)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private CheckedListBox po_gen_ecert;
        private TextBox ecert_send_as_input;
        private Label label2;
        private Label label3;
        private NumericUpDown ecert_make_qty;
        private Button b_gen_cert;
        private TableLayoutPanel tableLayoutPanel1;
    }
}