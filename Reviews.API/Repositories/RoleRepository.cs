using Microsoft.EntityFrameworkCore;
using Reviews.API.Exeption;
using Reviews.API.Interfaces;
using Reviews.API.Models;

namespace Reviews.API.Repositories;

public class RoleRepository : GenericRepository<Role>, IRoleRepository
{
    private readonly DbSet<Role> _dbSet;

    public RoleRepository(ReviewsDbContext context) : base(context)
    {         
        _dbSet = context.Set<Role>();
    }

    public override Task<List<Role>> GetAll(CancellationToken cancellationToken) =>
        _dbSet.AsNoTracking().Include(x => x.Actor).Include(x => x.Film).ToListAsync(cancellationToken);

    public override async Task<Role> GetById(Guid id, CancellationToken cancellationToken)
    {
        var data = await _dbSet.AsNoTracking().Where(x => x.Id == id).Include(x => x.Actor)
            .Include(x => x.Film).FirstOrDefaultAsync(cancellationToken);
        if (data == null)
        {
            throw new NotFoundException();
        }
        return data;
    }

    public Task<List<Role>> GetByFilmId(Guid id, CancellationToken cancellationToken) =>
        GetByPredicate(x => x.FilmId == id, cancellationToken);

    public Task<List<Role>> GetByActorId(Guid id, CancellationToken cancellationToken) =>
        GetByPredicate(x => x.ActorId == id, cancellationToken);
}
