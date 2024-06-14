namespace Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumAdi { get; set; }
        public string AlbumSanatcisi_Grubu { get; set; }
        public DateTime AlbumCikisTarihi { get; set; }
        public Decimal AlbumFiyati { get; set; }
        public double IndirimOrani { get; set; }
        public bool Satistami { get; set; }

        //Navigation Prop.
        public IList<AlbumKullanıcı> Albumler { get; set; }
    }
}
