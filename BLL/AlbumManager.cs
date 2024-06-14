using BLL.Interfaces;
using Data_Access_Layer.Context;
using Models;

namespace BLL
{
    public class AlbumManager : ICRUD<Album>
    {
        NapalmRecordsDB context;
        public AlbumManager()
        {
            context = new NapalmRecordsDB();     
        }
        public Album Bul(int id)
        {
           return context.Albumler.Find(id);
        }
        public void Ekle(Album entity)
        {
           context.Albumler.Add(entity);
            context.SaveChanges();
        }
        public void Guncelle(Album entity)
        {
            context.Albumler.Add(entity);
            context.SaveChanges();
        }
        public List<Album> Liste()
        {
            return context.Albumler.ToList();
        }
        public void Sil(int id)
        {
            context.Albumler.Remove(Bul(id));
        }
    }
}
