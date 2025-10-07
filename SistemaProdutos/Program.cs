using Microsoft.EntityFrameworkCore;
using SistemaProdutos.Data;

var builder = WebApplication.CreateBuilder(args);

// Conexão com SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.Run();
