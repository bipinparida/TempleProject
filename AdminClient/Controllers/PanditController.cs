﻿using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class PanditController : Controller
    {
        public IActionResult CreatePandit()
        {
            return View();
        }
        public IActionResult PanditList()
        {
            return View();
        }
        public IActionResult PanditEdit(int PanditId)
        {
            ViewBag.PanditId = PanditId;
            return View();
        }
    }
}