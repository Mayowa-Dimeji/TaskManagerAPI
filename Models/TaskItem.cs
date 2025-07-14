using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagerApi.Models
{
public class TaskItem
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    public bool IsCompleted { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // ✅ Don't mark UserId as [Required] — you're setting it in code
    [Required]
    public string UserId { get; set; }= string.Empty;

    [ForeignKey("UserId")]
    public ApplicationUser? User { get; set; } = null!;
}
}
