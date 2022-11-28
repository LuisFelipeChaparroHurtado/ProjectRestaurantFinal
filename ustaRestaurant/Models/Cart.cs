using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ustaRestaurant.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        //Relationship
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
