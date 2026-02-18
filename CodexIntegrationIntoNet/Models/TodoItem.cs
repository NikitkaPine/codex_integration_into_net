using System.ComponentModel.DataAnnotations;

namespace CodexIntegrationIntoNet.Models;

public class TodoItem
{
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Title { get; set; } = string.Empty;

    public bool IsCompleted { get; set; }
}
