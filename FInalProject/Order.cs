﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;



namespace FinalProject
{
    public partial class Window : Form
    {
        private Dictionary<string, Order> order_list = new Dictionary<string, Order>();
        
        public static Window order_Window_Instance;

        private string loaded_order = "";

        private const int increment_column = 2;
        private const int edit_column = 6;
        private const int notes_column = 7;

        public Window()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();

            OrderSearchBox_Order.KeyPress += new KeyPressEventHandler(OrderSearchBoxEnterHandler);
            OrderSearchBox_Main.KeyPress += new KeyPressEventHandler(OrderSearchBoxEnterHandler);
            OrderSearchBox_Docs.KeyPress += new KeyPressEventHandler(OrderSearchBoxEnterHandler);

            MainTabs.SelectedIndexChanged += new EventHandler(tab_chnage_handler);

            initilize_fake_data();

            UpdateWorklistGridVisibility();

            // I have to set the here becasue visual studio resets it in the desginer as a "feature"
            this.OrderGridView.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            this.WorklistGrid.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorklistGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            order_Window_Instance = this;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == increment_column) { 
                    ((OrderStep)this.SelectedOrder.List[e.RowIndex]).increment_done();
                    update_grid();
                }
                if (e.ColumnIndex == edit_column) {
                    this.OrderGridView.CurrentCell = this.OrderGridView[notes_column, e.RowIndex];
                }
            }
        }

        private void update_grid() {
            this.OrderGridView.DataSource = null;
            this.OrderGridView.DataSource = this.SelectedOrder;
        }

        private void makecert_Click(object sender, EventArgs e)
        {
            var formPopup = new E_Certs.E_Cert_Gen(order_Window_Instance, order_list[loaded_order]);
            formPopup.Show(this); // if you need non-modal window
        }

        private bool load_order(string order_id) {
            if (!order_list.ContainsKey(order_id)) { 
                return false;
            }
            SelectedOrder.Clear();
            Order order = order_list[order_id];

            foreach (OrderStep step in order.steps)
            {
                SelectedOrder.Add(step);
            }
            update_grid();
            loaded_order = order_id;
            update_ui();
            return true;
        }

        private void handle_order_search(string order_id) {
            if (string.IsNullOrEmpty(order_id) || !load_order(order_id)) {
                show_order_error(order_id);
                return;
            }
        }

        private void show_order_error(string order_id) {
            MessageBox.Show($"Could not find order with id: {order_id}", "Could not find order", MessageBoxButtons.OK);
        }

        private void OrderSeachGo_Order_Click(object sender, EventArgs e)
        {
            handle_order_search(OrderSearchBox_Order.Text);
        }

        private void OrderSearchBoxEnterHandler(object sender, KeyPressEventArgs e) {
            // enter key
            if (e.KeyChar == (char)Keys.Return) { 
                handle_order_search(((TextBox) sender).Text);
            }
        }

        private void OrderSeachGo_Main_Click(object sender, EventArgs e)
        {
            handle_order_search(OrderSearchBox_Main.Text);
        }

        private void tab_chnage_handler(object sender, EventArgs e) {
            if (loaded_order == "" && MainTabs.SelectedTab != Main) {
                MainTabs.SelectedTab = Main;
                show_order_not_selected();
            }
        }

        private void show_order_not_selected() {
            MessageBox.Show("No selcted order", "Warning", MessageBoxButtons.OK);
        }

        public void update_ui() {
            var order = order_list[loaded_order];

            // update search boxes
            OrderSearchBox_Main.Text = loaded_order;
            OrderSearchBox_Order.Text = loaded_order;
            OrderSearchBox_Docs.Text = loaded_order;

            // update header in orders and docs
            String cLabel = $"{order.Part} \nID: {order.RMS}";
            String rLabel = $"Qty: {order.quantity}, Part No. {order.part_no}\r\nDesc: {order.description}\r\nPO: {order.PONumber}\r\n";

            CLabel_Order.Text = cLabel;
            CLabel_Docs.Text = cLabel;

            RLabel_Order.Text = rLabel;
            RLabel_Docs.Text = rLabel;

            // update document status icon
            if (order.ecert_done) {
                ecert_status.Image = Properties.Resources.e_cert_good;
            }
            else {
                ecert_status.Image = Properties.Resources.e_cert_bad;
            }
            ecert_status.Refresh();

            // update the enabled status of the buttons
            makecert.Enabled = !order.ecert_done;
            viewcert.Enabled = order.ecert_done;

            // move to order tab if on main
            if (MainTabs.SelectedTab == Main) {
                MainTabs.SelectedTab = Order;
            }
        }

        private void OrderSeachGo_Docs_Click(object sender, EventArgs e)
        {
            handle_order_search(OrderSearchBox_Docs.Text);
        }

        private void initilize_fake_data() {
            const int COUNT = 30;

            order_list.Add("1234", new Order("1234",
                new OrderStep("Forming", "5/11", COUNT, ""),
                new OrderStep("Threads", "5/13", COUNT, ""),
                new OrderStep("Heat Treatment", "5/14", COUNT, ""),
                new OrderStep("Plating", "5/17", COUNT, ""),
                new OrderStep("QC", "5/18", COUNT, "")
                )
            {
                Part = "Large Bolt",
                Op = "Some Operation",
                PONumber = 12345,
                Due = "6/15",
                PromiseDate = "6/12",
                description = "Large Bolt",
                qtyComplete = 10,
                part_no = 2,
                quantity = COUNT,
                active_order = true
            });

            order_list.Add("5678", new Order("5678",
                new OrderStep("Forming2", "5/11", COUNT, ""),
                new OrderStep("Threads", "5/13", COUNT, ""),
                new OrderStep("Heat Treatment", "5/14", COUNT, ""),
                new OrderStep("Plating", "5/17", COUNT, ""),
                new OrderStep("QC", "5/18", COUNT, "")
                )
            {
                Part = "Small Bolt",
                Op = "Some Operation",
                PONumber = 12345,
                Due = "6/15",
                PromiseDate = "6/12",
                description = "Small Bolt",
                qtyComplete = 10,
                part_no = 1,
                quantity = COUNT,
                active_order = false
            }); 

            worklist_data.Add(order_list["1234"]);
            worklist_data.Add(order_list["5678"]);
        }

        private void WorklistGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1)
            {
                return;
            }

            load_order(((Order)this.worklist_data.List[e.RowIndex]).RMS);
        }

        private void ActiveOrdersOnly_CheckedChanged(object sender, EventArgs e)
        {
            activeOrdersOnlyChecked = ActiveOrdersOnly.Checked;

            // Call the function to update the visibility of rows in the WorklistGrid
            UpdateWorklistGridVisibility();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string rmsNumber = textBox2.Text;

            foreach (DataGridViewRow row in WorklistGrid.Rows)
            {
                if (row.Cells["rMSDataGridViewTextBoxColumn"].Value.ToString() == rmsNumber)
                {
                    row.Cells["rMSDataGridViewTextBoxColumn"].Style.BackColor = Color.LightGreen;
                    row.Cells["partDataGridViewTextBoxColumn"].Style.BackColor = Color.LightGreen;
                    row.Cells["opDataGridViewTextBoxColumn"].Style.BackColor = Color.LightGreen;
                    row.Cells["pONumberDataGridViewTextBoxColumn"].Style.BackColor = Color.LightGreen;
                    row.Cells["dueDataGridViewTextBoxColumn"].Style.BackColor = Color.LightGreen;
                    row.Cells["promiseDateDataGridViewTextBoxColumn"].Style.BackColor = Color.LightGreen;
                    row.Cells["descriptionDataGridViewTextBoxColumn"].Style.BackColor = Color.LightGreen;
                    row.Cells["qtyCompleteDataGridViewTextBoxColumn"].Style.BackColor = Color.LightGreen;
                }
                else
                {
                    row.Cells["rMSDataGridViewTextBoxColumn"].Style.BackColor = Color.White;
                    row.Cells["partDataGridViewTextBoxColumn"].Style.BackColor = Color.White;
                    row.Cells["opDataGridViewTextBoxColumn"].Style.BackColor = Color.White;
                    row.Cells["pONumberDataGridViewTextBoxColumn"].Style.BackColor = Color.White;
                    row.Cells["dueDataGridViewTextBoxColumn"].Style.BackColor = Color.White;
                    row.Cells["promiseDateDataGridViewTextBoxColumn"].Style.BackColor = Color.White;
                    row.Cells["descriptionDataGridViewTextBoxColumn"].Style.BackColor = Color.White;
                    row.Cells["qtyCompleteDataGridViewTextBoxColumn"].Style.BackColor = Color.White;
                }
            }
        }

        private void UpdateWorklistGridVisibility()
        {
            foreach (DataGridViewRow row in WorklistGrid.Rows)
            {
                Order order = (Order)row.DataBoundItem;
                bool isVisible = !activeOrdersOnlyChecked || order.active_order;

                row.Visible = isVisible;
            }
        }

        private bool activeOrdersOnlyChecked = false;

    }

    public class Order { 
        public Order(string RMS, params OrderStep[] steps)
        {
            this.RMS = RMS;
            foreach (OrderStep step in steps) { 
                this.steps.Add(step);
            }
            Part = "";
            Op = "";
            PONumber = -1;
            Due = "";
            PromiseDate = "";
            PromiseDate = "";
            description = "";
            qtyComplete = 0;
            part_no = -1;
            quantity = 0;
            ecert_done = false;
        }

        public string RMS { get; set; }
        public string Part { get; set; }
        public string Op { get; set; }
        public int PONumber { get; set; }
        public string Due { get; set; }
        public string PromiseDate { get; set; }
        public string description { get; set; }
        public int qtyComplete { get; set; }
        public int part_no { get; set; }
        public int quantity { get; set; }

        public bool ecert_done { get; set; }

        public bool active_order { get; set; }

        
        public List<OrderStep> steps = new List<OrderStep>();
    }

    public class OrderStep { 
        public OrderStep(string step_name, string due_date, int total, string notes)
        {
            this.step_name = step_name;
            this.due_date = due_date;
            this.complete = 0;
            this.todo = total;
            this.total = total;
            this.notes = notes;
        }

        public void increment_done(int increase=1) {
            if (complete + increase > total)
            {
                complete = total;
                todo = 0;
                return;
            }

            complete += increase;
            todo -= increase;
        }

        public string step_name { get; set; }
        public string due_date { get; set; }
        public int complete { get; set; }
        public int todo { get; set; }
        public int total { get; set; }
        public string notes { get; set; }

    }
}
