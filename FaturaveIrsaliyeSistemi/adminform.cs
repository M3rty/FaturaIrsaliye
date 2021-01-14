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
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            adminform af = new adminform();
            af.Close();
        }

        private void btKullaniciIslem_Click(object sender, EventArgs e)
        {
            pnlslemler.Controls.Clear();
            kul_islemform kif = new kul_islemform();
            kif.TopLevel = false;
            pnlslemler.Controls.Add(kif);
            kif.Show();
            kif.Dock = DockStyle.Fill;
            kif.BringToFront();
        }

        private void iTalk_Button_14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iTalk_Button_14_Click_1(object sender, EventArgs e)
        {
            pnlslemler.Controls.Clear();
            iletisim iform = new iletisim();
            iform.TopLevel = false;
            pnlslemler.Controls.Add(iform);
            iform.Show();
            iform.Dock = DockStyle.Fill;
            iform.BringToFront();
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            pnlslemler.Controls.Clear();
            f_islemler fi = new f_islemler();
            fi.TopLevel = false;
            pnlslemler.Controls.Add(fi);
            fi.Show();
            fi.Dock = DockStyle.Fill;
            fi.BringToFront();
        }

        private void iTalk_Button_11_Click_1(object sender, EventArgs e)
        {
            pnlslemler.Controls.Clear();
            urunislem uislem = new urunislem();
            uislem.TopLevel = false;
            pnlslemler.Controls.Add(uislem);
            uislem.Show();
            uislem.Dock = DockStyle.Fill;
            uislem.BringToFront();
        }

   
    }
}
