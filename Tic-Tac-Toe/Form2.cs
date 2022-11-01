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
    public partial class Form2 : Form
    {
        bool potez=true;
        public Form2()
        {
            InitializeComponent();
            Properties.Settings.Default.PrvoPokretanje = true;
            label1.Text = Properties.Settings.Default.ImePrvi + ": " + Properties.Settings.Default.BodoviPrvi;
            label1.Font = new Font(label1.Font,FontStyle.Bold);
            label3.Text = Properties.Settings.Default.ImeDrugi + ": " + Properties.Settings.Default.BodoviDrugi;
            label3.Font = new Font(label3.Font,  FontStyle.Bold);
            lblVodi.Text = "";
            label4.Text = DateTime.Now.ToString("dd.mm.yyyy hh:mm:ss");
        }
        private void ProvjeriPobjednika()
        {
            if (A1.Text == "X" && A2.Text=="X" && A3.Text =="X" || (B1.Text == "X" && B2.Text =="X" && B3.Text=="X") || (C1.Text =="X" && C2.Text=="X" && C3.Text=="X") || (A1.Text =="X" && B2.Text=="X" &&  C3.Text=="X") || (A3.Text =="X" && B2.Text=="X" &&  C1.Text=="X")||(A1.Text=="X" && B1.Text=="X" && C1.Text=="X")||(A2.Text=="X" && B2.Text=="X" && C2.Text=="X")||(A3.Text=="X" && B3.Text=="X" && C3.Text=="X"))
            {
  
                    Properties.Settings.Default.BodoviPrvi++;
                    MessageBox.Show("Pobjedio je " + Properties.Settings.Default.ImePrvi);
                    Properties.Settings.Default.ImamoPobjednika = true;
                    foreach (Control c in tableLayoutPanel1.Controls)
                    {
                        if (c is Button)
                        {
                            c.Enabled = true;
                            c.Text = "";
                        }
                    } 
                    label1.Text = Properties.Settings.Default.ImePrvi + ": " + Properties.Settings.Default.BodoviPrvi;
                    label1.Font = new Font(label1.Font, FontStyle.Underline|FontStyle.Bold);
                    label1.ForeColor = Color.Red;
                    label3.Font = new Font(label3.Font, FontStyle.Bold);
                    label3.ForeColor = Color.DarkBlue;
                    potez = true;
            }
            else if (A1.Text == "O" && A2.Text == "O" && A3.Text == "O" || (B1.Text == "O" && B2.Text == "O" && B3.Text == "O") || (C1.Text == "O" && C2.Text == "O" && C3.Text == "O") || (A1.Text == "O" && B2.Text == "O" && C3.Text == "O") || (A3.Text == "O" && B2.Text == "O" && C1.Text == "O")||(A1.Text=="O" && B1.Text=="O" && C1.Text=="O")||(A2.Text=="O" && B2.Text=="O" && C2.Text=="O")||(A3.Text=="O" && B3.Text=="O" && C3.Text=="O"))
            {
  
            
                Properties.Settings.Default.BodoviDrugi++;
                MessageBox.Show("Pobjedio je " + Properties.Settings.Default.ImeDrugi);
                Properties.Settings.Default.ImamoPobjednika = true;
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    if (c is Button)
                    {
                        c.Enabled = true;
                        c.Text = "";
                    }
                }
                label3.Text = Properties.Settings.Default.ImeDrugi + ": " + Properties.Settings.Default.BodoviDrugi;
                label3.Font = new Font(label3.Font, FontStyle.Underline|FontStyle.Bold);
                label3.ForeColor = Color.Red;
                label1.Font = new Font(label1.Font, FontStyle.Bold);
                label1.ForeColor = Color.DarkBlue;
                potez = true;
            }
        }
        private void Resetuj()
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is Button)
                {
                    c.Enabled = true;
                    c.Text = "";
                    label1.Text = Properties.Settings.Default.ImePrvi + " " + Properties.Settings.Default.BodoviPrvi;
                    label3.Text = Properties.Settings.Default.ImeDrugi + " " + Properties.Settings.Default.BodoviDrugi;
                    potez = true;
                }
            }
        }
        private void NemaPobjednika()
        {
            int br = 0;
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is Button)
                {
                    if (c.Text != "")
                    {
                        br++;
                        if (br == 9)
                        {
                            MessageBox.Show("Nemamo pobjednika");
                            Resetuj();
                        }
                    }
                }
            }
        }
        private void Klik(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (potez)
            {
                b.Text = "X";
                potez = !potez;
                b.ForeColor = Color.Green;
                ProvjeriPobjednika();
                NemaPobjednika();
            }
            else
            {
                b.Text = "O";
                potez = !potez;
                b.ForeColor = Color.DarkBlue;
                ProvjeriPobjednika();
                NemaPobjednika();
            }

               
        }

        private void tmrVrijeme_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("dd.MM.yyyy hh:mm:ss");
            if (Properties.Settings.Default.BodoviPrvi > Properties.Settings.Default.BodoviDrugi)
            {
                lblVodi.Text = "Vodi:" + Properties.Settings.Default.ImePrvi;
            }
            else if (Properties.Settings.Default.BodoviPrvi == Properties.Settings.Default.BodoviDrugi)
            {
                lblVodi.Text = "Izjednaceno";
            }

            else
                lblVodi.Text = "Vodi:" + Properties.Settings.Default.ImeDrugi;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}