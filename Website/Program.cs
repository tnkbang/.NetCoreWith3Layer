using DAL.DataContext;
using DAL.Repositories;
using DAL.Repositories.Contracts;
using BLL.Services;
using BLL.Services.Contracts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add connection string
builder.Services.AddDbContext<DayHocTrucTuyenContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DayHocTrucTuyen"));
});

builder.Services.AddTransient(typeof(INguoiDungRepository<>), typeof(NguoiDungRepository<>));
builder.Services.AddScoped<INguoiDungServices, NguoiDungServices>();

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
