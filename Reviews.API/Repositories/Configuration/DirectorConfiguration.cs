using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reviews.API.Models;

namespace Reviews.API.Repositories.Configuration;

public class DirectorConfiguration : IEntityTypeConfiguration<Director>
{
    public void Configure(EntityTypeBuilder<Director> builder)
    {
        builder.HasData(
            new Director
            {
                Id = new Guid("3f53b590-e7ed-4c5c-a6f8-9f182cf78278"),
                Name = "Tim",
                Surname = "Berton",
                Country = "USA",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Director
            {
                Id = new Guid("1e95e4e8-bf2b-4e09-b3e0-f59a8e4e601f"),
                Name = "Christopher",
                Surname = "Nolan",
                Country = "UK",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Director
            {
                Id = new Guid("7b99b5d6-1234-4a6d-8b25-eb210b48dd10"),
                Name = "Greta",
                Surname = "Gerwig",
                Country = "USA",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Director
            {
                Id = new Guid("156fcaab-2bfe-411c-a58e-f92d5e2a0991"),
                Name = "Quentin",
                Surname = "Tarantino",
                Country = "USA",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Director
            {
                Id = new Guid("c71faf10-d0d1-42c8-b315-8b5364a58672"),
                Name = "Alfonso",
                Surname = "Cuarón",
                Country = "Mexico",
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            }
        );
    }
}
