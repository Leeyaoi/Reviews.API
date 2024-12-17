using Microsoft.EntityFrameworkCore;
using Reviews.API.Exeption;
using Reviews.API.Interfaces;
using Reviews.API.Models;

namespace Reviews.API.Repositories;

public class ReviewRepository : GenericRepository<Review>, IReviewRepository
{
    private readonly DbSet<Review> _dbSet;

    public ReviewRepository(ReviewsDbContext context) : base(context)
    {
        _dbSet = context.Set<Review>();
    }

    public override Task<List<Review>> GetAll(CancellationToken cancellationToken) =>
        _dbSet.AsNoTracking().Include(x => x.Film).Include(x => x.User).ToListAsync(cancellationToken);

    public override async Task<Review> GetById(Guid id, CancellationToken cancellationToken)
    {
        var data = await _dbSet.AsNoTracking().Where(x => x.Id == id).Include(x => x.Film).Include(x => x.User)
            .FirstOrDefaultAsync(cancellationToken);
        if (data == null)
        {
            throw new NotFoundException();
        }
        return data;
    }
}
