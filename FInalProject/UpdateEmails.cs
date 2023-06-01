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
            //check that email contains an @ symbol & .com/isn't empty
            if(email.Contains("@") && email.Contains(".com"))
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = checkedListBox1.SelectedIndex;
            EmailWarning warning = new EmailWarning();
            warning.ShowDialog();
            //if user clicks "yes" to delete then delete appropriate index TODO
            if(warning.getRemoveEmail())
            {
                //checkedListBox1.Items.RemoveAt(index);
                warning.removeEmail = false;
            }
            //reloadUpdateEmail();
            
        }
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
