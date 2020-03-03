using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CoreWebStore.Services.Models
{
    public class ItemModel
    {
        private Guid _itemId;
        private string _itemName;
        private string _itemDescription;
        private DateTime _lastUpdatedDate;
        private bool _inStock;
        private string _categoryName;
        private CategoryType _categoryType;

        public Guid ItemId { get => _itemId; set => _itemId = value; }
        public string ItemName { get => _itemName; set => _itemName = value; }
        public string ItemDescription { get => _itemDescription; set => _itemDescription = value; }
        public DateTime LastUpdatedDate { get => _lastUpdatedDate; set => _lastUpdatedDate = value; }
        public bool InStock { get => _inStock; set => _inStock = value; }        
        public CategoryType CategoryType { get => _categoryType; set => _categoryType = value; }
    }

    public class CategoryType
    {
        private int _categoryId;
        private string _categoryName;

        public string CategoryName { get => _categoryName; set => _categoryName = value; }
        public int CategoryId { get => _categoryId; set => _categoryId = value; }
    }
}
