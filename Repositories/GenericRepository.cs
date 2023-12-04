using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using CvProject.Models.Entity;

namespace CvProject.Repositories
{
    public class GenericRepository<T> where T : class, new() // T db deki tabloları içerecek.
    {
        DbCVEntities db = new DbCVEntities(); // db yi newledik
        public List<T> List() 
        {
            return db.Set<T>().ToList();  // db deki tabloları listeye aldık.
        }
        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }
        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }
        public void TUpdate(T p)
        {
            db.SaveChanges();
        }
        public T Find (Expression<Func<T, bool>> where) // silinecek olan deneyimin id sini bulmak için
        {
            return db.Set<T>().FirstOrDefault(where);
        }

    }
}