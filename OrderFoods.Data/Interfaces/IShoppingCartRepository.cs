using System;
using System.Collections.Generic;
using System.Text;
using OrderFoods.Core;

namespace OrderFoods.Data.Interfaces
{
    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        int IncrementCount(ShoppingCart shoppingCart, int count);
        int DecrementCount(ShoppingCart shoppingCart, int count);
    }
}
