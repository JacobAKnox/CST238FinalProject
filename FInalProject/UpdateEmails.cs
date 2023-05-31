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

    }
}
