using Data_Access_Layer.Context;
using Microsoft.VisualBasic.ApplicationServices;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form3 : Form
    {
        Kullanici _kullanici;
        NapalmRecordsDB context;
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            _kullanici = new Kullanici();
            context = new NapalmRecordsDB();
        }
        private void btnYeniKayitEkle_Click(object sender, EventArgs e)
        {
            #region Kullanaci Adi
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                MessageBox.Show("İsim Alanı Boş Geçilemez");
                return;
            }
            else
            {
                char[] letters = { 'ç', 'ğ', 'ı', 'ö', 'ş', 'ü', 'İ', 'Ç', 'Ğ', 'Ö', 'Ş', 'Ü' };
                char[] replace = { 'c', 'g', 'i', 'o', 's', 'u', 'i', 'c', 'g', 'o', 's', 'u' };

                for (int i = 0; i < txtKullaniciAdi.Text.Length; i++)
                {
                    //harfleri dön
                    for (int j = 0; j < letters.Length; j++)
                    {
                        if (txtKullaniciAdi.Text[i] == letters[j])
                        {
                            txtKullaniciAdi.Text = txtKullaniciAdi.Text.Replace(txtKullaniciAdi.Text[i], replace[j]);
                        }
                    }
                }
                _kullanici.KullaniciAdi = txtKullaniciAdi.Text;
            }

            #endregion
            #region Kullanci SoyAdi
            if (string.IsNullOrEmpty(txtKullaniciSoyadi.Text))
            {
                MessageBox.Show("Soyadı alanı boş geçilemez");
                return;
            }
            else
            {
                char[] letters = { 'ç', 'ğ', 'ı', 'ö', 'ş', 'ü', 'İ', 'Ç', 'Ğ', 'Ö', 'Ş', 'Ü' };
                char[] replace = { 'c', 'g', 'i', 'o', 's', 'u', 'i', 'c', 'g', 'o', 's', 'u' };

                for (int i = 0; i < txtKullaniciSoyadi.Text.Length; i++)
                {
                    for (int j = 0; j < letters.Length; j++)
                    {
                        if (txtKullaniciSoyadi.Text[i] == letters[j])
                        {
                            txtKullaniciSoyadi.Text = txtKullaniciSoyadi.Text.Replace(txtKullaniciSoyadi.Text[i], replace[j]);
                        }
                    }
                }
                _kullanici.KullaniciSoyAdi = txtKullaniciSoyadi.Text;
            }
            #endregion
            #region Mail
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Mail alanı boş geçilemez");
                return;
            }
            else if (Methods.Methods.IsValidEmail(txtEmail.Text))
            {
                _kullanici.Email = txtEmail.Text.Trim();
            }
            else
            {
                MessageBox.Show("Lütfen mailiniz kontrol ediniz");
                return;
            }
            #endregion
            #region Password

            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                if (Methods.Methods.CheckForUpperCase(txtSifre.Text) && Methods.Methods.CheckForLowerCase(txtSifre.Text) && Methods.Methods.CheckForSpecialCharacter(txtSifre.Text))
                {
                    _kullanici.Sifre = Methods.Methods.Sha256_hash(txtSifre.Text);
                }
                else
                {
                    MessageBox.Show("Parola en az 2 büyük harf, 3 küçük harf ve 2 özel karakter içermelidir ");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Girilen şifrelere uyumlu değil.");
                return;
            }
            #endregion
            #region EmailCheck

            foreach (var email in context.Kullanicilar)
            {
                if (email.Email == _kullanici.Email)
                {
                    MessageBox.Show("Mail Adresi Kullanılıoyor..");
                    return;
                }
            }

            #endregion

            context.Kullanicilar.Add(_kullanici);
            context.SaveChanges();
            MessageBox.Show("Kullanıcı başarılı ile kaydedil");
            this.Close();
        }
    }
}
