using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebStore.Models;
using CoreWebStore.Services.Interfaces;
using CoreWebStore.Services.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebStore.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IOrderService _orderService;
        private readonly IInventoryService _inventoryService;

        public CustomerController(ICustomerService customerService, IOrderService orderService, IInventoryService inventoryService)
        {
            _customerService = customerService;
            _orderService = orderService;
            _inventoryService = inventoryService;
        }

        public async Task<IActionResult> Index(UserModel model)
        {
            List<CustomerOrdersViewModel> viewModel = new List<CustomerOrdersViewModel>();

            List<OrderModel> orders = await _orderService.GetCustomerOrders(model.CustomerId.ToString());
            
            foreach(OrderModel om in orders)
            {
                foreach(OrderDetails d in om.OrderDetails)
                {
                    ItemModel item = await _inventoryService.GetByItemId(d.ItemId.ToString());
                    viewModel.Add(new CustomerOrdersViewModel(om, item));
                }                
            }

            return View(viewModel);
        }
    }
}