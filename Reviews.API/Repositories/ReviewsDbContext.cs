using Microsoft.EntityFrameworkCore;
using Reviews.API.Models;
using Reviews.API.Repositories.Configuration;

namespace Reviews.API.Repositories;

public class ReviewsDbContext : DbContext
{
    public ReviewsDbContext(DbContextOptions<ReviewsDbContext> options) : base(options)
    {
        if (Database.IsRelational())
        {
            Database.Migrate();
        }
    }

    public DbSet<Actor> Actors { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Director> Directors { get; set; }
    public DbSet<Film> Films { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Role> Roles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>().HasMany(e => e.Films).WithMany(e => e.Actors).UsingEntity<Role>();

        modelBuilder.ApplyConfiguration(new DirectorConfiguration());
        modelBuilder.ApplyConfiguration(new ActorConfiguration());
        modelBuilder.ApplyConfiguration(new UsersConfiguration());
        modelBuilder.ApplyConfiguration(new FilmConfiguration());
        modelBuilder.ApplyConfiguration(new ReviewConfiguration());
        modelBuilder.ApplyConfiguration(new RoleConfiguration());

        base.OnModelCreating(modelBuilder);
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        ChangeTracker.DetectChanges();

        var now = DateTime.UtcNow;
        var entries = ChangeTracker.Entries();

        foreach (var entry in entries)
        {
            var entity = entry.Entity as BaseModel;

            if (entity == null) { continue; }

            switch (entry.State)
            {
                case EntityState.Modified:
                    Entry(entity).Property(x => x.CreatedAt).IsModified = false;
                    entity.UpdatedAt = now;
                    break;

                case EntityState.Added:
                    entity.CreatedAt = now;
                    entity.UpdatedAt = now;
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }
}
