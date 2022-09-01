using Microsoft.EntityFrameworkCore;
using PlaygroundDotNet6.Models;

namespace PlaygroundDotNet6.DBContext;

public class TodoContext : DbContext
{
    public virtual DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server = .;DataBase = TodoListDB ; Trusted_Connection=true"
        );
        base.OnConfiguring(optionsBuilder);
    }
}