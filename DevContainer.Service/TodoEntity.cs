namespace DevContainer.Service
{
    public class Todo
    {
        public int TodoId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        private Todo() { }

        public Todo(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}