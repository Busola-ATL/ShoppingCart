using ShoppingCart.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[Authorize]
namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartApi : ControllerBase
    {
        private readonly ShoppingCart productModel;

        public CartApi(CartApi shoppingCartService)
        {
            productModel = shoppingCartService;
        }

        // GET: /ShoppingCart
        public IActionResult Index()
        {
            // Retrieve the user's shopping cart (replace with your actual logic)
            var userId = Id.get(); // Replace with your authentication logic
            return productModel.Products.get();
    }
}
