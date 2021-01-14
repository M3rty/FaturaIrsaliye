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
    public partial class f_islemler : Form
    {
        public f_islemler()
        {
            InitializeComponent();
        }

        private void btFKes_Click(object sender, EventArgs e)
        {

            pnlIslm.Controls.Clear();
            faturaform fform = new faturaform();
            fform.TopLevel = false;
            pnlIslm.Controls.Add(fform);
            fform.Show();
            fform.Dock = DockStyle.Fill;
            fform.BringToFront();
        }

        private void btIrsaliye_Click(object sender, EventArgs e)
        {

            pnlIslm.Controls.Clear();
            irsaliye iform = new irsaliye();
            iform.TopLevel = false;
            pnlIslm.Controls.Add(iform);
            iform.Show();
            iform.Dock = DockStyle.Fill;
            iform.BringToFront();
        }

        private void ambiance_Button_12_Click(object sender, EventArgs e)
        {
            pnlIslm.Controls.Clear();
            f_irsaliyeislem firs = new f_irsaliyeislem();
            firs.TopLevel = false;
            pnlIslm.Controls.Add(firs);
            firs.Show();
            firs.Dock = DockStyle.Fill;
            firs.BringToFront();
        }
    }
}
