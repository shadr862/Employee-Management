
using Employee_Management.Application.Interfaces;
using Employee_Management.Application.Mappings;
using Employee_Management.Application.Services;
using Employee_Management.Domain.Interfaces;
using Employee_Management.Infrastructure.Data;
using Employee_Management.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Employee_Management_WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<ApplicationDbContext>
                (options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<IEmployeeService,EmployeeService>();
            builder.Services.AddScoped<IEmployeeRepository,EmployeeRepository>();
            builder.Services.AddScoped<ISearchService,SearchService>();
            builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);
            builder.Services.AddCors(options => options.AddPolicy(name: "Policy",
                policy => policy.WithOrigins("*").AllowAnyHeader().AllowAnyMethod()));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddAppDI();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();
            app.UseCors("Policy");

            app.MapControllers();

            app.Run();
        }
    }
}
