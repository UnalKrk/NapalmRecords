using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Configuration
{
    public class AlbumKullanıcı_CFG : IEntityTypeConfiguration<AlbumKullanıcı>
    {
       
        public void Configure(EntityTypeBuilder<AlbumKullanıcı> builder)
        {
            builder.HasKey(x => new { x.AlbumId, x.KullaniciId });


        }
    }
}
