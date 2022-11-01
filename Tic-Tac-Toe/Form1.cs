using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IKS_OKS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogovanje_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PrvoPokretanje = true;

            Properties.Settings.Default.ImePrvi = txtbPrviIgrac.Text;
            Properties.Settings.Default.ImeDrugi = txtbDrugiIgrac.Text;
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
            
   
        }

        private void tmrProvjeriPolja_Tick(object sender, EventArgs e)
        {
            if (txtbPrviIgrac.Text == "" || txtbDrugiIgrac.Text == "")
                btnLogovanje.Enabled = false;
            else btnLogovanje.Enabled = true;
        }
    }
}
