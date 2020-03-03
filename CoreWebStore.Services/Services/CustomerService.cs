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
    public class CustomerService : ICustomerService
    {
        private readonly ServicesConfig _servicesConfig;

        public CustomerService(IOptions<ServicesConfig> servicesConfig)
        {
            _servicesConfig = servicesConfig.Value;
        }
        public async Task<CustomerModel> GetCustomer(string customerId)
        {
            CustomerModel customer = null;
            string apiUrl = _servicesConfig.CustomerServiceApi.Trim();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    customer = JsonConvert.DeserializeObject<CustomerModel>(apiResponse);
                }
            }

            return customer;
        }

        public async Task<UserModel> UserLogin(string username, string password)
        {
            UserModel user = null;
            string apiUrl = _servicesConfig.CustomerServiceApi.Trim();
            apiUrl += _servicesConfig.CustomerServiceLogin;

            using (var httpClient = new HttpClient())
            {
                string json = JsonConvert.SerializeObject(new LoginRequest(username, password));
                using (var response = await httpClient.PostAsync(apiUrl, new StringContent(json, Encoding.UTF8, "application/json")))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    user = JsonConvert.DeserializeObject<UserModel>(apiResponse);
                }
            }

            return user;
        }
    }
}
