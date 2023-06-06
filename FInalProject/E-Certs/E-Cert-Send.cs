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
            ecert_send_send_as.Text = "Send as from db for " + send_as;
            opening_popup_instance_to_close = instance_to_close;
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
            opening_popup_instance_to_close.Close();
        }


        private void E_Cert_Send_Load(object sender, EventArgs e)
        {
            load_email_field(ecert_send_customers,E_Cert.Email_Address_List.CUSTOMER);
            load_email_field(ecert_send_cc, E_Cert.Email_Address_List.CC);
        }


        private void ecert_send_customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ecert_send_customers.Items.Count == 1)
            {
                ecert_send_warning_label.Text = "There must be at least 1 customer email to send to.";
                ecert_send_warning_label.Visible = true;
                return;
            }

            bool succsesful_remove = remove_email_from_checked_list_box(ecert_send_customers, E_Cert.Email_Address_List.CUSTOMER);
            
            if (succsesful_remove)
            {
                ecert_send_reset_customers_emails.Visible = true;
            }
        }

        private void ecert_send_cc_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool succsesful_remove = remove_email_from_checked_list_box(ecert_send_cc, E_Cert.Email_Address_List.CUSTOMER);

            if (succsesful_remove)
            {
                ecert_send_reset_cc_emails.Visible = true;
            }
            
        }


        private void ecert_send_reset_cc_emails_Click(object sender, EventArgs e)
        {
            reset_email_field(ecert_send_cc, E_Cert.Email_Address_List.CC);
            ecert_send_reset_cc_emails.Visible = false;
        }

        private void ecert_send_reset_customers_emails_Click(object sender, EventArgs e)
        {
            reset_email_field(ecert_send_customers, E_Cert.Email_Address_List.CUSTOMER);
            ecert_send_reset_customers_emails.Visible = false;
            ecert_send_warning_label.Visible = false;
        }


        private void reset_email_field(CheckedListBox listBox, E_Cert.Email_Address_List address_List) {

            int toremove = listBox.Items.Count;
            for (int i = 0; i < toremove; i++)
            {
                listBox.Items.RemoveAt(0);
            }
            foreach (String email in e_cert_to_send.get_email_address_list(address_List))
            {
                listBox.Items.Add(email);
            }
        }

        private void load_email_field(CheckedListBox listBox, E_Cert.Email_Address_List address_List)
        {
            foreach (String email in e_cert_to_send.get_email_address_list(address_List))
            {
                listBox.Items.Add(email);
            }
        }

        private bool remove_email_from_checked_list_box(CheckedListBox listBox, E_Cert.Email_Address_List address_List)
        {
            int selectedIndex = listBox.SelectedIndex;

            if (selectedIndex != -1)
            {
                listBox.Items.RemoveAt(selectedIndex);
                return true;
            }

            return false;
        }
    }
}
