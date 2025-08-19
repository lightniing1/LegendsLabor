using LegendsLabor.Core.Repository.Interfaces;
using LegendsLabor.Core.Services;
using LegendsLabor.Core.Services.Interfaces;
using LegendsLabor.Infrastructure;
using LegendsLabor.Infrastructure.Repository;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace LegendsLabor.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //Repositories
            builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();
            builder.Services.AddScoped<IUserService, UserService>();

            //Services
            builder.Services.AddScoped<UserService>();

            builder.Services.AddDbContext<LegendsLaborDbContext>(options =>
                options.UseNpgsql(builder.Configuration.GetConnectionString("Postgres")));

            var app = builder.Build();
            var logger = app.Services.GetRequiredService<ILogger<Program>>();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.UseDeveloperExceptionPage();

                using (var scope = app.Services.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<LegendsLaborDbContext>();
                    dbContext.Database.Migrate();
                }
            }
            else
            {
                app.UseExceptionHandler(errorApp =>
                {
                    errorApp.Run(async context =>
                    {
                        context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                        context.Response.ContentType = "application/json";
                        var errorFeature = context.Features.Get<IExceptionHandlerFeature>();
                        var exception = errorFeature?.Error;

                        if (exception != null)
                        {
                            logger.LogError(exception, "An unhandled exception occurred.");
                        }

                        var result = System.Text.Json.JsonSerializer.Serialize(new { error = "An unexpected error occurred." });
                        await context.Response.WriteAsync(result);
                    });
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
