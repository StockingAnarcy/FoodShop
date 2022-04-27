using FoodShop.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//string connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<FoodContext>(options => options.UseSqlServer("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename = 'E:\\VSPROJECTS\\FOODSHOP\\FOODSHOP\\APP_DATA\\FOODSHOP.MDF';Integrated Security = True;"));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
