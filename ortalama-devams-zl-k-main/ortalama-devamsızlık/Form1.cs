using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ortalama_devamsızlık
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double Ortalama, Devamsızlık;
            Ortalama = Convert.ToDouble(txtOrtalama.Text);
            Devamsızlık = Convert.ToDouble(txtDevamsızlık.Text);

            if (Ortalama >= 50 && Devamsızlık < 10) 
             {
            lblSonuc.Text = ("Geçti");
            }

            else
            { 
                lblSonuc.Text = ("Geçmedi");
            }
        }
    }
}
