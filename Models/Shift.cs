using System.ComponentModel.DataAnnotations;
using System;
public class Shift
{
    [Key]
    public int ShiftId { get; set; }
    
    public DateTime ShiftDate { get; set; }
    
    public DateTime ShiftTimeStart { get; set; }
    
    public DateTime ShiftTimeEnd { get; set; }
}