using Anipat.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string conn=builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppIdentityDbContext>
    (options => options.UseSqlServer(conn));

builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<AppIdentityDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddTransient<IEmailSender, SmsSender>();

// ��������� Serilog � Seq
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console() // ����� � �������
    .WriteTo.Seq("http://localhost:5341") // �������� ����� � Seq
    .MinimumLevel.Debug() // ����������� ������� �����������
    .WriteTo.File("logs/myapp.txt", rollingInterval: RollingInterval.Day) // ���� � ����, ����� ������ ����

    .Enrich.FromLogContext() // ��������� ��������
    .CreateLogger();

builder.Host.UseSerilog(); // ���������� Serilog � ����������

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
