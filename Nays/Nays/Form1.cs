using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nays
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            lblAciklama.Text = "TC Kimlik Numaranizin ilk 9 rakamini giriniz";
            lblAciklama.Location = new Point(lblAciklama.Location.X + 25, lblAciklama.Location.Y);
            btnBasla.Visible = false;
            btnTemizle.Visible = true;
            btnHesapla.Visible = true;
            txbTCGiris.Visible = true;
            pnlSayiGiris.Visible = true;
        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            btnBasla.Location = new Point(btnBasla.Location.X, btnBasla.Location.Y - 125);
        }

        private void btnSayi1_Click(object sender, EventArgs e)
        {
            if (txbTCGiris.TextLength < 9)
                txbTCGiris.Text += "1";
        }

        private void btnSayi2_Click(object sender, EventArgs e)
        {
            if (txbTCGiris.TextLength < 9)
                txbTCGiris.Text += "2";
        }

        private void btnSayi3_Click(object sender, EventArgs e)
        {
            if (txbTCGiris.TextLength < 9)
                txbTCGiris.Text += "3";
        }

        private void btnSayi4_Click(object sender, EventArgs e)
        {
            if (txbTCGiris.TextLength < 9)
                txbTCGiris.Text += "4";
        }

        private void btnSayi5_Click(object sender, EventArgs e)
        {
            if (txbTCGiris.TextLength < 9)
                txbTCGiris.Text += "5";
        }

        private void btnSayi6_Click(object sender, EventArgs e)
        {
            if (txbTCGiris.TextLength < 9)
                txbTCGiris.Text += "6";
        }

        private void btnSayi7_Click(object sender, EventArgs e)
        {
            if (txbTCGiris.TextLength < 9)
                txbTCGiris.Text += "7";
        }

        private void btnSayi8_Click(object sender, EventArgs e)
        {
            if (txbTCGiris.TextLength < 9)
                txbTCGiris.Text += "8";
        }

        private void btnSayi9_Click(object sender, EventArgs e)
        {
            if (txbTCGiris.TextLength < 9)
                txbTCGiris.Text += "9";
        }

        private void btnSayi0_Click(object sender, EventArgs e)
        {
            if (txbTCGiris.TextLength < 9)
                txbTCGiris.Text += "0";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblAciklama.Text = "TC Kimlik Numaranizin ilk 9 rakamini giriniz";
            txbTCGiris.Text = "";
        }

        private void txbTCGiris_TextChanged(object sender, EventArgs e)
        {
            if (txbTCGiris.TextLength >= 9)
            {
                btnHesapla.Enabled = true;
            }
            if (txbTCGiris.TextLength > 0)
            {
                btnTemizle.Enabled = true;
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int i;
            int ciftBas = 0, tekBas = 0;
            int TC = Convert.ToInt32(txbTCGiris.Text);
            int[] TCNo = new int[11];

            for (i = 0; i < 9; i++)
            {
                TCNo[i] = TC % 10;
                TC = (TC - TC % 10) / 10;
            }

            for(i = 0; i < 9; i++)
            {
                if(i % 2 == 0)
                {
                    ciftBas += TCNo[i];
                }
                if(i % 2 == 1)
                {
                    tekBas += TCNo[i];
                }
            }

            TCNo[9] = (ciftBas * 7 - tekBas) % 10;
            txbTCGiris.Text += TCNo[9];
            MessageBox.Show("TC Kimlik Numaranizin 10. rakami : " + TCNo[9].ToString() + "'dir.");
            TCNo[10] = (ciftBas + tekBas + TCNo[9]) % 10;
            txbTCGiris.Text += TCNo[10];
            MessageBox.Show("TC Kimlik Numaranizin 11. rakami : " + TCNo[10].ToString() + "'dir.");
            btnHesapla.Enabled = false;
            lblAciklama.Text = "TC Kimlik Numaranizin son iki rakamini bulduk.";
        }
    }
}
