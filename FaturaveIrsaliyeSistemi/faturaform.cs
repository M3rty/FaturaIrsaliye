using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaveIrsaliyeSistemi
{
    public partial class faturaform : Form
    {
        public faturaform()
        {
            InitializeComponent();
        }
        islemler i = new islemler();
  

        private void faturaform_Load(object sender, EventArgs e)
        {
            
            i.urunlistele(dgUrunler);
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbSeri.Text) || string.IsNullOrWhiteSpace(tbIrsaliyeNo.Text) || 
               string.IsNullOrWhiteSpace(tbFaturaNo.Text) || string.IsNullOrWhiteSpace(tbMusteri.Text) ){
        MessageBox.Show("Fatura Bilgisi Eksik Girilmiş","--__Hata Eksik Bilgi__--");
            }
            else {
            FaturaPnl.Enabled = false;
            }
            
            }

        private void iTalk_Button_22_Click(object sender, EventArgs e)
        {
            FaturaPnl.Enabled = true;
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            if (FaturaPnl.Enabled == true)
            {
                MessageBox.Show("Fatura Bilgileri Kaydedilmemiş","Lütfen Kaydediniz");
            }
            else
            {
                string seri, musteri, vergi_daire, tarih, irs_tar, birim, urun_ad;
                int vergi_no, irs_no, barkod, fatura_no, durum, kdv,satilan;
                double tutar, fiyat, miktar;
                try
                {
                    
                    //String Olanlar
                    seri = tbSeri.Text;
                    musteri = tbMusteri.Text;
                    vergi_daire = tbVd.Text;
                    tarih = Convert.ToString(dtTarih.Value);
                    irs_tar =Convert.ToString(dtIrsaliyeTar.Value);
                    birim = dgUrunler.CurrentRow.Cells[5].Value.ToString();
                    urun_ad = dgUrunler.CurrentRow.Cells[1].Value.ToString();

                    //İnt Olanlar
                    vergi_no = Convert.ToInt32(tbVn.Text);
                    irs_no = Convert.ToInt32(tbIrsaliyeNo.Text);
                    barkod = Convert.ToInt32(dgUrunler.CurrentRow.Cells[2].Value);
                    fatura_no = Convert.ToInt32(tbFaturaNo.Text);
                    miktar = Convert.ToDouble(tbMiktar.Text);
                    durum = 0;
                    kdv = Convert.ToInt32(tbKdv.Text);
                    fiyat = Convert.ToDouble(dgUrunler.CurrentRow.Cells[6].Value);
                    tutar = fiyat * miktar;
                    satilan = Convert.ToInt32(tbMiktar.Text);
                    if(Convert.ToInt32(LblStok.Text)<=0){ MessageBox.Show("Bu Üründen Stokta Kalmamıştır!"); }
                    else {

                    i.faturaekle(seri, fatura_no, musteri, vergi_daire, vergi_no, tarih, irs_no, irs_tar, barkod, urun_ad, miktar, birim, tutar, durum, kdv,satilan);
                    i.f_UrunGoster(dgFUrunler, fatura_no);
                    }
                   
                }
                catch
                {
                   
                    MessageBox.Show("Miktar Bilgisi Girilmemiş");
                }
                       
            
            
            }


        }

        private void dgUrunler_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int barkod;
                barkod = Convert.ToInt32(dgUrunler.CurrentRow.Cells[2].Value);
                i.kalanstok(LblStok, barkod);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btUruniptal_Click(object sender, EventArgs e)
        {
            try
            {
                int barkod, fatura_no,miktar;

                barkod = Convert.ToInt32(dgFUrunler.CurrentRow.Cells[0].Value);
                fatura_no = Convert.ToInt32(tbFaturaNo.Text);
                miktar = Convert.ToInt32(dgFUrunler.CurrentRow.Cells[2].Value);
                i.FaturaUrunIptal(fatura_no, barkod,miktar);
                i.f_UrunGoster(dgFUrunler, fatura_no);
            }
            catch
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void btFaturaIptal_Click(object sender, EventArgs e)
        {
            int fatura_no;
            fatura_no = Convert.ToInt32(tbFaturaNo.Text);
            i.faturaKayitIptal(fatura_no);
        }

        private void btFaturaKaydetBitir_Click(object sender, EventArgs e)
        {
            int f_no;
            string seri;
            seri = tbSeri.Text;
            f_no = Convert.ToInt32(tbFaturaNo.Text);
            i.faturakaydetbitir(f_no,seri);
        }
    

    }
}
