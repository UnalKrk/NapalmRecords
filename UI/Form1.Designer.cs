namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grbAlbumAra = new GroupBox();
            dgvArananAlbum = new DataGridView();
            btnAra = new Button();
            cmbBoxAra = new ComboBox();
            lblAramaKriteri = new Label();
            grbAlbumEkle = new GroupBox();
            txtIndirimOrani = new TextBox();
            rbtnSatistaDegil = new RadioButton();
            btnSil = new Button();
            rbtnSatista = new RadioButton();
            btnGüncelle = new Button();
            txtFiyat = new TextBox();
            dtpCikisTarihi = new DateTimePicker();
            txtAlbumAdi = new TextBox();
            txtSanatci = new TextBox();
            btnEkle = new Button();
            lblSatis = new Label();
            lblİdirimOranı = new Label();
            lblFiyat = new Label();
            lblCikisTarihi = new Label();
            lblAlbumAdi = new Label();
            lblSanatci = new Label();
            dgvButunAlbumler = new DataGridView();
            grbAlbumAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArananAlbum).BeginInit();
            grbAlbumEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvButunAlbumler).BeginInit();
            SuspendLayout();
            // 
            // grbAlbumAra
            // 
            grbAlbumAra.Controls.Add(dgvArananAlbum);
            grbAlbumAra.Controls.Add(btnAra);
            grbAlbumAra.Controls.Add(cmbBoxAra);
            grbAlbumAra.Controls.Add(lblAramaKriteri);
            grbAlbumAra.Location = new Point(11, 276);
            grbAlbumAra.Margin = new Padding(2);
            grbAlbumAra.Name = "grbAlbumAra";
            grbAlbumAra.Padding = new Padding(2);
            grbAlbumAra.Size = new Size(772, 188);
            grbAlbumAra.TabIndex = 5;
            grbAlbumAra.TabStop = false;
            grbAlbumAra.Text = "Albüm Ara";
            // 
            // dgvArananAlbum
            // 
            dgvArananAlbum.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArananAlbum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArananAlbum.Location = new Point(21, 29);
            dgvArananAlbum.Name = "dgvArananAlbum";
            dgvArananAlbum.Size = new Size(429, 150);
            dgvArananAlbum.TabIndex = 5;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(552, 92);
            btnAra.Margin = new Padding(2);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(174, 20);
            btnAra.TabIndex = 4;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // cmbBoxAra
            // 
            cmbBoxAra.FormattingEnabled = true;
            cmbBoxAra.Items.AddRange(new object[] { "Lütfen Bir Arama Kriteri Seçiniz!", "Satışı durmuş albümler", "Satışı devam eden albümler", "Son eklenen 10 albüm", "İndirimdeki albümler" });
            cmbBoxAra.Location = new Point(552, 51);
            cmbBoxAra.Margin = new Padding(2);
            cmbBoxAra.Name = "cmbBoxAra";
            cmbBoxAra.Size = new Size(173, 23);
            cmbBoxAra.TabIndex = 1;
            // 
            // lblAramaKriteri
            // 
            lblAramaKriteri.AutoSize = true;
            lblAramaKriteri.Location = new Point(467, 58);
            lblAramaKriteri.Margin = new Padding(2, 0, 2, 0);
            lblAramaKriteri.Name = "lblAramaKriteri";
            lblAramaKriteri.Size = new Size(79, 15);
            lblAramaKriteri.TabIndex = 0;
            lblAramaKriteri.Text = "Arama Kriteri:";
            // 
            // grbAlbumEkle
            // 
            grbAlbumEkle.Controls.Add(txtIndirimOrani);
            grbAlbumEkle.Controls.Add(rbtnSatistaDegil);
            grbAlbumEkle.Controls.Add(btnSil);
            grbAlbumEkle.Controls.Add(rbtnSatista);
            grbAlbumEkle.Controls.Add(btnGüncelle);
            grbAlbumEkle.Controls.Add(txtFiyat);
            grbAlbumEkle.Controls.Add(dtpCikisTarihi);
            grbAlbumEkle.Controls.Add(txtAlbumAdi);
            grbAlbumEkle.Controls.Add(txtSanatci);
            grbAlbumEkle.Controls.Add(btnEkle);
            grbAlbumEkle.Controls.Add(lblSatis);
            grbAlbumEkle.Controls.Add(lblİdirimOranı);
            grbAlbumEkle.Controls.Add(lblFiyat);
            grbAlbumEkle.Controls.Add(lblCikisTarihi);
            grbAlbumEkle.Controls.Add(lblAlbumAdi);
            grbAlbumEkle.Controls.Add(lblSanatci);
            grbAlbumEkle.Controls.Add(dgvButunAlbumler);
            grbAlbumEkle.Location = new Point(11, 11);
            grbAlbumEkle.Margin = new Padding(2);
            grbAlbumEkle.Name = "grbAlbumEkle";
            grbAlbumEkle.Padding = new Padding(2);
            grbAlbumEkle.Size = new Size(1060, 261);
            grbAlbumEkle.TabIndex = 4;
            grbAlbumEkle.TabStop = false;
            grbAlbumEkle.Text = "Albüm Ekle";
            // 
            // txtIndirimOrani
            // 
            txtIndirimOrani.Location = new Point(819, 120);
            txtIndirimOrani.Margin = new Padding(2);
            txtIndirimOrani.Name = "txtIndirimOrani";
            txtIndirimOrani.Size = new Size(211, 23);
            txtIndirimOrani.TabIndex = 14;
            // 
            // rbtnSatistaDegil
            // 
            rbtnSatistaDegil.AutoSize = true;
            rbtnSatistaDegil.Location = new Point(920, 142);
            rbtnSatistaDegil.Margin = new Padding(2);
            rbtnSatistaDegil.Name = "rbtnSatistaDegil";
            rbtnSatistaDegil.Size = new Size(98, 19);
            rbtnSatistaDegil.TabIndex = 13;
            rbtnSatistaDegil.TabStop = true;
            rbtnSatistaDegil.Text = "Satıştan Kalktı";
            rbtnSatistaDegil.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(730, 215);
            btnSil.Margin = new Padding(2);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(300, 20);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // rbtnSatista
            // 
            rbtnSatista.AutoSize = true;
            rbtnSatista.Location = new Point(817, 143);
            rbtnSatista.Margin = new Padding(2);
            rbtnSatista.Name = "rbtnSatista";
            rbtnSatista.Size = new Size(59, 19);
            rbtnSatista.TabIndex = 12;
            rbtnSatista.TabStop = true;
            rbtnSatista.Text = "Satışta";
            rbtnSatista.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(730, 191);
            btnGüncelle.Margin = new Padding(2);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(300, 20);
            btnGüncelle.TabIndex = 2;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(819, 96);
            txtFiyat.Margin = new Padding(2);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(211, 23);
            txtFiyat.TabIndex = 11;
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(819, 68);
            dtpCikisTarihi.Margin = new Padding(2);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(211, 23);
            dtpCikisTarihi.TabIndex = 10;
            // 
            // txtAlbumAdi
            // 
            txtAlbumAdi.Location = new Point(819, 44);
            txtAlbumAdi.Margin = new Padding(2);
            txtAlbumAdi.Name = "txtAlbumAdi";
            txtAlbumAdi.Size = new Size(211, 23);
            txtAlbumAdi.TabIndex = 9;
            // 
            // txtSanatci
            // 
            txtSanatci.Location = new Point(819, 18);
            txtSanatci.Margin = new Padding(2);
            txtSanatci.Name = "txtSanatci";
            txtSanatci.Size = new Size(211, 23);
            txtSanatci.TabIndex = 8;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(730, 167);
            btnEkle.Margin = new Padding(2);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(300, 20);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lblSatis
            // 
            lblSatis.AutoSize = true;
            lblSatis.Location = new Point(727, 143);
            lblSatis.Margin = new Padding(2, 0, 2, 0);
            lblSatis.Name = "lblSatis";
            lblSatis.Size = new Size(81, 15);
            lblSatis.TabIndex = 6;
            lblSatis.Text = "Satış Durumu:";
            // 
            // lblİdirimOranı
            // 
            lblİdirimOranı.AutoSize = true;
            lblİdirimOranı.Location = new Point(727, 118);
            lblİdirimOranı.Margin = new Padding(2, 0, 2, 0);
            lblİdirimOranı.Name = "lblİdirimOranı";
            lblİdirimOranı.Size = new Size(80, 15);
            lblİdirimOranı.TabIndex = 5;
            lblİdirimOranı.Text = "İndirim Oranı:";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Location = new Point(727, 94);
            lblFiyat.Margin = new Padding(2, 0, 2, 0);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(38, 15);
            lblFiyat.TabIndex = 4;
            lblFiyat.Text = "Fiyatı:";
            // 
            // lblCikisTarihi
            // 
            lblCikisTarihi.AutoSize = true;
            lblCikisTarihi.Location = new Point(727, 66);
            lblCikisTarihi.Margin = new Padding(2, 0, 2, 0);
            lblCikisTarihi.Name = "lblCikisTarihi";
            lblCikisTarihi.Size = new Size(69, 15);
            lblCikisTarihi.TabIndex = 3;
            lblCikisTarihi.Text = "Çıkış Tarihi: ";
            // 
            // lblAlbumAdi
            // 
            lblAlbumAdi.AutoSize = true;
            lblAlbumAdi.Location = new Point(727, 42);
            lblAlbumAdi.Margin = new Padding(2, 0, 2, 0);
            lblAlbumAdi.Name = "lblAlbumAdi";
            lblAlbumAdi.Size = new Size(70, 15);
            lblAlbumAdi.TabIndex = 2;
            lblAlbumAdi.Text = "Albüm Adı: ";
            // 
            // lblSanatci
            // 
            lblSanatci.AutoSize = true;
            lblSanatci.Location = new Point(727, 20);
            lblSanatci.Margin = new Padding(2, 0, 2, 0);
            lblSanatci.Name = "lblSanatci";
            lblSanatci.Size = new Size(82, 15);
            lblSanatci.TabIndex = 1;
            lblSanatci.Text = "Sanaçtı/Grup :";
            // 
            // dgvButunAlbumler
            // 
            dgvButunAlbumler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvButunAlbumler.Location = new Point(21, 18);
            dgvButunAlbumler.Margin = new Padding(2);
            dgvButunAlbumler.Name = "dgvButunAlbumler";
            dgvButunAlbumler.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvButunAlbumler.RowTemplate.Height = 33;
            dgvButunAlbumler.Size = new Size(677, 191);
            dgvButunAlbumler.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 482);
            Controls.Add(grbAlbumAra);
            Controls.Add(grbAlbumEkle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grbAlbumAra.ResumeLayout(false);
            grbAlbumAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArananAlbum).EndInit();
            grbAlbumEkle.ResumeLayout(false);
            grbAlbumEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvButunAlbumler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbAlbumAra;
        private DataGridView dgvArananAlbum;
        private Button btnAra;
        private ComboBox cmbBoxAra;
        private Label lblAramaKriteri;
        private GroupBox grbAlbumEkle;
        private TextBox txtIndirimOrani;
        private RadioButton rbtnSatistaDegil;
        private Button btnSil;
        private RadioButton rbtnSatista;
        private Button btnGüncelle;
        private TextBox txtFiyat;
        private DateTimePicker dtpCikisTarihi;
        private TextBox txtAlbumAdi;
        private TextBox txtSanatci;
        private Button btnEkle;
        private Label lblSatis;
        private Label lblİdirimOranı;
        private Label lblFiyat;
        private Label lblCikisTarihi;
        private Label lblAlbumAdi;
        private Label lblSanatci;
        private DataGridView dgvButunAlbumler;
    }
}
