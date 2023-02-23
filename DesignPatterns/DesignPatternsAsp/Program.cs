using DesignPatterns.Models.Data;
using DesignPatterns.Repository;
using DesignPatternsAsp.Configuration;
using Microsoft.EntityFrameworkCore;
using Tools.Earn;

var builder = WebApplication.CreateBuilder(args);
IConfiguration Configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.Configure<MyConfig>(Configuration.GetSection("MyConfig"));
builder.Services.AddTransient((factory) => { return new LocalEarnFactory(
               Configuration.GetSection("MyConfig").GetValue<decimal>("LocalPercentage")); });
builder.Services.AddTransient((factory) => {
    return new ForeignEarnFactory(
               Configuration.GetSection("MyConfig").GetValue<decimal>("ForeignPercentage"),
               Configuration.GetSection("MyConfig").GetValue<decimal>("Extra")); });

builder.Services.AddDbContext<DesignPatternsContext>(options => {
    options.UseSqlServer(Configuration.GetConnectionString("Connection"));
});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
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
