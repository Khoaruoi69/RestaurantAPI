using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Models
{
    public class OrderMaster
    {
        [Key]
        [Column("OrderMasterId")]
        public long OrderMasterId { get; set; }

        [Column("OrderNumber",TypeName ="nvarchar(75)")]
        [Required(ErrorMessage ="OrderNumber can't not null")]
        public string OrderNumber { get; set; }

        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }
  //      public Customer Customer { get; set; }

        [Column("PMethod", TypeName ="nvarchar(10)")]
        public string PMethod { get; set; }

        [Column("Gtotal")]
        public decimal Gtotal { get; set; } 

        public List<OrderDetail> OrderDetails { get; set; } 
        

        
    }
}
