using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Reviews.API.Models;

namespace Reviews.API.Repositories.Configuration;

public class UsersConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasData(
            new User
            {
                Id = new Guid("38d0309d-c534-4cda-bcb8-0d0e1f62c3f9"),
                Name = "John",
                RegistrationDate = DateOnly.ParseExact("12.12.2000", "dd.MM.yyyy"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new User
            {
                Id = new Guid("d67e36c7-1d12-4583-9513-967d7d9e0784"),
                Name = "Alice",
                RegistrationDate = DateOnly.ParseExact("05.03.2015", "dd.MM.yyyy"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new User
            {
                Id = new Guid("bc88c297-6c3c-46af-83d6-be1ed99902b2"),
                Name = "Michael",
                RegistrationDate = DateOnly.ParseExact("22.07.2018", "dd.MM.yyyy"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new User
            {
                Id = new Guid("cd22c8ef-e58c-4b79-b8e0-df707f9c793c"),
                Name = "Sophia",
                RegistrationDate = DateOnly.ParseExact("30.11.2021", "dd.MM.yyyy"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            },
            new User
            {
                Id = new Guid("9d822e19-19c8-4b25-9e73-a33c8c53d1e8"),
                Name = "David",
                RegistrationDate = DateOnly.ParseExact("15.01.2012", "dd.MM.yyyy"),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            }
        );
    }
}
