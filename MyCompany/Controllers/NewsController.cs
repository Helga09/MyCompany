using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain;


namespace MyCompany.Controllers
{
    public class NewsController : Controller
    {
        private readonly DataManager dataManager;
        public NewsController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.News.GetNewsById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWords("PageNews");
            return View(dataManager.News.GetNews());
        }
    }
}

