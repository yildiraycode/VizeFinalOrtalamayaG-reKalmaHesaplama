using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeFinalOrtalamayaGöreKalmaHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            listBoxAdSoyad.Items.Add(txtAdSoyad.Text);
            int vize, final;
            double ortalama;

            vize = Convert.ToInt32(txtVize.Text);
            final = Convert.ToInt32(txtFinal.Text);

            ortalama = vize * 0.4 + final * 0.6;
            listBoxVize.Items.Add(txtVize.Text);
            listBoxFinal.Items.Add(txtFinal.Text);
            listBoxOrtalama.Items.Add(ortalama);
            if (ortalama >= 50)
            {
                listBoxDurum.Items.Add("GEÇTİ");
            }
            else
            {
                listBoxDurum.Items.Add("KALDI");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            txtVize.Clear();
            txtFinal.Clear();

        }
    }
}
