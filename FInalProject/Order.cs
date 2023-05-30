using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;



namespace FinalProject
{
    public partial class Window : Form
    {
        private Dictionary<string, Order> order_list = new Dictionary<string, Order>();
        
        public static Window orderWindowInstance;
        public PictureBox ecert_stats;

        private const int increment_column = 2;
        private const int edit_column = 6;
        private const int notes_column = 7;

        public Window()
        {
            WindowState = FormWindowState.Maximized;
            const int COUNT = 30;
            InitializeComponent();

            order_list.Add("1234", new Order("1234",
                new OrderStep("Forming", "5/11", COUNT, ""),
                new OrderStep("Threads", "5/13", COUNT, ""),
                new OrderStep("Heat Treatment", "5/14", COUNT, ""),
                new OrderStep("Plating", "5/17", COUNT, ""),
                new OrderStep("QC", "5/18", COUNT, "")
                )
            {
                Part = "Some Part",
                Op = "Some Operation",
                PONumber = 12345,
                Due = "6/15",
                PromiseDate = "6/12",
                description = "Some description",
                qtyComplete = 10
            });

            foreach (OrderStep step in order_list["1234"].steps) { 
                this.SelectedOrder.Add(step);
            }

            worklist_data.Add(order_list["1234"]);

            // I have to set the here becasue visual studio resets it in the desginer as a "feature"
            this.OrderGridView.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));

            this.WorklistGrid.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorklistGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }
        
        private void UpdateDataGridView2()
        {
            WorklistGrid.DataSource = null;
            WorklistGrid.DataSource = worklist_data;
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
            var formPopup = new E_Certs.E_Cert_Gen();
            formPopup.Show(this); // if you need non-modal window

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDataGridView2();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            UpdateDataGridView2();
        }

        private void Window_Load(object sender, EventArgs e)
        {

        }
    }

    class Order { 
        public Order(string RMS, params OrderStep[] steps)
        {
            this.RMS = RMS;
            foreach (OrderStep step in steps) { 
                this.steps.Add(step);
            }
        }

        public string RMS { get; set; }
        public string Part { get; set; }
        public string Op { get; set; }
        public int PONumber { get; set; }
        public string Due { get; set; }
        public string PromiseDate { get; set; }
        public string description { get; set; }
        public int qtyComplete { get; set; }



        
        public List<OrderStep> steps = new List<OrderStep>();
    }

    class OrderStep { 
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
