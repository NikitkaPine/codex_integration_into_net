using CodexIntegrationIntoNet.Models;
using Microsoft.EntityFrameworkCore;

namespace CodexIntegrationIntoNet.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<TodoItem> TodoItems => Set<TodoItem>();
}
