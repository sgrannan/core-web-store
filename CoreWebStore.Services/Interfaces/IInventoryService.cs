using CoreWebStore.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebStore.Services.Interfaces
{
    public interface IInventoryService
    {
        Task<List<ItemModel>> GetAllItemsAsync();
    }
}
