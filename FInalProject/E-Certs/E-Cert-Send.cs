using FinalProject.Properties;
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
    public partial class E_Cert_Send : Form
    {
        // To close as things as you exit, you have to close the instance that opened this instance.
        private Form opening_popup_instance_to_close;
        private E_Cert e_cert_to_send;

        public E_Cert_Send(String send_as, Form instance_to_close, E_Cert cert)
        {
            InitializeComponent();
            e_cert_to_send = cert;
            ecert_send_send_as.Text = send_as;
            opening_popup_instance_to_close = instance_to_close;

            //for each customer in perm list 
            // add to ecert_send_customers

            // foreach cc in perm list
            // add to ecert_send_cc

        }

        private void ecery_edit_permanant_group_Click(object sender, EventArgs e)
        {
            var formPopup = new UpdateEmails();
            formPopup.Show(this);
        }

        private void ecert_confirm_send_data_CheckedChanged(object sender, EventArgs e)
        {
            ecert_send_ecert.Enabled = ecert_confirm_send_data.Checked;
        }

        private void ecert_send_ecert_Click(object sender, EventArgs e)
        {
            //change icon of sending icon based on stage

            //const string Filename = "\\Resources\\Check Icon.bmp";
            //Window.orderWindowInstance.ecert_stats.Image = Image.FromFile(Filename);

            opening_popup_instance_to_close.Close();
        }

        private void E_Cert_Send_Load(object sender, EventArgs e)
        {
            foreach (String customer in e_cert_to_send.get_email_address_list(E_Cert.Email_Address_List.CUSTOMER))
            {
                ecert_send_customers.Items.Add(customer);
            }

            foreach (String cc in e_cert_to_send.get_email_address_list(E_Cert.Email_Address_List.CC))
            {
                ecert_send_cc.Items.Add(cc);
            }
        }
    }
}
