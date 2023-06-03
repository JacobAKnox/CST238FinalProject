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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class UpdateEmails : Form
    {
        E_Cert Cert;
        
        public UpdateEmails(E_Cert read_ecert)
        {
            InitializeComponent();
            Cert = read_ecert;
        }

        private void button1Click(object sender, EventArgs e)
        {
            string email = textBox2.Text;
            checkedListBox1.Items.Add(email);
            textBox3.Clear();

        }

        private void button3Click(object sender, EventArgs e)
        {
            string email = textBox3.Text;
            checkedListBox2.Items.Add(email);
            textBox3.Clear();
        }

        private void button4Click(object sender, EventArgs e)
        {
            string email = textBox5.Text;
            checkedListBox3.Items.Add(email);
            textBox3.Clear();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmailWarning warning = new EmailWarning();
            warning.ShowDialog();
        }

        private void UpdateEmails_Load(object sender, EventArgs e)
        {

            var to_remove = checkedListBox1.Items.Count;
            for (int i = 0; i < to_remove; i++)
            {
                checkedListBox1.Items.RemoveAt(0);
            }

            to_remove = checkedListBox2.Items.Count;
            for (int i = 0; i < to_remove; i++)
            {
                checkedListBox2.Items.RemoveAt(0);
            }

            to_remove = checkedListBox3.Items.Count;
            for (int i = 0; i < to_remove; i++)
            {
                checkedListBox3.Items.RemoveAt(0);
            }

            foreach (string customer in Cert.get_email_address_list(E_Cert.Email_Address_List.CUSTOMER))
            {
                checkedListBox1.Items.Add(customer);
            }
            foreach (string customer in Cert.get_email_address_list(E_Cert.Email_Address_List.SEND_AS))
            {
                checkedListBox2.Items.Add(customer);
            }
            foreach (string customer in Cert.get_email_address_list(E_Cert.Email_Address_List.CC))
            {
                checkedListBox3.Items.Add(customer);
            }
        }

    }
}
