using System.Net.NetworkInformation;
using System.Windows.Forms;
//I commented out all references to "pictureBox5" as it wasn't recognized - EAR 05-28-23
namespace FinalProject
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.Main = new System.Windows.Forms.TabPage();
            this.WorklistGrid = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.ActiveOrdersOnly = new System.Windows.Forms.CheckBox();
            this.OrderSeachGo_Main = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.OrderSearchBox_Main = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Order = new System.Windows.Forms.TabPage();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.increment = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NotesEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.RLabel_Order = new System.Windows.Forms.Label();
            this.CLabel_Order = new System.Windows.Forms.Label();
            this.OrderSeachGo_Order = new System.Windows.Forms.Button();
            this.OrderSearchBox_Order = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Docs = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ecert_status = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.viewcert = new System.Windows.Forms.Button();
            this.makecert = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.RLabel_Docs = new System.Windows.Forms.Label();
            this.CLabel_Docs = new System.Windows.Forms.Label();
            this.OrderSeachGo_Docs = new System.Windows.Forms.Button();
            this.OrderSearchBox_Docs = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rMSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pONumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promiseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyCompleteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worklist_data = new System.Windows.Forms.BindingSource(this.components);
            this.stepnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.todoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedOrder = new System.Windows.Forms.BindingSource(this.components);
            this.MainTabs.SuspendLayout();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorklistGrid)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Docs.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecert_status)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worklist_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabs.Controls.Add(this.Main);
            this.MainTabs.Controls.Add(this.Order);
            this.MainTabs.Controls.Add(this.Docs);
            this.MainTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabs.ItemSize = new System.Drawing.Size(100, 40);
            this.MainTabs.Location = new System.Drawing.Point(12, 12);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(1553, 821);
            this.MainTabs.TabIndex = 0;
            // 
            // Main
            // 
            this.Main.Controls.Add(this.WorklistGrid);
            this.Main.Controls.Add(this.panel3);
            this.Main.Location = new System.Drawing.Point(4, 44);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(1545, 773);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // WorklistGrid
            // 
            this.WorklistGrid.AllowUserToAddRows = false;
            this.WorklistGrid.AllowUserToDeleteRows = false;
            this.WorklistGrid.AllowUserToResizeColumns = false;
            this.WorklistGrid.AllowUserToResizeRows = false;
            this.WorklistGrid.AutoGenerateColumns = false;
            this.WorklistGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WorklistGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.WorklistGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorklistGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rMSDataGridViewTextBoxColumn,
            this.partDataGridViewTextBoxColumn,
            this.opDataGridViewTextBoxColumn,
            this.pONumberDataGridViewTextBoxColumn,
            this.dueDataGridViewTextBoxColumn,
            this.promiseDateDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.qtyCompleteDataGridViewTextBoxColumn});
            this.WorklistGrid.DataSource = this.worklist_data;
            this.WorklistGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorklistGrid.Location = new System.Drawing.Point(3, 166);
            this.WorklistGrid.Name = "WorklistGrid";
            this.WorklistGrid.ReadOnly = true;
            this.WorklistGrid.RowHeadersVisible = false;
            this.WorklistGrid.RowHeadersWidth = 51;
            this.WorklistGrid.Size = new System.Drawing.Size(1539, 604);
            this.WorklistGrid.TabIndex = 27;
            this.WorklistGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorklistGrid_CellContentClick);
            this.WorklistGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WorklistGrid_CellContentClick_1);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.ActiveOrdersOnly);
            this.panel3.Controls.Add(this.OrderSeachGo_Main);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.OrderSearchBox_Main);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1539, 163);
            this.panel3.TabIndex = 22;
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(543, 122);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(83, 29);
            this.button7.TabIndex = 30;
            this.button7.Text = "Highlight";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ActiveOrdersOnly
            // 
            this.ActiveOrdersOnly.AutoSize = true;
            this.ActiveOrdersOnly.Dock = System.Windows.Forms.DockStyle.Right;
            this.ActiveOrdersOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveOrdersOnly.Location = new System.Drawing.Point(1381, 103);
            this.ActiveOrdersOnly.Name = "ActiveOrdersOnly";
            this.ActiveOrdersOnly.Size = new System.Drawing.Size(158, 60);
            this.ActiveOrdersOnly.TabIndex = 27;
            this.ActiveOrdersOnly.Text = "Active Orders Only";
            this.ActiveOrdersOnly.UseVisualStyleBackColor = true;
            this.ActiveOrdersOnly.CheckedChanged += new System.EventHandler(this.ActiveOrdersOnly_CheckedChanged);
            // 
            // OrderSeachGo_Main
            // 
            this.OrderSeachGo_Main.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrderSeachGo_Main.BackColor = System.Drawing.Color.Transparent;
            this.OrderSeachGo_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSeachGo_Main.Location = new System.Drawing.Point(834, 122);
            this.OrderSeachGo_Main.Name = "OrderSeachGo_Main";
            this.OrderSeachGo_Main.Size = new System.Drawing.Size(67, 38);
            this.OrderSeachGo_Main.TabIndex = 3;
            this.OrderSeachGo_Main.Text = "Go";
            this.OrderSeachGo_Main.UseVisualStyleBackColor = false;
            this.OrderSeachGo_Main.Click += new System.EventHandler(this.OrderSeachGo_Main_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(437, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 29;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // OrderSearchBox_Main
            // 
            this.OrderSearchBox_Main.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrderSearchBox_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OrderSearchBox_Main.Location = new System.Drawing.Point(632, 122);
            this.OrderSearchBox_Main.Name = "OrderSearchBox_Main";
            this.OrderSearchBox_Main.Size = new System.Drawing.Size(196, 38);
            this.OrderSearchBox_Main.TabIndex = 2;
            this.OrderSearchBox_Main.Text = "1234";
            this.OrderSearchBox_Main.TextChanged += new System.EventHandler(this.OrderSearchBox_Main_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1539, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Order
            // 
            this.Order.Controls.Add(this.OrderGridView);
            this.Order.Controls.Add(this.panel1);
            this.Order.Location = new System.Drawing.Point(4, 44);
            this.Order.Name = "Order";
            this.Order.Padding = new System.Windows.Forms.Padding(3);
            this.Order.Size = new System.Drawing.Size(1545, 773);
            this.Order.TabIndex = 1;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            // 
            // OrderGridView
            // 
            this.OrderGridView.AllowUserToDeleteRows = false;
            this.OrderGridView.AllowUserToResizeColumns = false;
            this.OrderGridView.AllowUserToResizeRows = false;
            this.OrderGridView.AutoGenerateColumns = false;
            this.OrderGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stepnameDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn,
            this.increment,
            this.completeDataGridViewTextBoxColumn,
            this.todoDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.NotesEdit,
            this.notesDataGridViewTextBoxColumn});
            this.OrderGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OrderGridView.DataSource = this.SelectedOrder;
            this.OrderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.OrderGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.OrderGridView.Location = new System.Drawing.Point(3, 188);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.RowHeadersVisible = false;
            this.OrderGridView.RowHeadersWidth = 51;
            this.OrderGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrderGridView.RowTemplate.Height = 36;
            this.OrderGridView.Size = new System.Drawing.Size(1539, 582);
            this.OrderGridView.TabIndex = 3;
            this.OrderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // increment
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.NullValue = null;
            this.increment.DefaultCellStyle = dataGridViewCellStyle2;
            this.increment.FillWeight = 6.012024F;
            this.increment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.increment.HeaderText = "";
            this.increment.MinimumWidth = 6;
            this.increment.Name = "increment";
            this.increment.ReadOnly = true;
            this.increment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.increment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.increment.Text = "+";
            this.increment.UseColumnTextForButtonValue = true;
            this.increment.Width = 30;
            // 
            // NotesEdit
            // 
            this.NotesEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.NotesEdit.DefaultCellStyle = dataGridViewCellStyle3;
            this.NotesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotesEdit.HeaderText = "";
            this.NotesEdit.Name = "NotesEdit";
            this.NotesEdit.ReadOnly = true;
            this.NotesEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NotesEdit.Text = "✎";
            this.NotesEdit.UseColumnTextForButtonValue = true;
            this.NotesEdit.Width = 30;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.RLabel_Order);
            this.panel1.Controls.Add(this.CLabel_Order);
            this.panel1.Controls.Add(this.OrderSeachGo_Order);
            this.panel1.Controls.Add(this.OrderSearchBox_Order);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1539, 185);
            this.panel1.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label12.Location = new System.Drawing.Point(181, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 31);
            this.label12.TabIndex = 6;
            this.label12.Text = "Search";
            // 
            // RLabel_Order
            // 
            this.RLabel_Order.AutoSize = true;
            this.RLabel_Order.Dock = System.Windows.Forms.DockStyle.Right;
            this.RLabel_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLabel_Order.Location = new System.Drawing.Point(1123, 0);
            this.RLabel_Order.Name = "RLabel_Order";
            this.RLabel_Order.Size = new System.Drawing.Size(416, 138);
            this.RLabel_Order.TabIndex = 5;
            this.RLabel_Order.Text = "Qty: 30, Part No. 7567\r\nDesc: Large Bolt\r\nPO: 674567";
            // 
            // CLabel_Order
            // 
            this.CLabel_Order.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CLabel_Order.AutoSize = true;
            this.CLabel_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLabel_Order.Location = new System.Drawing.Point(600, 0);
            this.CLabel_Order.Name = "CLabel_Order";
            this.CLabel_Order.Size = new System.Drawing.Size(273, 126);
            this.CLabel_Order.TabIndex = 4;
            this.CLabel_Order.Text = "Large Bolt\r\n ID: 1234\r\n";
            this.CLabel_Order.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrderSeachGo_Order
            // 
            this.OrderSeachGo_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSeachGo_Order.Location = new System.Drawing.Point(344, 40);
            this.OrderSeachGo_Order.Name = "OrderSeachGo_Order";
            this.OrderSeachGo_Order.Size = new System.Drawing.Size(67, 38);
            this.OrderSeachGo_Order.TabIndex = 3;
            this.OrderSeachGo_Order.Text = "Go";
            this.OrderSeachGo_Order.UseVisualStyleBackColor = true;
            this.OrderSeachGo_Order.Click += new System.EventHandler(this.OrderSeachGo_Order_Click);
            // 
            // OrderSearchBox_Order
            // 
            this.OrderSearchBox_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OrderSearchBox_Order.Location = new System.Drawing.Point(181, 40);
            this.OrderSearchBox_Order.Name = "OrderSearchBox_Order";
            this.OrderSearchBox_Order.Size = new System.Drawing.Size(157, 38);
            this.OrderSearchBox_Order.TabIndex = 2;
            this.OrderSearchBox_Order.Text = "1234";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 182);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Docs
            // 
            this.Docs.Controls.Add(this.panel9);
            this.Docs.Controls.Add(this.panel2);
            this.Docs.Location = new System.Drawing.Point(4, 44);
            this.Docs.Name = "Docs";
            this.Docs.Size = new System.Drawing.Size(1545, 773);
            this.Docs.TabIndex = 2;
            this.Docs.Text = "Documents";
            this.Docs.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.AutoScroll = true;
            this.panel9.AutoSize = true;
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Controls.Add(this.panel7);
            this.panel9.Controls.Add(this.panel6);
            this.panel9.Controls.Add(this.panel4);
            this.panel9.Controls.Add(this.panel5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 185);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1545, 588);
            this.panel9.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel8.AutoSize = true;
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.Controls.Add(this.pictureBox8);
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.button12);
            this.panel8.Controls.Add(this.button13);
            this.panel8.Location = new System.Drawing.Point(868, 388);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(280, 127);
            this.panel8.TabIndex = 9;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(186, 1);
            this.pictureBox8.MaximumSize = new System.Drawing.Size(48, 48);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(48, 48);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label11.Location = new System.Drawing.Point(45, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 46);
            this.label11.TabIndex = 4;
            this.label11.Text = "E-Cert";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(146, 49);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(131, 75);
            this.button12.TabIndex = 7;
            this.button12.Text = "View";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.Enabled = false;
            this.button13.Location = new System.Drawing.Point(3, 49);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(137, 75);
            this.button13.TabIndex = 6;
            this.button13.Text = "Create";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel7.AutoSize = true;
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.Controls.Add(this.pictureBox7);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.button10);
            this.panel7.Controls.Add(this.button11);
            this.panel7.Location = new System.Drawing.Point(868, 172);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(280, 127);
            this.panel7.TabIndex = 9;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(186, 0);
            this.pictureBox7.MaximumSize = new System.Drawing.Size(48, 48);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(48, 48);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label10.Location = new System.Drawing.Point(45, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 46);
            this.label10.TabIndex = 4;
            this.label10.Text = "E-Cert";
            // 
            // button10
            // 
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(146, 49);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(131, 75);
            this.button10.TabIndex = 7;
            this.button10.Text = "View";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(3, 49);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(137, 75);
            this.button11.TabIndex = 6;
            this.button11.Text = "Create";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel6.AutoSize = true;
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.button8);
            this.panel6.Controls.Add(this.button9);
            this.panel6.Location = new System.Drawing.Point(345, 391);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(280, 127);
            this.panel6.TabIndex = 8;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(186, 0);
            this.pictureBox6.MaximumSize = new System.Drawing.Size(48, 48);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(48, 48);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label9.Location = new System.Drawing.Point(45, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 46);
            this.label9.TabIndex = 4;
            this.label9.Text = "E-Cert";
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(146, 49);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(131, 75);
            this.button8.TabIndex = 7;
            this.button8.Text = "View";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 49);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(137, 75);
            this.button9.TabIndex = 6;
            this.button9.Text = "Create";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(this.pictureBox4);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button5);
            this.panel4.Location = new System.Drawing.Point(348, 172);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(280, 127);
            this.panel4.TabIndex = 8;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(186, 0);
            this.pictureBox4.MaximumSize = new System.Drawing.Size(48, 48);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label7.Location = new System.Drawing.Point(45, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 46);
            this.label7.TabIndex = 4;
            this.label7.Text = "E-Cert";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(146, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 75);
            this.button4.TabIndex = 7;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(3, 49);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 75);
            this.button5.TabIndex = 6;
            this.button5.Text = "Create";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel5.AutoSize = true;
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.Controls.Add(this.ecert_status);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.viewcert);
            this.panel5.Controls.Add(this.makecert);
            this.panel5.Location = new System.Drawing.Point(613, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(280, 127);
            this.panel5.TabIndex = 7;
            // 
            // ecert_status
            // 
            this.ecert_status.Image = ((System.Drawing.Image)(resources.GetObject("ecert_status.Image")));
            this.ecert_status.Location = new System.Drawing.Point(186, 0);
            this.ecert_status.MaximumSize = new System.Drawing.Size(48, 48);
            this.ecert_status.Name = "ecert_status";
            this.ecert_status.Size = new System.Drawing.Size(48, 48);
            this.ecert_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ecert_status.TabIndex = 8;
            this.ecert_status.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label8.Location = new System.Drawing.Point(45, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 46);
            this.label8.TabIndex = 4;
            this.label8.Text = "E-Cert";
            // 
            // viewcert
            // 
            this.viewcert.Enabled = false;
            this.viewcert.Location = new System.Drawing.Point(146, 49);
            this.viewcert.Name = "viewcert";
            this.viewcert.Size = new System.Drawing.Size(131, 75);
            this.viewcert.TabIndex = 7;
            this.viewcert.Text = "View";
            this.viewcert.UseVisualStyleBackColor = false;
            // 
            // makecert
            // 
            this.makecert.Location = new System.Drawing.Point(3, 49);
            this.makecert.Name = "makecert";
            this.makecert.Size = new System.Drawing.Size(137, 75);
            this.makecert.TabIndex = 6;
            this.makecert.Text = "Create";
            this.makecert.UseVisualStyleBackColor = true;
            this.makecert.Click += new System.EventHandler(this.makecert_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.RLabel_Docs);
            this.panel2.Controls.Add(this.CLabel_Docs);
            this.panel2.Controls.Add(this.OrderSeachGo_Docs);
            this.panel2.Controls.Add(this.OrderSearchBox_Docs);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1545, 185);
            this.panel2.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label13.Location = new System.Drawing.Point(181, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 31);
            this.label13.TabIndex = 7;
            this.label13.Text = "Search";
            // 
            // RLabel_Docs
            // 
            this.RLabel_Docs.AutoSize = true;
            this.RLabel_Docs.Dock = System.Windows.Forms.DockStyle.Right;
            this.RLabel_Docs.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLabel_Docs.Location = new System.Drawing.Point(1129, 0);
            this.RLabel_Docs.Name = "RLabel_Docs";
            this.RLabel_Docs.Size = new System.Drawing.Size(416, 138);
            this.RLabel_Docs.TabIndex = 5;
            this.RLabel_Docs.Text = "Qty: 30, Part No. 7567\r\nDesc: Large Bolt\r\nPO: 674567\r\n";
            // 
            // CLabel_Docs
            // 
            this.CLabel_Docs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CLabel_Docs.AutoSize = true;
            this.CLabel_Docs.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLabel_Docs.Location = new System.Drawing.Point(621, 0);
            this.CLabel_Docs.Name = "CLabel_Docs";
            this.CLabel_Docs.Size = new System.Drawing.Size(273, 126);
            this.CLabel_Docs.TabIndex = 4;
            this.CLabel_Docs.Text = "Large Bolt\r\n ID: 1234\r\n";
            this.CLabel_Docs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OrderSeachGo_Docs
            // 
            this.OrderSeachGo_Docs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderSeachGo_Docs.Location = new System.Drawing.Point(344, 45);
            this.OrderSeachGo_Docs.Name = "OrderSeachGo_Docs";
            this.OrderSeachGo_Docs.Size = new System.Drawing.Size(67, 38);
            this.OrderSeachGo_Docs.TabIndex = 3;
            this.OrderSeachGo_Docs.Text = "Go";
            this.OrderSeachGo_Docs.UseVisualStyleBackColor = true;
            this.OrderSeachGo_Docs.Click += new System.EventHandler(this.OrderSeachGo_Docs_Click);
            // 
            // OrderSearchBox_Docs
            // 
            this.OrderSearchBox_Docs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OrderSearchBox_Docs.Location = new System.Drawing.Point(181, 45);
            this.OrderSearchBox_Docs.Name = "OrderSearchBox_Docs";
            this.OrderSearchBox_Docs.Size = new System.Drawing.Size(157, 38);
            this.OrderSearchBox_Docs.TabIndex = 2;
            this.OrderSearchBox_Docs.Text = "1234";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 182);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(20, 159);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(774, 250);
            this.webBrowser1.TabIndex = 15;
            // 
            // rMSDataGridViewTextBoxColumn
            // 
            this.rMSDataGridViewTextBoxColumn.DataPropertyName = "RMS";
            this.rMSDataGridViewTextBoxColumn.HeaderText = "RMS";
            this.rMSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rMSDataGridViewTextBoxColumn.Name = "rMSDataGridViewTextBoxColumn";
            this.rMSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partDataGridViewTextBoxColumn
            // 
            this.partDataGridViewTextBoxColumn.DataPropertyName = "Part";
            this.partDataGridViewTextBoxColumn.HeaderText = "Part";
            this.partDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partDataGridViewTextBoxColumn.Name = "partDataGridViewTextBoxColumn";
            this.partDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opDataGridViewTextBoxColumn
            // 
            this.opDataGridViewTextBoxColumn.DataPropertyName = "Op";
            this.opDataGridViewTextBoxColumn.HeaderText = "Op";
            this.opDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opDataGridViewTextBoxColumn.Name = "opDataGridViewTextBoxColumn";
            this.opDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pONumberDataGridViewTextBoxColumn
            // 
            this.pONumberDataGridViewTextBoxColumn.DataPropertyName = "PONumber";
            this.pONumberDataGridViewTextBoxColumn.HeaderText = "PONumber";
            this.pONumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pONumberDataGridViewTextBoxColumn.Name = "pONumberDataGridViewTextBoxColumn";
            this.pONumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueDataGridViewTextBoxColumn
            // 
            this.dueDataGridViewTextBoxColumn.DataPropertyName = "Due";
            this.dueDataGridViewTextBoxColumn.HeaderText = "Due";
            this.dueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dueDataGridViewTextBoxColumn.Name = "dueDataGridViewTextBoxColumn";
            this.dueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // promiseDateDataGridViewTextBoxColumn
            // 
            this.promiseDateDataGridViewTextBoxColumn.DataPropertyName = "PromiseDate";
            this.promiseDateDataGridViewTextBoxColumn.HeaderText = "PromiseDate";
            this.promiseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.promiseDateDataGridViewTextBoxColumn.Name = "promiseDateDataGridViewTextBoxColumn";
            this.promiseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyCompleteDataGridViewTextBoxColumn
            // 
            this.qtyCompleteDataGridViewTextBoxColumn.DataPropertyName = "qtyComplete";
            this.qtyCompleteDataGridViewTextBoxColumn.HeaderText = "qtyComplete";
            this.qtyCompleteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyCompleteDataGridViewTextBoxColumn.Name = "qtyCompleteDataGridViewTextBoxColumn";
            this.qtyCompleteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // worklist_data
            // 
            this.worklist_data.DataSource = typeof(FinalProject.Order);
            // 
            // stepnameDataGridViewTextBoxColumn
            // 
            this.stepnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stepnameDataGridViewTextBoxColumn.DataPropertyName = "step_name";
            this.stepnameDataGridViewTextBoxColumn.HeaderText = "Operation";
            this.stepnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stepnameDataGridViewTextBoxColumn.Name = "stepnameDataGridViewTextBoxColumn";
            this.stepnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stepnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stepnameDataGridViewTextBoxColumn.Width = 118;
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "due_date";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "Due";
            this.duedateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            this.duedateDataGridViewTextBoxColumn.ReadOnly = true;
            this.duedateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.duedateDataGridViewTextBoxColumn.Width = 70;
            // 
            // completeDataGridViewTextBoxColumn
            // 
            this.completeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.completeDataGridViewTextBoxColumn.DataPropertyName = "complete";
            this.completeDataGridViewTextBoxColumn.HeaderText = "Qty. Complete";
            this.completeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.completeDataGridViewTextBoxColumn.Name = "completeDataGridViewTextBoxColumn";
            this.completeDataGridViewTextBoxColumn.ReadOnly = true;
            this.completeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.completeDataGridViewTextBoxColumn.Width = 154;
            // 
            // todoDataGridViewTextBoxColumn
            // 
            this.todoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.todoDataGridViewTextBoxColumn.DataPropertyName = "todo";
            this.todoDataGridViewTextBoxColumn.HeaderText = "Qty. Todo";
            this.todoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.todoDataGridViewTextBoxColumn.Name = "todoDataGridViewTextBoxColumn";
            this.todoDataGridViewTextBoxColumn.ReadOnly = true;
            this.todoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.todoDataGridViewTextBoxColumn.Width = 118;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.totalDataGridViewTextBoxColumn.Width = 76;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.FillWeight = 193.988F;
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SelectedOrder
            // 
            this.SelectedOrder.DataSource = typeof(FinalProject.OrderStep);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 845);
            this.Controls.Add(this.MainTabs);
            this.Name = "Window";
            this.Text = "Manufacturing App";
            this.MainTabs.ResumeLayout(false);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorklistGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Docs.ResumeLayout(false);
            this.Docs.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ecert_status)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worklist_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage Order;
        private System.Windows.Forms.TabPage Docs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox OrderSearchBox_Order;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button OrderSeachGo_Order;
        private System.Windows.Forms.Label CLabel_Order;
        private System.Windows.Forms.Label RLabel_Order;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.BindingSource SelectedOrder;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button viewcert;
        private System.Windows.Forms.Button makecert;
        private System.Windows.Forms.PictureBox i_ecert_status_docs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.BindingSource worklist_data;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label RLabel_Docs;
        private System.Windows.Forms.Label CLabel_Docs;
        private System.Windows.Forms.Button OrderSeachGo_Docs;
        private System.Windows.Forms.TextBox OrderSearchBox_Docs;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button OrderSeachGo_Main;
        private System.Windows.Forms.TextBox OrderSearchBox_Main;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView WorklistGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn rMSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pONumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn promiseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyCompleteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox ActiveOrdersOnly;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label12;
        private Label label13;
        private DataGridViewTextBoxColumn stepnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn increment;
        private DataGridViewTextBoxColumn completeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn todoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn NotesEdit;
        private DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private PictureBox ecert_status;
    }
}

