using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing.Printing;

namespace FaturaveIrsaliyeSistemi
{
    public partial class f_irsaliyeislem : Form
    {
        public f_irsaliyeislem()
        {
            InitializeComponent();
        }
        islemler i = new islemler();

        private void iTalk_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbsecim_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                i.irsaliye_faturalistele(cbsecim, dgFaturalariGoster);
            }
            catch
            {
                return;
            }
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            
            //try
            //{
            //    string dosya_adi = tbDosyaAd.Text;
            //    int fat_no = Convert.ToInt32(dgFaturalariGoster.CurrentRow.Cells[0].Value);
            //    if (cbsecim.SelectedIndex == 1)
            //    {

            //        i.faturaexcel(dosya_adi, fat_no);
            //    }
            //    else if (cbsecim.SelectedIndex == 2)
            //    {
            //        i.irsaliyeexcel(dosya_adi,fat_no);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("HATA OLUŞTU , DOSYA ADI BOŞ OLABİLİR , TABLODAN SEÇİM YAPILMAMIŞ OLABİLİR","__--**HATA**--__");
            //}
        }

        private void ambiance_Button_12_Click(object sender, EventArgs e)
        {
            try
            {
                int no = Convert.ToInt32(dgFaturalariGoster.SelectedCells[0].Value);
                i.faturaKayitIptal(no);
                i.IrsaliyeIptal(no);
                i.irsaliye_faturalistele(cbsecim,dgFaturalariGoster);
            }
            catch
            {
                return;
            }
        }

        private void ambiance_Button_13_Click(object sender, EventArgs e)
        {
            try
            {
                string dosya_ad, mail_adr;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                dosya_ad = ofd.FileName.ToString();
                mail_adr = tbMailadrs.Text;
                i.mailgond(mail_adr, dosya_ad);
                tmDurum.Enabled = true;
            }
            catch
            {
                MessageBox.Show("BEKLENMEYEN HATA OLUŞTU");
            }
        }

        private void tmPrBar_Tick(object sender, EventArgs e)
        {
          
        }

        private void tmDurum_Tick(object sender, EventArgs e)
        {
            prBar.Value += 4;
            if(prBar.Value==100){
            lbMailDurum.Text = "GÖNDERİLDİ";
            }
           
        }
    }
}
