namespace FaturaveIrsaliyeSistemi
{
    partial class urunislem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunislem));
            this.dgUrunler = new System.Windows.Forms.DataGridView();
            this.cbKriter = new iTalk.iTalk_ComboBox();
            this.tbUrunAra = new MonoFlat.MonoFlat_TextBox();
            this.btGunc = new iTalk.iTalk_Button_2();
            this.cbBirimm = new Ambiance.Ambiance_ComboBox();
            this.tbFiyat = new Ambiance.Ambiance_TextBox();
            this.tbStok = new Ambiance.Ambiance_TextBox();
            this.tbBarkod = new Ambiance.Ambiance_TextBox();
            this.ambiance_Label7 = new Ambiance.Ambiance_Label();
            this.ambiance_Label5 = new Ambiance.Ambiance_Label();
            this.ambiance_Label4 = new Ambiance.Ambiance_Label();
            this.ambiance_Label3 = new Ambiance.Ambiance_Label();
            this.ambiance_Label2 = new Ambiance.Ambiance_Label();
            this.ambiance_Label1 = new Ambiance.Ambiance_Label();
            this.tbUrunAd = new Ambiance.Ambiance_TextBox();
            this.cbKategorim = new Ambiance.Ambiance_ComboBox();
            this.urnGunc = new Ambiance.Ambiance_Button_1();
            this.urnSil = new Ambiance.Ambiance_Button_1();
            this.urnEkle = new Ambiance.Ambiance_Button_1();
            this.ambiance_Button_11 = new Ambiance.Ambiance_Button_1();
            this.tbStokEkle = new MonoFlat.MonoFlat_TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbGunc = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUrunler
            // 
            this.dgUrunler.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dgUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUrunler.GridColor = System.Drawing.Color.Cyan;
            this.dgUrunler.Location = new System.Drawing.Point(522, 122);
            this.dgUrunler.Name = "dgUrunler";
            this.dgUrunler.RowTemplate.Height = 24;
            this.dgUrunler.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgUrunler.Size = new System.Drawing.Size(900, 252);
            this.dgUrunler.TabIndex = 18;
            // 
            // cbKriter
            // 
            this.cbKriter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cbKriter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKriter.DropDownHeight = 100;
            this.cbKriter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKriter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbKriter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.cbKriter.FormattingEnabled = true;
            this.cbKriter.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.cbKriter.IntegralHeight = false;
            this.cbKriter.ItemHeight = 20;
            this.cbKriter.Items.AddRange(new object[] {
            "Ürün Adına Göre",
            "Ürün Barkoduna Göre"});
            this.cbKriter.Location = new System.Drawing.Point(1049, 52);
            this.cbKriter.Name = "cbKriter";
            this.cbKriter.Size = new System.Drawing.Size(154, 26);
            this.cbKriter.StartIndex = 0;
            this.cbKriter.TabIndex = 23;
            this.cbKriter.SelectedIndexChanged += new System.EventHandler(this.cbKriter_SelectedIndexChanged);
            // 
            // tbUrunAra
            // 
            this.tbUrunAra.BackColor = System.Drawing.Color.Transparent;
            this.tbUrunAra.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbUrunAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.tbUrunAra.Image = null;
            this.tbUrunAra.Location = new System.Drawing.Point(1209, 43);
            this.tbUrunAra.MaxLength = 32767;
            this.tbUrunAra.Multiline = false;
            this.tbUrunAra.Name = "tbUrunAra";
            this.tbUrunAra.ReadOnly = false;
            this.tbUrunAra.Size = new System.Drawing.Size(152, 46);
            this.tbUrunAra.TabIndex = 22;
            this.tbUrunAra.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUrunAra.UseSystemPasswordChar = false;
            this.tbUrunAra.TextChanged += new System.EventHandler(this.monoFlat_TextBox1_TextChanged);
            // 
            // btGunc
            // 
            this.btGunc.BackColor = System.Drawing.Color.Transparent;
            this.btGunc.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btGunc.ForeColor = System.Drawing.Color.White;
            this.btGunc.Image = null;
            this.btGunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGunc.Location = new System.Drawing.Point(90, 472);
            this.btGunc.Name = "btGunc";
            this.btGunc.Size = new System.Drawing.Size(175, 55);
            this.btGunc.TabIndex = 21;
            this.btGunc.Text = "Güncelle";
            this.btGunc.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btGunc.Visible = false;
            this.btGunc.Click += new System.EventHandler(this.btGunc_Click);
            // 
            // cbBirimm
            // 
            this.cbBirimm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cbBirimm.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBirimm.DropDownHeight = 100;
            this.cbBirimm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBirimm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBirimm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.cbBirimm.FormattingEnabled = true;
            this.cbBirimm.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cbBirimm.IntegralHeight = false;
            this.cbBirimm.ItemHeight = 20;
            this.cbBirimm.Location = new System.Drawing.Point(151, 348);
            this.cbBirimm.Name = "cbBirimm";
            this.cbBirimm.Size = new System.Drawing.Size(175, 26);
            this.cbBirimm.StartIndex = 0;
            this.cbBirimm.TabIndex = 19;
            // 
            // tbFiyat
            // 
            this.tbFiyat.BackColor = System.Drawing.Color.Transparent;
            this.tbFiyat.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbFiyat.ForeColor = System.Drawing.Color.DimGray;
            this.tbFiyat.Location = new System.Drawing.Point(151, 405);
            this.tbFiyat.MaxLength = 32767;
            this.tbFiyat.Multiline = false;
            this.tbFiyat.Name = "tbFiyat";
            this.tbFiyat.ReadOnly = false;
            this.tbFiyat.Size = new System.Drawing.Size(175, 33);
            this.tbFiyat.TabIndex = 17;
            this.tbFiyat.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbFiyat.UseSystemPasswordChar = false;
            // 
            // tbStok
            // 
            this.tbStok.BackColor = System.Drawing.Color.Transparent;
            this.tbStok.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbStok.ForeColor = System.Drawing.Color.DimGray;
            this.tbStok.Location = new System.Drawing.Point(151, 288);
            this.tbStok.MaxLength = 32767;
            this.tbStok.Multiline = false;
            this.tbStok.Name = "tbStok";
            this.tbStok.ReadOnly = false;
            this.tbStok.Size = new System.Drawing.Size(175, 33);
            this.tbStok.TabIndex = 15;
            this.tbStok.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbStok.UseSystemPasswordChar = false;
            // 
            // tbBarkod
            // 
            this.tbBarkod.BackColor = System.Drawing.Color.Transparent;
            this.tbBarkod.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbBarkod.ForeColor = System.Drawing.Color.DimGray;
            this.tbBarkod.Location = new System.Drawing.Point(151, 176);
            this.tbBarkod.MaxLength = 32767;
            this.tbBarkod.Multiline = false;
            this.tbBarkod.Name = "tbBarkod";
            this.tbBarkod.ReadOnly = false;
            this.tbBarkod.Size = new System.Drawing.Size(175, 33);
            this.tbBarkod.TabIndex = 13;
            this.tbBarkod.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbBarkod.UseSystemPasswordChar = false;
            // 
            // ambiance_Label7
            // 
            this.ambiance_Label7.AutoSize = true;
            this.ambiance_Label7.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label7.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label7.Location = new System.Drawing.Point(58, 405);
            this.ambiance_Label7.Name = "ambiance_Label7";
            this.ambiance_Label7.Size = new System.Drawing.Size(51, 25);
            this.ambiance_Label7.TabIndex = 12;
            this.ambiance_Label7.Text = "Fiyat";
            // 
            // ambiance_Label5
            // 
            this.ambiance_Label5.AutoSize = true;
            this.ambiance_Label5.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label5.Location = new System.Drawing.Point(59, 288);
            this.ambiance_Label5.Name = "ambiance_Label5";
            this.ambiance_Label5.Size = new System.Drawing.Size(48, 25);
            this.ambiance_Label5.TabIndex = 10;
            this.ambiance_Label5.Text = "Stok";
            // 
            // ambiance_Label4
            // 
            this.ambiance_Label4.AutoSize = true;
            this.ambiance_Label4.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label4.Location = new System.Drawing.Point(58, 341);
            this.ambiance_Label4.Name = "ambiance_Label4";
            this.ambiance_Label4.Size = new System.Drawing.Size(56, 25);
            this.ambiance_Label4.TabIndex = 9;
            this.ambiance_Label4.Text = "Birim";
            // 
            // ambiance_Label3
            // 
            this.ambiance_Label3.AutoSize = true;
            this.ambiance_Label3.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label3.Location = new System.Drawing.Point(58, 236);
            this.ambiance_Label3.Name = "ambiance_Label3";
            this.ambiance_Label3.Size = new System.Drawing.Size(83, 25);
            this.ambiance_Label3.TabIndex = 8;
            this.ambiance_Label3.Text = "Kategori";
            // 
            // ambiance_Label2
            // 
            this.ambiance_Label2.AutoSize = true;
            this.ambiance_Label2.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label2.Location = new System.Drawing.Point(58, 176);
            this.ambiance_Label2.Name = "ambiance_Label2";
            this.ambiance_Label2.Size = new System.Drawing.Size(82, 25);
            this.ambiance_Label2.TabIndex = 7;
            this.ambiance_Label2.Text = "Barkodu";
            // 
            // ambiance_Label1
            // 
            this.ambiance_Label1.AutoSize = true;
            this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ambiance_Label1.Location = new System.Drawing.Point(59, 119);
            this.ambiance_Label1.Name = "ambiance_Label1";
            this.ambiance_Label1.Size = new System.Drawing.Size(87, 25);
            this.ambiance_Label1.TabIndex = 6;
            this.ambiance_Label1.Text = "Ürün Adı";
            // 
            // tbUrunAd
            // 
            this.tbUrunAd.BackColor = System.Drawing.Color.Transparent;
            this.tbUrunAd.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbUrunAd.ForeColor = System.Drawing.Color.DimGray;
            this.tbUrunAd.Location = new System.Drawing.Point(151, 119);
            this.tbUrunAd.MaxLength = 32767;
            this.tbUrunAd.Multiline = false;
            this.tbUrunAd.Name = "tbUrunAd";
            this.tbUrunAd.ReadOnly = false;
            this.tbUrunAd.Size = new System.Drawing.Size(175, 33);
            this.tbUrunAd.TabIndex = 5;
            this.tbUrunAd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUrunAd.UseSystemPasswordChar = false;
            // 
            // cbKategorim
            // 
            this.cbKategorim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cbKategorim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbKategorim.DropDownHeight = 100;
            this.cbKategorim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategorim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbKategorim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.cbKategorim.FormattingEnabled = true;
            this.cbKategorim.HoverSelectionColor = System.Drawing.Color.Empty;
            this.cbKategorim.IntegralHeight = false;
            this.cbKategorim.ItemHeight = 20;
            this.cbKategorim.Location = new System.Drawing.Point(151, 236);
            this.cbKategorim.Name = "cbKategorim";
            this.cbKategorim.Size = new System.Drawing.Size(175, 26);
            this.cbKategorim.StartIndex = 0;
            this.cbKategorim.TabIndex = 4;
            // 
            // urnGunc
            // 
            this.urnGunc.BackColor = System.Drawing.Color.Transparent;
            this.urnGunc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.urnGunc.Image = null;
            this.urnGunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.urnGunc.Location = new System.Drawing.Point(522, 34);
            this.urnGunc.Name = "urnGunc";
            this.urnGunc.Size = new System.Drawing.Size(155, 55);
            this.urnGunc.TabIndex = 3;
            this.urnGunc.Text = "Ürün Güncelle";
            this.urnGunc.TextAlignment = System.Drawing.StringAlignment.Center;
            this.urnGunc.Click += new System.EventHandler(this.urnGunc_Click);
            // 
            // urnSil
            // 
            this.urnSil.BackColor = System.Drawing.Color.Transparent;
            this.urnSil.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.urnSil.Image = null;
            this.urnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.urnSil.Location = new System.Drawing.Point(763, 34);
            this.urnSil.Name = "urnSil";
            this.urnSil.Size = new System.Drawing.Size(147, 55);
            this.urnSil.TabIndex = 2;
            this.urnSil.Text = "Ürün Sil";
            this.urnSil.TextAlignment = System.Drawing.StringAlignment.Center;
            this.urnSil.Click += new System.EventHandler(this.urnSil_Click);
            // 
            // urnEkle
            // 
            this.urnEkle.BackColor = System.Drawing.Color.Transparent;
            this.urnEkle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.urnEkle.Image = null;
            this.urnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.urnEkle.Location = new System.Drawing.Point(64, 34);
            this.urnEkle.Name = "urnEkle";
            this.urnEkle.Size = new System.Drawing.Size(262, 55);
            this.urnEkle.TabIndex = 1;
            this.urnEkle.Text = "Ürün Ekle";
            this.urnEkle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.urnEkle.Click += new System.EventHandler(this.urnEkle_Click);
            // 
            // ambiance_Button_11
            // 
            this.ambiance_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.ambiance_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ambiance_Button_11.Image = null;
            this.ambiance_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ambiance_Button_11.Location = new System.Drawing.Point(522, 405);
            this.ambiance_Button_11.Name = "ambiance_Button_11";
            this.ambiance_Button_11.Size = new System.Drawing.Size(204, 55);
            this.ambiance_Button_11.TabIndex = 24;
            this.ambiance_Button_11.Text = "Stok Ekle";
            this.ambiance_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ambiance_Button_11.Click += new System.EventHandler(this.ambiance_Button_11_Click);
            // 
            // tbStokEkle
            // 
            this.tbStokEkle.BackColor = System.Drawing.Color.Transparent;
            this.tbStokEkle.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tbStokEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.tbStokEkle.Image = null;
            this.tbStokEkle.Location = new System.Drawing.Point(522, 478);
            this.tbStokEkle.MaxLength = 32767;
            this.tbStokEkle.Multiline = false;
            this.tbStokEkle.Name = "tbStokEkle";
            this.tbStokEkle.ReadOnly = false;
            this.tbStokEkle.Size = new System.Drawing.Size(204, 46);
            this.tbStokEkle.TabIndex = 25;
            this.tbStokEkle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbStokEkle.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pbGunc
            // 
            this.pbGunc.Image = ((System.Drawing.Image)(resources.GetObject("pbGunc.Image")));
            this.pbGunc.Location = new System.Drawing.Point(271, 472);
            this.pbGunc.Name = "pbGunc";
            this.pbGunc.Size = new System.Drawing.Size(55, 52);
            this.pbGunc.TabIndex = 27;
            this.pbGunc.TabStop = false;
            this.pbGunc.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(916, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 55);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(732, 405);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 55);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1367, 43);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 46);
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(683, 34);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(55, 55);
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // urunislem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1749, 588);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pbGunc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbStokEkle);
            this.Controls.Add(this.ambiance_Button_11);
            this.Controls.Add(this.cbKriter);
            this.Controls.Add(this.tbUrunAra);
            this.Controls.Add(this.btGunc);
            this.Controls.Add(this.cbBirimm);
            this.Controls.Add(this.dgUrunler);
            this.Controls.Add(this.tbFiyat);
            this.Controls.Add(this.tbStok);
            this.Controls.Add(this.tbBarkod);
            this.Controls.Add(this.ambiance_Label7);
            this.Controls.Add(this.ambiance_Label5);
            this.Controls.Add(this.ambiance_Label4);
            this.Controls.Add(this.ambiance_Label3);
            this.Controls.Add(this.ambiance_Label2);
            this.Controls.Add(this.ambiance_Label1);
            this.Controls.Add(this.tbUrunAd);
            this.Controls.Add(this.cbKategorim);
            this.Controls.Add(this.urnGunc);
            this.Controls.Add(this.urnSil);
            this.Controls.Add(this.urnEkle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "urunislem";
            this.Text = "urunislem";
            this.Load += new System.EventHandler(this.urunislem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ambiance.Ambiance_Button_1 urnEkle;
        private Ambiance.Ambiance_Button_1 urnSil;
        private Ambiance.Ambiance_Button_1 urnGunc;
        private Ambiance.Ambiance_ComboBox cbKategorim;
        private Ambiance.Ambiance_TextBox tbUrunAd;
        private Ambiance.Ambiance_Label ambiance_Label1;
        private Ambiance.Ambiance_Label ambiance_Label2;
        private Ambiance.Ambiance_Label ambiance_Label3;
        private Ambiance.Ambiance_Label ambiance_Label4;
        private Ambiance.Ambiance_Label ambiance_Label5;
        private Ambiance.Ambiance_Label ambiance_Label7;
        private Ambiance.Ambiance_TextBox tbBarkod;
        private Ambiance.Ambiance_TextBox tbFiyat;
        private Ambiance.Ambiance_TextBox tbStok;
        private System.Windows.Forms.DataGridView dgUrunler;
        private Ambiance.Ambiance_ComboBox cbBirimm;
        private iTalk.iTalk_Button_2 btGunc;
        private MonoFlat.MonoFlat_TextBox tbUrunAra;
        private iTalk.iTalk_ComboBox cbKriter;
        private Ambiance.Ambiance_Button_1 ambiance_Button_11;
        private MonoFlat.MonoFlat_TextBox tbStokEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbGunc;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}