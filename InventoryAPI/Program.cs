using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Use the InventoryDatabase connection string from appsettings.json
builder.Services.AddDbContext<InventoryContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("InventoryDatabase")));

var app = builder.Build();

// Configure the HTTP request pipeline (if needed)
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
