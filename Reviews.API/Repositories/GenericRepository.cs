using Microsoft.EntityFrameworkCore;
using Reviews.API.Exeption;
using Reviews.API.Interfaces;
using Reviews.API.Models;
using System.Linq.Expressions;

namespace Reviews.API.Repositories;

public class GenericRepository<Model> : IGenericRepository<Model> where Model : BaseModel
{
    private readonly ReviewsDbContext _dbContext;
    private readonly DbSet<Model> _dbSet;

    public GenericRepository(ReviewsDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<Model>();
    }

    public async Task<Model> Create(Model entity, CancellationToken cancellationToken)
    {
        var result = await _dbSet.AddAsync(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return result.Entity;
    }

    public async Task<Model> Delete(Guid id, CancellationToken cancellationToken)
    {
        var entity = await GetById(id, cancellationToken);
        var result = _dbSet.Remove(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return result.Entity;
    }

    public async Task<Model> Update(Model entity, Guid id, CancellationToken cancellationToken)
    {
        entity.Id = id;
        await GetById(id, cancellationToken);
        var result = _dbSet.Update(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return result.Entity;
    }

    public virtual Task<List<Model>> GetAll(CancellationToken cancellationToken)
    {
        return _dbSet.AsNoTracking().ToListAsync(cancellationToken);
    }

    public virtual async Task<Model> GetById(Guid id, CancellationToken cancellationToken)
    {
        var data = await _dbSet.AsNoTracking().Where(x => x.Id == id).FirstOrDefaultAsync(cancellationToken);
        if (data == null)
        {
            throw new NotFoundException();
        }
        return data;
    }

    public virtual Task<List<Model>> GetByPredicate(Expression<Func<Model, bool>> predicate, CancellationToken cancellationToken)
    {
        return _dbSet.AsNoTracking().Where(predicate).ToListAsync(cancellationToken);
    }
}
