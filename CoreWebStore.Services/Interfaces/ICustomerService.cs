using CoreWebStore.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebStore.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<UserModel> UserLogin(string username, string password);
        Task<CustomerModel> GetCustomer(string customerId);
    }
}
