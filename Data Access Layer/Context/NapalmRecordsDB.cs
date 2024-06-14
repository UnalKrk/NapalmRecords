using Data_Access_Layer.Configuration;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data_Access_Layer.Context
{
    public class NapalmRecordsDB:DbContext
    {
        public DbSet<Album> Albumler { get; set; }

        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<AlbumKullanıcı> AlbumKullanıcılar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source =DESKTOP-PA352PN\\MSSQLSERVER01; Initial catalog =NapalmRecordsDB;Integrated security=true;TrustServerCertificate=true ");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new Album_CFG());
            modelBuilder.ApplyConfiguration(new AlbumKullanıcı_CFG());
            modelBuilder.ApplyConfiguration(new Kullanıcı_CFG());

            base.OnModelCreating(modelBuilder);
        }
    }
}
