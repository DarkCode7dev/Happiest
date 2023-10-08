using Microsoft.AspNetCore.Mvc;
using notification.Models;
using NToastNotify;
using System.Diagnostics;

namespace notification.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IToastNotification _toastNotification;

        public HomeController(ILogger<HomeController> logger, IToastNotification toastNotification)
        {
            _logger = logger;
            _toastNotification = toastNotification;
        }

        public IActionResult Index()
        {
            try
            {
                object m = null;
                string s = m.ToString();
            }
            catch (Exception)
            {
                // Success Toast
                _toastNotification.AddSuccessToastMessage("Woo hoo - it works!");

                // Info Toast
                _toastNotification.AddInfoToastMessage("Here is some information.");

                // Error Toast
                _toastNotification.AddErrorToastMessage("Woops an error occured.");

                // Warning Toast
                _toastNotification.AddWarningToastMessage("Here is a simple warning!");




            }
            return View();
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