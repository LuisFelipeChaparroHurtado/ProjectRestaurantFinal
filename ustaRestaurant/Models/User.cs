using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ustaRestaurant.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string Address { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public IdentityDbContext<IdentityUser> IdentityUser;
     }
}
