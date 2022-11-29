using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ustaRestaurant.Data.Services;
using ustaRestaurant.Models;

namespace ustaRestaurant.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingService _service;

        public BookingController(IBookingService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName")] Booking booking)
        {
            if (!ModelState.IsValid)
            {
                return View(booking);
            }
            await _service.AddAsync(booking);
            return RedirectToAction(nameof(Index));
        }
        //Get: ProductTypes/Details/1

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var bookingsDetails = await _service.GetByIdAsync(id);

            if (bookingsDetails == null) return View("NotFound");
            return View(bookingsDetails);
        }
        //Get: ProductType/Edit
        public async Task<IActionResult> Edit(int id)
        {
            var bookingsDetails = await _service.GetByIdAsync(id);

            if (bookingsDetails == null) return View("NotFound");
            return View(bookingsDetails);
        }

        //Get: ProductType/Edit/1
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName")] Booking booking)
        {
            if (!ModelState.IsValid) return View(booking);
            {
                if (id == booking.Id)
                {
                    await _service.UpdateAsync(id, booking);
                    return RedirectToAction(nameof(Index));
                }

            }
            return View(booking);
        }
        //Get: ProductType/Delete/id
        public async Task<IActionResult> Delete(int id)
        {
            var bookingsDetails = await _service.GetByIdAsync(id);

            if (bookingsDetails == null) return View("NotFound");
            return View(bookingsDetails);
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookingsDetails = await _service.GetByIdAsync(id);
            if (bookingsDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}