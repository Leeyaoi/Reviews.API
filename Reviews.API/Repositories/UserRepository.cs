using Microsoft.EntityFrameworkCore;
using Reviews.API.Exeption;
using Reviews.API.Interfaces;
using Reviews.API.Models;

namespace Reviews.API.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly DbSet<User> _dbSet;

    public UserRepository(ReviewsDbContext context) : base(context)
    {
        _dbSet = context.Set<User>();
    }

    public override Task<List<User>> GetAll(CancellationToken cancellationToken) =>
        _dbSet.AsNoTracking().Include(x => x.Reviews).ToListAsync(cancellationToken);

    public override async Task<User> GetById(Guid id, CancellationToken cancellationToken)
    {
        var data = await _dbSet.AsNoTracking().Where(x => x.Id == id).Include(x => x.Reviews)
            .FirstOrDefaultAsync(cancellationToken);
        if (data == null)
        {
            throw new NotFoundException();
        }
        return data;
    }
}
