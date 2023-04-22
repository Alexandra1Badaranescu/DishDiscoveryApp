using AspNetCoreServicesApp.Repositories;
using DishDiscovery.Models;
using DishDiscovery.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AspNetCoreServicesApp.Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DishDiscoveryContext DishDiscoveryContext { get; set; }

        public RepositoryBase(DishDiscoveryContext dishDiscoveryContext)
        {
            this.DishDiscoveryContext = dishDiscoveryContext;
        }

        //public IQueryable<T> FindAll()
        //{
        //    return this.LocationContext.Set<T>().AsNoTracking();
        //}

        //public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        //{
        //    return this.LocationContext.Set<T>().Where(expression).AsNoTracking();
        //}

        public void Create(T entity)
        {
            this.DishDiscoveryContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this.DishDiscoveryContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this.DishDiscoveryContext.Set<T>().Remove(entity);
        }
    }
}
