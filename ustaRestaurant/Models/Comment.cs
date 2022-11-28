using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ustaRestaurant.Data.Enum;
namespace ustaRestaurant.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }
        public QualityProduct qualification { get; set; }
        public string Opinion { get; set; }

    }
}
