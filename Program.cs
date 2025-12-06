using EntityAspMvcFirst.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register EF Core context
builder.Services.AddDbContext<SubbudbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("constr")));

// Register distributed memory cache required by session
builder.Services.AddDistributedMemoryCache();

// Configure session (optional: tune as needed)
builder.Services.AddSession(options =>
{
    options.Cookie.HttpOnly = true;
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseStaticFiles();

// Ensure session middleware is registered
app.UseSession();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=LoginUser}/{id?}")
    .WithStaticAssets();

app.Run();
