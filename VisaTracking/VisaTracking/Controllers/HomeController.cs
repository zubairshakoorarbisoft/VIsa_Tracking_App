using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VisaTracking.Data;
using VisaTracking.Models;

namespace VisaTracking.Controllers
{
    [Authorize(Roles = "Super Admin,Admin,Counselor,Processor,Operator")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {
            string userId = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name).Id;
            ViewBag.RoleName = _context.Roles.FirstOrDefault(i => i.Id == _context.UserRoles.FirstOrDefault(u => u.UserId == userId).RoleId).Name;
            ViewBag.ProfilePicture = _context.ProfilePictures.FirstOrDefault(i => i.UserId == userId)?.ProfilePictureName;
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
