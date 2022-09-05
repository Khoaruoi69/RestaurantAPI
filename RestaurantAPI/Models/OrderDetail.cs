using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }

        [ForeignKey("OrderMasterId")]
        public long OrderMasterId { get; set; }
        

        [ForeignKey("FoodItemId")]
        public int FoodItemId { get; set; }
   //     public FoodItem FoodItem { get; set; }

        [Column("FoodItemPrice")]
        public decimal FoodItemPrice { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }

    }
}
