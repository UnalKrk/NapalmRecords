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
    public class Kullanıcı_CFG : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(a => a.KullaniciId);

            builder.HasKey(u => u.KullaniciId);

            builder.Property(u => u.KullaniciAdi)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(20);

            builder.Property(u => u.KullaniciSoyAdi)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(30);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasColumnType("nvarchar")
                .HasMaxLength(75);

            builder.Property(u => u.Sifre)
                .IsRequired()
                .HasColumnType("nvarchar");
        }
    }
}
