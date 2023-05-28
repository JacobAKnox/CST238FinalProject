using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class EmailWarning : Form
    {
        public EmailWarning()
        {
            InitializeComponent();
        }
        public void button1Click(object sender, EventArgs e)
        {
            //remove from list of names 
            MessageBox.Show("will allow email to be removed from list");
        }

        public void button2Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
