using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebStore.Services.Models
{
    public class OrderModel
    {
        private int _orderId;
        private Guid _customerId;
        private DateTime _orderDate;
        private DateTime _estimatedDeliveryDate;
        private string _specialNotes;
        private List<OrderDetails> _orderDetails;

        public int OrderId { get => _orderId; set => _orderId = value; }
        public Guid CustomerId { get => _customerId; set => _customerId = value; }
        public DateTime OrderDate { get => _orderDate; set => _orderDate = value; }
        public DateTime EstimatedDeliveryDate { get => _estimatedDeliveryDate; set => _estimatedDeliveryDate = value; }
        public string SpecialNotes { get => _specialNotes; set => _specialNotes = value; }
        public List<OrderDetails> OrderDetails { get => _orderDetails; set => _orderDetails = value; }
    }

    public class OrderDetails
    {
        private int _orderDetailId;
        private Guid _itemId;

        public int OrderDetailId { get => _orderDetailId; set => _orderDetailId = value; }
        public Guid ItemId { get => _itemId; set => _itemId = value; }
    }
}
