using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

public class Order
{
    [Key]
    public int OrderId { get; set; }
    
    public string? ClientName { get; set; }
    
    [ForeignKey("Shift")]
    public int ShiftId { get; set; }
    
    public Shift? Shift { get; set; }
    
    public System.DateTime OrderTime { get; set; }
    
    public bool Payed { get; set; }
    
    public ICollection<OrderDish>? OrderDishes { get; set; }
}