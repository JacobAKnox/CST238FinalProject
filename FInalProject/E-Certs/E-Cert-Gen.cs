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

        public Window form_instance_of_order_window;
        public PictureBox ecert_status_icon;
        public Button ecert_view_button, ecert_create_button;

        public E_Cert_Gen(Window instance_of_order_window, PictureBox ecert_status_icon_insance, Button ecert_view_button_insance, Button ecert_create_button_insance)
        {
            InitializeComponent();
            e_Cert_Gen_Instance = this;

            form_instance_of_order_window = instance_of_order_window;
            ecert_status_icon = ecert_status_icon_insance;
            ecert_view_button = ecert_view_button_insance;
            ecert_create_button = ecert_create_button_insance;
        }

        private E_Cert generate_ecert()
        {
            // I tottally could have just passed this E_Cert through the constructor,
            // this is more to model the correct workflow of the program
            E_Cert cert = new E_Cert(form_instance_of_order_window, 
                ecert_status_icon, 
                ecert_view_button, 
                ecert_create_button);
            
            return cert;
        }

        private void b_gen_cert_Click(object sender, EventArgs e)
        {
            var formPopup = new E_Certs.E_Cert_Send(ecert_send_as_input.Text, e_Cert_Gen_Instance, generate_ecert());
            formPopup.Show(this);
        }
    }
}
