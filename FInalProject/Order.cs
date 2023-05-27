using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject
{
    public partial class Window : Form
    {
        private Dictionary<string, Order> order_list = new Dictionary<string, Order>();

        public Window()
        {
            const int COUNT = 30;
            InitializeComponent();

            order_list.Add("1234", new Order("1234",
                new OrderStep("Forming", "5/11", COUNT, ""),
                new OrderStep("Threads", "5/13", COUNT, ""),
                new OrderStep("Heat Treatment", "5/14", COUNT, ""),
                new OrderStep("Plating", "5/17", COUNT, ""),
                new OrderStep("QC", "5/18", COUNT, "")
                ));

            foreach (OrderStep step in order_list["1234"].steps) { 
                this.SelectedOrder.Add(step);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
                ((OrderStep) this.SelectedOrder.List[e.RowIndex]).increment_done();
                update_grid();
            }
        }

        private void update_grid() {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.SelectedOrder;
        }

        private void makecert_Click(object sender, EventArgs e)
        {

        }
    }

    class Order { 
        public Order(string id, params OrderStep[] steps)
        {
            this.id = id;
            foreach (OrderStep step in steps) { 
                this.steps.Add(step);
            }
        }


        public string id;
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
