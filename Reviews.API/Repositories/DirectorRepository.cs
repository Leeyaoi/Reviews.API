using Microsoft.EntityFrameworkCore;
using Reviews.API.Exeption;
using Reviews.API.Interfaces;
using Reviews.API.Models;

namespace Reviews.API.Repositories;

public class DirectorRepository : GenericRepository<Director>, IDirectorRepository
{
    private readonly DbSet<Director> _dbSet;

    public DirectorRepository(ReviewsDbContext context) : base(context)
    {        
        _dbSet = context.Set<Director>();
    }

    public override Task<List<Director>> GetAll(CancellationToken cancellationToken) =>
        _dbSet.AsNoTracking().Include(x => x.Films).ToListAsync(cancellationToken);

    public override async Task<Director> GetById(Guid id, CancellationToken cancellationToken)
    {
        var data = await _dbSet.AsNoTracking().Where(x => x.Id == id)
            .Include(x => x.Films).FirstOrDefaultAsync(cancellationToken);
        if (data == null)
        {
            throw new NotFoundException();
        }
        return data;
    }
}
