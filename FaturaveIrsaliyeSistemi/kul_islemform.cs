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
    public partial class kul_islemform : Form
    {
        public kul_islemform()
        {
            InitializeComponent();
        }
        string kriter;

        islemler i = new islemler();
        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Clicked Meeee !");
        }

        private void kul_islemform_Load(object sender, EventArgs e)
        {
            //DataGridViewde Kullanıcıları Listeledik...
            i.kullanıcılistele(dgKullanicilar);
    
        }

        private void cbSifreGoster_CheckedChanged(object sender)
        {
            if (cbSifreGoster.Checked)  //Şifre Göstermenin Açık veya Kapalı Olması Kontrolü !!
            {
                tbKulSif.UseSystemPasswordChar = false;
            }
            else {
                tbKulSif.UseSystemPasswordChar = true;
            }
            
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            string ad, sad,dtarih, tc, kan, tel, kulad, kulsif;
            ad = tbAd.Text;
            sad = tbSoyad.Text;
            dtarih = Convert.ToString(dtTarihP.Value);
            tc = tbTc.Text;
            kan = cbKan.Text;
            tel = tbTel.Text;
            kulad = tbKulad.Text;
            kulsif = tbKulSif.Text;
            i.kullaniciekle(ad, sad, dtarih, tc, kan, tel, kulad, kulsif,dgKullanicilar);
            i.kullanıcılistele(dgKullanicilar);
            
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            if(dgKullanicilar.SelectedRows.Count>0){
            int kul_no;
            kul_no = Convert.ToInt32(dgKullanicilar.CurrentRow.Cells[0].Value);
            i.kullanici_sil(kul_no,dgKullanicilar);
            i.kullanıcılistele(dgKullanicilar);
            }
            else {
                MessageBox.Show("Tablodan Herhangi Bir Kişi Seçilmemiş...", "**HATA**");
            }
        }

        private void tbArama_TextChanged(object sender, EventArgs e)
        {
            string  kelimem;
            kelimem = tbArama.Text;
            i.kullanici_ara(kriter,kelimem,dgKullanicilar);
        }

        private void cbKriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        int kul_no;
        private void monoFlat_Button3_Click(object sender, EventArgs e)
        {
            if (dgKullanicilar.SelectedRows.Count > 0)
            {
               
                kul_no = Convert.ToInt32(dgKullanicilar.CurrentRow.Cells[0].Value);
                i.kul_GuncVeriCek(kul_no,tbAd,tbSoyad,dtTarihP,tbTc,cbKan,tbTel,tbKulad,tbKulSif,dgKullanicilar,btnDuzenle);
                
                pbEdit.Visible = true;
               
                
            }
            else
            {
                MessageBox.Show("Tablodan Herhangi Bir Kişi Seçilmemiş...", "**HATA**");
            }
           
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            
            string ad, sad, dtarih, tc, kan, tel, kulad, kulsif;
            ad = tbAd.Text;
            sad = tbSoyad.Text;
            dtarih = Convert.ToString(dtTarihP.Value);
            tc = tbTc.Text;
            kan = cbKan.Text;
            tel = tbTel.Text;
            kulad = tbKulad.Text;
            kulsif = tbKulSif.Text;
            i.kullanici_guncelle(kul_no,ad, sad, dtarih, tc, kan, tel, kulad, kulsif,btnDuzenle,dgKullanicilar);
            pbEdit.Visible = false;
            i.kullanıcılistele(dgKullanicilar);
        }

        private void cbKriter_SelectedValueChanged(object sender, EventArgs e)
        {
            int index;
            index = cbKriter.SelectedIndex;
            if (index == 0) { kriter = "adi"; }
            else if (index == 1) { kriter = "soyadi"; }
            else if (index == 2) { kriter = "tc_no"; }
            else if (index == 3) { kriter = "kul_adi"; }
            else { kriter = "adi"; }  //Varsayılan Olarak Adına Göre Araması İçin
        }

        private void cbKriter_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

    }
}
