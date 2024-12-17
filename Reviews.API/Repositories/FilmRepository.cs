using Microsoft.EntityFrameworkCore;
using Reviews.API.Exeption;
using Reviews.API.Interfaces;
using Reviews.API.Models;
using System.Linq.Expressions;

namespace Reviews.API.Repositories;

public class FilmRepository : GenericRepository<Film>, IFilmRepository
{
    private readonly DbSet<Film> _dbSet;

    public FilmRepository(ReviewsDbContext context) : base(context)
    {
        _dbSet = context.Set<Film>();
    }

    public override async Task<Film> GetById(Guid id, CancellationToken cancellationToken)
    {
        var data = await _dbSet.AsNoTracking().Where(x => x.Id == id).Include(x => x.Director).Include(x => x.Roles)
            .Include(x => x.Reviews).Include(x => x.Actors).FirstOrDefaultAsync(cancellationToken);
        if (data == null)
        {
            throw new NotFoundException();
        }
        return data;
    }

    public override Task<List<Film>> GetByPredicate(Expression<Func<Film, bool>> predicate, CancellationToken cancellationToken)
    {
        return _dbSet.AsNoTracking().Where(predicate).Include(x => x.Director).Include(x => x.Roles)
            .Include(x => x.Reviews).Include(x => x.Actors).ToListAsync(cancellationToken);
    }
}
