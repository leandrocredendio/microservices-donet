using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CartAPI.Model
{
    public class Cart
    {
        [ForeignKey("CartHeaderId")]
        public CartHeader CartHeader { get; set; }

        public IEnumerable<CartDetail> CartDetails { get; set; }
    }
}
