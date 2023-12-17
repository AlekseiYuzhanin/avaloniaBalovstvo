using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public class ShiftAssignment
{
    [Key]
    public int ShiftAssignmentId { get; set; }
    
    [ForeignKey("User")]
    public int UserId { get; set; }
    
    public User? User { get; set; }
    
    [ForeignKey("Shift")]
    public int ShiftId { get; set; }
    
    public Shift? Shift { get; set; }
}