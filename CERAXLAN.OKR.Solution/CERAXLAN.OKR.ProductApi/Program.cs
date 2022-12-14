using CERAXLAN.OKR.ProductApi;
using CERAXLAN.OKR.ProductApi.Application;
using CERAXLAN.OKR.ProductApi.Persistence;
using CERAXLAN.OKR.ProductApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices(builder.Configuration);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
/* Database Context Dependency Injection */
var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_ROOT_PASSWORD");

var connectionString = $"server={dbHost};port=3306;database={dbName};user=root;password={dbPassword}";
builder.Services.AddDbContext<ProductContext>(o => o.UseMySQL(connectionString));
//builder.Services.AddDbContext<ProductContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
/* ===================================== */
var app = builder.Build();


app.UseAuthorization();

app.MapControllers();

app.Run();
