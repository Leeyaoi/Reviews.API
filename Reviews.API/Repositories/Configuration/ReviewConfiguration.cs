using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reviews.API.Enums;
using Reviews.API.Models;

namespace Reviews.API.Repositories.Configuration;

public class ReviewConfiguration : IEntityTypeConfiguration<Review>
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.HasData(
            new Review
            {
                Id = Guid.NewGuid(),
                Mark = 1,
                Type = ReviewType.Neutral,
                Text = "Good",
                UserId = new Guid("38d0309d-c534-4cda-bcb8-0d0e1f62c3f9"),
                FilmId = new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Review
            {
                Id = Guid.NewGuid(),
                Mark = 5,
                Type = ReviewType.Positive,
                Text = "Absolutely fantastic! A must-watch.",
                UserId = new Guid("d67e36c7-1d12-4583-9513-967d7d9e0784"),
                FilmId = new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Review
            {
                Id = Guid.NewGuid(),
                Mark = 3,
                Type = ReviewType.Neutral,
                Text = "It was okay, nothing special.",
                UserId = new Guid("bc88c297-6c3c-46af-83d6-be1ed99902b2"),
                FilmId = new Guid("e3c0b4e4-7768-4143-b8d9-b218e9d77444"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Review
            {
                Id = Guid.NewGuid(),
                Mark = 2,
                Type = ReviewType.Negative,
                Text = "I didn't enjoy it as much as I hoped.",
                UserId = new Guid("cd22c8ef-e58c-4b79-b8e0-df707f9c793c"),
                FilmId = new Guid("42d3f71b-04bc-4b16-8d7f-4955de68bd19"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new Review
            {
                Id = Guid.NewGuid(),
                Mark = 4,
                Type = ReviewType.Positive,
                Text = "Great performances and stunning visuals!",
                UserId = new Guid("9d822e19-19c8-4b25-9e73-a33c8c53d1e8"),
                FilmId = new Guid("eb7c3fae-7008-43c7-bb9a-d2d37458b6e2"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            }
        );
    }
}
