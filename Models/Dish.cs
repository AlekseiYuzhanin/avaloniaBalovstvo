using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

public class Dish
{
    [Key]
    public int DishId { get; set; }
    
    public string DishTitle { get; set; }
    
    public decimal DishPrice { get; set; }
    
    public ICollection<OrderDish> OrderDishes { get; set; }
}