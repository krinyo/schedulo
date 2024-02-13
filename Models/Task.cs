namespace schedulo.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public User? Author { get; set; }
        public Status? TaskStatus { get; set; }
    }
}