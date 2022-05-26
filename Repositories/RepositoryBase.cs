
using FlightBooking.Repositories.Interfaces;
using FlightBooking.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using System;

namespace FlightBooking.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationDbContext ApplicationDbContext { get; set; }

        public RepositoryBase(ApplicationDbContext ApplicationDbContext)
        {
            this.ApplicationDbContext = ApplicationDbContext;
        }

        public IQueryable<T> FindAll()
        {
            return this.ApplicationDbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.ApplicationDbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this.ApplicationDbContext.Set<T>().Add(entity);
            this.ApplicationDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            this.ApplicationDbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.ApplicationDbContext.Set<T>().Remove(entity);
            this.ApplicationDbContext.SaveChanges();
        }
    }
}
