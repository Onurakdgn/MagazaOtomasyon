namespace MağazaOtomasyonn
{
    partial class frmSatis
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
            this.btnSatışİptal = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatışYap = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToplamFiyati = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSatışFiyati = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.txtürunAdı = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışlarıListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSatışİptal
            // 
            this.btnSatışİptal.Location = new System.Drawing.Point(781, 103);
            this.btnSatışİptal.Name = "btnSatışİptal";
            this.btnSatışİptal.Size = new System.Drawing.Size(75, 23);
            this.btnSatışİptal.TabIndex = 21;
            this.btnSatışİptal.Text = "Satış İptal";
            this.btnSatışİptal.UseVisualStyleBackColor = true;
            this.btnSatışİptal.Click += new System.EventHandler(this.btnSatışİptal_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(781, 71);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 20;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatışYap
            // 
            this.btnSatışYap.Location = new System.Drawing.Point(700, 360);
            this.btnSatışYap.Name = "btnSatışYap";
            this.btnSatışYap.Size = new System.Drawing.Size(75, 23);
            this.btnSatışYap.TabIndex = 19;
            this.btnSatışYap.Text = "Satış Yap";
            this.btnSatışYap.UseVisualStyleBackColor = true;
            this.btnSatışYap.Click += new System.EventHandler(this.btnSatışYap_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(116, 338);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 18;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(242, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 288);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(577, 357);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(13, 13);
            this.lblGenelToplam.TabIndex = 16;
            this.lblGenelToplam.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(489, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Genel Toplam";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtToplamFiyati);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSatışFiyati);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMiktari);
            this.groupBox2.Controls.Add(this.txtürunAdı);
            this.groupBox2.Controls.Add(this.txtBarkodNo);
            this.groupBox2.Location = new System.Drawing.Point(20, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 156);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Barkod No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Toplam Fiyat";
            // 
            // txtToplamFiyati
            // 
            this.txtToplamFiyati.Location = new System.Drawing.Point(71, 127);
            this.txtToplamFiyati.Name = "txtToplamFiyati";
            this.txtToplamFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtToplamFiyati.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Satış Fiyatı";
            // 
            // txtSatışFiyati
            // 
            this.txtSatışFiyati.Location = new System.Drawing.Point(71, 100);
            this.txtSatışFiyati.Name = "txtSatışFiyati";
            this.txtSatışFiyati.Size = new System.Drawing.Size(100, 20);
            this.txtSatışFiyati.TabIndex = 3;
            this.txtSatışFiyati.TextChanged += new System.EventHandler(this.txtSatışFiyati_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Miktar";
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(71, 73);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(100, 20);
            this.txtMiktari.TabIndex = 2;
            this.txtMiktari.Text = "1";
            this.txtMiktari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiktari.TextChanged += new System.EventHandler(this.txtMiktari_TextChanged);
            // 
            // txtürunAdı
            // 
            this.txtürunAdı.Location = new System.Drawing.Point(71, 46);
            this.txtürunAdı.Name = "txtürunAdı";
            this.txtürunAdı.Size = new System.Drawing.Size(100, 20);
            this.txtürunAdı.TabIndex = 1;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(71, 19);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(100, 20);
            this.txtBarkodNo.TabIndex = 0;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.TxtUrunID_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(19, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 115);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel İşlemleri";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(72, 85);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 5;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(72, 54);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtAdSoyad.TabIndex = 4;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(72, 27);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 3;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEklemeToolStripMenuItem,
            this.müşteriListelemeToolStripMenuItem,
            this.ürünEklemeToolStripMenuItem,
            this.ürünListelemeToolStripMenuItem,
            this.satışlarıListelemeToolStripMenuItem,
            this.kategoriEklemeToolStripMenuItem,
            this.markaEklemeToolStripMenuItem,
            this.kategoriSilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelEklemeToolStripMenuItem
            // 
            this.personelEklemeToolStripMenuItem.Name = "personelEklemeToolStripMenuItem";
            this.personelEklemeToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.personelEklemeToolStripMenuItem.Text = "Personel Ekleme";
            this.personelEklemeToolStripMenuItem.Click += new System.EventHandler(this.müşteriEklemeToolStripMenuItem_Click);
            // 
            // müşteriListelemeToolStripMenuItem
            // 
            this.müşteriListelemeToolStripMenuItem.Name = "müşteriListelemeToolStripMenuItem";
            this.müşteriListelemeToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.müşteriListelemeToolStripMenuItem.Text = "Personel Listeleme";
            this.müşteriListelemeToolStripMenuItem.Click += new System.EventHandler(this.müşteriListelemeToolStripMenuItem_Click);
            // 
            // ürünEklemeToolStripMenuItem
            // 
            this.ürünEklemeToolStripMenuItem.Name = "ürünEklemeToolStripMenuItem";
            this.ürünEklemeToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.ürünEklemeToolStripMenuItem.Text = "Ürün Ekleme";
            this.ürünEklemeToolStripMenuItem.Click += new System.EventHandler(this.ürünEklemeToolStripMenuItem_Click);
            // 
            // ürünListelemeToolStripMenuItem
            // 
            this.ürünListelemeToolStripMenuItem.Name = "ürünListelemeToolStripMenuItem";
            this.ürünListelemeToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.ürünListelemeToolStripMenuItem.Text = "Ürün Listeleme";
            this.ürünListelemeToolStripMenuItem.Click += new System.EventHandler(this.ürünListelemeToolStripMenuItem_Click);
            // 
            // satışlarıListelemeToolStripMenuItem
            // 
            this.satışlarıListelemeToolStripMenuItem.Name = "satışlarıListelemeToolStripMenuItem";
            this.satışlarıListelemeToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.satışlarıListelemeToolStripMenuItem.Text = "Satışları Listeleme";
            this.satışlarıListelemeToolStripMenuItem.Click += new System.EventHandler(this.satışlarıListelemeToolStripMenuItem_Click);
            // 
            // kategoriEklemeToolStripMenuItem
            // 
            this.kategoriEklemeToolStripMenuItem.Name = "kategoriEklemeToolStripMenuItem";
            this.kategoriEklemeToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.kategoriEklemeToolStripMenuItem.Text = "Kategori Ekleme";
            this.kategoriEklemeToolStripMenuItem.Click += new System.EventHandler(this.kategoriEklemeToolStripMenuItem_Click);
            // 
            // markaEklemeToolStripMenuItem
            // 
            this.markaEklemeToolStripMenuItem.Name = "markaEklemeToolStripMenuItem";
            this.markaEklemeToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.markaEklemeToolStripMenuItem.Text = "Marka Ekleme";
            this.markaEklemeToolStripMenuItem.Click += new System.EventHandler(this.markaEklemeToolStripMenuItem_Click);
            // 
            // kategoriSilToolStripMenuItem
            // 
            this.kategoriSilToolStripMenuItem.Name = "kategoriSilToolStripMenuItem";
            this.kategoriSilToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.kategoriSilToolStripMenuItem.Text = "Kategori Sil";
            this.kategoriSilToolStripMenuItem.Click += new System.EventHandler(this.kategoriSilToolStripMenuItem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Satış Sayfası";
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(871, 434);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSatışİptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnSatışYap);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSatışİptal;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatışYap;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToplamFiyati;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSatışFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMiktari;
        private System.Windows.Forms.TextBox txtürunAdı;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personelEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışlarıListelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaEklemeToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem kategoriSilToolStripMenuItem;
    }
}