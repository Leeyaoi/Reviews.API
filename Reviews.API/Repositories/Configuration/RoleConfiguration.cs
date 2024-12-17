using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reviews.API.Models;

namespace Reviews.API.Repositories.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasData(
            new Role
            {
                Id = Guid.NewGuid(),
                FilmId = new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"),
                ActorId = new Guid("9802d4e7-1248-4a3c-be68-cc5196ae5a5b"),
                Title = "1",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Role
            {
                Id = Guid.NewGuid(),
                FilmId = new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"),
                ActorId = new Guid("4f13e67b-285f-4e30-9a54-154fa8ea1af2"),
                Title = "1",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Role
            {
                Id = Guid.NewGuid(),
                FilmId = new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"),
                ActorId = new Guid("b645ec84-e4bf-4d4f-b6ae-372b1f12329f"),
                Title = "1",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Role
            {
                Id = Guid.NewGuid(),
                FilmId = new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"),
                ActorId = new Guid("b645ec84-e4bf-4d4f-b6ae-372b1f12329f"),
                Title = "1",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Role
            {
                Id = Guid.NewGuid(),
                FilmId = new Guid("e3c0b4e4-7768-4143-b8d9-b218e9d77444"),
                ActorId = new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"),
                Title = "1",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Role
            {
                Id = Guid.NewGuid(),
                FilmId = new Guid("e3c0b4e4-7768-4143-b8d9-b218e9d77444"),
                ActorId = new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"),
                Title = "1",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Role
            {
                Id = Guid.NewGuid(),
                FilmId = new Guid("42d3f71b-04bc-4b16-8d7f-4955de68bd19"),
                ActorId = new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"),
                Title = "1",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Role
            {
                Id = Guid.NewGuid(),
                FilmId = new Guid("eb7c3fae-7008-43c7-bb9a-d2d37458b6e2"),
                ActorId = new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"),
                Title = "1",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Role
            {
                Id = Guid.NewGuid(),
                FilmId = new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"),
                ActorId = new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"),
                Title = "1",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Role
            {
                Id = Guid.NewGuid(),
                FilmId = new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"),
                ActorId = new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"),
                Title = "1",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            }
        );
    }
}
