namespace FaturaveIrsaliyeSistemi
{
    partial class irsaliye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(irsaliye));
            this.tbMusteri = new System.Windows.Forms.TextBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.dgUrunler = new System.Windows.Forms.DataGridView();
            this.dgFUrunler = new System.Windows.Forms.DataGridView();
            this.FaturaPnl = new System.Windows.Forms.Panel();
            this.ambiance_Label13 = new Ambiance.Ambiance_Label();
            this.tbTeslimAlan = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label12 = new Ambiance.Ambiance_Label();
            this.dtSevkTar = new System.Windows.Forms.DateTimePicker();
            this.lbFormat = new System.Windows.Forms.Label();
            this.tbSaat = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label11 = new Ambiance.Ambiance_Label();
            this.ambiance_Label9 = new Ambiance.Ambiance_Label();
            this.tbKdv = new Ambiance.Ambiance_TextBox();
            this.tbSeri = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.ambiance_Label2 = new Ambiance.Ambiance_Label();
            this.ambiance_Label3 = new Ambiance.Ambiance_Label();
            this.ambiance_Label4 = new Ambiance.Ambiance_Label();
            this.ambiance_Label5 = new Ambiance.Ambiance_Label();
            this.ambiance_Label6 = new Ambiance.Ambiance_Label();
            this.ambiance_Label7 = new Ambiance.Ambiance_Label();
            this.tbIrsNo = new Ambiance.Ambiance_TextBox();
            this.tbVn = new Ambiance.Ambiance_TextBox();
            this.tbVd = new Ambiance.Ambiance_TextBox();
            this.tbTeslimEden = new Ambiance.Ambiance_TextBox();
            this.btFaturaIptal = new iTalk.iTalk_Button_1();
            this.btUruniptal = new iTalk.iTalk_Button_1();
            this.btFaturayaUrunEkle = new iTalk.iTalk_Button_1();
            this.LblStok = new iTalk.iTalk_Label();
            this.iTalk_Button_22 = new iTalk.iTalk_Button_2();
            this.iTalk_Button_21 = new iTalk.iTalk_Button_2();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.tbMiktar = new Ambiance.Ambiance_TextBox();
            this.btFaturaKaydetBitir = new iTalk.iTalk_Button_1();
            this.ambiance_Label10 = new Ambiance.Ambiance_Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFUrunler)).BeginInit();
            this.FaturaPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMusteri
            // 
            this.tbMusteri.Location = new System.Drawing.Point(210, 108);
            this.tbMusteri.Multiline = true;
            this.tbMusteri.Name = "tbMusteri";
            this.tbMusteri.Size = new System.Drawing.Size(338, 108);
            this.tbMusteri.TabIndex = 30;
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(769, 72);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 22);
            this.dtTarih.TabIndex = 34;
            this.dtTarih.Value = new System.DateTime(2016, 5, 17, 16, 49, 0, 0);
            // 
            // dgUrunler
            // 
            this.dgUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUrunler.Location = new System.Drawing.Point(26, 394);
            this.dgUrunler.Name = "dgUrunler";
            this.dgUrunler.RowTemplate.Height = 24;
            this.dgUrunler.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgUrunler.Size = new System.Drawing.Size(900, 150);
            this.dgUrunler.TabIndex = 47;
            this.dgUrunler.SelectionChanged += new System.EventHandler(this.dgUrunler_SelectionChanged);
            // 
            // dgFUrunler
            // 
            this.dgFUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFUrunler.Location = new System.Drawing.Point(26, 684);
            this.dgFUrunler.Name = "dgFUrunler";
            this.dgFUrunler.RowTemplate.Height = 24;
            this.dgFUrunler.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgFUrunler.Size = new System.Drawing.Size(750, 165);
            this.dgFUrunler.TabIndex = 44;
            // 
            // FaturaPnl
            // 
            this.FaturaPnl.Controls.Add(this.ambiance_Label13);
            this.FaturaPnl.Controls.Add(this.tbTeslimAlan);
            this.FaturaPnl.Controls.Add(this.ambiance_Label12);
            this.FaturaPnl.Controls.Add(this.dtSevkTar);
            this.FaturaPnl.Controls.Add(this.lbFormat);
            this.FaturaPnl.Controls.Add(this.tbSaat);
            this.FaturaPnl.Controls.Add(this.ambiance_Label11);
            this.FaturaPnl.Controls.Add(this.ambiance_Label9);
            this.FaturaPnl.Controls.Add(this.tbKdv);
            this.FaturaPnl.Controls.Add(this.tbMusteri);
            this.FaturaPnl.Controls.Add(this.tbSeri);
            this.FaturaPnl.Controls.Add(this.ambiance_Label1);
            this.FaturaPnl.Controls.Add(this.ambiance_Label2);
            this.FaturaPnl.Controls.Add(this.ambiance_Label3);
            this.FaturaPnl.Controls.Add(this.ambiance_Label4);
            this.FaturaPnl.Controls.Add(this.ambiance_Label5);
            this.FaturaPnl.Controls.Add(this.ambiance_Label6);
            this.FaturaPnl.Controls.Add(this.ambiance_Label7);
            this.FaturaPnl.Controls.Add(this.dtTarih);
            this.FaturaPnl.Controls.Add(this.tbIrsNo);
            this.FaturaPnl.Controls.Add(this.tbVn);
            this.FaturaPnl.Controls.Add(this.tbVd);
            this.FaturaPnl.Controls.Add(this.tbTeslimEden);
            this.FaturaPnl.Location = new System.Drawing.Point(26, 11);
            this.FaturaPnl.Name = "FaturaPnl";
            this.FaturaPnl.Size = new System.Drawing.Size(1239, 331);
            this.FaturaPnl.TabIndex = 42;
            // 
            // ambiance_Label13
            // 
            this.ambiance_Label13.AutoSize = true;
            this.ambiance_Label13.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label13.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ambiance_Label13.Location = new System.Drawing.Point(599, 224);
            this.ambiance_Label13.Name = "ambiance_Label13";
            this.ambiance_Label13.Size = new System.Drawing.Size(109, 25);
            this.ambiance_Label13.TabIndex = 43;
            this.ambiance_Label13.Text = "Teslim Alan";
            // 
            // tbTeslimAlan
            // 
            this.tbTeslimAlan.BackColor = System.Drawing.Color.Transparent;
            this.tbTeslimAlan.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbTeslimAlan.ForeColor = System.Drawing.Color.DimGray;
            this.tbTeslimAlan.Location = new System.Drawing.Point(769, 221);
            this.tbTeslimAlan.MaxLength = 32767;
            this.tbTeslimAlan.Multiline = false;
            this.tbTeslimAlan.Name = "tbTeslimAlan";
            this.tbTeslimAlan.ReadOnly = false;
            this.tbTeslimAlan.Size = new System.Drawing.Size(203, 33);
            this.tbTeslimAlan.TabIndex = 44;
            this.tbTeslimAlan.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTeslimAlan.UseSystemPasswordChar = false;
            // 
            // ambiance_Label12
            // 
            this.ambiance_Label12.AutoSize = true;
            this.ambiance_Label12.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label12.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ambiance_Label12.Location = new System.Drawing.Point(599, 121);
            this.ambiance_Label12.Name = "ambiance_Label12";
            this.ambiance_Label12.Size = new System.Drawing.Size(137, 25);
            this.ambiance_Label12.TabIndex = 41;
            this.ambiance_Label12.Text = "Fiili Sevk Tarihi";
            // 
            // dtSevkTar
            // 
            this.dtSevkTar.Location = new System.Drawing.Point(769, 124);
            this.dtSevkTar.Name = "dtSevkTar";
            this.dtSevkTar.Size = new System.Drawing.Size(200, 22);
            this.dtSevkTar.TabIndex = 42;
            this.dtSevkTar.Value = new System.DateTime(2016, 5, 17, 16, 49, 0, 0);
            // 
            // lbFormat
            // 
            this.lbFormat.AutoSize = true;
            this.lbFormat.Location = new System.Drawing.Point(972, 28);
            this.lbFormat.Name = "lbFormat";
            this.lbFormat.Size = new System.Drawing.Size(143, 17);
            this.lbFormat.TabIndex = 40;
            this.lbFormat.Text = "Örnek Format= 08:00";
            // 
            // tbSaat
            // 
            this.tbSaat.BackColor = System.Drawing.Color.Transparent;
            this.tbSaat.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbSaat.ForeColor = System.Drawing.Color.DimGray;
            this.tbSaat.Location = new System.Drawing.Point(769, 20);
            this.tbSaat.MaxLength = 32767;
            this.tbSaat.Multiline = false;
            this.tbSaat.Name = "tbSaat";
            this.tbSaat.ReadOnly = false;
            this.tbSaat.Size = new System.Drawing.Size(197, 33);
            this.tbSaat.TabIndex = 39;
            this.tbSaat.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSaat.UseSystemPasswordChar = false;
            // 
            // ambiance_Label11
            // 
            this.ambiance_Label11.AutoSize = true;
            this.ambiance_Label11.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label11.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ambiance_Label11.Location = new System.Drawing.Point(596, 20);
            this.ambiance_Label11.Name = "ambiance_Label11";
            this.ambiance_Label11.Size = new System.Drawing.Size(153, 25);
            this.ambiance_Label11.TabIndex = 38;
            this.ambiance_Label11.Text = "Düzenleme Saati";
            // 
            // ambiance_Label9
            // 
            this.ambiance_Label9.AutoSize = true;
            this.ambiance_Label9.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label9.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ambiance_Label9.Location = new System.Drawing.Point(602, 283);
            this.ambiance_Label9.Name = "ambiance_Label9";
            this.ambiance_Label9.Size = new System.Drawing.Size(48, 25);
            this.ambiance_Label9.TabIndex = 36;
            this.ambiance_Label9.Text = "KDV";
            // 
            // tbKdv
            // 
            this.tbKdv.BackColor = System.Drawing.Color.Transparent;
            this.tbKdv.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbKdv.ForeColor = System.Drawing.Color.DimGray;
            this.tbKdv.Location = new System.Drawing.Point(769, 275);
            this.tbKdv.MaxLength = 32767;
            this.tbKdv.Multiline = false;
            this.tbKdv.Name = "tbKdv";
            this.tbKdv.ReadOnly = false;
            this.tbKdv.Size = new System.Drawing.Size(203, 33);
            this.tbKdv.TabIndex = 35;
            this.tbKdv.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbKdv.UseSystemPasswordChar = false;
            // 
            // tbSeri
            // 
            this.tbSeri.BackColor = System.Drawing.Color.Transparent;
            this.tbSeri.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbSeri.ForeColor = System.Drawing.Color.DimGray;
            this.tbSeri.Location = new System.Drawing.Point(210, 20);
            this.tbSeri.MaxLength = 32767;
            this.tbSeri.Multiline = false;
            this.tbSeri.Name = "tbSeri";
            this.tbSeri.ReadOnly = false;
            this.tbSeri.Size = new System.Drawing.Size(147, 33);
            this.tbSeri.TabIndex = 21;
            this.tbSeri.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSeri.UseSystemPasswordChar = false;
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(32, 20);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(48, 25);
            this.ambiance_Label1.TabIndex = 22;
            this.ambiance_Label1.Text = "SERİ";
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ambiance_Label2.Location = new System.Drawing.Point(32, 61);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(101, 25);
            this.ambiance_Label2.TabIndex = 23;
            this.ambiance_Label2.Text = "İrsaliye No";
            // 
            // ambiance_Label3
            // 
            this.ambiance_Label3.AutoSize = true;
            this.ambiance_Label3.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ambiance_Label3.Location = new System.Drawing.Point(602, 173);
            this.ambiance_Label3.Name = "ambiance_Label3";
            this.ambiance_Label3.Size = new System.Drawing.Size(113, 25);
            this.ambiance_Label3.TabIndex = 24;
            this.ambiance_Label3.Text = "Teslim Eden";
            // 
            // ambiance_Label4
            // 
            this.ambiance_Label4.AutoSize = true;
            this.ambiance_Label4.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ambiance_Label4.Location = new System.Drawing.Point(599, 69);
            this.ambiance_Label4.Name = "ambiance_Label4";
            this.ambiance_Label4.Size = new System.Drawing.Size(160, 25);
            this.ambiance_Label4.TabIndex = 25;
            this.ambiance_Label4.Text = "Düzenleme Tarihi";
            // 
            // ambiance_Label5
            // 
            this.ambiance_Label5.AutoSize = true;
            this.ambiance_Label5.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ambiance_Label5.Location = new System.Drawing.Point(32, 275);
            this.ambiance_Label5.Name = "ambiance_Label5";
            this.ambiance_Label5.Size = new System.Drawing.Size(87, 25);
            this.ambiance_Label5.TabIndex = 26;
            this.ambiance_Label5.Text = "Vergi No";
            // 
            // ambiance_Label6
            // 
            this.ambiance_Label6.AutoSize = true;
            this.ambiance_Label6.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ambiance_Label6.Location = new System.Drawing.Point(32, 229);
            this.ambiance_Label6.Name = "ambiance_Label6";
            this.ambiance_Label6.Size = new System.Drawing.Size(120, 25);
            this.ambiance_Label6.TabIndex = 27;
            this.ambiance_Label6.Text = "Vergi Dairesi";
            // 
            // ambiance_Label7
            // 
            this.ambiance_Label7.AutoSize = true;
            this.ambiance_Label7.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ambiance_Label7.Location = new System.Drawing.Point(32, 144);
            this.ambiance_Label7.Name = "ambiance_Label7";
            this.ambiance_Label7.Size = new System.Drawing.Size(147, 25);
            this.ambiance_Label7.TabIndex = 28;
            this.ambiance_Label7.Text = "Müşteri / Ünvan";
            // 
            // tbIrsNo
            // 
            this.tbIrsNo.BackColor = System.Drawing.Color.Transparent;
            this.tbIrsNo.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbIrsNo.ForeColor = System.Drawing.Color.DimGray;
            this.tbIrsNo.Location = new System.Drawing.Point(210, 61);
            this.tbIrsNo.MaxLength = 32767;
            this.tbIrsNo.Multiline = false;
            this.tbIrsNo.Name = "tbIrsNo";
            this.tbIrsNo.ReadOnly = false;
            this.tbIrsNo.Size = new System.Drawing.Size(147, 33);
            this.tbIrsNo.TabIndex = 29;
            this.tbIrsNo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbIrsNo.UseSystemPasswordChar = false;
            // 
            // tbVn
            // 
            this.tbVn.BackColor = System.Drawing.Color.Transparent;
            this.tbVn.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbVn.ForeColor = System.Drawing.Color.DimGray;
            this.tbVn.Location = new System.Drawing.Point(210, 275);
            this.tbVn.MaxLength = 32767;
            this.tbVn.Multiline = false;
            this.tbVn.Name = "tbVn";
            this.tbVn.ReadOnly = false;
            this.tbVn.Size = new System.Drawing.Size(147, 33);
            this.tbVn.TabIndex = 33;
            this.tbVn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbVn.UseSystemPasswordChar = false;
            // 
            // tbVd
            // 
            this.tbVd.BackColor = System.Drawing.Color.Transparent;
            this.tbVd.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbVd.ForeColor = System.Drawing.Color.DimGray;
            this.tbVd.Location = new System.Drawing.Point(210, 229);
            this.tbVd.MaxLength = 32767;
            this.tbVd.Multiline = false;
            this.tbVd.Name = "tbVd";
            this.tbVd.ReadOnly = false;
            this.tbVd.Size = new System.Drawing.Size(147, 33);
            this.tbVd.TabIndex = 31;
            this.tbVd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbVd.UseSystemPasswordChar = false;
            // 
            // tbTeslimEden
            // 
            this.tbTeslimEden.BackColor = System.Drawing.Color.Transparent;
            this.tbTeslimEden.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbTeslimEden.ForeColor = System.Drawing.Color.DimGray;
            this.tbTeslimEden.Location = new System.Drawing.Point(769, 170);
            this.tbTeslimEden.MaxLength = 32767;
            this.tbTeslimEden.Multiline = false;
            this.tbTeslimEden.Name = "tbTeslimEden";
            this.tbTeslimEden.ReadOnly = false;
            this.tbTeslimEden.Size = new System.Drawing.Size(203, 33);
            this.tbTeslimEden.TabIndex = 32;
            this.tbTeslimEden.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTeslimEden.UseSystemPasswordChar = false;
            // 
            // btFaturaIptal
            // 
            this.btFaturaIptal.BackColor = System.Drawing.Color.Transparent;
            this.btFaturaIptal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btFaturaIptal.Image = null;
            this.btFaturaIptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFaturaIptal.Location = new System.Drawing.Point(782, 730);
            this.btFaturaIptal.Name = "btFaturaIptal";
            this.btFaturaIptal.Size = new System.Drawing.Size(229, 40);
            this.btFaturaIptal.TabIndex = 49;
            this.btFaturaIptal.Text = "Faturayı İptal Et";
            this.btFaturaIptal.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btFaturaIptal.Click += new System.EventHandler(this.btFaturaIptal_Click);
            // 
            // btUruniptal
            // 
            this.btUruniptal.BackColor = System.Drawing.Color.Transparent;
            this.btUruniptal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btUruniptal.Image = null;
            this.btUruniptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUruniptal.Location = new System.Drawing.Point(26, 626);
            this.btUruniptal.Name = "btUruniptal";
            this.btUruniptal.Size = new System.Drawing.Size(189, 40);
            this.btUruniptal.TabIndex = 46;
            this.btUruniptal.Text = "Ürünü İptal Et";
            this.btUruniptal.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btUruniptal.Click += new System.EventHandler(this.btUruniptal_Click);
            // 
            // btFaturayaUrunEkle
            // 
            this.btFaturayaUrunEkle.BackColor = System.Drawing.Color.Transparent;
            this.btFaturayaUrunEkle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btFaturayaUrunEkle.Image = null;
            this.btFaturayaUrunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFaturayaUrunEkle.Location = new System.Drawing.Point(26, 571);
            this.btFaturayaUrunEkle.Name = "btFaturayaUrunEkle";
            this.btFaturayaUrunEkle.Size = new System.Drawing.Size(193, 40);
            this.btFaturayaUrunEkle.TabIndex = 45;
            this.btFaturayaUrunEkle.Text = "Ürünü Faturaya Ekle";
            this.btFaturayaUrunEkle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btFaturayaUrunEkle.Click += new System.EventHandler(this.btFaturayaUrunEkle_Click);
            // 
            // LblStok
            // 
            this.LblStok.AutoSize = true;
            this.LblStok.BackColor = System.Drawing.Color.Transparent;
            this.LblStok.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.LblStok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.LblStok.Location = new System.Drawing.Point(755, 584);
            this.LblStok.Name = "LblStok";
            this.LblStok.Size = new System.Drawing.Size(0, 19);
            this.LblStok.TabIndex = 43;
            // 
            // iTalk_Button_22
            // 
            this.iTalk_Button_22.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_22.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_22.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_22.Image = null;
            this.iTalk_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_22.Location = new System.Drawing.Point(441, 348);
            this.iTalk_Button_22.Name = "iTalk_Button_22";
            this.iTalk_Button_22.Size = new System.Drawing.Size(293, 40);
            this.iTalk_Button_22.TabIndex = 41;
            this.iTalk_Button_22.Text = "Fatura Bilgilerini Değiştir";
            this.iTalk_Button_22.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(26, 348);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(293, 40);
            this.iTalk_Button_21.TabIndex = 40;
            this.iTalk_Button_21.Text = "Fatura Bilgilerini Kaydet";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(676, 584);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(73, 19);
            this.iTalk_Label1.TabIndex = 48;
            this.iTalk_Label1.Text = "Kalan Stok";
            // 
            // tbMiktar
            // 
            this.tbMiktar.BackColor = System.Drawing.Color.Transparent;
            this.tbMiktar.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbMiktar.ForeColor = System.Drawing.Color.DimGray;
            this.tbMiktar.Location = new System.Drawing.Point(473, 578);
            this.tbMiktar.MaxLength = 32767;
            this.tbMiktar.Multiline = false;
            this.tbMiktar.Name = "tbMiktar";
            this.tbMiktar.ReadOnly = false;
            this.tbMiktar.Size = new System.Drawing.Size(197, 33);
            this.tbMiktar.TabIndex = 38;
            this.tbMiktar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMiktar.UseSystemPasswordChar = false;
            // 
            // btFaturaKaydetBitir
            // 
            this.btFaturaKaydetBitir.BackColor = System.Drawing.Color.Transparent;
            this.btFaturaKaydetBitir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btFaturaKaydetBitir.Image = null;
            this.btFaturaKaydetBitir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btFaturaKaydetBitir.Location = new System.Drawing.Point(782, 684);
            this.btFaturaKaydetBitir.Name = "btFaturaKaydetBitir";
            this.btFaturaKaydetBitir.Size = new System.Drawing.Size(229, 40);
            this.btFaturaKaydetBitir.TabIndex = 50;
            this.btFaturaKaydetBitir.Text = "İrsaliyeyi Kaydet ve Bitir";
            this.btFaturaKaydetBitir.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btFaturaKaydetBitir.Click += new System.EventHandler(this.btFaturaKaydetBitir_Click);
            // 
            // ambiance_Label10
            // 
            this.ambiance_Label10.AutoSize = true;
            this.ambiance_Label10.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label10.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ambiance_Label10.Location = new System.Drawing.Point(295, 578);
            this.ambiance_Label10.Name = "ambiance_Label10";
            this.ambiance_Label10.Size = new System.Drawing.Size(111, 25);
            this.ambiance_Label10.TabIndex = 39;
            this.ambiance_Label10.Text = "Adet Giriniz";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1021, 730);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 41);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 57;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1021, 684);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 41);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 56;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(804, 571);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 41);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 55;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(240, 627);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 54;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(240, 571);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(763, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(329, 348);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // irsaliye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1277, 916);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btFaturaIptal);
            this.Controls.Add(this.btUruniptal);
            this.Controls.Add(this.btFaturayaUrunEkle);
            this.Controls.Add(this.LblStok);
            this.Controls.Add(this.iTalk_Button_22);
            this.Controls.Add(this.iTalk_Button_21);
            this.Controls.Add(this.iTalk_Label1);
            this.Controls.Add(this.tbMiktar);
            this.Controls.Add(this.dgUrunler);
            this.Controls.Add(this.dgFUrunler);
            this.Controls.Add(this.btFaturaKaydetBitir);
            this.Controls.Add(this.FaturaPnl);
            this.Controls.Add(this.ambiance_Label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "irsaliye";
            this.Text = "irsaliye";
            this.Load += new System.EventHandler(this.irsaliye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFUrunler)).EndInit();
            this.FaturaPnl.ResumeLayout(false);
            this.FaturaPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Button_1 btFaturaIptal;
        private Ambiance.Ambiance_Label ambiance_Label9;
        private Ambiance.Ambiance_TextBox tbKdv;
        private System.Windows.Forms.TextBox tbMusteri;
        private Ambiance.Ambiance_TextBox tbSeri;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private Ambiance.Ambiance_Label ambiance_Label2;
        private Ambiance.Ambiance_Label ambiance_Label3;
        private Ambiance.Ambiance_Label ambiance_Label4;
        private iTalk.iTalk_Button_1 btUruniptal;
        private iTalk.iTalk_Button_1 btFaturayaUrunEkle;
        private iTalk.iTalk_Label LblStok;
        private iTalk.iTalk_Button_2 iTalk_Button_22;
        private iTalk.iTalk_Button_2 iTalk_Button_21;
        private Ambiance.Ambiance_Label ambiance_Label5;
        private Ambiance.Ambiance_Label ambiance_Label6;
        private Ambiance.Ambiance_Label ambiance_Label7;
        private iTalk.iTalk_Label iTalk_Label1;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private Ambiance.Ambiance_TextBox tbMiktar;
        private Ambiance.Ambiance_TextBox tbIrsNo;
        private System.Windows.Forms.DataGridView dgUrunler;
        private System.Windows.Forms.DataGridView dgFUrunler;
        private Ambiance.Ambiance_TextBox tbVn;
        private Ambiance.Ambiance_TextBox tbVd;
        private Ambiance.Ambiance_TextBox tbTeslimEden;
        private iTalk.iTalk_Button_1 btFaturaKaydetBitir;
        private System.Windows.Forms.Panel FaturaPnl;
        private Ambiance.Ambiance_Label ambiance_Label10;
        private Ambiance.Ambiance_Label ambiance_Label11;
        private System.Windows.Forms.Label lbFormat;
        private Ambiance.Ambiance_TextBox tbSaat;
        private Ambiance.Ambiance_Label ambiance_Label12;
        private System.Windows.Forms.DateTimePicker dtSevkTar;
        private Ambiance.Ambiance_Label ambiance_Label13;
        private Ambiance.Ambiance_TextBox tbTeslimAlan;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}