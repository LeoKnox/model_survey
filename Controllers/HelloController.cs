using System;
using Microsoft.AspNetCore.Mvc;
using survey_form.Models;

namespace survey_form.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("method")]
        public IActionResult Surver(User student)
        {
            return View("Survey");
        }
    }
}