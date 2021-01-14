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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        islemler i = new islemler();

    

        private void monoFlat_Label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/M3rty"); 
        }

  
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            string k_adi, k_sifre;
            k_adi = tbKulad.Text;
            k_sifre = tbSif.Text;
            i.girisyap(k_adi, k_sifre, loginpanel,GirisPanel);
        }

        private void cbSifreGoster_CheckedChanged_1(object sender)
        {
            if (cbSifreGoster.Checked)
            {
                tbSif.UseSystemPasswordChar = false;
            }
            else
            {
                tbSif.UseSystemPasswordChar = true;
            }
        }

        private void ambiance_Button_21_Click(object sender, EventArgs e)
        {
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
