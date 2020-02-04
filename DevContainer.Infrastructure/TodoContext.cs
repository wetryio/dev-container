using Microsoft.EntityFrameworkCore;
using DevContainer.Service;

namespace DevContainer.Infrastructure {
    public class TodoContext : DbContext {
        public DbSet<Todo> Todos {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseMySql("Server=db;Database=tododb;Uid=todoapplication;Pwd=!todoapplication;");
        }
    }
}