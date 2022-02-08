using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delux.Services.ShoppingCartAPI.Models
{
    public class Cart
    {
        public CartHeader CartHeader { get; set; }
        public IEnumerable<CartDetails> CartDetails { get; set; }
    }
}
