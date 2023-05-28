using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInalProject.E_Certs
{
    public partial class E_Cert_Gen : Form
    {
        public E_Cert_Gen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formPopup = new E_Certs.E_Cert_Send();
            formPopup.Show(this); // if you need non-modal window
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
