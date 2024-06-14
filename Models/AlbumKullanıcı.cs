using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AlbumKullanıcı
    {

        public int KullaniciId { get; set; }
        public int AlbumId { get; set; }

        //Navigation Prop
        public Album Album { get; set; }
        public Kullanici Kullanıcı { get; set; }
    }
}
