using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MyKeyBox.Shared.Abstractions.Common;

[assembly:InternalsVisibleTo("MyKeyBox.Modules.BackOffice.Core")]

namespace MyKeyBox.Shared.Abstractions.Persistence;

internal abstract class Repository<T, TDbContext> 
    where TDbContext : DbContext
    where T : Entity
{
    protected readonly TDbContext DbContext;

    protected Repository(TDbContext dbContext)
        => DbContext = dbContext;

    public async Task<T?> GetByIdAsync(Expression<Func<T,bool>> func,CancellationToken token= default)
        => await DbContext
            .Set<T>()
            .FirstOrDefaultAsync(func,token);


    public Task<List<T>> GetAllAsync()
        => Task.FromResult(DbContext.Set<T>().ToList());

    public Task<bool> ExistById(int id) 
        => Task.FromResult(DbContext.Set<T>().Any(x => x.Id == id));
    
    public EntityEntry<T> Add(T entity)=> DbContext.Add(entity);

    public Task<EntityEntry<T>> Update(T type) 
        => Task.FromResult(DbContext.Set<T>().Update(type));
        
    
}