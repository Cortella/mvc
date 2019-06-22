﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc.Services;

namespace mvc.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerservice;

        public SellersController(SellerService sellerService)
        {
            _sellerservice = sellerService;
        }
        public IActionResult Index()
        {
            var list = _sellerservice.FindAll();
            return View(list);
        }
    }
}