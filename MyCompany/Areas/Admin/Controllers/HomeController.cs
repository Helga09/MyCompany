using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;
        
        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
       public IActionResult Index()
        {
            dynamic mymodel = new ExpandoObject();
            mymodel.News = dataManager.News.GetNews();
            mymodel.ServiceItems = dataManager.ServiceItems.GetServiceItems();
            mymodel.Messages=dataManager.Messages.GetMessages();
            return View(mymodel);
            //return View(dataManager.ServiceItems.GetServiceItems());
        }
    }
}
