using System.Collections.Generic;

namespace ecom_app.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
    }
}
