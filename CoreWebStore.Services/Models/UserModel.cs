using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebStore.Services.Models
{
    public class UserModel
    {
        private string _username;
        private string _customerName;
        private Guid _customerId;

        public string Username { get => _username; set => _username = value; }
        public string CustomerName { get => _customerName; set => _customerName = value; }
        public Guid CustomerId { get => _customerId; set => _customerId = value; }
    }
}
