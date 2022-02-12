using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCApp.Models;
using System.Threading;

namespace MVCApp.Controllers
{
    public class AccountsController : Controller
    {
        private readonly ILogger<AccountsController> _logger;

        public AccountsController(ILogger<AccountsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login()
        {
            Thread theThread = Thread.CurrentThread;
            Console.WriteLine("Login ="+theThread.ManagedThreadId); 
            return View();
        }

        public IActionResult Register()
        {
            Thread theThread = Thread.CurrentThread;
            Console.WriteLine("Register ="+theThread.ManagedThreadId); 
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
