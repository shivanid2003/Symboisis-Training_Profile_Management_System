using Microsoft.EntityFrameworkCore;
using Accura.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configure the DbContext - AccuraDbContext to use SQL Server
builder.Services.AddDbContext<AccuraDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AccuraDbConnection")));

// Add session services
builder.Services.AddDistributedMemoryCache(); // Adds a default in-memory implementation of IDistributedCache
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Set the session timeout
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
var app = builder.Build();

// Enable serving static files
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();