using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ustaRestaurant.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }

        public double Total { get; set; }

        public int Amount { get; set; }

        //Relationship
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }    

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int TicketId { get; set; }
        [ForeignKey("TicketId")]
        public Ticket Ticket { get; set; }

    }
}
