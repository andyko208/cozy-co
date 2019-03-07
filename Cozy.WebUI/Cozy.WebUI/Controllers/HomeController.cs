using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Cozy.Domain.Models;
using Cozy.Service.Services;
using Cozy.WebUI.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cozy.WebUI.Controllers
{
    [Authorize(Roles = "Landlord")]
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHostingEnvironment _environment;

        // Constructor
        public HomeController(IHomeService homeService, UserManager<AppUser> userManager,
            IHostingEnvironment environment)
        {
            _homeService = homeService;
            _userManager = userManager;
            _environment = environment;
        }

        public IActionResult Index()
        {
            var home = _homeService.GetById(3);
            return View(home);
        }

        public IActionResult List()
        {
            var userId = _userManager.GetUserId(User);  // gets the id of the user

            var homes = _homeService.GetByLandlordId(userId);   // get the homes of that landlord user

            return View(homes); // ICollection<Home>
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CreateHomeViewModel vm)
        {
            // if(ModelState.IsValid) add annotations later [Required] in model for attributes
            Home newHome = vm.Home;
            IFormFile image = vm.Image;

            // upload image
            if (image != null && image.Length > 0)
            {
                // _environment.WebRootPath --> ~/webroot/images/homes
                string storageFolder = Path.Combine(_environment.WebRootPath,"images/homes");

                // 000-1234-dsaf-asgsa.jpg
                string newImageName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(image.FileName)}";

                // ~/wwwroot/images/home/000-1234-dsaf-asgsa.jpg
                string fullPath = Path.Combine(storageFolder, newImageName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }

                // append new image location to new Home
                newHome.ImageURL = $"/images/homes/{newImageName}";
            }

            // Add the landlord
            newHome.LandlordId = _userManager.GetUserId(User);

            // save newHome
            _homeService.Create(newHome);


            return RedirectToAction("List");
        }
    }
}