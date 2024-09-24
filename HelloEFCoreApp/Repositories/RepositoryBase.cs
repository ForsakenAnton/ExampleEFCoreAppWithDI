using HelloEFCoreApp.Data;
using HelloEFCoreApp.RepositoryContracts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HelloEFCoreApp.Repositories;

public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected ApplicationDbContext Context;

    public RepositoryBase(ApplicationDbContext context)
    {
        Context = context;
    }

    public IQueryable<T> FindAll(bool trackChanges) =>
        !trackChanges ?
            Context.Set<T>()
                .AsNoTracking() :
            Context.Set<T>();

    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
        !trackChanges ?
            Context.Set<T>()
                .Where(expression)
                .AsNoTracking() :
            Context.Set<T>()
                .Where(expression);

    public void Create(T entity) => Context.Set<T>().Add(entity);
    public async Task CreateAsync(T entity) => await Context.Set<T>().AddAsync(entity);
    public void Update(T entity) => Context.Set<T>().Update(entity);
    public void Delete(T entity) => Context.Set<T>().Remove(entity);
}
