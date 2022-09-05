using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Models
{
    public class Customer
    {
        [Key]
        [Column("CustumerId", TypeName = "int")]
        public int CustomerId { get; set; }

        [Column("CustomerName", TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Custumer name can't null")]
        public string CustomerName { get; set; }

    }
}
