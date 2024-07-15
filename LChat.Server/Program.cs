using LChat.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer($"Server=DESKTOP-K3SVLFI;Database=LChat;Trusted_Connection=True;TrustServerCertificate=true"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
