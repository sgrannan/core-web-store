using CoreWebStore.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebStore.Models
{
    public class CustomerOrdersViewModel
    {
        private int _orderId;
        private Guid _customerId;
        private DateTime _orderDate;
        private DateTime _estimatedDeliveryDate;
        private string _specialNotes;
        private ItemViewModel _orderItem;

        public CustomerOrdersViewModel(OrderModel orderModel, ItemModel itemModel)
        {
            _orderId = orderModel.OrderId;
            _customerId = orderModel.CustomerId;
            _orderDate = orderModel.OrderDate;
            _estimatedDeliveryDate = orderModel.EstimatedDeliveryDate;
            _orderItem = new ItemViewModel(itemModel);
        }

        public int OrderId { get => _orderId; set => _orderId = value; }
        public Guid CustomerId { get => _customerId; set => _customerId = value; }
        public DateTime OrderDate { get => _orderDate; set => _orderDate = value; }
        public DateTime EstimatedDeliveryDate { get => _estimatedDeliveryDate; set => _estimatedDeliveryDate = value; }
        public string SpecialNotes { get => _specialNotes; set => _specialNotes = value; }
        public ItemViewModel OrderItem { get => _orderItem; set => _orderItem = value; }
    }
}
