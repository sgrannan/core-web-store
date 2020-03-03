using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebStore.Services.Models
{
    public class CustomerModel
    {
        private string customerId;
        private string firstName;
        private string lastName;
        private List<AddressModel> addresses;

        public string CustomerId { get => customerId; set => customerId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public List<AddressModel> Addresses { get => addresses; set => addresses = value; }
    }

    public class AddressModel
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
