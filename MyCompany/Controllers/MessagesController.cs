using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using MyCompany.Domain.Entities;
using MyCompany.Servise;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Controllers
{
    public class MessagesController : Controller
    {

        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public MessagesController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index(Guid id)
        {
            var entity = id == default ? new Messages() : dataManager.Messages.GetMessagesById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Index(Messages model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Messages.SaveMessages(model);
                return View("Success");

            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Messages.DeleteMessages(id);
            return Redirect("/admin");
        }
    }
}
