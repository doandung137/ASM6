using jsonCategory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonCategory.Adapters
{
    interface CartService
    {
        List<CartItem> GetCarts();
        bool AddToCart(CartItem ite);
        bool DeleteItem(CartItem item);
        bool UpdateQty(CartItem item,int Quantity);
        bool ClearCart();
    }
}
