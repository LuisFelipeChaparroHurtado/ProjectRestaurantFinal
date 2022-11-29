using System.ComponentModel.DataAnnotations;
using ustaRestaurant.Data.Base;

namespace ustaRestaurant.Models
{
    public class Booking : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "FullName")]
        [Required(ErrorMessage = "Name is required")]
        public string FullName { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number is required")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Date is required")]
        public string Email { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Date is required")]
        public double Date { get; set; }
    }
}
