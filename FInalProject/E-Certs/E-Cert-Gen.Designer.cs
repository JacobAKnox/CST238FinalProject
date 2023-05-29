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
            this.ecert_po_label = new System.Windows.Forms.Label();
            this.ecert_po_selection = new System.Windows.Forms.CheckedListBox();
            this.ecert_send_as_input = new System.Windows.Forms.TextBox();
            this.ecert_send_as_input_label = new System.Windows.Forms.Label();
            this.ecert_cert_quantity_label = new System.Windows.Forms.Label();
            this.ecert_set_qty = new System.Windows.Forms.NumericUpDown();
            this.ecert_generate_ecert = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ecert_set_qty)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ecert_po_label
            // 
            this.ecert_po_label.AutoSize = true;
            this.ecert_po_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ecert_po_label.Location = new System.Drawing.Point(3, 0);
            this.ecert_po_label.Name = "ecert_po_label";
            this.ecert_po_label.Size = new System.Drawing.Size(42, 24);
            this.ecert_po_label.TabIndex = 1;
            this.ecert_po_label.Text = "PO:";
            // 
            // ecert_po_selection
            // 
            this.ecert_po_selection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ecert_po_selection.FormattingEnabled = true;
            this.ecert_po_selection.Items.AddRange(new object[] {
            "1234",
            "5678",
            "91011"});
            this.ecert_po_selection.Location = new System.Drawing.Point(93, 5);
            this.ecert_po_selection.Margin = new System.Windows.Forms.Padding(5);
            this.ecert_po_selection.Name = "ecert_po_selection";
            this.ecert_po_selection.Size = new System.Drawing.Size(272, 124);
            this.ecert_po_selection.TabIndex = 2;
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
            // ecert_send_as_input_label
            // 
            this.ecert_send_as_input_label.AutoSize = true;
            this.ecert_send_as_input_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ecert_send_as_input_label.Location = new System.Drawing.Point(3, 154);
            this.ecert_send_as_input_label.Name = "ecert_send_as_input_label";
            this.ecert_send_as_input_label.Size = new System.Drawing.Size(66, 48);
            this.ecert_send_as_input_label.TabIndex = 4;
            this.ecert_send_as_input_label.Text = "Enter Name:";
            // 
            // ecert_cert_quantity_label
            // 
            this.ecert_cert_quantity_label.AutoSize = true;
            this.ecert_cert_quantity_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ecert_cert_quantity_label.Location = new System.Drawing.Point(3, 231);
            this.ecert_cert_quantity_label.Name = "ecert_cert_quantity_label";
            this.ecert_cert_quantity_label.Size = new System.Drawing.Size(82, 24);
            this.ecert_cert_quantity_label.TabIndex = 6;
            this.ecert_cert_quantity_label.Text = "Cert Qty:";
            // 
            // ecert_set_qty
            // 
            this.ecert_set_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ecert_set_qty.Location = new System.Drawing.Point(93, 236);
            this.ecert_set_qty.Margin = new System.Windows.Forms.Padding(5);
            this.ecert_set_qty.Name = "ecert_set_qty";
            this.ecert_set_qty.Size = new System.Drawing.Size(82, 29);
            this.ecert_set_qty.TabIndex = 7;
            this.ecert_set_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ecert_generate_ecert
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ecert_generate_ecert, 2);
            this.ecert_generate_ecert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ecert_generate_ecert.Location = new System.Drawing.Point(5, 313);
            this.ecert_generate_ecert.Margin = new System.Windows.Forms.Padding(5);
            this.ecert_generate_ecert.Name = "ecert_generate_ecert";
            this.ecert_generate_ecert.Size = new System.Drawing.Size(374, 33);
            this.ecert_generate_ecert.TabIndex = 8;
            this.ecert_generate_ecert.Text = "Generate E-Cert";
            this.ecert_generate_ecert.UseVisualStyleBackColor = true;
            this.ecert_generate_ecert.Click += new System.EventHandler(this.b_gen_cert_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.91667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.08334F));
            this.tableLayoutPanel1.Controls.Add(this.ecert_po_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ecert_po_selection, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ecert_send_as_input, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ecert_cert_quantity_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ecert_send_as_input_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ecert_set_qty, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ecert_generate_ecert, 0, 3);
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
            ((System.ComponentModel.ISupportInitialize)(this.ecert_set_qty)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label ecert_po_label;
        private CheckedListBox ecert_po_selection;
        private TextBox ecert_send_as_input;
        private Label ecert_send_as_input_label;
        private Label ecert_cert_quantity_label;
        private NumericUpDown ecert_set_qty;
        private Button ecert_generate_ecert;
        private TableLayoutPanel tableLayoutPanel1;
    }
}