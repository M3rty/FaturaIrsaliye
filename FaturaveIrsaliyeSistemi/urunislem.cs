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
    public partial class urunislem : Form
    {
        public urunislem()
        {
            InitializeComponent();
        }

        islemler i = new islemler();


        private void urunislem_Load(object sender, EventArgs e)
        {
            i.urunlistele(dgUrunler);
            i.birimListele(cbBirimm);
            i.kategorilist(cbKategorim);
        }

        private void urnSil_Click(object sender, EventArgs e)
        {
            if (dgUrunler.SelectedRows.Count > 0)
            {
                int urun_no;
                urun_no = Convert.ToInt32(dgUrunler.CurrentRow.Cells[0].Value);
                i.urun_sil(urun_no, dgUrunler);
                i.urunlistele(dgUrunler);
            }
            else
            {
                MessageBox.Show("Tablodan Herhangi Bir Ürün Seçilmemiş...", "**HATA**");
            }
        }

        int urun_no;
        private void urnGunc_Click(object sender, EventArgs e)
        {

           
            if (dgUrunler.SelectedRows.Count > 0)
            {

                urun_no = Convert.ToInt32(dgUrunler.CurrentRow.Cells[0].Value);
                i.urunGuncVeriCek(urun_no,tbUrunAd,tbBarkod,cbKategorim,tbStok,cbBirimm,tbFiyat,btGunc,dgUrunler);
                i.urunlistele(dgUrunler);
                pbGunc.Visible = true;
            }
            else
            {
                MessageBox.Show("Tablodan Herhangi Bir Kişi Seçilmemiş...", "**HATA**");
            }
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {

            string value = cbKategorim.SelectedValue.ToString();
            
            
        }

        private void btGunc_Click(object sender, EventArgs e)
        {
            string urun_adi;
            int  u_barkod, u_kategori, u_stok, u_birim;
            double u_fiyat;
            urun_adi = tbUrunAd.Text;
            u_barkod = Convert.ToInt32(tbBarkod.Text);

            u_kategori = Convert.ToInt32(cbKategorim.SelectedValue);

            u_stok = Convert.ToInt32(tbStok.Text);

            u_birim = Convert.ToInt32(cbBirimm.SelectedValue);

            u_fiyat=Convert.ToDouble(tbFiyat.Text);

            i.urunGuncelle(urun_no,urun_adi,u_barkod,u_kategori,u_stok,u_birim,u_fiyat,btGunc,dgUrunler);

        }

        private void urnEkle_Click(object sender, EventArgs e)
        {
            string urun_adi;
            int u_barkod, u_kategori, u_stok, u_birim;
            double u_fiyat;
            urun_adi = tbUrunAd.Text;
            u_barkod = Convert.ToInt32(tbBarkod.Text);

            u_kategori = Convert.ToInt32(cbKategorim.SelectedValue);

            u_stok = Convert.ToInt32(tbStok.Text);

            u_birim = Convert.ToInt32(cbBirimm.SelectedValue);

            u_fiyat = Convert.ToDouble(tbFiyat.Text);

            i.urunEkle(urun_adi, u_barkod, u_kategori, u_stok, u_birim, u_fiyat, dgUrunler);
            i.urunlistele(dgUrunler);
        }

        string kriter;
        private void monoFlat_TextBox1_TextChanged(object sender, EventArgs e)
        {
            string kelimem;
            kelimem = tbUrunAra.Text;
            i.urun_ara(kriter, kelimem, dgUrunler);
        }

        private void cbKriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = cbKriter.SelectedIndex;
            if (index == 0) { kriter = "urun_adi";  }
            else if (index == 1) { kriter = "urun_barkod"; }
            else { kriter = "urun_barkod";  } 
        }

        private void ambiance_Button_11_Click(object sender, EventArgs e)
        {
            try
            {
                int stok, barkod;
                barkod = Convert.ToInt32(dgUrunler.CurrentRow.Cells[2].Value);
                stok = Convert.ToInt32(tbStokEkle.Text);
                if (dgUrunler.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Tablodan Ürün Seçini Yapılmamış");
                }
                else
                {
                    i.stokekle(stok, barkod);
                    i.urunlistele(dgUrunler);
                }
            }
            catch
            {
                MessageBox.Show("Stok Miktarı Girilmemiş");
            }
        }
    }
}
