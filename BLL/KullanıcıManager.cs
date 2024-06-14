using BLL.Interfaces;
using Data_Access_Layer.Context;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KullanıcıManager : ICRUD<Kullanici>
    {
        NapalmRecordsDB context;
        public KullanıcıManager()
        {
                context = new NapalmRecordsDB();
        }
        public Kullanici Bul(int id)
        {
            return context.Kullanicilar.Find(id);
        }
        public void Ekle(Kullanici entity)
        {
            context.Kullanicilar.Add(entity);
            context.SaveChanges();
        }
        public void Guncelle(Kullanici entity)
        {
            context.Kullanicilar.Update(entity);
            context.SaveChanges();
        }
        public List<Kullanici> Liste()
        {
            return context.Kullanicilar.ToList();
        }
        public void Sil(int id)
        {
            context.Kullanicilar.Remove(Bul(id));
        }
    }
}
