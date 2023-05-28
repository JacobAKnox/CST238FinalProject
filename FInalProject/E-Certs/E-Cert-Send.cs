﻿using FInalProject.Properties;
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
    public partial class E_Cert_Send : Form
    {
        // To close as things as you exit, you have to close the parent of the 
        private Form toClose;

        public E_Cert_Send(String sendAs, Form callback)
        {
            InitializeComponent();
            ecert_send_send_as.Text = sendAs;
            toClose = callback;

            //for each customer in perm list 
            // add to ecert_send_customers

            // foreach cc in perm list
            // add to ecert_send_cc


        }

        private void b_send_ecert_Click(object sender, EventArgs e)
        {
            //const string Filename = "\\Resources\\Check Icon.bmp";
            //Window.orderWindowInstance.ecert_stats.Image = Image.FromFile(Filename);
            toClose.Close();
        }

        private void ecery_edit_pgroup_c_Click(object sender, EventArgs e)
        {
            update_email_pgroup();
        }

        private void ecery_edit_pgroup_cc_Click(object sender, EventArgs e)
        {
            update_email_pgroup();
        }

        private void update_email_pgroup()
        {
            var formPopup = new UpdateEmails();
            formPopup.Show(this);
        }
    }
}
