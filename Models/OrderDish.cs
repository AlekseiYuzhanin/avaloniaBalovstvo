using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class OrderDish
{
    [ForeignKey("Order")]
    public int OrderId { get; set; }
    public Order? Order { get; set; }

    [ForeignKey("Dish")]
    public int DishId { get; set; }
    public Dish? Dish { get; set; }
}