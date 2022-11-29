using System.ComponentModel.DataAnnotations;
using ustaRestaurant.Data.Base;

namespace ustaRestaurant.Models
{
<<<<<<< HEAD
    public class Booking: IEntityBase
=======
    public class Booking : IEntityBase
>>>>>>> 7d92e6c5b14e7a616c52a2209b8e0b891382523f
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

        [Display(Name = "How Many")]
        [Required(ErrorMessage = "HowMany is required")]
        public int HowMany { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }
    }
}
