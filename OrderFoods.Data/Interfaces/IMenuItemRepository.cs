using System;
using System.Collections.Generic;
using System.Text;
using OrderFoods.Core;

namespace OrderFoods.Data.Interfaces
{
    public interface IMenuItemRepository : IRepository<MenuItem>
    {
        void Update(MenuItem menuItem);
    }
}
