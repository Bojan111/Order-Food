using System;
using System.Collections.Generic;
using System.Text;

namespace OrderFoods.Core.ViewModels
{
    public class OrderDetailsViewModel
    {
        public OrderHeader OrderHeader { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
