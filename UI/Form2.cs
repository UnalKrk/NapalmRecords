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
    public partial class Form2 : Form
    {
        NapalmRecordsDB _context;
        Kullanici _kullanici;
        Form1 _frm1;
        Form3 _frm3;

        public Form2()
        {
            InitializeComponent();
            _context = new NapalmRecordsDB();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = Methods.Methods.Sha256_hash(txtSifre.Text);

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı veya parola boş bırakılamaz", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            _kullanici = _context.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == kullaniciAdi && x.Sifre == sifre);
            if (_kullanici == null)
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Giriş Başarılı");
                _frm1 = new Form1();
                _frm1.Show();
                this.Hide();
            }
        }
        private void chkSifreGoster_CheckedChanged(object sender, EventArgs e)
        {

            if (chkSifreGoster.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }
        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {

            _frm3 = new Form3();
            _frm3.ShowDialog();
        }
    }
}
