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
    public class LoginController : Controller
    {
        private readonly ICustomerService _customerService;

        public LoginController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            UserModel m = await _customerService.UserLogin(model.Username, model.Password);

            return RedirectToAction("Index", "Customer", m);
        }
    }
}