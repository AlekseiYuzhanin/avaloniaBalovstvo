using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    [Key]
    public int UserId { get; set; }
    
    public string? UserName { get; set; }
    
    public string? UserLogin { get; set; }
    
    public string? UserPassword { get; set; }
    
    public bool Fired { get; set; }
    
    [ForeignKey("Role")]
    public int RoleId { get; set; }
    
    public Role? Role { get; set; }
}