﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cozy.Service.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cozy.WebUI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        // Constructor
        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }
        public IActionResult Index()
        {
            var home = _homeService.GetById(1);
            return View(home);
        }
    }
}