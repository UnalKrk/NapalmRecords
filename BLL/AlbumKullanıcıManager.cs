using BLL.Interfaces;
using Data_Access_Layer.Context;
using Models;
using NPOI.SS.Formula.Functions;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AlbumKullanıcıManager : ICRUD<AlbumKullanıcı>
    {
        NapalmRecordsDB context;
        public AlbumKullanıcıManager()
        {
            context = new NapalmRecordsDB();
        }
        public AlbumKullanıcı Bul(int id)
        {
          return context.AlbumKullanıcılar.Find(id);
        }
        public void Ekle(AlbumKullanıcı entity)
        {
            context.AlbumKullanıcılar.Add(entity);
            context.SaveChanges();
        }
        public void Guncelle(AlbumKullanıcı entity)
        {
            context.AlbumKullanıcılar.Update(entity);
            context.SaveChanges();
        }
        public List<AlbumKullanıcı> Liste()
        {
            return context.AlbumKullanıcılar.ToList();
        }
        public void Sil(int id)
        {
            context.AlbumKullanıcılar.Remove(Bul(id));
            context.SaveChanges();
        }
    }
}
