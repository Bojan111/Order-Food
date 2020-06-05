using System;
using System.Collections.Generic;
using System.Text;
using OrderFoods.Core;

namespace OrderFoods.Data.Interfaces
{
    public interface IOrderDetailsRepository : IRepository<OrderDetails>
    {
        void Update(OrderDetails orderDetails);
    }
}
