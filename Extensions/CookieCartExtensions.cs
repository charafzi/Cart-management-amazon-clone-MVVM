using ecom_app.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace ecom_app.Extensions
{
    public static class CookieCartExtensions
    {
        private const string cookieKey = "CartCookie";

        public static void SetCartCookie(this HttpResponse response, Cart cart)
        {
            var cartJson = JsonConvert.SerializeObject(cart);
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(7), 
                HttpOnly = true, //prevent client access
                IsEssential = true //bypass privacy
            };
            response.Cookies.Append(cookieKey, cartJson, options);
        }

        public static Cart GetCartFromCookie(this HttpRequest request)
        {
            if (request.Cookies.TryGetValue(cookieKey, out var cartCookie))
            {
                //deserialize from cookie 
                return string.IsNullOrEmpty(cartCookie)
                    ? new Cart { CartItems = new List<CartItem>() }
                    : JsonConvert.DeserializeObject<Cart>(cartCookie);
            }

            //no cookie exists
            return new Cart { CartItems = new List<CartItem>() };
        }

        public static void RemoveCartCookie(this HttpResponse response)
        {
            response.Cookies.Delete(cookieKey);
        }
    }

}