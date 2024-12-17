using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reviews.API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Surname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RegistrationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    DirectorId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Films_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Mark = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    FilmId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ReviewId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    ActorId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FilmId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Title = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Roles_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Country", "CreatedAt", "Name", "Surname", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("45bcd88f-8c1f-4f95-b6ad-c1ea831e74ae"), "USA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scarlett", "Johansson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f13e67b-285f-4e30-9a54-154fa8ea1af2"), "England", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emma", "Watson", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), "Chile", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pedro", "Pascal", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9802d4e7-1248-4a3c-be68-cc5196ae5a5b"), "England", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom", "Holland", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b645ec84-e4bf-4d4f-b6ae-372b1f12329f"), "Canada", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ryan", "Reynolds", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Country", "CreatedAt", "Name", "Surname", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("156fcaab-2bfe-411c-a58e-f92d5e2a0991"), "USA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Quentin", "Tarantino", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e95e4e8-bf2b-4e09-b3e0-f59a8e4e601f"), "UK", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christopher", "Nolan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f53b590-e7ed-4c5c-a6f8-9f182cf78278"), "USA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tim", "Berton", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b99b5d6-1234-4a6d-8b25-eb210b48dd10"), "USA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Greta", "Gerwig", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c71faf10-d0d1-42c8-b315-8b5364a58672"), "Mexico", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alfonso", "Cuarón", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Name", "RegistrationDate", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("38d0309d-c534-4cda-bcb8-0d0e1f62c3f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", new DateOnly(2000, 12, 12), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9d822e19-19c8-4b25-9e73-a33c8c53d1e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", new DateOnly(2012, 1, 15), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc88c297-6c3c-46af-83d6-be1ed99902b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", new DateOnly(2018, 7, 22), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd22c8ef-e58c-4b79-b8e0-df707f9c793c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sophia", new DateOnly(2021, 11, 30), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d67e36c7-1d12-4583-9513-967d7d9e0784"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice", new DateOnly(2015, 3, 5), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "CreatedAt", "Date", "Description", "DirectorId", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("42d3f71b-04bc-4b16-8d7f-4955de68bd19"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2014, 2, 28), "Follows the misadventures of Gustave H, the concierge at a famous hotel.", new Guid("156fcaab-2bfe-411c-a58e-f92d5e2a0991"), "The Grand Budapest Hotel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2000, 12, 12), "...", new Guid("3f53b590-e7ed-4c5c-a6f8-9f182cf78278"), "Coralline", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2010, 7, 16), "A thief who steals corporate secrets through the use of dream-sharing technology.", new Guid("1e95e4e8-bf2b-4e09-b3e0-f59a8e4e601f"), "Inception", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e3c0b4e4-7768-4143-b8d9-b218e9d77444"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(1994, 10, 14), "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine.", new Guid("7b99b5d6-1234-4a6d-8b25-eb210b48dd10"), "Pulp Fiction", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb7c3fae-7008-43c7-bb9a-d2d37458b6e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateOnly(2006, 10, 11), "A young girl in post-Civil War Spain escapes into a mythical labyrinth.", new Guid("c71faf10-d0d1-42c8-b315-8b5364a58672"), "Pan's Labyrinth", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedAt", "FilmId", "Mark", "ReviewId", "Text", "Type", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0b80896d-963b-4b87-994f-7a5ba605c799"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e3c0b4e4-7768-4143-b8d9-b218e9d77444"), 3, null, "It was okay, nothing special.", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc88c297-6c3c-46af-83d6-be1ed99902b2") },
                    { new Guid("1942be3b-705b-45c4-8666-1ac57997ce97"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"), 1, null, "Good", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("38d0309d-c534-4cda-bcb8-0d0e1f62c3f9") },
                    { new Guid("3dc66893-798e-4393-b5e1-3c4b7012a4f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("42d3f71b-04bc-4b16-8d7f-4955de68bd19"), 2, null, "I didn't enjoy it as much as I hoped.", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd22c8ef-e58c-4b79-b8e0-df707f9c793c") },
                    { new Guid("9d6f7db3-a65b-4936-ae60-32967457bac4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eb7c3fae-7008-43c7-bb9a-d2d37458b6e2"), 4, null, "Great performances and stunning visuals!", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d822e19-19c8-4b25-9e73-a33c8c53d1e8") },
                    { new Guid("f6feb8bf-e782-4323-96d0-38fbd7035cf6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"), 5, null, "Absolutely fantastic! A must-watch.", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d67e36c7-1d12-4583-9513-967d7d9e0784") }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ActorId", "CreatedAt", "FilmId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("13d976a8-545f-4d36-be47-98dc2b852ed3"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e3c0b4e4-7768-4143-b8d9-b218e9d77444"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2661c629-c863-44b0-8683-71ee4d8489ef"), new Guid("4f13e67b-285f-4e30-9a54-154fa8ea1af2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5417e813-dfa8-442f-ab45-6a3294c5b454"), new Guid("9802d4e7-1248-4a3c-be68-cc5196ae5a5b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("578cd159-5e23-4993-ae1a-bacf03ea76ac"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7880ed85-5c93-4cab-9928-327d95262d2e"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8ed12f10-e70f-470a-8bad-62901f05a8ec"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("42d3f71b-04bc-4b16-8d7f-4955de68bd19"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac2bcaac-dd3c-4848-9358-3bff2137bce0"), new Guid("b645ec84-e4bf-4d4f-b6ae-372b1f12329f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd644f03-10d4-4020-bc76-6e569cf5a7a3"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eb7c3fae-7008-43c7-bb9a-d2d37458b6e2"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dbe0a322-c5a1-4af3-ac35-6d90731fe7b4"), new Guid("b645ec84-e4bf-4d4f-b6ae-372b1f12329f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5e26ee3-05d4-4bac-8241-1880d8db6f78"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e3c0b4e4-7768-4143-b8d9-b218e9d77444"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_DirectorId",
                table: "Films",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_FilmId",
                table: "Reviews",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewId",
                table: "Reviews",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_ActorId",
                table: "Roles",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_FilmId",
                table: "Roles",
                column: "FilmId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Directors");
        }
    }
}
