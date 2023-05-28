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

        public E_Cert_Gen()
        {
            InitializeComponent();
            e_Cert_Gen_Instance = this;
        }

        private void generate_ecert()
        {

            //This is where the E-Cert generation would go 
            Console.WriteLine("Ecert Generated");

        }

        private void b_gen_cert_Click(object sender, EventArgs e)
        {
            generate_ecert();
            
            var formPopup = new E_Certs.E_Cert_Send(ecert_send_as_input.Text, e_Cert_Gen_Instance);
            formPopup.Show(this);
        }
    }
}
