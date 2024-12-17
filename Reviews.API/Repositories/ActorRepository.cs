using Microsoft.EntityFrameworkCore;
using Reviews.API.Exeption;
using Reviews.API.Interfaces;
using Reviews.API.Models;

namespace Reviews.API.Repositories;

public class ActorRepository : GenericRepository<Actor>, IActorRepository
{
    private readonly DbSet<Actor> _dbSet;

    public ActorRepository(ReviewsDbContext context) : base(context)
    {
        _dbSet = context.Set<Actor>();
    }

    public override Task<List<Actor>> GetAll(CancellationToken cancellationToken) =>
        _dbSet.AsNoTracking().Include(x => x.Roles).Include(x => x.Films).ToListAsync(cancellationToken);

    public override async Task<Actor> GetById(Guid id, CancellationToken cancellationToken)
    {
        var data = await _dbSet.AsNoTracking().Where(x => x.Id == id).Include(x => x.Roles)
            .Include(x => x.Films).FirstOrDefaultAsync(cancellationToken);
        if (data == null)
        {
            throw new NotFoundException();
        }
        return data;
    }
}
