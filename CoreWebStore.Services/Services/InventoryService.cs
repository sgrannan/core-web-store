using CoreWebStore.Services.Interfaces;
using CoreWebStore.Services.Models;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace CoreWebStore.Services.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly ServicesConfig _servicesConfig;

        public InventoryService(IOptions<ServicesConfig> servicesConfig)
        {
            _servicesConfig = servicesConfig.Value;
        }

        public async System.Threading.Tasks.Task<List<ItemModel>> GetAllItemsAsync()
        {
            List < ItemModel > items = new List<ItemModel>();
            string apiUrl = _servicesConfig.InventoryServiceApi.Trim();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(apiUrl))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    items = JsonConvert.DeserializeObject<List<ItemModel>>(apiResponse);
                }
            }

            return items;
        }
    }
}
