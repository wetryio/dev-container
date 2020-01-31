using Microsoft.EntityFrameworkCore;
using DevContainer.Service;

namespace DevContainer.Infrastructure {
    public class TodoContext : DbContext {
        public DbSet<Todo> Todos {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlServer("Server=db;Database=Todo;User Id=TodoApplication;Password=!TodoApplication;");
        }
    }
}