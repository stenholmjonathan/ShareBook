
using Microsoft.EntityFrameworkCore;
using ShareBook.Repositories;
using ShareBook.Repositories.Interfaces;
using ShareBook.Services;
using ShareBookApi.Context;

namespace ShareBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var policyName = "_myAllowSpecificOrigins";
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddTransient<IBlogPostService, BlogPostService>();
            builder.Services.AddTransient<IProfileService, ProfileService>();

            builder.Services.AddTransient<IBlogPostRepository, BlogPostRepository>();
            builder.Services.AddTransient<IProfileRepository, ProfileRepository>();


            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: policyName,
                                  builder =>
                                  {
                                      builder
                                        .WithOrigins()
                                        .AllowAnyOrigin()
                                        .WithMethods("GET")
                                        .AllowAnyHeader();
                                  });
            });

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ShareBookContext>(options => options.UseSqlServer(
            builder.Configuration.GetConnectionString("ShareBookConnection")));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors(policyName);

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
