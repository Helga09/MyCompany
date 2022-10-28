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
using System.Net.Mail;
using System.Net;

namespace MyCompany.Controllers
{
    public class NewsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;

        public NewsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        [AcceptVerbs("Get", "Post")]
        public IActionResult CheckTitle(string title)
        {
            foreach (News news in dataManager.News.GetAllNews())
            {
                if (title == news.Title)
                    return Json(false);
            }
            return Json(true);
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.News.GetNewsById(id));
            }
            ViewBag.TextField = dataManager.TextFields.GetTextFieldByCodeWords("PageNews");
            return View(dataManager.News.GetPublishNews());
        }

        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new News() : dataManager.News.GetNewsById(id);
            return View(entity);
        }

        [HttpPost]
        public IActionResult Edit(News model, IFormFile titleImageFile)
        {
            if (ModelState.IsValid)
            {
                if (titleImageFile != null)
                {
                    model.TitleImagePath = titleImageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/", titleImageFile.FileName), FileMode.Create))
                    {
                        titleImageFile.CopyTo(stream);
                    }
                }
                dataManager.News.SaveNews(model);
                return View("Success");
            }
            return View(model);
        }

    }
}

