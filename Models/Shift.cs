using System.ComponentModel.DataAnnotations;

public class Shift
{
    [Key]
    public int ShiftId { get; set; }
    
    public System.DateTime ShiftDate { get; set; }
    
    public System.TimeSpan ShiftTimeStart { get; set; }
    
    public System.TimeSpan ShiftTimeEnd { get; set; }
}