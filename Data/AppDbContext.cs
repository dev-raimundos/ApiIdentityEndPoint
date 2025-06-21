using ApiIdentityEndPoint.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiIdentityEndPoint.Data;

public class AppDbContext(DbContextOptions options) : IdentityDbContext<User>(options)
{
    public string Document { get; set; } = string.Empty;
}