using AutoMapper;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Threading.Tasks;

namespace DevContainer.Service
{
    public interface ITodoService
    {
        Task<AddTodoResponse> Add(AddTodoRequest request);
        Task<GetTodoResponse> Get(GetTodoRequest request);
        Task<GetAllTodoResponse> GetAll();
    }

    public class TodoService : ITodoService
    {
        private ITodoRepository repository;
        private IMapper mapper;
        private ILogger<TodoService> logger;

        public TodoService(ITodoRepository repository, IMapper mapper, ILogger<TodoService> logger)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.logger = logger;
        }

        public async Task<AddTodoResponse> Add(AddTodoRequest request)
        {
            var todo = new Todo(request.Name, request.Description);
            try
            {
                await repository.Add(todo);
                return new AddTodoResponse { IsSuccess = true };
            }
            catch
            {
                return new AddTodoResponse { IsSuccess = false, Message = "Error while storing Todo" };
            }
        }

        public async Task<GetTodoResponse> Get(GetTodoRequest request)
        {
            var todo = await this.repository.Get(request.Id);
            logger.LogInformation($"{todo.Title}");
            return mapper.Map<GetTodoResponse>(todo);
        }

        public async Task<GetAllTodoResponse> GetAll()
        {
            var todos = await this.repository.GetAll();
            return new GetAllTodoResponse{
                Todos = todos.Select(item => new GetAllTodoResponse.TodoItem{
                    TodoId = item.TodoId,
                    Title = item.Title,
                    Description = item.Description
                })
            };
        }
    }
}