using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevContainer.Service
{
    public interface ITodoRepository
    {
        Task<Todo> Add(Todo todo);
        Task<Todo> Delete(Todo todo);
        Task<Todo> Get(int id);
        Task<IEnumerable<Todo>> GetAll();
    }
}