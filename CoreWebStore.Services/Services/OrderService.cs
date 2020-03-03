using CoreWebStore.Services.Interfaces;
using CoreWebStore.Services.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebStore.Services.Services
{
    public class OrderService : IOrderService
    {
        private readonly ServicesConfig _servicesConfig;

        public OrderService(IOptions<ServicesConfig> servicesConfig)
        {
            _servicesConfig = servicesConfig.Value;
        }

        public async Task<List<OrderModel>> GetCustomerOrders(string customerId)
        {
            List<OrderModel> orders = new List<OrderModel>();
            string apiUrl = _servicesConfig.OrdersServiceApi.Trim();
            apiUrl += "/" + customerId;

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    orders = JsonConvert.DeserializeObject<List<OrderModel>>(apiResponse);
                }
            }

            return orders;
        }
    }
}
