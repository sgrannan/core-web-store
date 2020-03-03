using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreWebStore.Models;
using CoreWebStore.Services;
using CoreWebStore.Services.Interfaces;
using CoreWebStore.Services.Models;

namespace CoreWebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IInventoryService _inventoryService;

        public HomeController(ILogger<HomeController> logger, IInventoryService inventoryService)
        {
            _logger = logger;
            _inventoryService = inventoryService;
        }

        public async Task<IActionResult> Index()
        {
            List<ItemModel> items = await _inventoryService.GetAllItemsAsync();

            List<ItemViewModel> viewModel = new List<ItemViewModel>();

            foreach(ItemModel i in items)
            {
                viewModel.Add(new ItemViewModel(i));
            }

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
