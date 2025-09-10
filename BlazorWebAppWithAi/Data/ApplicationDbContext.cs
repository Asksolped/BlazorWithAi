using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAppWithAi.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Chat> Chats { get; set; }
    public DbSet<Prompt> Prompts { get; set; }
    public DbSet<Response> Responses { get; set; }
}