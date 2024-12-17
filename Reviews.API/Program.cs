using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Reviews.API.Interfaces;
using Reviews.API.Middleware;
using Reviews.API.Repositories;
using Reviews.API.Validators;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;

namespace Reviews.API;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddDbContext<ReviewsDbContext>(options =>
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            options.UseMySql(connectionString ?? "", new MySqlServerVersion(new Version(8, 0, 11)));
        }, ServiceLifetime.Transient);

        builder.Services.AddAutoMapper(typeof(Program).Assembly);
        builder.Services.AddValidatorsFromAssemblyContaining<ActorValidator>();
        builder.Services.AddFluentValidationAutoValidation();

        builder.Services.AddControllers().AddNewtonsoftJson(
          options =>
          {
              options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
          });

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        //repositories
        builder.Services.AddTransient<IActorRepository, ActorRepository>();
        builder.Services.AddTransient<IDirectorRepository, DirectorRepository>();
        builder.Services.AddTransient<IFilmRepository, FilmRepository>();
        builder.Services.AddTransient<IReviewRepository, ReviewRepository>();
        builder.Services.AddTransient<IRoleRepository, RoleRepository>();
        builder.Services.AddTransient<IUserRepository, UserRepository>();

        var app = builder.Build();

        app.UseMiddleware<ExeptionHandlerMiddleware>();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action}/{id?}");

        app.UseAuthorization();

        app.Run();
    }
}