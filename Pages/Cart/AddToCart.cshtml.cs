using ecom_app.Extensions;
using ecom_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace ecom_app.Pages.Cart
{
    public class AddToCartModel : PageModel
    {
        private readonly ecom_app.Data.ecom_appContext _context;

        public AddToCartModel(ecom_app.Data.ecom_appContext context)
        {
            _context = context;
        }

        public IActionResult OnPost(int productId, int quantity)
        {
            //get product based on Id
            var product = _context.Product.FirstOrDefault(p => p.ProductId == productId);
            if (product == null)
            {
                return NotFound();
            }

            //get cookie
            var cart = Request.GetCartFromCookie();

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productId);

            //Product exist in cart
            if (cartItem != null)
            {
                if(quantity >= 1)
                    cartItem.Quantity += quantity;
                else
                    cartItem.Quantity += 1;
            }
            //Product don't exist in cart
            else
            {
                //Add product with user quantity
                int qty = quantity >= 1 ? quantity : quantity = 1;
               
                cart.CartItems.Add(new CartItem
                {
                    ProductId = productId,
                    Quantity = qty,
                    Product = product 
                });
            }

            //save cart in cookie
            Response.SetCartCookie(cart);

            TempData["successMsg"] = $"{product.Name} was added to your cart !";
            var lastURL = Request.Headers["Referer"].ToString();

            if (!string.IsNullOrEmpty(lastURL))
            {
                return Redirect(lastURL); 
            }

            return RedirectToPage("/Index");
        }
    }
}
