using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebStore.Services.Interfaces
{
    public interface IServicesConfig
    {
        string CustomerServiceApi { get; set; }
        string InventoryServiceApi { get; set; }
        string OrdersServiceApi { get; set; }

        string CustomerServiceLogin { get; set; }
    }
}
