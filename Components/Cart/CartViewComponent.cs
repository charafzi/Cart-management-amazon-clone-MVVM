using ecom_app.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace ecom_app.Components.Cart
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cart = HttpContext.Request.GetCartFromCookie(); 

            return View(cart);
        }
    }
}
