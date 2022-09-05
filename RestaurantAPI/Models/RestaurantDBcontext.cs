using Microsoft.EntityFrameworkCore;

namespace RestaurantAPI.Models
{
    public class RestaurantDBcontext:DbContext
    {
        public RestaurantDBcontext(DbContextOptions<RestaurantDBcontext> options):base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }  
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet <OrderMaster> OrderMasters { get; set;  }

    }
}
