using System.ComponentModel.DataAnnotations;

namespace ustaRestaurant.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }
        public string DeliveryAddreess { get; set; }

        //Relationship
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
