using System.Collections.Generic;

namespace DevContainer.Service
{
    public class GetAllTodoResponse
    {
        public class TodoItem
        {
            public int TodoId { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
        }
        public IEnumerable<TodoItem> Todos { get; set; }
    }
}
