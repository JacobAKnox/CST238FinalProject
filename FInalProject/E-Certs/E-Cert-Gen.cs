using FInalProject.E_Certs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.E_Certs
{
    public partial class E_Cert_Gen : Form
    {
        private int Generation_Step_MAX = 20000;
        private int Generation_Step_MIN = 0;
        private int Generation_Step = 1;

        // Used to call back to the instance of the window to close it from the new window
        public static E_Cert_Gen e_Cert_Gen_Instance;
        public Window documents_window_instance;
        public Order order;
        public E_Cert generated_ecert;

        public E_Cert_Gen(Window instance_of_order_window, Order ecert_status_icon)
        {
            documents_window_instance = instance_of_order_window;
            order = ecert_status_icon;

            InitializeComponent();
            e_Cert_Gen_Instance = this;
        }

        private void generate_ecert()
        {
            generated_ecert = new E_Cert();
            order.ecert_done = true;
            documents_window_instance.update_ui();
        }

        private void b_gen_cert_Click(object sender, EventArgs e)
        {
            generate_ecert();
            
            var formPopup = new E_Certs.E_Cert_Send(ecert_send_as_input.Text, e_Cert_Gen_Instance, generated_ecert);
            formPopup.Show(this);
        }

        private void can_generate_ecert() { 
            if (ecert_po_selection.CheckedItems.Count == 0 || ecert_send_as_input.Text == "")
            {
                ecert_generate_ecert.Enabled = false;
                return;
            }
            ecert_generate_ecert.Enabled = true;
        }

        private void ecert_po_selection_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            can_generate_ecert();
        }

        private void ecert_send_as_input_TextChanged(object sender, EventArgs e)
        {
            can_generate_ecert();
        }

        private void ecert_po_selection_SelectedValueChanged(object sender, EventArgs e)
        {
            can_generate_ecert();
        }

        private void ecert_po_selection_SelectedIndexChanged(object sender, EventArgs e)
        {
            can_generate_ecert();
        }
    }
}
