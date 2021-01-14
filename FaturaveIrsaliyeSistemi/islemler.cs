using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using iTalk;
using MonoFlat;
using Ambiance;
//using iTextSharp.text.pdf;
//using Microsoft.Office.Core;
//using Microsoft.Office.Interop;
using System.Net;
using System.Net.Mail;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.Collections;

namespace FaturaveIrsaliyeSistemi
{
    class islemler
    {
        string bag_cumlem = "Data Source=MERT Initial Catalog=faturaveirsaliye Integrated Security=True";



        public void girisyap(string tbkul_adi, string tbkul_sif, iTalk_Panel girispanel, MonoFlat_Panel anapanel)
        {
            if (string.IsNullOrWhiteSpace(tbkul_adi) || (string.IsNullOrWhiteSpace(tbkul_sif)))
            {
                MessageBox.Show("Giriş Başarısız! Eksiksiz Giriniz!", "..:: HATA ::..", //Boş Girildiyse Hata Vermesi İçin
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sql;
             
                try
                {
                    SqlConnection b = new SqlConnection();
                    b.ConnectionString = bag_cumlem;
                    b.Open();  
                    sql = "Select * from kullanicilar where kul_adi=@k_adi and kul_sifre=@k_sif";
                    SqlParameter p1 = new SqlParameter("@k_adi", tbkul_adi); //Sql Açıklarına Karşı Kullandık
                    SqlParameter p2 = new SqlParameter("@k_sif", tbkul_sif);
                    SqlCommand k = new SqlCommand(sql, b);
                    k.Parameters.Add(p1);
                    k.Parameters.Add(p2);
                    DataTable t = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(k);
                    da.Fill(t);

                    if (t.Rows.Count > 0)
                    {
                        //Giriş Yapıldıysa Yapılacak İşlemler
                        girispanel.Visible = false;

                        anapanel.Controls.Clear();
                        adminform af = new adminform();
                        af.TopLevel = false;
                        anapanel.Controls.Add(af);
                        af.Show();
                        af.Dock = DockStyle.Fill;
                        af.BringToFront();
                    }
                    else  //Parola Yanlış İse
                    {
                        MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı...", "**HATA**");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void kullanıcılistele(DataGridView dg)
        {
            SqlConnection b = new SqlConnection();
            b.ConnectionString = bag_cumlem;
            b.Open();
            string sql = "Select * from kullanicilar";
            SqlDataAdapter da = new SqlDataAdapter(sql, b);
            DataTable t = new DataTable();
            da.Fill(t);
            dg.DataSource = t;
            dg.Columns[0].HeaderText = "Kayıt No";
            dg.Columns[0].Width = 100;

            dg.Columns[1].HeaderText = "Adı";
            dg.Columns[1].Width = 100;

            dg.Columns[2].HeaderText = "Soyadı";
            dg.Columns[2].Width = 100;

            dg.Columns[3].HeaderText = "Doğum Tarihi";
            dg.Columns[3].Width = 150;

            dg.Columns[4].HeaderText = "Tc No";
            dg.Columns[4].Width = 100;

            dg.Columns[5].HeaderText = "Kan Grubu";
            dg.Columns[5].Width = 150;

            dg.Columns[6].HeaderText = "Telefon No";
            dg.Columns[6].Width = 150;

            dg.Columns[7].HeaderText = "Kullanıcı Adı";
            dg.Columns[7].Width = 150;

            dg.Columns[8].HeaderText = "Şifre";
            dg.Columns[8].Width = 150;
        }

        public void kullaniciekle(string adi, string soyadi, string dt, string tc, string kan_grubu, string tel_no,
            string kul_adi, string sifre, DataGridView dgview)
        {

            try
            {
                if (string.IsNullOrEmpty(adi) || string.IsNullOrEmpty(soyadi) || string.IsNullOrWhiteSpace(tc) || string.IsNullOrWhiteSpace(kul_adi) || string.IsNullOrWhiteSpace(sifre))
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız", "**__--LÜTFEN--__**");

                }
                else
                {
                    SqlConnection b = new SqlConnection();
                    b.ConnectionString = bag_cumlem;
                    b.Open();
                    string sql2 = "Select * from kullanicilar where tc_no='"+tc+"'";
                    SqlDataAdapter da = new SqlDataAdapter(sql2,b);
                    DataTable t = new DataTable();
                    da.Fill(t);
                    if (t.Rows.Count > 0)
                    {
                        MessageBox.Show("Bu Kullanıcı Sistemde Kayıtlıdır");
                    }
                    else
                    {

                        string sql = "Exec spKullaniciEkle '" + adi + "' ,'" + soyadi + "' ,'" + dt + "','" + tc + "','" + kan_grubu + "','" + tel_no + "','" + kul_adi + "','" + sifre + "'";

                        SqlCommand k = new SqlCommand(sql, b);
                        k.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Başarıyla Eklendi");
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Kayıt Yapılırken Hata Oluştu");
            }


        }

        public void kullanici_sil(int kayit_no, DataGridView dgview)
        {
            try
            {
                string sql = "Exec spKullaniciSil '" + kayit_no + "'";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlCommand k = new SqlCommand(sql, b);
                k.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
                //   dgview.Update();
            }
            catch
            {
                MessageBox.Show("Kayıt Silinirken Hata Oluştu. Kullanıcı Seçilmemiş");
            }

        }
        public void kullanici_ara(string kriter, string kelime, DataGridView dg)
        {
            try
            {
                string sql = "Select * from kullanicilar where " + kriter + " like '%" + kelime + "%' ";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, b);
                DataTable t = new DataTable();
                da.Fill(t);
                dg.DataSource = t;
            }
            catch
            {
                MessageBox.Show("Bir Hata Arama Yapılırken Bir Hata Oluştu Arama Kriteri Seçilmemiş", "__--Hata--__");
                return;
            }
        }
        public void kullanici_guncelle(int id, string adi, string soyadi, string dt, string tc, string kan_grubu, string tel_no,
            string kul_adi, string sifre, Ambiance_Button_1 btngunc, DataGridView dgview)
        {
            try
            {
                string sql = "Exec spKulGuncelle '" + id + "','" + adi + "' ,'" + soyadi + "' ,'" + dt.ToString() + "','" + tc + "','" + kan_grubu + "','" + tel_no + "','" + kul_adi + "','" + sifre + "'";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlCommand k = new SqlCommand(sql, b);
                k.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarıyla Güncellendi");
                btngunc.Visible = false;
              
            }
            catch
            {
                MessageBox.Show("Kayıt Güncellenirken Hata Oluştu");
            }
        }
        public void kul_GuncVeriCek(int no, iTalk_TextBox_Small ad, iTalk_TextBox_Small sad, DateTimePicker dt
            , iTalk_TextBox_Small tc, iTalk_ComboBox kan_g, iTalk_TextBox_Small tel, iTalk_TextBox_Small kul_ad,
            iTalk_TextBox_Small kul_sifre, DataGridView dg, Ambiance_Button_1 btduzenle)
        {

            try
            {
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                string sql = "Select * from kullanicilar where kul_no='" + no + "'";
                SqlCommand k = new SqlCommand(sql, b);
                SqlDataReader dr = k.ExecuteReader();
                while (dr.Read())
                {
                    ad.Text = dr["adi"].ToString();
                    sad.Text = dr["soyadi"].ToString();
                    dt.Text = dr["dog_tar"].ToString();
                    tc.Text = dr["tc_no"].ToString();
                    kan_g.Text = dr["kan_grub"].ToString();
                    tel.Text = dr["tel_no"].ToString();
                    kul_ad.Text = dr["kul_adi"].ToString();
                    kul_sifre.Text = dr["kul_sifre"].ToString();
                    btduzenle.Visible = true;
                }

            }
            catch
            {
                MessageBox.Show("Kullanıcı Getirilirken bir hata oluştu tekrar deneyiniz");
            }

        }

        public void urunlistele(DataGridView dg)
        {
            string sql = "Select u.urun_id, u.urun_adi,u.urun_barkod,uk.kategori,u.stok,ub.birim,u.fiyat from urunler u, urunkategori uk, urun_birim ub Where uk.kategori_no=u.urun_kategori and ub.birim_no=u.birim";

            SqlConnection b = new SqlConnection();
            b.ConnectionString = bag_cumlem;
            SqlDataAdapter da = new SqlDataAdapter(sql, b);
            DataTable t = new DataTable();
            da.Fill(t);
            dg.DataSource = t;

            dg.Columns[0].HeaderText = "Kayıt No";
            dg.Columns[0].Width = 100;

            dg.Columns[1].HeaderText = "Ürün Adı";
            dg.Columns[1].Width = 100;

            dg.Columns[2].HeaderText = "Ürün Barkodu";
            dg.Columns[2].Width = 150;

            dg.Columns[3].HeaderText = "Ürün Kategori";
            dg.Columns[3].Width = 150;

            dg.Columns[4].HeaderText = "Stok";
            dg.Columns[4].Width = 100;

            dg.Columns[5].HeaderText = "Birim";
            dg.Columns[5].Width = 150;

            dg.Columns[6].HeaderText = "Fiyat";
            dg.Columns[6].Width = 150;
        }

        public void kategorilist(Ambiance_ComboBox cbUrunler)
        {
            string sql = "Select * from urunkategori";
            SqlConnection b = new SqlConnection();
            b.ConnectionString = bag_cumlem;
            b.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, b);
            DataTable t = new DataTable();
            da.Fill(t);
            cbUrunler.DataSource = t;
            cbUrunler.DisplayMember = t.Columns[1].ColumnName;
            cbUrunler.ValueMember = t.Columns[0].ColumnName;
        }

        public void birimListele(Ambiance_ComboBox cbBirim)
        {
            string sql = "Select * from urun_birim";
            SqlConnection b = new SqlConnection();
            b.ConnectionString = bag_cumlem;
            b.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, b);
            DataTable t = new DataTable();
            da.Fill(t);
            cbBirim.DataSource = t;
            cbBirim.DisplayMember = t.Columns[1].ColumnName;
            cbBirim.ValueMember = t.Columns[0].ColumnName;
        }
        public void urun_sil(int urun_no, DataGridView dgview)
        {
            try
            {
                string sql = "Exec spUrunSil '" + urun_no + "'";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlCommand k = new SqlCommand(sql, b);
                k.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti");
                dgview.Refresh();
            }
            catch
            {
                MessageBox.Show("Kayıt Silinirken Hata Oluştu. Kullanıcı Seçilmemiş");
            }

        }

        public void urunGuncVeriCek(int no, Ambiance_TextBox tbUAdi, Ambiance_TextBox tbUBarkod, Ambiance_ComboBox cbKategori,
                                    Ambiance_TextBox Tb_Stok, Ambiance_ComboBox CbBirim, Ambiance_TextBox TbFiyat,
                                    iTalk_Button_2 btnDuzenle, DataGridView dgUrun)
        {

            try
            {
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                string sql = "Select * from urunler where urun_id='" + no + "'";
                SqlCommand k = new SqlCommand(sql, b);
                SqlDataReader dr = k.ExecuteReader();
                while (dr.Read())
                {
                    tbUAdi.Text = dr["urun_adi"].ToString();
                    tbUBarkod.Text = dr["urun_barkod"].ToString();
                    cbKategori.Text = dr["urun_kategori"].ToString();
                    Tb_Stok.Text = dr["stok"].ToString();
                    CbBirim.Text = dr["birim"].ToString();
                    TbFiyat.Text = dr["fiyat"].ToString();

                    btnDuzenle.Visible = true;
                }

            }
            catch
            {
                MessageBox.Show("Kullanıcı Getirilirken bir hata oluştu tekrar deneyiniz");
            }

        }


        public void urunGuncelle(int id, string u_ad, int u_Barkod, int u_Kategori, int u_Stok, int u_Birim, double u_Fiyat,
           iTalk_Button_2 btGuncellendi, DataGridView dg)
        {
            try
            {
                string sql = "Exec spUrunGunc '" + id + "','" + u_ad + "' ,'" + u_Barkod + "' ,'" + u_Kategori + "','" + u_Stok + "','" + u_Birim + "','" + u_Fiyat + "' ";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlCommand k = new SqlCommand(sql, b);
                k.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarıyla Güncellendi");
                btGuncellendi.Visible = false;
            }
            catch (Exception mesaj)
            {
                MessageBox.Show("Kayıt Güncellenirken Hata Oluştu");
                MessageBox.Show(Convert.ToString(mesaj));
            }

        }

        public void urunEkle(string urunAdi, int urunBarkod, int urunkategori, int stok, int birim, double fiyat,
            DataGridView dgview)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(urunAdi))
                {
                    MessageBox.Show("Lütfen Boş Alan Bırakmayınız", "**__--BOŞ ALAN--__**");

                }
                else
                {
                    SqlConnection b = new SqlConnection();
                    b.ConnectionString = bag_cumlem;
                    b.Open();

                    string sql2 = "Select * from urunler where urun_barkod='"+urunBarkod+"'";
                    SqlDataAdapter da = new SqlDataAdapter(sql2,b);
                    DataTable t = new DataTable();
                    da.Fill(t);
                    if(t.Rows.Count>0){
                    MessageBox.Show("Bu ürün Sistemde Kayıtlıdır");
                    }
                    else {

                    string sql = "Exec spUrunEkle '" + urunAdi + "' ,'" + urunBarkod + "' ,'" + urunkategori + "','" + stok + "','" + birim + "','" + fiyat + "'";
                    
                    SqlCommand k = new SqlCommand(sql, b);
                    k.ExecuteNonQuery();
                    MessageBox.Show("Ürün Kaydı Başarıyla Eklendi");
                    dgview.Refresh();
                    dgview.Update();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Ürün Kaydı Yapılırken Hata Oluştu");
            }

        }

        public void urun_ara(string kriter, string kelime, DataGridView dg)
        {
            try
            {
                string sql = "Select * from urunler where " + kriter + " like '%" + kelime + "%' ";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, b);
                DataTable t = new DataTable();
                da.Fill(t);
                dg.DataSource = t;
            }
            catch
            {
                MessageBox.Show("Bir Hata Arama Yapılırken Bir Hata Oluştu Arama Kriteri Seçilmemiş", "__--Hata--__");
            }

        }
        public void stokekle(int stok , int urunbarkod)
        {
            try
            {
                string sql = "Update urunler set stok= stok + '" + stok + "' where urun_barkod=" + urunbarkod + " ";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlCommand k = new SqlCommand(sql, b);
                k.ExecuteNonQuery();
                MessageBox.Show("Stok Başarıyla Eklendi");
            }
            catch
            {
               
                MessageBox.Show("Stok Güncellenirken Hata Oluştu");
            }

        }

        
        public void faturaekle(string seri,int fatura_no,string musteri,string vergi_daire,int vergi_no,string tarih,int irs_no,
            string irs_tar,int barkod,string urun_adi,double miktar,string birim , double tutar,int durumu,int kdv,int satilan)
        {
            double toplam, genel_toplam;
            toplam = 0;
            genel_toplam = 0;

            SqlConnection b = new SqlConnection();
            b.ConnectionString = bag_cumlem;
            b.Open();
            try
            {
                    string sql1 = "Exec spFaturaKaydet '" + seri + "' ,  '" + fatura_no + "' , '" + musteri + "' , '" + vergi_daire + "' , '" + vergi_no + "'  , '" + tarih.ToString() + "'  , '" + irs_no + "'  , '" + irs_tar.ToString() + "'  , '" + barkod + "'  , '" + urun_adi + "'  , '" + miktar + "' , '" + birim + "'  , '" + tutar + "'  , '" + durumu + "'  ,'" + toplam + "' , '" + kdv + "' , '" + genel_toplam + "' ";
                    SqlCommand k = new SqlCommand(sql1, b);
                    k.ExecuteNonQuery();
                    MessageBox.Show("Ürün Başarıyla Eklendi");

                    string sqlstokdusur = "Exec spStokDusur '"+barkod+"' , '"+satilan+"'";
                    SqlCommand k2 = new SqlCommand(sqlstokdusur,b);
                    k2.ExecuteNonQuery();                    
            }
            catch
            {
                MessageBox.Show("Beklenmeyen Hata Oluştu!!!","--__HATA__--");
            }
        }
        public void kalanstok(iTalk_Label lblStok,int urun_barkod) {
            try
            {
                string sql = "Select stok from urunler where urun_barkod='" + urun_barkod + "'";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, b);
                DataTable t = new DataTable();
                da.Fill(t);
                lblStok.Text = Convert.ToString(t.Rows[0][0]);
            }
            catch
            {
                MessageBox.Show("Stok Getirilirken Hata Oluştu");
            }

        }

        public void f_UrunGoster(DataGridView dg,int f_no)
        {
            string sql = "Select barkod,urun_adi,miktar,birim,tutar from fatura where fatura_no='"+f_no+"'";
            SqlConnection b = new SqlConnection();
            b.ConnectionString = bag_cumlem;
            SqlDataAdapter da = new SqlDataAdapter(sql, b);
            DataTable t = new DataTable();
            da.Fill(t);
            dg.DataSource = t;

            dg.Columns[0].HeaderText = "Barkodu";
            dg.Columns[0].Width = 150;

            dg.Columns[1].HeaderText = "Ürün Adı";
            dg.Columns[1].Width = 150;

            dg.Columns[2].HeaderText = "Miktarı";
            dg.Columns[2].Width = 150;

            dg.Columns[3].HeaderText = "Birimi";
            dg.Columns[3].Width = 150;

            dg.Columns[3].HeaderText = "Tutarı";
            dg.Columns[3].Width = 150;


        }


        public void FaturaUrunIptal(int fatura_no,int urun_barkod,int miktar)
        {
            try
            {
                string sql = "Exec spFaturaurunSil " + fatura_no + ", " + urun_barkod + " , "+miktar+"";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlCommand k = new SqlCommand(sql, b);
                k.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Silindi !!","__--Başarılı--__");
            }
            catch
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        public void faturaKayitIptal(int fatura_no)
        {
            try
            {
                string sql = "Exec spFaturaSil " + fatura_no + " ";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlCommand k = new SqlCommand(sql, b);
                k.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Silindi !!", "__--Başarılı--__");
            }
            catch {
                MessageBox.Show("Fatura İptal Edilirken Bir Hata Oluştu");
            }
        }
        public void faturakaydetbitir(int faturano,string seri)
        {
            try
            {
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();

                string sql = "Exec spGenelToplam "+faturano+" ,"+seri+" ";
                SqlCommand k = new SqlCommand(sql, b);
                k.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Kaydedildi !!", "__--Başarılı--__");
            }
            catch
            {
                MessageBox.Show("Fatura Kaydedilemedi");
            }
        }

        public void irsaliye_Ekle(string seri, int irs_no, string musteri, string vergi_daire, int vergi_no, string duz_saat, string duz_tar,
           string sevk_tar, int barkod, string urun_adi, double miktar, string birim, double tutar,string teslim_eden,string teslim_alan, int durumu,int kdv)
        {
            double toplam, genel_toplam;
            toplam = 0;
            genel_toplam = 0;

            SqlConnection b = new SqlConnection();
            b.ConnectionString = bag_cumlem;
            b.Open();
            try
            {
                string sql1 = "Exec spIrsaliyeKayit '"+seri+"','"+irs_no+"','"+musteri+"','"+vergi_daire+"','"+vergi_no+"','"+duz_saat+"','"+duz_tar+"','"+sevk_tar+"','"+barkod+"','"+urun_adi+"','"+miktar+"','"+birim+"','"+tutar+"','"+teslim_eden+"','"+teslim_alan+"','"+durumu+"','"+toplam+"','"+kdv+"','"+genel_toplam+"'";
                SqlCommand k = new SqlCommand(sql1, b);
                k.ExecuteNonQuery();
                MessageBox.Show("Ürün Başarıyla Eklendi");

                string sqlstokdusur = "Exec spStokDusur '" + barkod + "' , '" + miktar + "'";
                SqlCommand k2 = new SqlCommand(sqlstokdusur, b);
                k2.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Beklenmeyen Hata Oluştu!!!", "--__HATA__--");
            }
        }
        public void irs_urun_gost(DataGridView dg, int irs_no)
        {
            string sql = "Select barkod,urun_adi,miktar,birim,tutar from irsaliye where irsaliye_no='" + irs_no + "'";
            SqlConnection b = new SqlConnection();
            b.ConnectionString = bag_cumlem;
            SqlDataAdapter da = new SqlDataAdapter(sql, b);
            DataTable t = new DataTable();
            da.Fill(t);
            dg.DataSource = t;

            dg.Columns[0].HeaderText = "Barkodu";
            dg.Columns[0].Width = 150;

            dg.Columns[1].HeaderText = "Ürün Adı";
            dg.Columns[1].Width = 150;

            dg.Columns[2].HeaderText = "Miktarı";
            dg.Columns[2].Width = 150;

            dg.Columns[3].HeaderText = "Birimi";
            dg.Columns[3].Width = 150;

            dg.Columns[3].HeaderText = "Tutarı";
            dg.Columns[3].Width = 150;


        }
        public void IrsaliyeGToplam(int irsaliye_no,string seri)
        {
            try
            {
                string sql = "Exec spIrsaliyeGToplam " + irsaliye_no + " , '" + seri + "'";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlCommand k = new SqlCommand(sql, b);
                k.ExecuteNonQuery();
                MessageBox.Show("Fatura Başarıyla Kaydedildi");
            }
            catch(Exception msj)
            {
                MessageBox.Show(msj.ToString());
            }
        }

        public void IrsaliyeUrunIptal(int irsaliye_no, int urun_barkod,int miktar)
        {
            try
            {
                string sql = "Exec spIrsaliyeUrunSil '" + irsaliye_no + "', '" + urun_barkod + "' ,'"+miktar+"' ";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlCommand k = new SqlCommand(sql, b);
                k.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Silindi !!", "__--Başarılı--__");
            }
            catch
            {
                MessageBox.Show("Hata Oluştu");
            }
        }

        public void IrsaliyeIptal(int irsaliye_no)
        {
            try
            {
                string sql = "Exec spIrsaliyeSil " + irsaliye_no + " ";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlCommand k = new SqlCommand(sql, b);
                k.ExecuteNonQuery();
                MessageBox.Show("Fatura Başarıyla Silindi");
            }
            catch
            {
                MessageBox.Show("Fatura İptal Edilirken Bir Hata Oluştu");
            }
        }
        //FATURA İRSALİYE LİSTELEME
        public void irsaliye_faturalistele(iTalk_ComboBox cb,DataGridView dg){
            string sql;
            if(cb.SelectedIndex==1){
                sql = "Select DISTINCT(fatura_no)  fatura_no,isim_unvan,vergi_d,vergi_no,irsaliye_tarihi,kdv,genel_toplam from fatura ";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, b);
                DataTable t = new DataTable();
                da.Fill(t);
                dg.DataSource = t;

                dg.Columns[0].HeaderText = "FATURA NO";
                dg.Columns[0].Width = 150;

                dg.Columns[1].HeaderText = "MÜŞTERİ";
                dg.Columns[1].Width = 150;

                dg.Columns[2].HeaderText = "VERGİ DAİRESİ";
                dg.Columns[2].Width = 150;

                dg.Columns[3].HeaderText = "VERGİ NO";
                dg.Columns[3].Width = 150;

                dg.Columns[3].HeaderText = "İRSALİYE TARİHİ";
                dg.Columns[3].Width = 150;

                dg.Columns[3].HeaderText = "KDV";
                dg.Columns[3].Width = 150;

                dg.Columns[3].HeaderText = "GENEL TOPLAM";
                dg.Columns[3].Width = 150;
            }
            else if(cb.SelectedIndex==2){
                sql = "Select DISTINCT(irsaliye_no) irsaliye_no,isim_unvan,vergi_d,vergi_no,duz_tar,kdv,genel_toplam from irsaliye";
                SqlConnection b = new SqlConnection();
                b.ConnectionString = bag_cumlem;
                b.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, b);
                DataTable t = new DataTable();
                da.Fill(t);
                dg.DataSource = t;
                dg.Columns[0].HeaderText = "İRSALİYE NO";
                dg.Columns[0].Width = 150;

                dg.Columns[1].HeaderText = "MÜŞTERİ";
                dg.Columns[1].Width = 150;

                dg.Columns[2].HeaderText = "VERGİ DAİRESİ";
                dg.Columns[2].Width = 150;

                dg.Columns[3].HeaderText = "VERGİ NO";
                dg.Columns[3].Width = 150;

                dg.Columns[4].HeaderText = "TARİH";
                dg.Columns[4].Width = 150;

                dg.Columns[5].HeaderText = "KDV";
                dg.Columns[5].Width = 150;

                dg.Columns[6].HeaderText = "GENEL TOPLAM";
                dg.Columns[6].Width = 150;

            }
            else if(cb.SelectedIndex==0){
                
            }
            else
            {
                MessageBox.Show("Seçim Yapılmamış","__--ERROR--__");
            }
            try
            {
              
            }
            catch{
                MessageBox.Show("BİR HATA OLUŞTU");
            }
        }




        //----------------_ _ _ _ _ _ _ _ _ _ Fatura Yazdırma ve Görüntüleme İşlemleri _ _ _ _ _ _ _ _ _ _ _ _ ----------------


        //public void faturaexcel(string dosya_adi, int fatura_no) 
        //{
        //    try
        //    {
        //        Microsoft.Office.Interop.Excel.Application exceldosyam;
        //        Microsoft.Office.Interop.Excel.Workbook excelkitabim;
        //        Microsoft.Office.Interop.Excel.Worksheet excelSayfam;

        //        exceldosyam = new Microsoft.Office.Interop.Excel.Application();
        //        exceldosyam.Visible = true;

        //        object sayfa = true;

        //        excelkitabim = exceldosyam.Workbooks.Add(sayfa);

        //        excelSayfam = exceldosyam.Application.Sheets[1];

        //        object hangiSayfaAktif = 1;
        //        excelSayfam.Select(hangiSayfaAktif);

        //        string sql = "Select * from fatura where fatura_no="+fatura_no+" ";
        //        SqlConnection b = new SqlConnection();
        //        b.ConnectionString = bag_cumlem;
        //        b.Open();
        //        SqlDataAdapter da = new SqlDataAdapter(sql, b);
        //        DataTable t = new DataTable();
        //        da.Fill(t);
        //        string seri1,fatura_no1,isim,vergi_d,vergi_no,tarih,irs_no,irs_tar,barkod,urun_ad,miktar,birim,tutar,toplam,kdv,genel_top;
        //        seri1 = t.Rows[0][1].ToString();
        //        fatura_no1 = t.Rows[0][2].ToString();
        //        isim = t.Rows[0][3].ToString();
        //        vergi_d = t.Rows[0][4].ToString();
        //        vergi_no = t.Rows[0][5].ToString();
        //        tarih = t.Rows[0][6].ToString();
        //        irs_no = t.Rows[0][7].ToString();
        //        irs_tar = t.Rows[0][8].ToString();
        //        toplam = t.Rows[0][15].ToString(); // fiyat*adet
        //        kdv = t.Rows[0][16].ToString();
        //        genel_top = t.Rows[0][17].ToString();

        //        int satir = 15;
        //        int i;
        //        for (i = 0; i <= t.Rows.Count - 1;i++ )
        //        {
        //            barkod = t.Rows[i][9].ToString();
        //            urun_ad = t.Rows[i][10].ToString();
        //            miktar = t.Rows[i][11].ToString();
        //            birim = t.Rows[i][12].ToString();
        //            tutar = t.Rows[i][13].ToString(); //Fiyat * Adet
        //            satir++;

        //            excelSayfam.Cells[satir, 1] = urun_ad;
        //            excelSayfam.Cells[satir, 4] = barkod;
        //            excelSayfam.Cells[satir, 5] = birim;
        //            excelSayfam.Cells[satir, 6] = miktar;
        //          //   excelSayfam.Cells[18, 7] = ;  Birim Fiyat
        //            excelSayfam.Cells[satir, 8] = tutar;
        //        }
        //        string logo_yol = "C:\\Users\\Mert\\Desktop\\FaturaveIrsaliyeSistemi\\FaturaveIrsaliyeSistemi\\bin\\Debug\\imgs\\paulogo.png";
        //        excelSayfam.Shapes.AddPicture(logo_yol,MsoTriState.msoFalse,
        //                                         MsoTriState.msoCTrue,
        //                                         2,1,75,75);

        //        excelSayfam.Cells[2, 6] = "Pamukkale Üniversitesi Rektörlüğü";
        //        excelSayfam.Cells[3,6]="Öğrenci İşleri Daire Başkanlığı";
        //        excelSayfam.Cells[4, 6]="Kınıklı Kampüsü Rektörlük Binası";

        //        excelSayfam.Cells[1, 8] = "FATURA";

        //        int irs_satir = 14;
        //        excelSayfam.Cells[irs_satir, 1] = "ÜRÜN ADI";
        //        excelSayfam.Cells[irs_satir, 4] = "BARKOD";
        //        excelSayfam.Cells[irs_satir, 5] = "BİRİM";
        //        excelSayfam.Cells[irs_satir, 6] = "MİKTAR";
        //        excelSayfam.Cells[irs_satir, 8] = "TUTAR";


        //        excelSayfam.Cells[7, 1] = "SAYIN";
        //        excelSayfam.Cells[8,1]=isim;

        //        excelSayfam.Cells[7,6]="SERİ";
        //        excelSayfam.Cells[8, 8] = seri1;

        //        excelSayfam.Cells[8,6]="Fatura No";
        //        excelSayfam.Cells[8, 8] = fatura_no1;

        //        excelSayfam.Cells[9,6]="İRSALİYE TARİHİ";
        //        excelSayfam.Cells[9, 8] = irs_tar;

        //        excelSayfam.Cells[10, 6] = "İRSALİYE NO";
        //        excelSayfam.Cells[10, 8] = irs_no;

        //        excelSayfam.Cells[11, 6] = "TARİHİ";
        //        excelSayfam.Cells[11, 8] = tarih;

        //        excelSayfam.Cells[40,7] = "TOPLAM";
        //        excelSayfam.Cells[40, 9] = toplam;
        //        excelSayfam.Cells[41, 7] = "%KDV";
        //        excelSayfam.Cells[41, 9] = kdv;
        //        excelSayfam.Cells[42, 7] = "GENEL TOPLAM";
        //        excelSayfam.Cells[42, 9] = genel_top;

        //        excelSayfam.Cells[1][46] = "BANKA HESAP NUMARALARIMIZ";
        //        excelSayfam.Cells[1][47] = "YAPI KREDİ MİLAS ŞUBESİ";
        //        excelSayfam.Cells[1][48] = "TR43 0006 7010 0000 0095 2341 18";


        //        excelSayfam.Cells[10, 1] = "VERGİ D.";
        //        excelSayfam.Cells[10, 2] = vergi_d;

        //        excelSayfam.Cells[11, 1] = "VERGİ NO";
        //        excelSayfam.Cells[11, 2] = vergi_no;




        // // FARKLI KAYDETME OLAYI İÇİN BU GEREKLİ     
        //        excelkitabim.SaveAs(@"C:\Users\Mert\Desktop\FaturaveIrsaliyeSistemi\FaturaveIrsaliyeSistemi\bin\Debug\faturalar\" + dosya_adi + "  .xls  ",
        //  Microsoft.Office.Interop.Excel.XlFileFormat.xlXMLSpreadsheet, Type.Missing, Type.Missing,
        //  false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
        //  Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                

        //    }
        //    catch
        //    {
        //        MessageBox.Show("BİR HATA OLUŞTU");
        //    }

        //}


        //public void irsaliyeexcel(string dosya_adi, int irsaliye_no)
        //{
        //    try
        //    {
        //        Microsoft.Office.Interop.Excel.Application exceldosyam;
        //        Microsoft.Office.Interop.Excel.Workbook excelkitabim;
        //        Microsoft.Office.Interop.Excel.Worksheet excelSayfam;

        //        exceldosyam = new Microsoft.Office.Interop.Excel.Application();
        //        exceldosyam.Visible = true;

        //        object sayfa = true;

        //        excelkitabim = exceldosyam.Workbooks.Add(sayfa);

        //        excelSayfam = exceldosyam.Application.Sheets[1];

        //        object hangiSayfaAktif = 1;
        //        excelSayfam.Select(hangiSayfaAktif);

        //        string sql = "Select * from irsaliye where irsaliye_no=" + irsaliye_no + " ";
        //        SqlConnection b = new SqlConnection();
        //        b.ConnectionString = bag_cumlem;
        //        b.Open();
        //        SqlDataAdapter da = new SqlDataAdapter(sql, b);
        //        DataTable t = new DataTable();
        //        da.Fill(t);
        //        string seri1, irss_no, isim, vergi_d, vergi_no, duz_saat, duz_tar, fiili_sevk_tar, barkod, urun_ad, miktar, birim, tutar, toplam, kdv, genel_top,t_eden,t_alan;
               
        //        seri1 = t.Rows[0][1].ToString();

        //        irss_no = t.Rows[0][2].ToString();

        //        isim = t.Rows[0][3].ToString();

        //        vergi_d = t.Rows[0][4].ToString();

        //        vergi_no = t.Rows[0][5].ToString();

        //        duz_saat = t.Rows[0][6].ToString();

        //        duz_tar = t.Rows[0][7].ToString();

        //        fiili_sevk_tar = t.Rows[0][8].ToString();

        //        toplam = t.Rows[0][17].ToString(); 

        //        kdv = t.Rows[0][18].ToString();

        //        genel_top = t.Rows[0][19].ToString();

        //        t_eden=t.Rows[0][14].ToString();
        //        t_alan=t.Rows[0][15].ToString();

        //        int satir = 13;
        //        int i;
        //        for (i = 0; i <= t.Rows.Count - 1; i++)
        //        {
        //            barkod = t.Rows[i][9].ToString();
        //            urun_ad = t.Rows[i][10].ToString();
        //            miktar = t.Rows[i][11].ToString();
        //            birim = t.Rows[i][12].ToString();
        //            tutar = t.Rows[i][13].ToString(); //Fiyat * Adet
        //            satir++;

        //            excelSayfam.Cells[satir, 1] = urun_ad;
        //            excelSayfam.Cells[satir, 4] = barkod;
        //            excelSayfam.Cells[satir, 5] = birim;
        //            excelSayfam.Cells[satir, 6] = miktar;
        //            //   excelSayfam.Cells[18, 7] = ;  Birim Fiyat
        //            excelSayfam.Cells[satir, 8] = tutar;
        //        }


        //        excelSayfam.Cells[1, 1] = "Pamukkale Üniversitesi Rektörlüğü";
        //        excelSayfam.Cells[2, 1] = "Öğrenci İşleri Daire Başkanlığı";
        //        excelSayfam.Cells[3, 1] = "Kınıklı Kampüsü Rektörlük Binası";

        //        excelSayfam.Cells[12, 1] = "ÜRÜN ADI";
        //        excelSayfam.Cells[12, 4] = "BARKOD";
        //        excelSayfam.Cells[12, 5] = "BİRİM";
        //        excelSayfam.Cells[12, 6] = "MİKTAR";
        //        excelSayfam.Cells[12, 7] = "FİYAT";
        //        excelSayfam.Cells[12, 8] = "TUTAR";


        //        excelSayfam.Cells[6, 1] = "SAYIN";
        //        excelSayfam.Cells[7, 1] = isim;

        //        excelSayfam.Cells[6, 6] = "SERİ";
        //        excelSayfam.Cells[6, 8] = seri1;

        //        excelSayfam.Cells[7, 6] = "İRSALİYE NO";
        //        excelSayfam.Cells[7, 8] = irss_no;

        //        excelSayfam.Cells[8, 6] = "DÜZ. SAATİ";
        //        excelSayfam.Cells[8, 8] = duz_saat;

        //        excelSayfam.Cells[9, 6] = "DÜZ. TAR";
        //        excelSayfam.Cells[9, 8] = duz_tar;

        //        excelSayfam.Cells[10, 6] = "FİİLİ SEVK TAR.";
        //        excelSayfam.Cells[10, 8] = fiili_sevk_tar;


        //        excelSayfam.Cells[40, 1] = "TESLİM EDEN";
        //        excelSayfam.Cells[40, 3] = t_eden;
        //        excelSayfam.Cells[41, 1] = "TESLİM ALAN";
        //        excelSayfam.Cells[41, 3] = t_alan;
        //        excelSayfam.Cells[42, 1] = "İMZA";

        //        excelSayfam.Cells[40, 7] = "TOPLAM";
        //        excelSayfam.Cells[40, 9] = toplam;
        //        excelSayfam.Cells[41, 7] = "%KDV";
        //        excelSayfam.Cells[41, 9] = kdv;
        //        excelSayfam.Cells[42, 7] = "GENEL TOPLAM";
        //        excelSayfam.Cells[42, 9] = genel_top;




        //        excelSayfam.Cells[1, 8] = "İRSALİYELİ FATURA";


        //        excelSayfam.Cells[9, 1] = "VERGİ D.";
        //        excelSayfam.Cells[9, 2] = vergi_d;

        //        excelSayfam.Cells[10, 1] = "VERGİ NO";
        //        excelSayfam.Cells[10, 2] = vergi_no;

        //        // FARKLI KAYDETME OLAYI İÇİN BU GEREKLİ     
        //        excelkitabim.SaveAs(@"C:\Users\Mert\Desktop\FaturaveIrsaliyeSistemi\FaturaveIrsaliyeSistemi\bin\Debug\faturalar\" + dosya_adi + "  .xls  ",
        //  Microsoft.Office.Interop.Excel.XlFileFormat.xlXMLSpreadsheet, Type.Missing, Type.Missing,
        //  false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
        //  Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

               

        //    }
        //    catch
        //    {
        //        MessageBox.Show("Bir Hata Oluştu");
        //    }

        //}


        ///////// MAİL GÖNDERME \\\\\
        public void mailgond(string alici,string dosya_adi)
        {
            try
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;

                sc.Credentials = new NetworkCredential("mertayten1996@gmail.com", "@321@Hakan");

                MailMessage mail = new MailMessage();

                mail.From = new MailAddress("mert.ayten@windowslive.com", "M3 Yazılım");

                mail.To.Add(alici);

                mail.Subject = "Fatura" + DateTime.Today.ToShortDateString(); mail.IsBodyHtml = true; mail.Body = "Bilgilendirme Mesajı";

                mail.Attachments.Add(new Attachment(@dosya_adi));

                sc.Send(mail);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show("Bir Hata Oluştu");
            }
        }
        public void sen_yazdiramazsan_baskasi_hic_yazdiramaz_beni_excel_ile_printerde_broooo(string dosya_ad,DataGridView dg)
        {
            try
            {
                string baglantiexcel = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=excel.xls; Extended Properties=’Excel 12.0 Xml;HDR=YES’";
                OleDbConnection b = new OleDbConnection(baglantiexcel);
                DataTable t = new DataTable();
                string excelegir = "SELECT * FROM [Sheet1]";
                OleDbDataAdapter da = new OleDbDataAdapter(excelegir,baglantiexcel);
                da.Fill(t);
                dg.DataSource = t;

                
            }
            catch(Exception ex){
                MessageBox.Show("CLASS DOSYASINDA BİR HATA");
                MessageBox.Show(ex.ToString());
            }
            
        }

        /*____________________________-------------------PROGRAM BİTTİ :) :) 24.05.2016-----------------------__________________   */


    }
}

