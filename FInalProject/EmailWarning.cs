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
        public bool removeEmail = false; 
        public EmailWarning()
        {
            InitializeComponent();
        }
        public void yesButtonClick(object sender, EventArgs e)
        {
            //allow remove from list of names 
            MessageBox.Show("Will delete emails!");
            //removeEmail = true;
            Close(); 
        }

        public void cancelButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool getRemoveEmail()
        {
            return removeEmail; 
        }
    }
}
