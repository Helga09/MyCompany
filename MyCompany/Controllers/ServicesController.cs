using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCompany.Domain;

namespace MyCompany.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;
        public ServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.ServiceItems.GetServiceItemById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWords("PageServices");
            return View(dataManager.ServiceItems.GetServiceItems());
        }
    }
}
