using IINVT.Data;
using IINVT.Interfaces;
using IINVT.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IINVT.Repository
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
        private readonly ApplicationDbContext _ctx;

        private readonly DbSet<T> _entity;

        public GenericRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
            _entity = _ctx.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _entity.ToList();
        }

        public T GetById(int id)
        {
            return _entity.Find(id);
        }

        public void Add(T entity)
        {
            _entity.Add(entity);
            _ctx.SaveChanges();
        }

        public void Update(T entity)
        {
            var entry = _ctx.Entry(entity);
            _entity.Attach(entity);
            entry.State = EntityState.Modified;
            _ctx.SaveChanges();
        }

        public void Delete(T entity)
        {
            var entry = _ctx.Entry(entity);
            entry.State = EntityState.Deleted;
            _ctx.SaveChanges();
        }
       
    }
}
