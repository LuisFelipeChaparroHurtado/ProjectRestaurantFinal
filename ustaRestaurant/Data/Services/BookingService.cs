using ustaRestaurant.Data.Base;
using ustaRestaurant.Models;

namespace ustaRestaurant.Data.Services
{
    public class BookingService : EntityBaseRepository<Booking>, IBookingService
    {
        public BookingService(ApplicationDbContext context) : base(context) { }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 7d92e6c5b14e7a616c52a2209b8e0b891382523f
