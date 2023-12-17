using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class OrderDish
{
    [Key]
    [Column(Order = 1)]
    [ForeignKey("Order")]
    public int OrderId { get; set; }
    
    [Key]
    [Column(Order = 2)]
    [ForeignKey("Dish")]
    public int DishId { get; set; }
    
    public Order? Order { get; set; }
    
    public Dish? Dish { get; set; }
}