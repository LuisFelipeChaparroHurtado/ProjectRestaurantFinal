using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ustaRestaurant.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; } 

        public string NumberTicket { get; set; }

        public DateTime Date { get; set; }

        //Relationship
        public int DeliveryId { get; set; }
        [ForeignKey("DeliveryId")]
        public Delivery Delivery { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
