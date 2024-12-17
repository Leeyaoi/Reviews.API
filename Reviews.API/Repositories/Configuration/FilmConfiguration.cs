using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reviews.API.Models;

namespace Reviews.API.Repositories.Configuration;

public class FilmConfiguration : IEntityTypeConfiguration<Film>
{
    public void Configure(EntityTypeBuilder<Film> builder)
    {
        builder.HasData(
            new Film
            {
                Id = new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"),
                Name = "Coraline",
                Date = DateOnly.ParseExact("12.12.2000", "dd.MM.yyyy"),
                Description = "...",
                DirectorId = new Guid("3f53b590-e7ed-4c5c-a6f8-9f182cf78278"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Film
            {
                Id = new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"),
                Name = "Inception",
                Date = DateOnly.ParseExact("16.07.2010", "dd.MM.yyyy"),
                Description = "A thief who steals corporate secrets through the use of dream-sharing technology.",
                DirectorId = new Guid("1e95e4e8-bf2b-4e09-b3e0-f59a8e4e601f"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Film
            {
                Id = new Guid("e3c0b4e4-7768-4143-b8d9-b218e9d77444"),
                Name = "Pulp Fiction",
                Date = DateOnly.ParseExact("14.10.1994", "dd.MM.yyyy"),
                Description = "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine.",
                DirectorId = new Guid("7b99b5d6-1234-4a6d-8b25-eb210b48dd10"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Film
            {
                Id = new Guid("42d3f71b-04bc-4b16-8d7f-4955de68bd19"),
                Name = "The Grand Budapest Hotel",
                Date = DateOnly.ParseExact("28.02.2014", "dd.MM.yyyy"),
                Description = "Follows the misadventures of Gustave H, the concierge at a famous hotel.",
                DirectorId = new Guid("156fcaab-2bfe-411c-a58e-f92d5e2a0991"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Film
            {
                Id = new Guid("eb7c3fae-7008-43c7-bb9a-d2d37458b6e2"),
                Name = "Pan's Labyrinth",
                Date = DateOnly.ParseExact("11.10.2006", "dd.MM.yyyy"),
                Description = "A young girl in post-Civil War Spain escapes into a mythical labyrinth.",
                DirectorId = new Guid("c71faf10-d0d1-42c8-b315-8b5364a58672"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            }
        );
    }
}
