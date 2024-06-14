using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Kullanici
    {
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyAdi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }

        //Navigation Property
        public IList<AlbumKullanıcı> Kullanicilar { get; set; }
    }
}
