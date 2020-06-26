using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using EnergyController.Models;
using Microsoft.EntityFrameworkCore;

namespace EnergyController.Services
{
    public class SQLRepository<T>: IRepository <T> where T:BaseEntity
    {
        protected readonly AppDBContext context;
        private DbSet<T> entitles;

        public SQLRepository(AppDBContext context)
        {
            this.context = context;
            entitles = context.Set<T>();
        }
        public SQLRepository()
        {
        }
        public void Delete(T obj)
        {
            if (obj == null) throw new ArgumentNullException("Entity");
            if (obj.Id <= 0) throw new ArgumentNullException("Entity");

            obj.UpdateAT = DateTime.Now;
            obj.Status = false;

            var entity = entitles.Attach(obj);
            entity.State = EntityState.Modified;
            context.SaveChanges();
        }
        public T Get(int id)
        {
            return entitles.SingleOrDefault(x => x.Id == id);
        }
        public IEnumerable<T> GetAll()
        {
            return entitles.AsEnumerable();
        }
        public int Insert(T obj)
        {
            if (obj == null) throw new ArgumentNullException("Entity");

            entitles.Add(obj);
            context.SaveChanges();
            return obj.Id;
        }
        public void Update(T obj)
        {
            if (obj == null) throw new ArgumentNullException("Entity");
            if (obj.Id <= 0) throw new ArgumentNullException("Entity");
            var entity = entitles.Attach(obj);
            entity.State = EntityState.Modified;
            context.SaveChanges();
        }

    }
}
