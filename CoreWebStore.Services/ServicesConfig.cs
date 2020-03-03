using CoreWebStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebStore.Services
{
    public class ServicesConfig : IServicesConfig
    {

        private string customerServiceApi;
        private string inventoryServiceApi;
        private string ordersServiceApi;
        private string customerServiceLogin;

        public string CustomerServiceApi { get => customerServiceApi; set => customerServiceApi = value; }
        public string InventoryServiceApi { get => inventoryServiceApi; set => inventoryServiceApi = value; }
        public string OrdersServiceApi { get => ordersServiceApi; set => ordersServiceApi = value; }
        public string CustomerServiceLogin { get => customerServiceLogin; set => customerServiceLogin = value; }
    }
}
