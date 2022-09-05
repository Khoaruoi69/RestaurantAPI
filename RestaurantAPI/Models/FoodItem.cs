using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Models
{
    public class FoodItem
    {
        [Key]
        [Column("FoodItemId")]
        public int FoodItemId { get; set; }

        [Column("FoodItemName", TypeName ="nvarchar(100)")]
        [Required(ErrorMessage ="FoodItem name can't nulll")]
        public string FoodItemName { get; set; }

        [Column("Price")]
        [Required(ErrorMessage ="Price can't null")]
        public decimal Price { get; set; }
        

    }
}
