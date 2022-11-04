using GeekShopping.Web.Models;
using GeekShopping.Web.Services.IServices;
using GeekShopping.Web.Utils;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.Web.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var products = await _productService.FindAllProducts("");
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(ProductViewModel productVwm)
        {
            if (!ModelState.IsValid) return View(productVwm);

            var token = await HttpContext.GetTokenAsync("access_token");

            var response = await _productService.CreateProduct(productVwm, token);

            if (response != null) return RedirectToAction(nameof(Index));

            return View(productVwm);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(long id)
        {
            var token = await HttpContext.GetTokenAsync("access_token");
            var product = await _productService.FindProductById(id, token);

            if (product != null)
                return View(product);

            return NotFound();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(ProductViewModel productVwm)
        {
            if (!ModelState.IsValid) return View(productVwm);

            var token = await HttpContext.GetTokenAsync("access_token");
            var response = await _productService.UpdateProduct(productVwm, token);

            if (response != null) return RedirectToAction(nameof(Index));

            return View(productVwm);
        }


        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Delete(long id)
        {
            var token = await HttpContext.GetTokenAsync("access_token");
            var product = await _productService.FindProductById(id, token);

            if (product == null)
                return NotFound();

            return View(product);
        }

        [HttpPost]
        [Authorize(Roles = Role.Admin)]
        public async Task<IActionResult> Delete(ProductViewModel productVwm)
        {
            var token = await HttpContext.GetTokenAsync("access_token");
            await _productService.DeleteProductById(productVwm.Id.Value, token);
            return RedirectToAction(nameof(Index));
        }

    }
}
