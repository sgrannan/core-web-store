using CoreWebStore.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebStore.Models
{
    public class CustomerViewModel
    {
        private Guid customerId;
        private string firstName;
        private string lastName;
        private List<AddressViewModel> addresses;

        public CustomerViewModel(CustomerModel customer)
        {
            
        }       
    }

    public class AddressViewModel
    {
        private int addressId;
        private string addressLine1;
        private string city;
        private string state;
        private string zipcode;

        public int AddressId { get => addressId; set => addressId = value; }
        public string AddressLine1 { get => addressLine1; set => addressLine1 = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zipcode { get => zipcode; set => zipcode = value; }
    }

}
