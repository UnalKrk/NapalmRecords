using Data_Access_Layer.Context;
using Models;
using UI.Methods;


namespace UI
{
    public partial class Form1 : Form
    {
        NapalmRecordsDB _context;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _context = new NapalmRecordsDB();
            cmbBoxAra.SelectedIndex = 0;
            DataGridWiew();
            btnGüncelle.Enabled = false;
            btnSil.Enabled = false;

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Album album = new Album();

            if (Methods.Methods.CheckIfBlankField(grbAlbumEkle))
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurunuz");
            }
            else
            {
                album.AlbumSanatcisi_Grubu = txtSanatci.Text;
                album.AlbumAdi = txtAlbumAdi.Text;
                album.AlbumCikisTarihi = dtpCikisTarihi.Value.Date;
                album.AlbumFiyati = Convert.ToDecimal(txtFiyat.Text);


                if (Convert.ToInt32(txtIndirimOrani.Text) > 100 || Convert.ToInt32(txtIndirimOrani.Text) < 0)
                {
                    MessageBox.Show("Ýndirim oraný 0-100 arasýnda olmalýdýr.");
                    return;
                }
                else
                {
                    album.IndirimOrani = Convert.ToDouble(txtIndirimOrani.Text) / 100;
                }

                if (rbtnSatista.Checked == true)
                {
                    album.Satistami = true;
                }
                else if (rbtnSatistaDegil.Checked == true)

                {
                    album.Satistami = false;
                }

                _context.Albumler.Add(album);
                _context.SaveChanges();
                MessageBox.Show("Album baþarýyla eklendi");
                DataGridWiew();
                Methods.Methods.ClearAllTextBoxes(grbAlbumEkle);


            }


        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Album album = (Album)dgvButunAlbumler.CurrentRow.DataBoundItem;

            album.AlbumSanatcisi_Grubu = txtSanatci.Text;
            album.AlbumAdi = txtAlbumAdi.Text;
            album.AlbumCikisTarihi = dtpCikisTarihi.Value.Date;
            album.AlbumFiyati = Convert.ToDecimal(txtFiyat.Text);
            album.IndirimOrani = Convert.ToDouble(txtIndirimOrani.Text);

            if (rbtnSatista.Checked == true)
            {
                album.Satistami = true;
            }
            else if (rbtnSatistaDegil.Checked == true)

            {
                album.Satistami = false;
            }

            _context.SaveChanges();
            MessageBox.Show("Albüm baþaraýyla güncellendi.");
            DataGridWiew();
            Methods.Methods.ClearAllTextBoxes(grbAlbumEkle);
            btnGüncelle.Enabled = false;
            btnEkle.Enabled = true;
            btnSil.Enabled = false;
        }
        private void btnAra_Click(object sender, EventArgs e)
        {

            if (cmbBoxAra.SelectedIndex == 1)
            {
                dgvArananAlbum.DataSource = _context.Albumler
                    .Where(x => x.Satistami == false)
                    .Select(a => new { a.AlbumAdi, a.AlbumSanatcisi_Grubu }).ToList();
            }
            else if (cmbBoxAra.SelectedIndex == 2)
            {
                dgvArananAlbum.DataSource = _context.Albumler
                    .Where(x => x.Satistami == true)
                    .Select(a => new { a.AlbumAdi, a.AlbumSanatcisi_Grubu }).ToList();
            }
            else if (cmbBoxAra.SelectedIndex == 3)
            {
                dgvArananAlbum.DataSource = _context.Albumler.OrderByDescending(x => x.AlbumCikisTarihi).Take(10).Select(a => new { a.AlbumAdi, a.AlbumSanatcisi_Grubu }).ToList();
            }
            else if (cmbBoxAra.SelectedIndex == 4)
            {
                dgvArananAlbum.DataSource = _context.Albumler.OrderByDescending(x => x.IndirimOrani).Select(a => new { a.AlbumAdi, a.AlbumSanatcisi_Grubu }).ToList();
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            Album album = (Album)dgvButunAlbumler.CurrentRow.DataBoundItem;
            _context.Albumler.Remove(album);
            _context.SaveChanges();
            MessageBox.Show("Albüm baþarýyla silindi.");
            DataGridWiew();
            Methods.Methods.ClearAllTextBoxes(grbAlbumEkle);
            btnGüncelle.Enabled = false;
            btnEkle.Enabled = true;
            btnSil.Enabled = false;
        }
        private void dgvButunAlbumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGüncelle.Enabled = true;
            btnEkle.Enabled = false;
            btnSil.Enabled = true;
            txtAlbumAdi.Text = dgvButunAlbumler.CurrentRow.Cells[1].Value.ToString();
            txtSanatci.Text = dgvButunAlbumler.CurrentRow.Cells[2].Value.ToString();
            dtpCikisTarihi.Value = Convert.ToDateTime(dgvButunAlbumler.CurrentRow.Cells[3].Value);
            txtFiyat.Text = dgvButunAlbumler.CurrentRow.Cells[4].Value.ToString();
            txtIndirimOrani.Text = dgvButunAlbumler.CurrentRow.Cells[5].Value.ToString();
            if (dgvButunAlbumler.CurrentRow.Cells[6].Value.ToString() == "True")
            {
                rbtnSatista.Checked = true;
            }
            else
            {
                rbtnSatistaDegil.Checked = true;
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Çýkmak istediðinize emin misiniz?", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }
        private void DataGridWiew()
        {
            dgvButunAlbumler.DataSource = _context.Albumler.ToList();
            dgvButunAlbumler.RowHeadersVisible = false;
            dgvButunAlbumler.Columns["AlbumId"].Visible = false;
            dgvButunAlbumler.Columns["Albumler"].Visible = false;
            dgvButunAlbumler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvButunAlbumler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
