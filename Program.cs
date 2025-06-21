using ApiIdentityEndPoint.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(""));



var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();