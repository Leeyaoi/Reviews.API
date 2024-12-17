using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reviews.API.Models;

namespace Reviews.API.Repositories.Configuration;

public class ActorConfiguration : IEntityTypeConfiguration<Actor>
{
    public void Configure(EntityTypeBuilder<Actor> builder)
    {
        builder.HasData(
            new Actor
            {
                Id = new Guid("9802d4e7-1248-4a3c-be68-cc5196ae5a5b"),
                Name = "Tom",
                Surname = "Holland",
                Country = "England",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Actor
            {
                Id = new Guid("4f13e67b-285f-4e30-9a54-154fa8ea1af2"),
                Name = "Emma",
                Surname = "Watson",
                Country = "England",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Actor
            {
                Id = new Guid("b645ec84-e4bf-4d4f-b6ae-372b1f12329f"),
                Name = "Ryan",
                Surname = "Reynolds",
                Country = "Canada",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Actor
            {
                Id = new Guid("45bcd88f-8c1f-4f95-b6ad-c1ea831e74ae"),
                Name = "Scarlett",
                Surname = "Johansson",
                Country = "USA",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Actor
            {
                Id = new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"),
                Name = "Pedro",
                Surname = "Pascal",
                Country = "Chile",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            }
        );
    }
}
