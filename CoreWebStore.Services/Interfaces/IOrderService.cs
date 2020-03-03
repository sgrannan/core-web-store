using CoreWebStore.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebStore.Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<OrderModel>> GetCustomerOrders(string customerId);
    }
}
