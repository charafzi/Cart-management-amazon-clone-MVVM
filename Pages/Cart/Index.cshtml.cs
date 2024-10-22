using ecom_app.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace ecom_app.Pages.Cart
{
    public class IndexModel : PageModel
    {
        public ecom_app.Models.Cart Cart { get; set; }

        public IActionResult OnGet()
        {
            Cart = Request.GetCartFromCookie();
            return Page();
        }

        //removing items from cart
        public IActionResult OnPostRemoveItem(int productId)
        {
            var cart = Request.GetCartFromCookie();

            var cartItem = cart.CartItems.FirstOrDefault(item => item.Product.ProductId == productId);
            if (cartItem != null)
            {
                cart.CartItems.Remove(cartItem);
            }

            Response.SetCartCookie(cart);

            return RedirectToPage("/Cart/Index");
        }

        public IActionResult OnPostClearCart()
        {
            Response.RemoveCartCookie();
            return RedirectToPage("/Cart/Index");
        }

        public IActionResult OnPostIncreaseQty(int productId)
        {
            var cart = Request.GetCartFromCookie();

            var cartItem = cart.CartItems.FirstOrDefault(item => item.Product.ProductId == productId);
            if (cartItem != null)
            {
                cartItem.Quantity += 1;
            }

            Response.SetCartCookie(cart);

            return RedirectToPage("/Cart/Index");
        }

        public IActionResult OnPostDecreaseQty(int productId)
        {
            var cart = Request.GetCartFromCookie();

            var cartItem = cart.CartItems.FirstOrDefault(item => item.Product.ProductId == productId);
            if (cartItem != null)
            {
                if (cartItem.Quantity > 1)
                {
                    cartItem.Quantity -= 1;
                }
                else if (cartItem.Quantity == 1)
                {
                    cart.CartItems.Remove(cartItem);
                }
            }

            Response.SetCartCookie(cart);

            return RedirectToPage("/Cart/Index");
        }
    }
}
