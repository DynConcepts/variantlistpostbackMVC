using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DynConSurveys.Models;

namespace DynConSurveys.Controllers
{
    public class SurveySelectionController : Controller
    {
        public IActionResult Index()
        {
            var model = new AvailableSurveyModel();
            return View(model);
        }

        public IActionResult SelectSurvey(int id)
        {
            if (Request.Method == "POST")
            {
                return null;
            }
            var model = new AvailableSurveyModel();
            var definition = model.FindById(id);
            return View("SurveyEntry", definition);
        }
        public void OnPost()
        {
            var f = Request.Form;
            // do something with emailAddress
        }

        [HttpPost]
        public IActionResult SurveyPostback(int id, SurveyDefinitionModel definition)
        {
            return View("SurveyEntry", definition);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
