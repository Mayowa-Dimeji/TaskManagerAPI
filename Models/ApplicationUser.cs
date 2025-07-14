using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace TaskManagerApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Optional: navigation property to user's tasks
        public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>();
    }
}
