using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    public partial class UpdateEmails : Form
    {
        public UpdateEmails()
        {
            InitializeComponent();
        }

        private void button1Click(object sender, EventArgs e)
        {
            string email = textBox2.Text;
            //check that email contains an @ symbol & .com/isn't empty
            if (email.Contains("@") && email.Contains(".com"))
            {
                checkedListBox1.Items.Add(email);
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Email format must be xxx@xxx.com");
            }

        }

        private void button3Click(object sender, EventArgs e)
        {
            string email = textBox3.Text;
            //check that email contains an @ symbol / isn't empty
            if (email.Contains("@"))
            {
                checkedListBox2.Items.Add(email);
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Email format must be xxx@xxx.com");
            }
        }

        private void button4Click(object sender, EventArgs e)
        {
            string email = textBox5.Text;
            //check that email contains an @ symbol & . and contains a minimum number of characters
            if (email.Contains("@") && email.Contains(".") && email.Length > 5)
            {
                checkedListBox3.Items.Add(email);
                textBox5.Clear();
            }
            else
            {
                MessageBox.Show("Email format must be xxx@xxx.com");
            }

        }

        //delete "To" email address 
        //if all emails deleted replaces with "add email" message - would be better to do a warning box to not allow deletion
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            EmailWarning warning = new EmailWarning();
            warning.ShowDialog();
            //if user clicks "yes" to delete then delete appropriate index
            if (warning.removeEmail)
            {
                //if more than 1 email in list, allow delete
                if (checkedListBox1.Items.Count > 1)
                {
                    checkedListBox1.Items.RemoveAt(index);
                    checkedListBox1.Refresh();
                    //checkedListBox1.ClearSelected();
                    warning.removeEmail = false;
                }
                //otherwise pop-up warning message until additional email is added
                else
                {
                    MessageBox.Show("You must have at least 1 email address. Please add an email address before deleting", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }
            checkedListBox1.ClearSelected();

        }

        //deletes "From" email addresses
        //only allows for deleting if more than 1 value in list
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox2.SelectedIndex; //store current index
            //open delete warning window 
            EmailWarning warning = new EmailWarning();
            warning.ShowDialog();

            //if more than 1 email in list, allow delete
            if (checkedListBox2.Items.Count > 1)
            {
                checkedListBox2.Items.RemoveAt(index);
                checkedListBox2.Refresh();
                //checkedListBox1.ClearSelected();
                warning.removeEmail = false;
            }
            //otherwise pop-up warning message until additional email is added
            else
            {
                MessageBox.Show("You must have at least 1 email address. Please add an email address before deleting", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            checkedListBox2.ClearSelected();

        }

        //delete "CC" email addresses 
        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox3.SelectedIndex; //store current index
            //open delete warning window 
            EmailWarning warning = new EmailWarning();
            warning.ShowDialog();

            //if more than 1 email in list, allow delete
            if (checkedListBox3.Items.Count > 1)
            {
                checkedListBox3.Items.RemoveAt(index);
                checkedListBox3.Refresh(); 
                //checkedListBox1.ClearSelected();
                warning.removeEmail = false;
            }
            //otherwise pop-up warning message until additional email is added
            else
            {
                MessageBox.Show("You must have at least 1 email address. Please add an email address before deleting", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            checkedListBox3.ClearSelected();
        }
    }
}
