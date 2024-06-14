namespace UI
{
    partial class Form2
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
            grpLogin = new GroupBox();
            chkSifreGoster = new CheckBox();
            btnYeniKullanici = new Button();
            btnGirisYap = new Button();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            lblSifre = new Label();
            lblKullaniciAdi = new Label();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grpLogin
            // 
            grpLogin.Controls.Add(chkSifreGoster);
            grpLogin.Controls.Add(btnYeniKullanici);
            grpLogin.Controls.Add(btnGirisYap);
            grpLogin.Controls.Add(txtSifre);
            grpLogin.Controls.Add(txtKullaniciAdi);
            grpLogin.Controls.Add(lblSifre);
            grpLogin.Controls.Add(lblKullaniciAdi);
            grpLogin.Location = new Point(12, 12);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(292, 195);
            grpLogin.TabIndex = 2;
            grpLogin.TabStop = false;
            grpLogin.Text = "Giriş Ekranı";
            // 
            // chkSifreGoster
            // 
            chkSifreGoster.AutoSize = true;
            chkSifreGoster.BackgroundImageLayout = ImageLayout.Stretch;
            chkSifreGoster.Location = new Point(191, 70);
            chkSifreGoster.Name = "chkSifreGoster";
            chkSifreGoster.Size = new Size(95, 19);
            chkSifreGoster.TabIndex = 7;
            chkSifreGoster.Text = "Şifreyi Göster";
            chkSifreGoster.UseVisualStyleBackColor = true;
            chkSifreGoster.CheckedChanged += chkSifreGoster_CheckedChanged;
            // 
            // btnYeniKullanici
            // 
            btnYeniKullanici.Location = new Point(6, 166);
            btnYeniKullanici.Name = "btnYeniKullanici";
            btnYeniKullanici.Size = new Size(128, 23);
            btnYeniKullanici.TabIndex = 5;
            btnYeniKullanici.Text = "Yeni Kullanıcı Kayıt";
            btnYeniKullanici.UseVisualStyleBackColor = true;
            btnYeniKullanici.Click += btnYeniKullanici_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Location = new Point(88, 97);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(100, 23);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(88, 68);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 3;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(88, 31);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(100, 23);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(40, 76);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(36, 15);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre :";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(0, 39);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(76, 15);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 304);
            Controls.Add(grpLogin);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLogin;
        private CheckBox chkSifreGoster;
        private Button btnYeniKullanici;
        private Button btnGirisYap;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label lblSifre;
        private Label lblKullaniciAdi;
    }
}