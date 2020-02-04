using System.Threading.Tasks;
using DevContainer.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevContainer
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private ITodoService todoService;
        private ILogger<TodoController> logger;

        public TodoController(ITodoService todoService, ILogger<TodoController> logger)
        {
            this.todoService = todoService;
            this.logger = logger;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetTodo([FromRoute]GetTodoRequest request) {
            return Ok(await this.todoService.Get(request));
        }

        [HttpPost]
        public async Task<IActionResult> AddTodo([FromBody]AddTodoRequest request)
        {
            try
            {

                return Ok(await this.todoService.Add(request));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}