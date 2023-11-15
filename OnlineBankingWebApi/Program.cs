using Microsoft.EntityFrameworkCore;
using OnlineBankingWebApi.Data;
using OnlineBankingWebApi.Mappers;
using OnlineBankingWebApi.Middlewares;
using OnlineBankingWebApi.Repositories;
using OnlineBankingWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Automapper configuration.
builder.Services.AddAutoMapper(typeof(AutomapperProfiles));

// Repositories and Services
builder.Services.AddScoped<IAuthRepository, AuthService>();

// Database Configuration.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.ConfigureCors();
builder.Services.ConfigureIdentity();
builder.Services.ConfigureJwt(builder.Configuration);
// builder.Services.AddHttpContextAccessor();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("CorsPolicy");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();