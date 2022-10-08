namespace Todos.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descricao { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public bool Completed { get; set; }

    }
}
