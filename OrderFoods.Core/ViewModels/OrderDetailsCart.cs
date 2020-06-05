using System;
using System.Collections.Generic;
using System.Text;

namespace OrderFoods.Core.ViewModels
{
    public class OrderDetailsCart
    { 
        public List<ShoppingCart> listCart { get; set; }
        public OrderHeader OrderHeader { get; set; }
    }
}
