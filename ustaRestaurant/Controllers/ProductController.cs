using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ustaRestaurant.Data.Services;
using ustaRestaurant.Data.Static;
using ustaRestaurant.Data.ViewModels;
using ustaRestaurant.Models;

namespace ustaRestaurant.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ProductController : Controller
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync(pt => pt.ProductType);
            return View(data);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Menu()
        {
            var data = await _service.GetAllAsync(pt => pt.ProductType);
            return View(data);
        }

        


        [Authorize(Roles = UserRoles.Admin)]
        public async Task<IActionResult> Admin()
        {

            var data = await _service.GetAllAsync(pt => pt.ProductType);
            return View(data);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var data = await _service.GetAllAsync(pt => pt.ProductType);

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = data.Where(
                    n => n.Name.Contains(searchString) ||
                    n.Description.Contains(searchString)
                ).ToList();
                return View("Index", filteredResult);
            }

            return View("Index", data);
        }
        
        public async Task<IActionResult> Create()
        {
            var ProductDropdownsData = await _service.GetNewProductDropdownsValues();
            ViewBag.ProductTypes = new SelectList(
                ProductDropdownsData.ProductTypes, "Id", "Name"
            );
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewProductVM Product)
        {
            if (!ModelState.IsValid)
            {
                var ProductDropdownsData = await _service.GetNewProductDropdownsValues();
                ViewBag.ProductTypes = new SelectList(ProductDropdownsData.ProductTypes, "Id", "Name");

                return View(Product);
            }
            await _service.AddNewProductAsync(Product);
            return RedirectToAction(nameof(Index));
        }
        [AllowAnonymous]
        // Get: Product/Details/id
        public async Task<IActionResult> Details(int id)
        {
            var data = await _service.GetProductByIdAsync(id);
            return View(data);
        }
        // Get: Product/Edit/id
        public async Task<IActionResult> Edit(int id)
        {
            var productDetails = await _service.GetProductByIdAsync(id);
            if (productDetails == null) return View("NotFound");

            var response = new NewProductVM()
            {
                Id = productDetails.Id,
                Name = productDetails.Name,
                Description = productDetails.Description,
                Price = productDetails.Price,

                Image = productDetails.Image,

                ProductTypeId = productDetails.ProductTypeId,

            };

            var movieDropdownsData = await _service.GetNewProductDropdownsValues();
            ViewBag.ProductTypes = new SelectList(movieDropdownsData.ProductTypes, "Id", "Name");

            return View(response);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewProductVM product)
        {
            if (id != product.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var productDropdownsData = await _service.GetNewProductDropdownsValues();
                ViewBag.ProductTypes = new SelectList(productDropdownsData.ProductTypes, "Id", "Name");
                return View(product);
            }
            await _service.UpdateProductAsync(product);
            return RedirectToAction(nameof(Index));
        }
        //Get: Product/Delete/id
        public async Task<IActionResult> Delete(int id)
        {
            var ProductDetails = await _service.GetByIdAsync(id);

            if (ProductDetails == null) return View("NotFound");
            return View(ProductDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ProductDetails = await _service.GetByIdAsync(id);
            if (ProductDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [AllowAnonymous]
        public async Task<IActionResult> Antipasto()
        {
            var data = await _service.GetAllAsync(pt => pt.ProductType);
            return View(data);
        }

        [AllowAnonymous]
        public async Task<IActionResult> OvenPizza()
        {
            var data = await _service.GetAllAsync(pt => pt.ProductType);
            return View(data);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Spaguetti()
        {
            var data = await _service.GetAllAsync(pt => pt.ProductType);
            return View(data);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Cannelloni()
        {
            var data = await _service.GetAllAsync(pt => pt.ProductType);
            return View(data);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Ravioli()
        {
            var data = await _service.GetAllAsync(pt => pt.ProductType);
            return View(data);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Lasagnas()
        {
            var data = await _service.GetAllAsync(pt => pt.ProductType);
            return View(data);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Crep()
        {
            var data = await _service.GetAllAsync(pt => pt.ProductType);
            return View(data);
        }
        [AllowAnonymous]
        public async Task<IActionResult> PiennoBread()
        {
            var data = await _service.GetAllAsync(pt => pt.ProductType);
            return View(data);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Fish()
        {
            var data = await _service.GetAllAsync(pt => pt.ProductType);
            return View(data);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Beverages()
        {
            var data = await _service.GetAllAsync(pt => pt.ProductType);
            return View(data);
        }

    }
}

