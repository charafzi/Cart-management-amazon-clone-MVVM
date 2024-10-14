using System.Collections.Generic;

namespace ecom_app.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        // Navigation property for cart items
        public ICollection<CartItem> CartItems { get; set; }
    }
}
