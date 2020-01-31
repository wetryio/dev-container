using System;
using System.Linq;
using System.Threading.Tasks;
using DevContainer.Service;

namespace DevContainer.Infrastructure
{
    public class TodoRepository : ITodoRepository
    {
        private TodoContext context;

        public TodoRepository(TodoContext context)
        {
            this.context = context;
        }

        public async Task<Todo> Add(Todo todo)
        {
            var valueTask = await context.Todos.AddAsync(todo);
            await context.SaveChangesAsync();
            return valueTask.Entity;
        }

        public Task<Todo> Delete(Todo todo)
        {
            throw new NotImplementedException();
        }

        public Task<Todo> Get(int id)
        {
            var todo = context.Todos.Single(td => td.TodoId.Equals(id));
            return Task.FromResult(todo);
        }
    }
}
