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
    public partial class irsaliye : Form
    {
        public irsaliye()
        {
            InitializeComponent();
        }
        islemler i = new islemler();
        private void btFaturayaUrunEkle_Click(object sender, EventArgs e)
        {
            if (FaturaPnl.Enabled == true)
            {
                MessageBox.Show("Fatura Bilgileri Kaydedilmemiş");
            }
            else
            {
                try
                {
                    string seri, musteri, vergi_daire, duz_saat, duz_tar, sevk_tar, urun_adi, birim, teslim_eden, teslim_alan;
                    int irs_no, vergi_no, barkod, durumu, kdv, satilan;
                    double miktar, tutar, fiyat;


                    seri = tbSeri.Text;
                    musteri = tbMusteri.Text;
                    vergi_daire = tbVd.Text;
                    duz_saat = tbSaat.Text;
                    duz_tar = Convert.ToString(dtTarih.Value);
                    sevk_tar = Convert.ToString(dtSevkTar.Value);
                    urun_adi = dgUrunler.CurrentRow.Cells[1].Value.ToString();
                    birim = dgUrunler.CurrentRow.Cells[5].Value.ToString();
                    teslim_eden = tbTeslimEden.Text;
                    teslim_alan = tbTeslimAlan.Text;

                    irs_no = Convert.ToInt32(tbIrsNo.Text);
                    vergi_no = Convert.ToInt32(tbVn.Text);
                    barkod = Convert.ToInt32(dgUrunler.CurrentRow.Cells[2].Value);
                    miktar = Convert.ToDouble(tbMiktar.Text);
                    kdv = Convert.ToInt32(tbKdv.Text);
                    satilan = Convert.ToInt32(tbMiktar.Text);
                    fiyat = Convert.ToDouble(dgUrunler.CurrentRow.Cells[6].Value);
                    tutar = miktar * fiyat;
                    durumu = 0;
                    if (Convert.ToInt32(LblStok.Text) <= 0) { MessageBox.Show("Bu Üründen Stokta Kalmamıştır !"); }
                    else {
                    i.irsaliye_Ekle(seri, irs_no, musteri, vergi_daire, vergi_no, duz_saat, duz_tar, sevk_tar, barkod, urun_adi, miktar, birim, tutar, teslim_eden, teslim_alan, durumu, kdv);
                    i.irs_urun_gost(dgFUrunler, irs_no); 
                    }
                }
                catch(Exception hata)
                {
                    MessageBox.Show(hata.ToString());
                }
            }
        }

        private void irsaliye_Load(object sender, EventArgs e)
        {
            i.urunlistele(dgUrunler);    
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSeri.Text) || string.IsNullOrWhiteSpace(tbTeslimEden.Text) ||
               string.IsNullOrWhiteSpace(tbIrsNo.Text) || string.IsNullOrWhiteSpace(tbMusteri.Text))
            {
                MessageBox.Show("Fatura Bilgisi Eksik Girilmiş", "--__Hata Eksik Bilgi__--");
            }
            else
            {
                FaturaPnl.Enabled = false;
            }
        }

        private void btFaturaKaydetBitir_Click(object sender, EventArgs e)
        {
            try
            {
                string seri;
                int irs_no;
                seri = tbSeri.Text;
                irs_no = Convert.ToInt32(tbIrsNo.Text);
                i.IrsaliyeGToplam(irs_no, seri);
            }
            catch
            {
                MessageBox.Show("Bir Hata Oluştu");
            }
        }

        private void btUruniptal_Click(object sender, EventArgs e)
        {
            try
            {
                int barkod, irsaliye,miktar;

                barkod = Convert.ToInt32(dgFUrunler.CurrentRow.Cells[0].Value);
                irsaliye = Convert.ToInt32(tbIrsNo.Text);
                miktar= Convert.ToInt32(dgFUrunler.CurrentRow.Cells[2].Value);

                i.IrsaliyeUrunIptal(irsaliye, barkod,miktar);              
                i.irs_urun_gost(dgFUrunler, irsaliye);
                
            }
            catch
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void btFaturaIptal_Click(object sender, EventArgs e)
        {
            try
            {
                int irsaliye_no;

               
                irsaliye_no = Convert.ToInt32(tbIrsNo.Text);
                i.IrsaliyeIptal(irsaliye_no);
                i.urunlistele(dgUrunler);  
            }
            catch
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        private void dgUrunler_SelectionChanged(object sender, EventArgs e)
        {
            int barkod;
            barkod = Convert.ToInt32(dgUrunler.CurrentRow.Cells[2].Value);
            i.kalanstok(LblStok, barkod);
        }
    }
}
