﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TheBTeam.BLL.DAL;
using TheBTeam.BLL.DAL.Entities;
using TheBTeam.BLL.Services;
using TheBTeam.Web.Models;

namespace TheBTeam.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PlannerContext _plannerContext;
        private readonly UserService _userService;


        public HomeController(ILogger<HomeController> logger, PlannerContext plannerContext, UserService userService)
        {
            _logger = logger;
            _plannerContext = plannerContext;
            _userService = userService;
        }

        public IActionResult Index()
        {

            if (_plannerContext.Users == null)
            {
                var modelDto = _userService.GetAll();
                _plannerContext.Add(modelDto);
                _plannerContext.SaveChanges();
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
