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
        public UpdateEmails()
        {
            InitializeComponent();
            ////remove checks from all items 
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void reloadUpdateEmail()
        {
            ////remove checks from all items 
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            ////remove checks from all items 
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                checkedListBox2.SetItemCheckState(i, CheckState.Unchecked);
            }
            ////remove checks from all items 
            for (int i = 0; i < checkedListBox3.Items.Count; i++)
            {
                checkedListBox3.SetItemCheckState(i, CheckState.Unchecked);
            }

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
            if(email.Contains("@"))
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
            //check that email contains an @ symbol & .com/isn't empty
            if (email.Contains("@") && email.Contains(".com"))
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
            if(warning.removeEmail)
            {
                if(checkedListBox1.Items.Count > 1)
                {
                    //checkedListBox1.ClearSelected();
                    checkedListBox1.Items.RemoveAt(index);
                    checkedListBox1.Refresh();
                    //checkedListBox1.ClearSelected();
                    warning.removeEmail = false;
                }
                else
                {
                    MessageBox.Show("You must have at least 1 email address. Please add an email address before deleting", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                    //checkedListBox1.ClearSelected();
                    //checkedListBox1.Items.RemoveAt(index);
                    //checkedListBox1.Items.Add("Please enter an email"); 
                    //checkedListBox1.Refresh();
                    //checkedListBox1.ClearSelected();
                    //warning.removeEmail = false;
                }

            }
            checkedListBox1.ClearSelected();

        }

        //delete "From" email address 
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmailWarning warning = new EmailWarning();
            warning.ShowDialog();

            //if user clicks "yes" to delete then delete appropriate index TODO
            if (warning.getRemoveEmail())
            {
                checkedListBox2.Items.RemoveAt(checkedListBox2.SelectedIndex);
                warning.removeEmail = false;
            }

        }

        //delete "CC" email addresses 
        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            EmailWarning warning = new EmailWarning();
            warning.ShowDialog();
            //if user clicks "yes" to delete then delete appropriate index 
            if (warning.getRemoveEmail())
            {
                checkedListBox3.Items.RemoveAt(checkedListBox3.SelectedIndex);
                warning.removeEmail = false;
            }

        }
    }
}
