using CoreWebStore.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebStore.Models
{
    public class ItemViewModel
    {
        private Guid _itemId;
        private string _itemCategory;
        private string _itemName;
        private string _itemDescription;
        private bool _outOfStock;

        public ItemViewModel(ItemModel apiModel)
        {
            ItemId = apiModel.ItemId;
            ItemCategory = apiModel.CategoryType.CategoryName;
            ItemName = apiModel.ItemName;
            ItemDescription = apiModel.ItemDescription;
            OutOfStock = !apiModel.InStock;
        }

        public Guid ItemId { get => _itemId; set => _itemId = value; }
        public string ItemCategory { get => _itemCategory; set => _itemCategory = value; }
        public string ItemName { get => _itemName; set => _itemName = value; }
        public string ItemDescription { get => _itemDescription; set => _itemDescription = value; }
        public bool OutOfStock { get => _outOfStock; set => _outOfStock = value; }
    }
}
