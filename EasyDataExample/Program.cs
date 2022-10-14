using EasyData.Services;
using EasyDataExample;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connection = builder.Configuration.GetConnectionString("DefaultConnection")
                 ?? throw new ApplicationException("Can't find connection string");

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connection, builder =>
{
    builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
}), ServiceLifetime.Transient);

var app = builder.Build();

app.MapEasyData(options => {
    options.UseDbContext<AppDbContext>();
});

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();