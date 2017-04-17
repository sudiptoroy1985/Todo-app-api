using Microsoft.EntityFrameworkCore;

namespace TodoServicesCore.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext (DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoServicesCore.Models.Todo> Todo { get; set; }
    }
}
