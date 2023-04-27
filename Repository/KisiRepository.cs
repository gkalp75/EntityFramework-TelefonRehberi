using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Context;
using WinFormsApp1.Models;

namespace WinFormsApp1.Repository
{
    internal class KisiRepository
    {
        KisiDb KisiDb;
        public KisiRepository()
        {
            KisiDb = new KisiDb();
        }
        /// <summary>
        /// Veritabanına yeni bir Kisi eklenmek istendiğinde kullanılır (When someone wants to add a new 'Kisi' to the database, this is used).
        /// </summary>
        /// <param name="kisi"></param>
        /// <returns></returns>
        public bool Add (Kisi kisi)
        {
            KisiDb.Kisis.Add(kisi);
            return KisiDb.SaveChanges()>0;
        }

        /// <summary>
        /// Veritabanında varolan bir Kisi'ye ait bilgiler güncellenmek isteniyorsa kullanılır (If information related to an existing 'Kisi' in the database needs to be updated, this is used).
        /// </summary>
        /// <param name="kisi"></param>
        /// <returns></returns>
        public bool Update (Kisi kisi)
        {
            KisiDb.Kisis.Update(kisi);
            return KisiDb.SaveChanges()>0;
        }
        /// <summary>
        /// 'KisiDb' veritabanında olan tüm 'Kisi' verilerini "List" yapısıyla getirir.
        /// </summary>
        /// <returns></returns>
        public List<Kisi> GetAll()
        {
            List<Kisi> kisiler = KisiDb.Kisis.ToList();
            return kisiler;
        }

        /// <summary>
        /// 'KisiDb' veritabanından Id numarası verilmiş olan 'Kisi' verisini getirir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Kisi GetByID(int id)
        {
            Kisi kisi = KisiDb.Kisis.Find(id);
            return kisi;
        }
        /// <summary>
        /// Gönderilen metinsel ifadenin 'KisiDb' veritabanındaki 'Kisi' nesnelerinin 'Ad' veya 'Soyad' bilgilerinin içerisinde geçip geçmediğini kontrol eder.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public List<Kisi> GetKisilerByWord (string word)
        {
            List<Kisi> kisiler = KisiDb.Kisis.Where(a=> a.Ad.Contains(word) || a.Soyad.Contains(word)).ToList();
            return kisiler;
        }
    }
}
