using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICRUD<T> where T : class
    {
        void Ekle(T entity); //INSERT
        void Guncelle(T entity); //UPDATE
        void Sil(int id); //DELETE
        List<T> Liste(); //SELECT
        T Bul(int id);   //Find()
    }
}
