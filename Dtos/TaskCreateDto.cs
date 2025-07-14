namespace TaskManagerApi.Dtos
{
    public class TaskCreateDto
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
    }
}
