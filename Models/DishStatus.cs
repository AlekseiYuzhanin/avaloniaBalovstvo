using System.ComponentModel.DataAnnotations;

public class DishStatus
{
    [Key]
    public int DishStatusId { get; set; }
    
    public string? StatusTitle { get; set; }
}