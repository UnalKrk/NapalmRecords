namespace UI
{
    partial class Form3
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
            grpYeniKullaniciKayitEkrani = new GroupBox();
            btnYeniKayitEkle = new Button();
            lblSifreKontrol = new Label();
            txtSifreTekrar = new TextBox();
            txtSifre = new TextBox();
            txtEmail = new TextBox();
            txtKullaniciSoyadi = new TextBox();
            txtKullaniciAdi = new TextBox();
            lblKullaniciSifre = new Label();
            lblEmail = new Label();
            lblSoyadi = new Label();
            lblAdi = new Label();
            grpYeniKullaniciKayitEkrani.SuspendLayout();
            SuspendLayout();
            // 
            // grpYeniKullaniciKayitEkrani
            // 
            grpYeniKullaniciKayitEkrani.Controls.Add(btnYeniKayitEkle);
            grpYeniKullaniciKayitEkrani.Controls.Add(lblSifreKontrol);
            grpYeniKullaniciKayitEkrani.Controls.Add(txtSifreTekrar);
            grpYeniKullaniciKayitEkrani.Controls.Add(txtSifre);
            grpYeniKullaniciKayitEkrani.Controls.Add(txtEmail);
            grpYeniKullaniciKayitEkrani.Controls.Add(txtKullaniciSoyadi);
            grpYeniKullaniciKayitEkrani.Controls.Add(txtKullaniciAdi);
            grpYeniKullaniciKayitEkrani.Controls.Add(lblKullaniciSifre);
            grpYeniKullaniciKayitEkrani.Controls.Add(lblEmail);
            grpYeniKullaniciKayitEkrani.Controls.Add(lblSoyadi);
            grpYeniKullaniciKayitEkrani.Controls.Add(lblAdi);
            grpYeniKullaniciKayitEkrani.Location = new Point(12, 12);
            grpYeniKullaniciKayitEkrani.Name = "grpYeniKullaniciKayitEkrani";
            grpYeniKullaniciKayitEkrani.Size = new Size(325, 307);
            grpYeniKullaniciKayitEkrani.TabIndex = 3;
            grpYeniKullaniciKayitEkrani.TabStop = false;
            grpYeniKullaniciKayitEkrani.Text = "Yeni Kullanıcı Kayıt Ekranı";
            // 
            // btnYeniKayitEkle
            // 
            btnYeniKayitEkle.BackColor = SystemColors.ActiveCaption;
            btnYeniKayitEkle.Location = new Point(108, 187);
            btnYeniKayitEkle.Name = "btnYeniKayitEkle";
            btnYeniKayitEkle.Size = new Size(183, 58);
            btnYeniKayitEkle.TabIndex = 6;
            btnYeniKayitEkle.Text = "Yeni Kayıt Ekle";
            btnYeniKayitEkle.UseVisualStyleBackColor = false;
            btnYeniKayitEkle.Click += btnYeniKayitEkle_Click;
            // 
            // lblSifreKontrol
            // 
            lblSifreKontrol.AutoSize = true;
            lblSifreKontrol.Location = new Point(32, 161);
            lblSifreKontrol.Name = "lblSifreKontrol";
            lblSifreKontrol.Size = new Size(70, 15);
            lblSifreKontrol.TabIndex = 5;
            lblSifreKontrol.Text = "Şifre Tekrar :";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(108, 158);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(183, 23);
            txtSifreTekrar.TabIndex = 4;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(108, 129);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(183, 23);
            txtSifre.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(108, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtKullaniciSoyadi
            // 
            txtKullaniciSoyadi.Location = new Point(108, 71);
            txtKullaniciSoyadi.Name = "txtKullaniciSoyadi";
            txtKullaniciSoyadi.Size = new Size(183, 23);
            txtKullaniciSoyadi.TabIndex = 4;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(108, 42);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(183, 23);
            txtKullaniciAdi.TabIndex = 4;
            // 
            // lblKullaniciSifre
            // 
            lblKullaniciSifre.AutoSize = true;
            lblKullaniciSifre.Location = new Point(66, 132);
            lblKullaniciSifre.Name = "lblKullaniciSifre";
            lblKullaniciSifre.Size = new Size(36, 15);
            lblKullaniciSifre.TabIndex = 3;
            lblKullaniciSifre.Text = "Şifre :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(55, 103);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-Mail :";
            // 
            // lblSoyadi
            // 
            lblSoyadi.AutoSize = true;
            lblSoyadi.Location = new Point(54, 74);
            lblSoyadi.Name = "lblSoyadi";
            lblSoyadi.Size = new Size(48, 15);
            lblSoyadi.TabIndex = 1;
            lblSoyadi.Text = "Soyadı :";
            // 
            // lblAdi
            // 
            lblAdi.AutoSize = true;
            lblAdi.Location = new Point(71, 45);
            lblAdi.Name = "lblAdi";
            lblAdi.Size = new Size(31, 15);
            lblAdi.TabIndex = 0;
            lblAdi.Text = "Adı :";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 352);
            Controls.Add(grpYeniKullaniciKayitEkrani);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            grpYeniKullaniciKayitEkrani.ResumeLayout(false);
            grpYeniKullaniciKayitEkrani.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpYeniKullaniciKayitEkrani;
        private Button btnYeniKayitEkle;
        private Label lblSifreKontrol;
        private TextBox txtSifreTekrar;
        private TextBox txtSifre;
        private TextBox txtEmail;
        private TextBox txtKullaniciSoyadi;
        private TextBox txtKullaniciAdi;
        private Label lblKullaniciSifre;
        private Label lblEmail;
        private Label lblSoyadi;
        private Label lblAdi;
    }
}